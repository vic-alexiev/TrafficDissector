using SharpPcap.Packets;
using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace TrafficDissector.Visualization
{
    internal static class TreeViewVisualizer
    {
        #region Internal Methods

        #region Add Methods

        internal static TreeNode AddFrameNode(TreeView treeView)
        {
            TreeNode frameNode = treeView.Nodes.Add("Frame", String.Empty);
            frameNode.Nodes.Add("ArrivalTime", String.Empty);
            frameNode.Nodes.Add("FrameLength", String.Empty);
            frameNode.Nodes.Add("CaptureLength", String.Empty);

            return frameNode;
        }

        internal static TreeNode AddEthernetNode(TreeView treeView)
        {
            TreeNode ethernetNode = treeView.Nodes.Add("Ethernet", String.Empty);
            ethernetNode.Nodes.Add("Destination", String.Empty);
            ethernetNode.Nodes.Add("Source", String.Empty);
            ethernetNode.Nodes.Add("Type", String.Empty);

            return ethernetNode;
        }

        internal static TreeNode AddArpNode(TreeView treeView)
        {
            TreeNode arpNode = treeView.Nodes.Add("ARP", String.Empty);
            arpNode.Nodes.Add("HwType", String.Empty);
            arpNode.Nodes.Add("ProtocolType", String.Empty);
            arpNode.Nodes.Add("HwSize", String.Empty);
            arpNode.Nodes.Add("ProtocolSize", String.Empty);
            arpNode.Nodes.Add("Opcode", String.Empty);
            arpNode.Nodes.Add("SenderHwAddress", String.Empty);
            arpNode.Nodes.Add("SenderIPAddress", String.Empty);
            arpNode.Nodes.Add("TargetHwAddress", String.Empty);
            arpNode.Nodes.Add("TargetIPAddress", String.Empty);

            return arpNode;
        }

        internal static TreeNode AddIPv4Node(TreeView treeView)
        {
            TreeNode ipv4Node = treeView.Nodes.Add("IPv4", String.Empty);
            ipv4Node.Nodes.Add("Version", String.Empty);
            ipv4Node.Nodes.Add("IHL", String.Empty);

            TreeNode dsNode = ipv4Node.Nodes.Add("DS", String.Empty);
            dsNode.Nodes.Add("Precedence", String.Empty);
            dsNode.Nodes.Add("Delay", String.Empty);
            dsNode.Nodes.Add("Throughput", String.Empty);
            dsNode.Nodes.Add("Reliability", String.Empty);
            dsNode.Nodes.Add("Cost", String.Empty);

            ipv4Node.Nodes.Add("TotalLength", String.Empty);
            ipv4Node.Nodes.Add("Id", String.Empty);

            TreeNode flagsNode = ipv4Node.Nodes.Add("Flags", String.Empty);
            flagsNode.Nodes.Add("Reserved", String.Empty);
            flagsNode.Nodes.Add("DF", String.Empty);
            flagsNode.Nodes.Add("MF", String.Empty);

            ipv4Node.Nodes.Add("FragmentOffset", String.Empty);
            ipv4Node.Nodes.Add("TTL", String.Empty);
            ipv4Node.Nodes.Add("Protocol", String.Empty);
            ipv4Node.Nodes.Add("Checksum", String.Empty);
            ipv4Node.Nodes.Add("SA", String.Empty);
            ipv4Node.Nodes.Add("DA", String.Empty);

            return ipv4Node;
        }

        internal static TreeNode AddTcpNode(TreeView treeView)
        {
            TreeNode tcpNode = treeView.Nodes.Add("TCP", String.Empty);
            tcpNode.Nodes.Add("SrcPort", String.Empty);
            tcpNode.Nodes.Add("DstPort", String.Empty);
            tcpNode.Nodes.Add("SeqNumber", String.Empty);
            tcpNode.Nodes.Add("AckNumber", String.Empty);
            tcpNode.Nodes.Add("HeaderLength", String.Empty);

            TreeNode flagsNode = tcpNode.Nodes.Add("Flags", String.Empty);
            flagsNode.Nodes.Add("CWR", String.Empty);
            flagsNode.Nodes.Add("ECN", String.Empty);
            flagsNode.Nodes.Add("Urg", String.Empty);
            flagsNode.Nodes.Add("Ack", String.Empty);
            flagsNode.Nodes.Add("Psh", String.Empty);
            flagsNode.Nodes.Add("Rst", String.Empty);
            flagsNode.Nodes.Add("Syn", String.Empty);
            flagsNode.Nodes.Add("Fin", String.Empty);

            tcpNode.Nodes.Add("WindowSize", String.Empty);
            tcpNode.Nodes.Add("Checksum", String.Empty);
            tcpNode.Nodes.Add("UrgPtr", String.Empty);

            return tcpNode;
        }

        internal static TreeNode AddUdpNode(TreeView treeView)
        {
            TreeNode udpNode = treeView.Nodes.Add("UDP", String.Empty);
            udpNode.Nodes.Add("SrcPort", String.Empty);
            udpNode.Nodes.Add("DstPort", String.Empty);
            udpNode.Nodes.Add("Length", String.Empty);
            udpNode.Nodes.Add("Checksum", String.Empty);

            return udpNode;
        }

        internal static TreeNode AddIcmpNode(TreeView treeView)
        {
            TreeNode icmpNode = treeView.Nodes.Add("ICMP", String.Empty);
            icmpNode.Nodes.Add("Type", String.Empty);
            icmpNode.Nodes.Add("Code", String.Empty);
            icmpNode.Nodes.Add("Checksum", String.Empty);
            icmpNode.Nodes.Add("Id", String.Empty);
            icmpNode.Nodes.Add("SeqNumber", String.Empty);

            return icmpNode;
        }

        #endregion


        #region Update Methods

        internal static void UpdateFrameNode(TreeView treeView, Packet frame)
        {
            TreeNode frameNode = treeView.Nodes["Frame"];
            if (frameNode == null)
            {
                frameNode = AddFrameNode(treeView);
            }

            frameNode.Text = String.Format("Frame ({0} bytes on wire, {1} bytes captured)", frame.PcapHeader.PacketLength, frame.PcapHeader.CaptureLength);
            frameNode.Nodes["ArrivalTime"].Text = String.Format("Arrival Time: {0}", frame.PcapHeader.Date);
            frameNode.Nodes["FrameLength"].Text = String.Format("Frame Length: {0} bytes", frame.PcapHeader.PacketLength);
            frameNode.Nodes["CaptureLength"].Text = String.Format("Capture Length: {0} bytes", frame.PcapHeader.CaptureLength);
        }

        internal static void UpdateEthernetNode(TreeView treeView, EthernetPacket ethPacket)
        {
            TreeNode ethNode = treeView.Nodes["Ethernet"];
            if (ethNode == null)
            {
                ethNode = AddEthernetNode(treeView);
            }

            ethNode.Text = String.Format("Ethernet II, Src: {0}, Dst: {1}", GetHyphenatedHwAddress(ethPacket.SourceHwAddress), GetHyphenatedHwAddress(ethPacket.DestinationHwAddress));
            ethNode.Nodes["Destination"].Text = String.Format("Destination: {0}", GetHyphenatedHwAddress(ethPacket.DestinationHwAddress));
            ethNode.Nodes["Source"].Text = String.Format("Source: {0}", GetHyphenatedHwAddress(ethPacket.SourceHwAddress));
            ethNode.Nodes["Type"].Text = String.Format("Type: {0} (0x{1:X4})", DataStructures.GetEtherTypeDescription(ethPacket.EthernetProtocol), (int)ethPacket.EthernetProtocol);
        }

        internal static void UpdateArpNode(TreeView treeView, ARPPacket arpPacket)
        {
            TreeNode arpNode = treeView.Nodes["ARP"];
            if (arpNode == null)
            {
                arpNode = AddArpNode(treeView);
            }

            arpNode.Text = String.Format("Address Resolution Protocol ({0})", DataStructures.GetARPOpDescription(arpPacket.ARPOperation));
            arpNode.Nodes["HwType"].Text = String.Format("Hardware type: {0} (0x{1:X4})", DataStructures.GetARPHwTypeDescription(arpPacket.ARPHwType), arpPacket.ARPHwType);
            arpNode.Nodes["ProtocolType"].Text = String.Format("Protocol type: {0} (0x{1:X4})", DataStructures.GetEtherTypeDescription((EthernetPacketType)arpPacket.ARPProtocolType), arpPacket.ARPProtocolType);
            arpNode.Nodes["HwSize"].Text = String.Format("Hardware size: {0}", arpPacket.ARPHwLength);
            arpNode.Nodes["ProtocolSize"].Text = String.Format("Protocol size: {0}", arpPacket.ARPProtocolLength);
            arpNode.Nodes["Opcode"].Text = String.Format("Operation: {0} (0x{1:X4})", DataStructures.GetARPOpDescription(arpPacket.ARPOperation), arpPacket.ARPOperation);
            arpNode.Nodes["SenderHwAddress"].Text = String.Format("Sender MAC address: {0}", GetHyphenatedHwAddress(arpPacket.ARPSenderHwAddress));
            arpNode.Nodes["SenderIPAddress"].Text = String.Format("Sender IP address: {0}", arpPacket.ARPSenderProtoAddress);
            arpNode.Nodes["TargetHwAddress"].Text = String.Format("Target MAC address: {0}", GetHyphenatedHwAddress(arpPacket.ARPTargetHwAddress));
            arpNode.Nodes["TargetIPAddress"].Text = String.Format("Target IP address: {0}", arpPacket.ARPTargetProtoAddress);
        }

        internal static void UpdateIPv4Node(TreeView treeView, IPv4Packet ipv4Packet)
        {
            TreeNode ipv4Node = treeView.Nodes["IPv4"];
            if (ipv4Node == null)
            {
                ipv4Node = AddIPv4Node(treeView);
            }

            ipv4Node.Text = String.Format("Internet Protocol V4 (IPv4), Src: {0}, Dst: {1}", ipv4Packet.SourceAddress, ipv4Packet.DestinationAddress);
            ipv4Node.Nodes["Version"].Text = String.Format("Version: {0}", ipv4Packet.Version);
            ipv4Node.Nodes["IHL"].Text = String.Format("Header length: {0} bytes", ipv4Packet.IPHeaderLength);

            TreeNode dsNode = ipv4Node.Nodes["DS"];
            dsNode.Text = String.Format("Differentiated Services field: 0x{0:X2}", ipv4Packet.TypeOfService);
            dsNode.Nodes["Precedence"].Text = GetIPv4PrecedenceText(ipv4Packet.Precedence);
            bool minimizeDelay = ipv4Packet.MinimizeDelay;
            dsNode.Nodes["Delay"].Text = String.Format(". . . {0}  . . . . = Delay: {1}", minimizeDelay ? "1" : "0", minimizeDelay ? "Low" : "Normal");
            bool maximizeThroughput = ipv4Packet.MaximizeThroughput;
            dsNode.Nodes["Throughput"].Text = String.Format(". . . .  {0} . . . = Throughput: {1}", maximizeThroughput ? "1" : "0", maximizeThroughput ? "High" : "Normal");
            bool maximizeReliability = ipv4Packet.MaximizeReliability;
            dsNode.Nodes["Reliability"].Text = String.Format(". . . .  . {0} . . = Reliability: {1}", maximizeReliability ? "1" : "0", maximizeReliability ? "High" : "Normal");
            bool minimizeCost = ipv4Packet.MinimizeMonetaryCost;
            dsNode.Nodes["Cost"].Text = String.Format(". . . .  . . {0} . = Cost: {1}", minimizeCost ? "1" : "0", minimizeCost ? "Minimize Monetary Cost" : "Normal");

            ipv4Node.Nodes["TotalLength"].Text = String.Format("Total length: {0} bytes", ipv4Packet.IPTotalLength);
            ipv4Node.Nodes["Id"].Text = String.Format("Identification: 0x{0:X4} ({0})", ipv4Packet.Id);

            TreeNode flagsNode = ipv4Node.Nodes["Flags"];
            flagsNode.Text = String.Format("Flags: 0x{0:X2}", ipv4Packet.FragmentFlags);
            flagsNode.Nodes["Reserved"].Text = String.Format("{0} . . = Reserved bit: {1}", ipv4Packet.ReservedFlag ? "1" : "0", ipv4Packet.ReservedFlag ? "Set" : "Not set");
            flagsNode.Nodes["DF"].Text = String.Format(". {0} . = Don't fragment: {1}", ipv4Packet.DontFragment ? "1" : "0", ipv4Packet.DontFragment ? "Set" : "Not set");
            flagsNode.Nodes["MF"].Text = String.Format(". . {0} = More fragments: {1}", ipv4Packet.MoreFragments ? "1" : "0", ipv4Packet.MoreFragments ? "Set" : "Not set");

            ipv4Node.Nodes["FragmentOffset"].Text = String.Format("Fragment offset: {0}", ipv4Packet.FragmentOffset);
            ipv4Node.Nodes["TTL"].Text = String.Format("Time to live: {0}", ipv4Packet.TimeToLive);
            ipv4Node.Nodes["Protocol"].Text = String.Format("Protocol: {0}", IPProtocol.getDescription(ipv4Packet.IPProtocol));
            ipv4Node.Nodes["Checksum"].Text = String.Format("Header checksum: 0x{0:X4} ({1})", ipv4Packet.IPChecksum, ipv4Packet.ValidIPChecksum ? "correct" : "incorrect");
            ipv4Node.Nodes["SA"].Text = String.Format("Source address: {0}", ipv4Packet.SourceAddress);
            ipv4Node.Nodes["DA"].Text = String.Format("Destination address: {0}", ipv4Packet.DestinationAddress);
        }

        internal static void UpdateTcpNode(TreeView treeView, TCPPacket tcpPacket)
        {
            TreeNode tcpNode = treeView.Nodes["TCP"];
            if (tcpNode == null)
            {
                tcpNode = AddTcpNode(treeView);
            }

            tcpNode.Text = String.Format("Transmission Control Protocol, Src port: {0}, Dst port: {1}", tcpPacket.SourcePort, tcpPacket.DestinationPort);
            tcpNode.Nodes["SrcPort"].Text = String.Format("Source port: {0}", tcpPacket.SourcePort);
            tcpNode.Nodes["DstPort"].Text = String.Format("Destination port: {0}", tcpPacket.DestinationPort);
            // If the SYN flag is set, then this is the initial sequence number - ISN
            tcpNode.Nodes["SeqNumber"].Text = String.Format("Sequence number: {0}{1}", tcpPacket.SequenceNumber, tcpPacket.Syn ? " (ISN)" : String.Empty);

            // If the ACK flag is set, only then we have a valid value in
            // the acknowlegement field
            if (tcpPacket.Ack)
            {
                if (tcpNode.Nodes["AckNumber"] == null)
                {
                    int seqNumberIndex = tcpNode.Nodes["SeqNumber"].Index;

                    tcpNode.Nodes.Insert(seqNumberIndex + 1, "AckNumber", String.Empty);
                }
                tcpNode.Nodes["AckNumber"].Text = String.Format("Acknowledgment number: {0}", tcpPacket.AcknowledgmentNumber);
            }
            else if (tcpNode.Nodes["AckNumber"] != null)
            {
                tcpNode.Nodes["AckNumber"].Remove();
            }

            tcpNode.Nodes["HeaderLength"].Text = String.Format("Header length: {0} bytes", tcpPacket.HeaderLength);

            TreeNode flagsNode = tcpNode.Nodes["Flags"];
            flagsNode.Text = String.Format("Flags: 0x{0:X2}", tcpPacket.AllFlags & 0xff);
            flagsNode.Nodes["CWR"].Text = String.Format("{0} . . .  . . . . = Congestion Window Reduced: {1}", tcpPacket.CWR ? "1" : "0", tcpPacket.CWR ? "Set" : "Not set");
            flagsNode.Nodes["ECN"].Text = String.Format(". {0} . .  . . . . = ECN-Echo: {1}", tcpPacket.ECN ? "1" : "0", tcpPacket.ECN ? "Set" : "Not set");
            flagsNode.Nodes["Urg"].Text = String.Format(". . {0} .  . . . . = Urgent: {1}", tcpPacket.Urg ? "1" : "0", tcpPacket.Urg ? "Set" : "Not set");
            flagsNode.Nodes["Ack"].Text = String.Format(". . . {0}  . . . . = Acknowledgement: {1}", tcpPacket.Ack ? "1" : "0", tcpPacket.Ack ? "Set" : "Not set");
            flagsNode.Nodes["Psh"].Text = String.Format(". . . .  {0} . . . = Push: {1}", tcpPacket.Psh ? "1" : "0", tcpPacket.Psh ? "Set" : "Not set");
            flagsNode.Nodes["Rst"].Text = String.Format(". . . .  . {0} . . = Reset: {1}", tcpPacket.Rst ? "1" : "0", tcpPacket.Rst ? "Set" : "Not set");
            flagsNode.Nodes["Syn"].Text = String.Format(". . . .  . . {0} . = Syn: {1}", tcpPacket.Syn ? "1" : "0", tcpPacket.Syn ? "Set" : "Not set");
            flagsNode.Nodes["Fin"].Text = String.Format(". . . .  . . . {0} = Fin: {1}", tcpPacket.Fin ? "1" : "0", tcpPacket.Fin ? "Set" : "Not set");

            tcpNode.Nodes["WindowSize"].Text = String.Format("Window size: {0} bytes", tcpPacket.WindowSize);
            tcpNode.Nodes["Checksum"].Text = String.Format("Checksum: 0x{0:X4} ({1})", tcpPacket.TCPChecksum, tcpPacket.ValidTCPChecksum ? "correct" : "incorrect");

            // If the URG flag is set, only then we have a valid 
            // value in the urgent pointer field
            if (tcpPacket.Urg)
            {
                if (tcpNode.Nodes["UrgPtr"] == null)
                {
                    tcpNode.Nodes.Add("UrgPtr", String.Empty);
                }
                tcpNode.Nodes["UrgPtr"].Text = String.Format("Urgent pointer: {0}", tcpPacket.getUrgentPointer());
            }
            else if (tcpNode.Nodes["UrgPtr"] != null)
            {
                tcpNode.Nodes["UrgPtr"].Remove();
            }
        }

        internal static void UpdateUdpNode(TreeView treeView, UDPPacket udpPacket)
        {
            TreeNode udpNode = treeView.Nodes["UDP"];
            if (udpNode == null)
            {
                udpNode = AddUdpNode(treeView);
            }

            udpNode.Text = String.Format("User Datagram Protocol, Src port: {0}, Dst port: {1}", udpPacket.SourcePort, udpPacket.DestinationPort);
            udpNode.Nodes["SrcPort"].Text = String.Format("Source port: {0}", udpPacket.SourcePort);
            udpNode.Nodes["DstPort"].Text = String.Format("Destination port: {0}", udpPacket.DestinationPort);
            udpNode.Nodes["Length"].Text = String.Format("Length: {0} bytes", udpPacket.Length);
            udpNode.Nodes["Checksum"].Text = String.Format("Checksum: 0x{0:X4} ({1})", udpPacket.UDPChecksum, udpPacket.ValidUDPChecksum ? "correct" : "incorrect");
        }

        internal static void UpdateIcmpNode(TreeView treeView, ICMPPacket icmpPacket)
        {
            TreeNode icmpNode = treeView.Nodes["ICMP"];
            if (icmpNode == null)
            {
                icmpNode = AddIcmpNode(treeView);
            }

            icmpNode.Text = String.Format("Internet Control Message Protocol: {0}", ICMPMessage.getDescription(icmpPacket.MessageKey));
            icmpNode.Nodes["Type"].Text = String.Format("Type: {0}", icmpPacket.MessageType);
            icmpNode.Nodes["Code"].Text = String.Format("Code: {0}", icmpPacket.MessageCode);
            icmpNode.Nodes["Checksum"].Text = String.Format("Checksum: 0x{0:X4} ({1})", icmpPacket.ICMPChecksum, icmpPacket.ValidICMPChecksum ? "correct" : "incorrect");

            if (icmpPacket.IsEchoRequestOrReply)
            {
                if (icmpNode.Nodes["Id"] == null)
                {
                    icmpNode.Nodes.Add("Id", String.Empty);
                    icmpNode.Nodes.Add("SeqNumber", String.Empty);
                }
                icmpNode.Nodes["Id"].Text = String.Format("Identifier: {0}", icmpPacket.Id);
                icmpNode.Nodes["SeqNumber"].Text = String.Format("Sequence number: {0}", icmpPacket.SequenceNumber);
            }
            else if (icmpNode.Nodes["Id"] != null)
            {
                icmpNode.Nodes["Id"].Remove();
                icmpNode.Nodes["SeqNumber"].Remove();
            }
        }

        internal static void UpdateTreeView(Packet packet, TreeView treeView)
        {
            // the packet's network layer data is an IP datagram

            UpdateFrameNode(treeView, packet);

            if (packet is EthernetPacket)
            {
                UpdateEthernetNode(treeView, (EthernetPacket)packet);
            }
            else
            {
                RemoveNode("Ethernet", treeView);
            }

            // the packet is an ARP packet
            if (packet is ARPPacket)
            {
                UpdateArpNode(treeView, (ARPPacket)packet);
            }
            else
            {
                RemoveNode("ARP", treeView);
            }

            if (packet is IPPacket && ((IPPacket)packet).IPVersion == IPPacket.IPVersions.IPv4)
            {
                UpdateIPv4Node(treeView, ((IPPacket)packet).ipv4);
            }
            else
            {
                RemoveNode("IPv4", treeView);
            }

            // the packet is an ICMP packet
            if (packet is ICMPPacket)
            {
                UpdateIcmpNode(treeView, (ICMPPacket)packet);
            }
            else
            {
                RemoveNode("ICMP", treeView);
            }

            // the packet's transport layer data is a TCP segment
            if (packet is TCPPacket)
            {
                UpdateTcpNode(treeView, (TCPPacket)packet);
            }
            else
            {
                RemoveNode("TCP", treeView);
            }

            // the packet's transport layer data is a UDP datagram
            if (packet is UDPPacket)
            {
                UpdateUdpNode(treeView, (UDPPacket)packet);
            }
            else
            {
                RemoveNode("UDP", treeView);
            }
        }

        #endregion


        #region RemoveMethods

        internal static void RemoveNode(string key, TreeView treeView)
        {
            if (treeView.Nodes[key] != null)
            {
                treeView.Nodes[key].Remove();
            }
        }

        #endregion

        #endregion


        #region Auxiliary Static Methods

        private static string GetIPv4PrecedenceText(int precedence)
        {
            string description = DataStructures.GetIPv4PrecedenceDescription(precedence);

            switch (precedence)
            {
                case 0:
                    return String.Format("000 .  . . . . = Precedence: {0} (0)", description);
                case 1:
                    return String.Format("001 .  . . . . = Precedence: {0} (1)", description);
                case 2:
                    return String.Format("010 .  . . . . = Precedence: {0} (2)", description);
                case 3:
                    return String.Format("011 .  . . . . = Precedence: {0} (3)", description);
                case 4:
                    return String.Format("100 .  . . . . = Precedence: {0} (4)", description);
                case 5:
                    return String.Format("101 .  . . . . = Precedence: {0} (5)", description);
                case 6:
                    return String.Format("110 .  . . . . = Precedence: {0} (6)", description);
                case 7:
                    return String.Format("111 .  . . . . = Precedence: {0} (7)", description);
                default:
                    return String.Empty;
            }
        }

        public static string GetHyphenatedHwAddress(PhysicalAddress hwAddress)
        {
            return BitConverter.ToString(hwAddress.GetAddressBytes());
        }

        #endregion
    }
}
