using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace TrafficDissector.UI
{
    internal partial class DetailedSummaryForm : BaseForm
    {
        #region Constructor

        public DetailedSummaryForm()
        {
            InitializeComponent();

            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();

            richTextBoxIPGlobalStatistics.Text =
                String.Format("{0}{1}",
                GetIPGlobalStatistics(NetworkInterfaceComponent.IPv4, properties),
                GetIPGlobalStatistics(NetworkInterfaceComponent.IPv6, properties));

            richTextBoxIcmpStatistics.Text =
                String.Format("{0}{1}",
                GetIcmpV4Statistics(properties),
                GetIcmpV6Statistics(properties));

            richTextBoxTcpStatistics.Text =
                String.Format("{0}{1}",
                GetTcpStatistics(NetworkInterfaceComponent.IPv4, properties),
                GetTcpStatistics(NetworkInterfaceComponent.IPv6, properties));

            richTextBoxUdpStatistics.Text =
                String.Format("{0}{1}",
                GetUdpStatistics(NetworkInterfaceComponent.IPv4, properties),
                GetUdpStatistics(NetworkInterfaceComponent.IPv6, properties));
        }

        #endregion


        #region Gather Statistics Methods

        private string GetIPGlobalStatistics(
            NetworkInterfaceComponent version,
            IPGlobalProperties properties)
        {
            IPGlobalStatistics ipStat = null;

            StringBuilder ipStatBuilder = new StringBuilder();

            try
            {
                switch (version)
                {
                    case NetworkInterfaceComponent.IPv4:
                        ipStat = properties.GetIPv4GlobalStatistics();
                        ipStatBuilder.Append("IPv4 Global Statistics\n");
                        break;
                    case NetworkInterfaceComponent.IPv6:
                        ipStat = properties.GetIPv6GlobalStatistics();
                        ipStatBuilder.Append("IPv6 Global Statistics:");
                        break;
                    default:
                        throw new ArgumentException("No such IP version");

                }
            }
            catch (NetworkInformationException)
            {
                return String.Empty;
            }

            ipStatBuilder.Append("=================================================\n");

            ipStatBuilder.AppendFormat(" Computer name ................. : {0}\n",
                properties.HostName);
            ipStatBuilder.AppendFormat(" Domain name ................... : {0}\n",
                properties.DomainName);
            ipStatBuilder.AppendFormat(" Node type ..................... : {0}\n",
                properties.NodeType);
            ipStatBuilder.AppendFormat(" DHCP scope .................... : {0}\n",
                properties.DhcpScopeName);
            ipStatBuilder.AppendFormat(" Is WINS proxy ................. : {0}\n",
                properties.IsWinsProxy);

            ipStatBuilder.AppendFormat(" Forwarding enabled ............ : {0}\n",
                ipStat.ForwardingEnabled);
            ipStatBuilder.AppendFormat(" Interfaces .................... : {0}\n",
                ipStat.NumberOfInterfaces);
            ipStatBuilder.AppendFormat(" IP addresses .................. : {0}\n",
                ipStat.NumberOfIPAddresses);
            ipStatBuilder.AppendFormat(" Routes ........................ : {0}\n",
                ipStat.NumberOfRoutes);
            ipStatBuilder.AppendFormat(" Default TTL ................... : {0}\n\n",
                ipStat.DefaultTtl);

            ipStatBuilder.AppendFormat(" Inbound Packet Data:\n");
            ipStatBuilder.AppendFormat("  Received ..................... : {0}\n",
                ipStat.ReceivedPackets);
            ipStatBuilder.AppendFormat("  Forwarded .................... : {0}\n",
                ipStat.ReceivedPacketsForwarded);
            ipStatBuilder.AppendFormat("  Delivered .................... : {0}\n",
                ipStat.ReceivedPacketsDelivered);
            ipStatBuilder.AppendFormat("  Discarded .................... : {0}\n",
                ipStat.ReceivedPacketsDiscarded);
            ipStatBuilder.AppendFormat("  Header Errors ................ : {0}\n",
                ipStat.ReceivedPacketsWithHeadersErrors);
            ipStatBuilder.AppendFormat("  Address Errors ............... : {0}\n",
                ipStat.ReceivedPacketsWithAddressErrors);
            ipStatBuilder.AppendFormat("  Unknown Protocol Errors ...... : {0}\n\n",
                ipStat.ReceivedPacketsWithUnknownProtocol);

            ipStatBuilder.AppendFormat(" Outbound Packet Data:\n");
            ipStatBuilder.AppendFormat("  Requested .................... : {0}\n",
                 ipStat.OutputPacketRequests);
            ipStatBuilder.AppendFormat("  Discarded .................... : {0}\n",
                ipStat.OutputPacketsDiscarded);
            ipStatBuilder.AppendFormat("  No Routing Discards .......... : {0}\n",
                ipStat.OutputPacketsWithNoRoute);
            ipStatBuilder.AppendFormat("  Routing Entry Discards ....... : {0}\n\n",
                ipStat.OutputPacketRoutingDiscards);

            ipStatBuilder.AppendFormat(" Reassembly Data:\n");
            ipStatBuilder.AppendFormat("  Reassembly Timeout ........... : {0}\n",
                ipStat.PacketReassemblyTimeout);
            ipStatBuilder.AppendFormat("  Reassemblies Required ........ : {0}\n",
                ipStat.PacketReassembliesRequired);
            ipStatBuilder.AppendFormat("  Reassembly Failures .......... : {0}\n",
                ipStat.PacketReassemblyFailures);
            ipStatBuilder.AppendFormat("  Packets Reassembled .......... : {0}\n",
                ipStat.PacketsReassembled);
            ipStatBuilder.AppendFormat("  Packets Fragmented ........... : {0}\n",
                ipStat.PacketsFragmented);
            ipStatBuilder.AppendFormat("  Fragment Failures ............ : {0}\n",
                ipStat.PacketFragmentFailures);

            return ipStatBuilder.ToString();
        }

        private string GetIcmpV4Statistics(IPGlobalProperties properties)
        {
            IcmpV4Statistics icmpV4Stat = null;

            StringBuilder icmpV4StatBuilder = new StringBuilder();

            try
            {
                icmpV4Stat = properties.GetIcmpV4Statistics();
            }
            catch (NetworkInformationException)
            {
                return String.Empty;
            }

            icmpV4StatBuilder.Append("ICMPv4 Statistics\n");
            icmpV4StatBuilder.Append("=================================================\n");

            icmpV4StatBuilder.AppendFormat(" Messages ...................... : Sent: {0,-10} Received: {1,-10}\n",
                icmpV4Stat.MessagesSent, icmpV4Stat.MessagesReceived);
            icmpV4StatBuilder.AppendFormat(" Errors ........................ : Sent: {0,-10} Received: {1,-10}\n",
                icmpV4Stat.ErrorsSent, icmpV4Stat.ErrorsReceived);

            icmpV4StatBuilder.AppendFormat(" Echo Requests ................. : Sent: {0,-10} Received: {1,-10}\n",
                icmpV4Stat.EchoRequestsSent, icmpV4Stat.EchoRequestsReceived);
            icmpV4StatBuilder.AppendFormat(" Echo Replies .................. : Sent: {0,-10} Received: {1,-10}\n",
                icmpV4Stat.EchoRepliesSent, icmpV4Stat.EchoRepliesReceived);

            icmpV4StatBuilder.AppendFormat(" Destination Unreachables ...... : Sent: {0,-10} Received: {1,-10}\n",
                icmpV4Stat.DestinationUnreachableMessagesSent, icmpV4Stat.DestinationUnreachableMessagesReceived);
            icmpV4StatBuilder.AppendFormat(" Source Quenches ............... : Sent: {0,-10} Received: {1,-10}\n",
                icmpV4Stat.SourceQuenchesSent, icmpV4Stat.SourceQuenchesReceived);

            icmpV4StatBuilder.AppendFormat(" Redirects ..................... : Sent: {0,-10} Received: {1,-10}\n",
                icmpV4Stat.RedirectsSent, icmpV4Stat.RedirectsReceived);
            icmpV4StatBuilder.AppendFormat(" TimeExceeded .................. : Sent: {0,-10} Received: {1,-10}\n",
                icmpV4Stat.TimeExceededMessagesSent, icmpV4Stat.TimeExceededMessagesReceived);

            icmpV4StatBuilder.AppendFormat(" Parameter Problems ............ : Sent: {0,-10} Received: {1,-10}\n",
                icmpV4Stat.ParameterProblemsSent, icmpV4Stat.ParameterProblemsReceived);
            icmpV4StatBuilder.AppendFormat(" Timestamp Requests ............ : Sent: {0,-10} Received: {1,-10}\n",
                icmpV4Stat.TimestampRequestsSent, icmpV4Stat.TimestampRequestsReceived);

            icmpV4StatBuilder.AppendFormat(" Timestamp Replies ............. : Sent: {0,-10} Received: {1,-10}\n",
                icmpV4Stat.TimestampRepliesSent, icmpV4Stat.TimestampRepliesReceived);
            icmpV4StatBuilder.AppendFormat(" Address Mask Requests ......... : Sent: {0,-10} Received: {1,-10}\n",
                icmpV4Stat.AddressMaskRequestsSent, icmpV4Stat.AddressMaskRequestsReceived);

            icmpV4StatBuilder.AppendFormat(" Address Mask Replies .......... : Sent: {0,-10} Received: {1,-10}\n",
                icmpV4Stat.AddressMaskRepliesSent, icmpV4Stat.AddressMaskRepliesReceived);

            return icmpV4StatBuilder.ToString();
        }

        private string GetIcmpV6Statistics(IPGlobalProperties properties)
        {
            IcmpV6Statistics icmpV6Stat = null;

            StringBuilder icmpV6StatBuilder = new StringBuilder();

            try
            {
                icmpV6Stat = properties.GetIcmpV6Statistics();
            }
            catch (NetworkInformationException)
            {
                return String.Empty;
            }

            icmpV6StatBuilder.Append("ICMPv6 Statistics\n");
            icmpV6StatBuilder.Append("=================================================\n");

            icmpV6StatBuilder.AppendFormat(" Messages ...................... : Sent: {0,-10} Received: {1,-10}\n",
                icmpV6Stat.MessagesSent, icmpV6Stat.MessagesReceived);
            icmpV6StatBuilder.AppendFormat(" Errors ........................ : Sent: {0,-10} Received: {1,-10}\n",
                icmpV6Stat.ErrorsSent, icmpV6Stat.ErrorsReceived);

            icmpV6StatBuilder.AppendFormat(" Echo Requests ................. : Sent: {0,-10} Received: {1,-10}\n",
                icmpV6Stat.EchoRequestsSent, icmpV6Stat.EchoRequestsReceived);
            icmpV6StatBuilder.AppendFormat(" Echo Replies .................. : Sent: {0,-10} Received: {1,-10}\n",
                icmpV6Stat.EchoRepliesSent, icmpV6Stat.EchoRepliesReceived);

            icmpV6StatBuilder.AppendFormat(" Destination Unreachables ...... : Sent: {0,-10} Received: {1,-10}\n",
                icmpV6Stat.DestinationUnreachableMessagesSent, icmpV6Stat.DestinationUnreachableMessagesReceived);
            icmpV6StatBuilder.AppendFormat(" Parameter Problems ............ : Sent: {0,-10} Received: {1,-10}\n",
                icmpV6Stat.ParameterProblemsSent, icmpV6Stat.ParameterProblemsReceived);

            icmpV6StatBuilder.AppendFormat(" Packets Too Big ............... : Sent: {0,-10} Received: {1,-10}\n",
                icmpV6Stat.PacketTooBigMessagesSent, icmpV6Stat.PacketTooBigMessagesReceived);
            icmpV6StatBuilder.AppendFormat(" Redirects ..................... : Sent: {0,-10} Received: {1,-10}\n",
                icmpV6Stat.RedirectsSent, icmpV6Stat.RedirectsReceived);

            icmpV6StatBuilder.AppendFormat(" Router Advertisements ......... : Sent: {0,-10} Received: {1,-10}\n",
                icmpV6Stat.RouterAdvertisementsSent, icmpV6Stat.RouterAdvertisementsReceived);
            icmpV6StatBuilder.AppendFormat(" Router Solicitations .......... : Sent: {0,-10} Received: {1,-10}\n",
                icmpV6Stat.RouterSolicitsSent, icmpV6Stat.RouterSolicitsReceived);

            icmpV6StatBuilder.AppendFormat(" Time Exceeded ................. : Sent: {0,-10} Received: {1,-10}\n",
                icmpV6Stat.TimeExceededMessagesSent, icmpV6Stat.TimeExceededMessagesReceived);
            icmpV6StatBuilder.AppendFormat(" Neighbor Advertisements ....... : Sent: {0,-10} Received: {1,-10}\n",
                icmpV6Stat.NeighborAdvertisementsSent, icmpV6Stat.NeighborAdvertisementsReceived);

            icmpV6StatBuilder.AppendFormat(" Neighbor Solicitations ........ : Sent: {0,-10} Received: {1,-10}\n",
                icmpV6Stat.NeighborSolicitsSent, icmpV6Stat.NeighborSolicitsReceived);
            icmpV6StatBuilder.AppendFormat(" Membership Queries ............ : Sent: {0,-10} Received: {1,-10}\n",
                icmpV6Stat.MembershipQueriesSent, icmpV6Stat.MembershipQueriesReceived);

            icmpV6StatBuilder.AppendFormat(" Membership Reports ............ : Sent: {0,-10} Received: {1,-10}\n",
                icmpV6Stat.MembershipReportsSent, icmpV6Stat.MembershipReportsReceived);
            icmpV6StatBuilder.AppendFormat(" Membership Reductions ......... : Sent: {0,-10} Received: {1,-10}\n",
                icmpV6Stat.MembershipReductionsSent, icmpV6Stat.MembershipReductionsReceived);

            return icmpV6StatBuilder.ToString();
        }

        private string GetTcpStatistics(
            NetworkInterfaceComponent version,
            IPGlobalProperties properties)
        {
            TcpStatistics tcpStat = null;

            StringBuilder tcpStatBuilder = new StringBuilder();

            try
            {
                switch (version)
                {
                    case NetworkInterfaceComponent.IPv4:
                        tcpStat = properties.GetTcpIPv4Statistics();
                        tcpStatBuilder.Append("TCP/IPv4 Statistics\n");
                        break;
                    case NetworkInterfaceComponent.IPv6:
                        tcpStat = properties.GetTcpIPv6Statistics();
                        tcpStatBuilder.Append("TCP/IPv6 Statistics\n");
                        break;
                    default:
                        throw new ArgumentException("No such IP version");

                }
            }
            catch (NetworkInformationException)
            {
                return String.Empty;
            }

            tcpStatBuilder.Append("=================================================\n");

            tcpStatBuilder.AppendFormat(" Minimum Transmission Timeout .. : {0}\n",
                tcpStat.MinimumTransmissionTimeout);
            tcpStatBuilder.AppendFormat(" Maximum Transmission Timeout .. : {0}\n",
                tcpStat.MaximumTransmissionTimeout);
            tcpStatBuilder.AppendFormat(" Maximum Connections ........... : {0}\n",
                tcpStat.MaximumConnections);

            tcpStatBuilder.AppendFormat(" Connection Data:\n");
            tcpStatBuilder.AppendFormat("  Current ...................... : {0}\n",
            tcpStat.CurrentConnections);
            tcpStatBuilder.AppendFormat("  Cumulative ................... : {0}\n",
                tcpStat.CumulativeConnections);
            tcpStatBuilder.AppendFormat("  Initiated .................... : {0}\n",
                tcpStat.ConnectionsInitiated);
            tcpStatBuilder.AppendFormat("  Accepted ..................... : {0}\n",
                tcpStat.ConnectionsAccepted);
            tcpStatBuilder.AppendFormat("  Failed Attempts .............. : {0}\n",
                tcpStat.FailedConnectionAttempts);
            tcpStatBuilder.AppendFormat("  Reset ........................ : {0}\n",
                tcpStat.ResetConnections);
            tcpStatBuilder.AppendFormat("  Errors ....................... : {0}\n",
                tcpStat.ErrorsReceived);

            tcpStatBuilder.AppendFormat(" Segment Data:\n");
            tcpStatBuilder.AppendFormat("  Received ..................... : {0}\n",
                tcpStat.SegmentsReceived);
            tcpStatBuilder.AppendFormat("  Sent ......................... : {0}\n",
                tcpStat.SegmentsSent);
            tcpStatBuilder.AppendFormat("  Retransmitted ................ : {0}\n",
                tcpStat.SegmentsResent);
            tcpStatBuilder.AppendFormat("  Resent with reset ............ : {0}\n",
                tcpStat.ResetsSent);

            TcpConnectionInformation[] connectionsInfo = properties.GetActiveTcpConnections();

            tcpStatBuilder.AppendFormat(" Active Connections ............ : {0}\n",
                connectionsInfo.Length);

            if (connectionsInfo.Length > 0)
            {
                tcpStatBuilder.Append("  Local Address   Port   Remote Address  Port\n");
            }

            foreach (TcpConnectionInformation connectionInfo in connectionsInfo)
            {
                tcpStatBuilder.AppendFormat("  {0, -15}:{1}   {2, -15}:{3}\n",
                    connectionInfo.LocalEndPoint.Address,
                    connectionInfo.LocalEndPoint.Port,
                    connectionInfo.RemoteEndPoint.Address,
                    connectionInfo.RemoteEndPoint.Port);
            }

            IPEndPoint[] endPoints = properties.GetActiveTcpListeners();

            tcpStatBuilder.AppendFormat(" TCP Listeners ................. : {0}\n",
                endPoints.Length);

            if (endPoints.Length > 0)
            {
                tcpStatBuilder.Append("  Local Address   Port\n");
            }

            foreach (IPEndPoint endPoint in endPoints)
            {
                tcpStatBuilder.AppendFormat("  {0, -15}:{1}\n",
                    endPoint.Address, endPoint.Port);
            }

            return tcpStatBuilder.ToString();
        }

        private string GetUdpStatistics(
            NetworkInterfaceComponent version,
            IPGlobalProperties properties)
        {
            UdpStatistics udpStat = null;

            StringBuilder udpStatBuilder = new StringBuilder();

            try
            {
                switch (version)
                {
                    case NetworkInterfaceComponent.IPv4:
                        udpStat = properties.GetUdpIPv4Statistics();
                        udpStatBuilder.Append("UDP IPv4 Statistics\n");
                        break;
                    case NetworkInterfaceComponent.IPv6:
                        udpStat = properties.GetUdpIPv6Statistics();
                        udpStatBuilder.Append("UDP IPv6 Statistics\n");
                        break;
                    default:
                        throw new ArgumentException("No such IP version");
                }
            }
            catch (NetworkInformationException)
            {
                return String.Empty;
            }

            udpStatBuilder.Append("=================================================\n");

            udpStatBuilder.AppendFormat(" Datagrams Received ............ : {0}\n",
                udpStat.DatagramsReceived);
            udpStatBuilder.AppendFormat(" Datagrams Sent ................ : {0}\n",
                udpStat.DatagramsSent);
            udpStatBuilder.AppendFormat(" Incoming Datagrams Discarded .. : {0}\n",
                udpStat.IncomingDatagramsDiscarded);
            udpStatBuilder.AppendFormat(" Incoming Datagrams With Errors  : {0}\n",
                udpStat.IncomingDatagramsWithErrors);
            udpStatBuilder.AppendFormat(" UDP Listeners ................. : {0}\n",
                udpStat.UdpListeners);

            IPEndPoint[] endPoints = properties.GetActiveUdpListeners();

            if (endPoints.Length > 0)
            {
                udpStatBuilder.Append("  Local Address   Port\n");
            }

            foreach (IPEndPoint endPoint in endPoints)
            {
                udpStatBuilder.AppendFormat("  {0, -15}:{1}\n",
                    endPoint.Address, endPoint.Port);
            }

            return udpStatBuilder.ToString();
        }

        #endregion
    }
}