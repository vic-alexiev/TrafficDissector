// ************************************************************************
// Copyright (C) 2001, Patrick Charles and Jonas Lehmann                   *
// Distributed under the Mozilla Public License                            *
// http://www.mozilla.org/NPL/MPL-1.1.txt                                *
// *************************************************************************
using SharpPcap.Packets.Util;
using System.Collections;
namespace SharpPcap.Packets
{
    /// <summary> IPProtocol utility class.
    /// 
    /// </summary>
    public class IPProtocol
    {
        public enum IPProtocolType
        {
            /// <summary> IPv6 Hop-by-Hop option. </summary>
            HOPOPT = 0,
            /// <summary> Internet Control Message Protocol. </summary>
            ICMP = 1,
            /// <summary> Internet Group Management Protocol.</summary>
            IGMP = 2,
            /// <summary> IP in IP (encapsulation). </summary>
            IP = 4,
            /// <summary> Transmission Control Protocol. </summary>
            TCP = 6,
            /// <summary> Exterior Gateway Protocol. </summary>
            EGP = 8,
            /// <summary> Xerox PUP. </summary>
            PUP = 12,
            /// <summary> User Datagram Protocol. </summary>
            UDP = 17,
            /// <summary> XEROX NS IDP. </summary>
            XNS_IDP = 22,
            /// <summary> ISO Transport Protocol Class 4. </summary>
            ISO_TP4 = 29,
            /// <summary> IPv6. </summary>
            IPv6 = 41,
            /// <summary> Routing Header for IPv6. </summary>
            IPv6_Route = 43,
            /// <summary> Fragment Header for IPv6. </summary>
            IPv6_Frag = 44,
            /// <summary> Resource Reservation Protocol. </summary>
            RSVP = 46,
            /// <summary> Generic Routing Encapsulation. </summary>
            GRE = 47,
            /// <summary> Encapsulating Security Payload. </summary>
            ESP = 50,
            /// <summary> Authentication Header. </summary>
            AH = 51,
            /// <summary> ICMP for IPv6. </summary>
            IPv6_ICMP = 58,
            /// <summary> No Next Header for IPv6. </summary>
            IPv6_NoNxt = 59,
            /// <summary> Destination Options for IPv6. </summary>
            IPv6_Opts = 60,
            /// <summary> EIGRP. </summary>
            EIGRP = 88,
            /// <summary> Open Shortest Path First. </summary>
            OSPF = 89,
            /// <summary> Multicast Transport Protocol. </summary>
            MTP = 92,
            /// <summary> Encapsulation Header. </summary>
            ENCAP = 98,
            /// <summary> Protocol Independent Multicast. </summary>
            PIM = 103,
            /// <summary> IP Payload Compression Protocol. </summary>
            IPComp = 108,

            /// <summary> Unrecognized IP protocol.
            /// WARNING: this only works because the int storage for the protocol
            /// code has more bits than the field in the IP header where it is stored.
            /// </summary>
            INVALID = -1,

            /// <summary> IP protocol mask.</summary>
            MASK = 0xFF
        }

        /// <summary> Fetch a protocol description.</summary>
        /// <param name="code">the code associated with the message.
        /// </param>
        /// <returns> a message describing the significance of the IP protocol.
        /// </returns>
        public static string getDescription(IPProtocolType protocolType)
        {
            if (messages.ContainsKey(protocolType))
            {
                return messages[protocolType].ToString();
            }
            else
            {
                return "unknown";
            }
        }

        /// <summary> 'Human-readable' IP protocol descriptions.</summary>
        private static Hashtable messages = new Hashtable();
        public static Hashtable Messages
        {
            get { return messages; }
        }

        /// <summary> Extract the protocol code from packet data. The packet data 
        /// must contain an IP datagram.
        /// The protocol code specifies what kind of information is contained in the 
        /// data block of the ip datagram.
        /// 
        /// </summary>
        /// <param name="lLen">the length of the link-level header.
        /// </param>
        /// <param name="packetBytes">packet bytes, including the link-layer header.
        /// </param>
        /// <returns> the IP protocol code. i.e. 0x06 signifies TCP protocol.
        /// </returns>
        public static int extractProtocol(int lLen, byte[] packetBytes)
        {
            IPPacket.IPVersions ipVer = ExtractVersion(lLen, packetBytes);
            int protoOffset;

            switch (ipVer)
            {
                case IPPacket.IPVersions.IPv4:
                    protoOffset = IPv4Fields_Fields.IP_CODE_POS;
                    break;
                case IPPacket.IPVersions.IPv6:
                    protoOffset = IPv6Fields_Fields.NEXT_HEADER_POS;
                    break;
                default:
                    return -1;//unknown ip version
            }
            return packetBytes[lLen + protoOffset];
        }

        public static IPPacket.IPVersions ExtractVersion(int lLen, byte[] packetBytes)
        {
            return (IPPacket.IPVersions)((ArrayHelper.extractInteger(packetBytes,
                                                            lLen + IPv4Fields_Fields.IP_VER_POS,
                                                            IPv4Fields_Fields.IP_VER_LEN) >> 4) & 0xF);
        }

        static IPProtocol()
        {
            {
                messages[IPProtocolType.HOPOPT] = "IPv6 Hop-by-Hop Option";
                messages[IPProtocolType.ICMP] = "Internet Control Message Protocol";
                messages[IPProtocolType.IGMP] = "Internet Group Management Protocol";
                messages[IPProtocolType.IP] = "IP in IP (encapsulation)";
                messages[IPProtocolType.TCP] = "Transmission Control Protocol";
                messages[IPProtocolType.EGP] = "Exterior Gateway Protocol";
                messages[IPProtocolType.PUP] = "Xerox PUP";
                messages[IPProtocolType.UDP] = "User Datagram Protocol";
                messages[IPProtocolType.XNS_IDP] = "XEROX NS IDP";
                messages[IPProtocolType.ISO_TP4] = "ISO Transport Protocol Class 4";
                messages[IPProtocolType.IPv6] = "IPv6";
                messages[IPProtocolType.IPv6_Route] = "Routing Header for IPv6";
                messages[IPProtocolType.IPv6_Frag] = "Fragment Header for IPv6";
                messages[IPProtocolType.RSVP] = "Resource Reservation Protocol";
                messages[IPProtocolType.GRE] = "Generic Routing Encapsulation";
                messages[IPProtocolType.ESP] = "Encapsulating Security Payload";
                messages[IPProtocolType.AH] = "Authentication Header";
                messages[IPProtocolType.IPv6_ICMP] = "ICMP for IPv6";
                messages[IPProtocolType.IPv6_NoNxt] = "No Next Header for IPv6";
                messages[IPProtocolType.IPv6_Opts] = "Destination Options for IPv6";
                messages[IPProtocolType.EIGRP] = "EIGRP";
                messages[IPProtocolType.OSPF] = "Open Shortest Path First";
                messages[IPProtocolType.MTP] = "Multicast Transport Protocol";
                messages[IPProtocolType.ENCAP] = "Encapsulation Header";
                messages[IPProtocolType.PIM] = "Protocol Independent Multicast";
                messages[IPProtocolType.IPComp] = "IP Payload Compression Protocol";
            }
        }
    }
}
