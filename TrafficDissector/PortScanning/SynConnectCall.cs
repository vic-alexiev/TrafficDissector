using SharpPcap;
using SharpPcap.Packets;
using SharpPcap.Protocols;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;

namespace TrafficDissector.PortScanning
{
    internal class SynConnectCall
    {
        #region Private Fields

        private readonly int timeout;
        private readonly PcapDevice device;
        private readonly IPAddress gatewayAddress;

        #endregion


        #region Constructor

        public SynConnectCall(int timeout, PcapDevice device, IPAddress gatewayAddress)
        {
            this.timeout = timeout;
            this.device = device;
            this.gatewayAddress = gatewayAddress;
        }

        #endregion


        #region Connect

        public ScanMessage Connect(IPEndPoint ipEndPoint)
        {
            // SYN packet creation

            //MAC address of gateway is provided by arp protocol
            ARP arper = new ARP(device.Name);
            arper.LocalIP = device.Interface.Addresses[0].Addr.ipAddress;
            arper.LocalMAC = device.Interface.MacAddress;
            PhysicalAddress gatewayHwAddress = arper.Resolve(gatewayAddress);

            EthernetPacket ethernetHeader = new EthernetPacket(
                device.Interface.MacAddress,
                gatewayHwAddress,
                EthernetPacketType.IPv4,
                null);

            byte[] content = new byte[
                EthernetFields_Fields.ETH_HEADER_LEN +
                IPv4Fields_Fields.IP_HEADER_LEN +
                TCPFields_Fields.TCP_HEADER_LEN];

            IPv4Packet ipv4Packet = new IPv4Packet(
                EthernetFields_Fields.ETH_HEADER_LEN,
                content);

            // Ethernet header
            ipv4Packet.EthernetHeader = ethernetHeader.Bytes;

            // IP fields
            ipv4Packet.Version = 4;
            ipv4Packet.IPHeaderLength = IPv4Fields_Fields.IP_HEADER_LEN;
            ipv4Packet.IPTotalLength = content.Length - EthernetFields_Fields.ETH_HEADER_LEN;
            ipv4Packet.Id = 100;
            ipv4Packet.TimeToLive = 20;
            ipv4Packet.IPProtocol = IPProtocol.IPProtocolType.TCP;
            ipv4Packet.SourceAddress = device.Interface.Addresses[0].Addr.ipAddress;
            ipv4Packet.DestinationAddress = ipEndPoint.Address;

            ipv4Packet.ComputeIPChecksum(true);

            TCPPacket tcpPacket = new TCPPacket(
                EthernetFields_Fields.ETH_HEADER_LEN,
                content);

            // TCP fields
            tcpPacket.SourcePort = 2222;
            tcpPacket.DestinationPort = ipEndPoint.Port;
            tcpPacket.SequenceNumber = 1000;
            tcpPacket.AcknowledgmentNumber = 1000;
            tcpPacket.Syn = true;
            tcpPacket.TCPHeaderLength = TCPFields_Fields.TCP_HEADER_LEN;
            tcpPacket.WindowSize = 555;

            // Calculate checksum
            tcpPacket.ComputeTCPChecksum(true);

            try
            {
                device.Open(false, 20);

                device.SetFilter(String.Format("ip src {0} and tcp src port {1} and tcp dst port {2}",
                    tcpPacket.DestinationAddress,
                    tcpPacket.DestinationPort,
                    tcpPacket.SourcePort));

                // Send the packet
                device.SendPacket(tcpPacket);

                TCPPacket replyPacket = null;
                bool replyReceived = false;

                Stopwatch watch = new Stopwatch();
                watch.Start();

                // Condition including timeout check.
                while (watch.ElapsedMilliseconds < timeout && replyReceived != true)
                {
                    if ((replyPacket = (TCPPacket)device.GetNextPacket()) != null)
                    {
                        replyReceived = true;
                    }
                }

                if (!replyReceived) // A reply hasn't been received
                {
                    return ScanMessage.Timeout;
                }
                else if (replyPacket.Rst) // Remote host reset the connection
                {
                    return ScanMessage.PortClosed;
                }
                else if (replyPacket.Ack) // Remote host replied with a TCP packet
                {
                    tcpPacket.Syn = false;
                    tcpPacket.Rst = true;
                    tcpPacket.WindowSize = 0;
                    tcpPacket.ComputeTCPChecksum(true);
                    device.SendPacket(tcpPacket);

                    return ScanMessage.PortOpened;
                }
                else
                {
                    return ScanMessage.Unknown;
                }
            }
            catch (Exception)
            {
                return ScanMessage.Unknown;
            }
            finally
            {
                device.Close();
            }
        }

        #endregion
    }
}
