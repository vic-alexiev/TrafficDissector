using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SharpPcap.Packets
{
    public struct ARPHardwareTypes_Fields
    {
        /// <summary> Ethernet (10Mb).</summary>
        public readonly static int ETHERNET_10MB = 1;
        /// <summary> Experimental Ethernet (3Mb).</summary>
        public readonly static int EXPERIMENTAL_ETHERNET_3MB = 2;
        /// <summary> Amateur Radio AX.25.</summary>
        public readonly static int AMATEUR_RADIO_AX25 = 3;
        /// <summary> Proteon ProNET Token Ring.</summary>
        public readonly static int PROTEON_PRONET_TOKEN_RING = 4;
        /// <summary> Chaos.</summary>
        public readonly static int CHAOS = 5;
        /// <summary> IEEE 802 Networks.</summary>
        public readonly static int IEEE802 = 6;
        /// <summary> ARCNET.</summary>
        public readonly static int ARCNET = 7;
        /// <summary> Hyperchannel.</summary>
        public readonly static int HYPERCHANNEL = 8;
        /// <summary> Lanstar.</summary>
        public readonly static int LANSTAR = 9;
        /// <summary> Autonet Short Address.</summary>
        public readonly static int AUTONET_SHORT_ADDRESS = 10;
        /// <summary> LocalTalk.</summary>
        public readonly static int LOCALTALK = 11;
        /// <summary> LocalNet (IBM PCNet or SYTEK LocalNET).</summary>
        public readonly static int LOCALNET = 12;
        /// <summary> Ultra link.</summary>
        public readonly static int ULTRA_LINK = 13;
        /// <summary> SMDS.</summary>
        public readonly static int SMDS = 14;
        /// <summary> Frame Relay.</summary>
        public readonly static int FRAME_RELAY = 15;
        /// <summary> Asynchronous Transmission Mode (ATM).</summary>
        public readonly static int ATM1 = 16;
        /// <summary> HDLC.</summary>
        public readonly static int HDLC = 17;
        /// <summary> Fibre Channel.</summary>
        public readonly static int FIBRE_CHANNEL = 18;
        /// <summary> Asynchronous Transmission Mode (ATM).</summary>
        public readonly static int ATM2 = 19;
        /// <summary> Serial Line.</summary>
        public readonly static int SERIAL_LINE = 20;
        /// <summary> Asynchronous Transmission Mode (ATM).</summary>
        public readonly static int ATM3 = 21;
        /// <summary> MIL-STD-188-220.</summary>
        public readonly static int MIL_STD_188_220 = 22;
        /// <summary> Metricom.</summary>
        public readonly static int METRICOM = 23;
        /// <summary> IEEE 1394.1995.</summary>
        public readonly static int IEEE1394_1995 = 24;
        /// <summary> MAPOS.</summary>
        public readonly static int MAPOS = 25;
        /// <summary> Twinaxial.</summary>
        public readonly static int TWINAXIAL = 26;
        /// <summary> EUI-64.</summary>
        public readonly static int EUI_64 = 27;
        /// <summary> HIPARP.</summary>
        public readonly static int HIPARP = 28;
        /// <summary> IP and ARP over ISO 7816-3.</summary>
        public readonly static int IP_ARPoISO7816_3 = 29;
        /// <summary> ARPSec.</summary>
        public readonly static int ARPSEC = 30;
        /// <summary> IPsec tunnel.</summary>
        public readonly static int IPSEC_TUNNEL = 31;
        /// <summary> InfiniBand (TM).</summary>
        public readonly static int INFINIBAND = 32;
        /// <summary> TIA-102 Project 25 Common Air Interface (CAI).</summary>
        public readonly static int CAI = 33;
        /// <summary> Wiegand Interface.</summary>
        public readonly static int WIEGAND_INTERFACE = 34;
        /// <summary> Pure IP.</summary>
        public readonly static int PURE_IP = 35;
        /// <summary> HW_EXP1.</summary>
        public readonly static int HW_EXP1 = 36;
        /// <summary> HW_EXP2.</summary>
        public readonly static int HW_EXP2 = 256;
    }

    public struct ARPOperations_Fields
    {
        /// <summary> Request.</summary>
        public readonly static int REQUEST = 1;
        /// <summary> Reply.</summary>
        public readonly static int REPLY = 2;
        /// <summary> request Reverse.</summary>
        public readonly static int REQUEST_REVERSE = 3;
        /// <summary> reply Reverse.</summary>
        public readonly static int REPLY_REVERSE = 4;
        /// <summary> DRARP-Request.</summary>
        public readonly static int DRARP_REQUEST = 5;
        /// <summary> DRARP-Reply.</summary>
        public readonly static int DRARP_REPLY = 6;
        /// <summary> DRARP-Error.</summary>
        public readonly static int DRARP_ERROR = 7;
        /// <summary> InARP-Request.</summary>
        public readonly static int INARP_REQUEST = 8;
        /// <summary> InARP-Reply.</summary>
        public readonly static int INARP_REPLY = 9;
        /// <summary> ARP-NAK.</summary>
        public readonly static int ARP_NAK = 10;
        /// <summary> MARS-Request.</summary>
        public readonly static int MARS_REQUEST = 11;
        /// <summary> MARS-Multi.</summary>
        public readonly static int MARS_MULTI = 12;
        /// <summary> MARS-MServ.</summary>
        public readonly static int MARS_MSERV = 13;
        /// <summary> MARS-Join.</summary>
        public readonly static int MARS_JOIN = 14;
        /// <summary> MARS-Leave.</summary>
        public readonly static int MARS_LEAVE = 15;
        /// <summary> MARS-NAK.</summary>
        public readonly static int MARS_NAK = 16;
        /// <summary> MARS-Unserv.</summary>
        public readonly static int MARS_UNSERV = 17;
        /// <summary> MARS-SJoin.</summary>
        public readonly static int MARS_SJOIN = 18;
        /// <summary> MARS-SLeave.</summary>
        public readonly static int MARS_SLEAVE = 19;
        /// <summary> MARS-Grouplist-Request.</summary>
        public readonly static int MARS_GROUPLIST_REQUEST = 20;
        /// <summary> MARS-Grouplist-Reply.</summary>
        public readonly static int MARS_GROUPLIST_REPLY = 21;
        /// <summary> MARS-Redirect-Map.</summary>
        public readonly static int MARS_REDIRECT_MAP = 22;
        /// <summary> MAPOS-UNARP.</summary>
        public readonly static int MAPOS_UNARP = 23;
        /// <summary> OP_EXP1.</summary>
        public readonly static int OP_EXP1 = 24;
        /// <summary> OP_EXP2.</summary>
        public readonly static int OP_EXP2 = 25;
    }

    public struct IPv4Precedence_Fields
    {
        /// <summary> Routine.</summary>
        public readonly static int ROUTINE = 0x0000;
        /// <summary> Priority.</summary>
        public readonly static int PRIORITY = 0x0001;
        /// <summary> Immediate.</summary>
        public readonly static int IMMEDIATE = 0x0002;
        /// <summary> Flash.</summary>
        public readonly static int FLASH = 0x0003;
        /// <summary> Flash Override.</summary>
        public readonly static int FLASH_OVERRIDE = 0x0004;
        /// <summary> CRITIC/ECP.</summary>
        public readonly static int CRITIC_ECP = 0x0005;
        /// <summary> Internetwork Control.</summary>
        public readonly static int INTERNETWORK_CONTROL = 0x0006;
        /// <summary> Network Control.</summary>
        public readonly static int NETWORK_CONTROL = 0x0007;
    }

    public static class DataStructures
    {
        #region Private Fields & Properties

        private static Hashtable ethernetTypes = new Hashtable();
        public static Hashtable EthernetTypes
        {
            get { return ethernetTypes; }
        }

        private static Hashtable ipv4Precedence = new Hashtable();
        public static Hashtable IPv4Precedence
        {
            get { return ipv4Precedence; }
        }

        private static Hashtable arpOperations = new Hashtable();
        public static Hashtable ARPOperations
        {
            get { return arpOperations; }
        }

        private static Hashtable arpHardwareTypes = new Hashtable();
        public static Hashtable ARPHardwareTypes
        {
            get { return arpHardwareTypes; }
        }

        #endregion


        #region Constructor

        static DataStructures()
        {
            InitEtherTypes();
            InitARPOperations();
            InitARPHardwareTypes();
            InitIPv4Precedence();
        }

        #endregion


        #region Private Methods

        private static void InitEtherTypes()
        {
            ethernetTypes[EthernetPacketType.None] = "unknown";
            ethernetTypes[EthernetPacketType.IPv4] = "Internet Protocol, Version 4 (IPv4)";
            ethernetTypes[EthernetPacketType.ARP] = "Address Resolution Protocol (ARP)";
            ethernetTypes[EthernetPacketType.WakeOnLAN] = "Wake-on-LAN Magic Packet";
            ethernetTypes[EthernetPacketType.SYN3] = "SYN-3 heartbeat protocol";
            ethernetTypes[EthernetPacketType.RARP] = "Reverse Address Resolution Protocol (RARP)";
            ethernetTypes[EthernetPacketType.AppleTalk] = "AppleTalk (Ethertalk)";
            ethernetTypes[EthernetPacketType.AppleTalkARP] = "AppleTalk Address Resolution Protocol (AARP)";
            ethernetTypes[EthernetPacketType.VLANTaggedFrame] = "VLAN-tagged frame (IEEE 802.1Q)";
            ethernetTypes[EthernetPacketType.NovellIPX] = "Novell IPX (alt)";
            ethernetTypes[EthernetPacketType.Novell] = "Novell";
            ethernetTypes[EthernetPacketType.IPv6] = "Internet Protocol, Version 6 (IPv6)";
            ethernetTypes[EthernetPacketType.MACControl] = "MAC Control";
            ethernetTypes[EthernetPacketType.CobraNet] = "CobraNet";
            ethernetTypes[EthernetPacketType.MPLSUnicast] = "MPLS unicast";
            ethernetTypes[EthernetPacketType.MPLSMulticast] = "MPLS multicast";
            ethernetTypes[EthernetPacketType.PPPoEDiscoveryStage] = "PPPoE Discovery Stage";
            ethernetTypes[EthernetPacketType.PPPoESessionStage] = "PPPoE Session Stage";
            ethernetTypes[EthernetPacketType.MicrosoftNLB] = "Microsoft NLB heartbeat";
            ethernetTypes[EthernetPacketType.EAPoLAN] = "EAP over LAN (IEEE 802.1X)";
            ethernetTypes[EthernetPacketType.HyperSCSI] = "HyperSCSI (SCSI over Ethernet)";
            ethernetTypes[EthernetPacketType.ATAoE] = "ATA over Ethernet";
            ethernetTypes[EthernetPacketType.EtherCAT] = "EtherCAT Protocol";
            ethernetTypes[EthernetPacketType.ProviderBridging] = "Provider Bridging (IEEE 802.1ad)";
            ethernetTypes[EthernetPacketType.EthernetPowerlink] = "Ethernet Powerlink";
            ethernetTypes[EthernetPacketType.SERCOSIII] = "SERCOS III";
            ethernetTypes[EthernetPacketType.CESoE] = "Circuit Emulation Services over Ethernet (MEF-8)";
            ethernetTypes[EthernetPacketType.HomePlug] = "HomePlug";
            ethernetTypes[EthernetPacketType.MACSecurity] = "MAC security (IEEE 802.1AE)";
            ethernetTypes[EthernetPacketType.PrecisionTimeProtocol] = "Precision Time Protocol (IEEE 1588)";
            ethernetTypes[EthernetPacketType.CFM_OAM] = "IEEE 802.1ag Connectivity Fault Management (CFM) Protocol / ITU-T Recommendation Y.1731 (OAM)";
            ethernetTypes[EthernetPacketType.FCoE] = "Fibre Channel over Ethernet";
            ethernetTypes[EthernetPacketType.FCoEInitializationProtocol] = "FCoE Initialization Protocol";
            ethernetTypes[EthernetPacketType.QInQ] = "Q-in-Q";
            ethernetTypes[EthernetPacketType.LLT] = "Veritas Low Latency Transport (LLT)";
            ethernetTypes[EthernetPacketType.Loopback] = "Loopback";
            ethernetTypes[EthernetPacketType.Echo] = "Echo";
        }

        private static void InitIPv4Precedence()
        {
            ipv4Precedence[IPv4Precedence_Fields.ROUTINE] = "Routine";
            ipv4Precedence[IPv4Precedence_Fields.PRIORITY] = "Priority";
            ipv4Precedence[IPv4Precedence_Fields.IMMEDIATE] = "Immediate";
            ipv4Precedence[IPv4Precedence_Fields.FLASH] = "Flash";
            ipv4Precedence[IPv4Precedence_Fields.FLASH_OVERRIDE] = "Flash Override";
            ipv4Precedence[IPv4Precedence_Fields.CRITIC_ECP] = "CRITIC/ECP";
            ipv4Precedence[IPv4Precedence_Fields.INTERNETWORK_CONTROL] = "Internetwork Control";
            ipv4Precedence[IPv4Precedence_Fields.NETWORK_CONTROL] = "Network Control";
        }

        private static void InitARPOperations()
        {
            arpOperations[ARPOperations_Fields.REQUEST] = "Request";
            arpOperations[ARPOperations_Fields.REPLY] = "Reply";
            arpOperations[ARPOperations_Fields.REQUEST_REVERSE] = "request Reverse";
            arpOperations[ARPOperations_Fields.REPLY_REVERSE] = "reply Reverse";
            arpOperations[ARPOperations_Fields.DRARP_REQUEST] = "DRARP-Request";
            arpOperations[ARPOperations_Fields.DRARP_REPLY] = "DRARP-Reply";
            arpOperations[ARPOperations_Fields.DRARP_ERROR] = "DRARP-Error";
            arpOperations[ARPOperations_Fields.INARP_REQUEST] = "InARP-Request";
            arpOperations[ARPOperations_Fields.INARP_REPLY] = "InARP-Reply";
            arpOperations[ARPOperations_Fields.ARP_NAK] = "ARP-NAK";
            arpOperations[ARPOperations_Fields.MARS_REQUEST] = "MARS-Request";
            arpOperations[ARPOperations_Fields.MARS_MULTI] = "MARS-Multi";
            arpOperations[ARPOperations_Fields.MARS_MSERV] = "MARS-MServ";
            arpOperations[ARPOperations_Fields.MARS_JOIN] = "MARS-Join";
            arpOperations[ARPOperations_Fields.MARS_LEAVE] = "MARS-Leave";
            arpOperations[ARPOperations_Fields.MARS_NAK] = "MARS-NAK";
            arpOperations[ARPOperations_Fields.MARS_UNSERV] = "MARS-Unserv";
            arpOperations[ARPOperations_Fields.MARS_SJOIN] = "MARS-SJoin";
            arpOperations[ARPOperations_Fields.MARS_SLEAVE] = "MARS-SLeave";
            arpOperations[ARPOperations_Fields.MARS_GROUPLIST_REQUEST] = "MARS-Grouplist-Request";
            arpOperations[ARPOperations_Fields.MARS_GROUPLIST_REPLY] = "MARS-Grouplist-Reply";
            arpOperations[ARPOperations_Fields.MARS_REDIRECT_MAP] = "MARS-Redirect-Map";
            arpOperations[ARPOperations_Fields.MAPOS_UNARP] = "MAPOS-UNARP";
            arpOperations[ARPOperations_Fields.OP_EXP1] = "OP_EXP1";
            arpOperations[ARPOperations_Fields.OP_EXP2] = "OP_EXP2";
        }

        private static void InitARPHardwareTypes()
        {
            arpHardwareTypes[ARPHardwareTypes_Fields.ETHERNET_10MB] = "Ethernet (10Mb)";
            arpHardwareTypes[ARPHardwareTypes_Fields.EXPERIMENTAL_ETHERNET_3MB] = "Experimental Ethernet (3Mb)";
            arpHardwareTypes[ARPHardwareTypes_Fields.AMATEUR_RADIO_AX25] = "Amateur Radio AX.25";
            arpHardwareTypes[ARPHardwareTypes_Fields.PROTEON_PRONET_TOKEN_RING] = "Proteon ProNET Token Ring";
            arpHardwareTypes[ARPHardwareTypes_Fields.CHAOS] = "Chaos";
            arpHardwareTypes[ARPHardwareTypes_Fields.IEEE802] = "IEEE 802 Networks";
            arpHardwareTypes[ARPHardwareTypes_Fields.ARCNET] = "ARCNET";
            arpHardwareTypes[ARPHardwareTypes_Fields.HYPERCHANNEL] = "Hyperchannel";
            arpHardwareTypes[ARPHardwareTypes_Fields.LANSTAR] = "Lanstar";
            arpHardwareTypes[ARPHardwareTypes_Fields.AUTONET_SHORT_ADDRESS] = "Autonet Short Address";
            arpHardwareTypes[ARPHardwareTypes_Fields.LOCALTALK] = "LocalTalk";
            arpHardwareTypes[ARPHardwareTypes_Fields.LOCALNET] = "LocalNet (IBM PCNet or SYTEK LocalNET)";
            arpHardwareTypes[ARPHardwareTypes_Fields.ULTRA_LINK] = "Ultra link";
            arpHardwareTypes[ARPHardwareTypes_Fields.SMDS] = "SMDS";
            arpHardwareTypes[ARPHardwareTypes_Fields.FRAME_RELAY] = "Frame Relay";
            arpHardwareTypes[ARPHardwareTypes_Fields.ATM1] = "ATM";
            arpHardwareTypes[ARPHardwareTypes_Fields.HDLC] = "HDLC";
            arpHardwareTypes[ARPHardwareTypes_Fields.FIBRE_CHANNEL] = "Fibre Channel";
            arpHardwareTypes[ARPHardwareTypes_Fields.ATM2] = "ATM";
            arpHardwareTypes[ARPHardwareTypes_Fields.SERIAL_LINE] = "Serial Line";
            arpHardwareTypes[ARPHardwareTypes_Fields.ATM3] = "ATM";
            arpHardwareTypes[ARPHardwareTypes_Fields.MIL_STD_188_220] = "MIL-STD-188-220";
            arpHardwareTypes[ARPHardwareTypes_Fields.METRICOM] = "Metricom";
            arpHardwareTypes[ARPHardwareTypes_Fields.IEEE1394_1995] = "IEEE 1394.1995";
            arpHardwareTypes[ARPHardwareTypes_Fields.MAPOS] = "MAPOS";
            arpHardwareTypes[ARPHardwareTypes_Fields.TWINAXIAL] = "Twinaxial";
            arpHardwareTypes[ARPHardwareTypes_Fields.EUI_64] = "EUI-64";
            arpHardwareTypes[ARPHardwareTypes_Fields.HIPARP] = "HIPARP";
            arpHardwareTypes[ARPHardwareTypes_Fields.IP_ARPoISO7816_3] = "IP and ARP over ISO 7816-3";
            arpHardwareTypes[ARPHardwareTypes_Fields.ARPSEC] = "ARPSec";
            arpHardwareTypes[ARPHardwareTypes_Fields.IPSEC_TUNNEL] = "IPsec tunnel";
            arpHardwareTypes[ARPHardwareTypes_Fields.INFINIBAND] = "InfiniBand (TM)";
            arpHardwareTypes[ARPHardwareTypes_Fields.CAI] = "TIA-102 Project 25 Common Air Interface (CAI)";
            arpHardwareTypes[ARPHardwareTypes_Fields.WIEGAND_INTERFACE] = "Wiegand Interface";
            arpHardwareTypes[ARPHardwareTypes_Fields.PURE_IP] = "Pure IP";
            arpHardwareTypes[ARPHardwareTypes_Fields.HW_EXP1] = "HW_EXP1";
            arpHardwareTypes[ARPHardwareTypes_Fields.HW_EXP2] = " HW_EXP2";
        }

        #endregion


        #region Public Methods

        public static string GetIPv4PrecedenceDescription(int code)
        {
            if (ipv4Precedence.ContainsKey(code))
            {
                return ipv4Precedence[code].ToString();
            }
            else
            {
                return "unknown";
            }
        }

        public static string GetARPOpDescription(int code)
        {
            if (arpOperations.ContainsKey(code))
            {
                return arpOperations[code].ToString();
            }
            else
            {
                return "unknown";
            }
        }

        public static string GetEtherTypeDescription(EthernetPacketType etherType)
        {
            if (ethernetTypes.ContainsKey(etherType))
            {
                return ethernetTypes[etherType].ToString();
            }
            else
            {
                return "unknown";
            }
        }

        public static string GetARPHwTypeDescription(int code)
        {
            if (arpHardwareTypes.ContainsKey(code))
            {
                return arpHardwareTypes[code].ToString();
            }
            else
            {
                return "unknown";
            }
        }

        #endregion
    }
}
