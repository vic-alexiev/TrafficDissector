// ************************************************************************
// Copyright (C) 2001, Patrick Charles and Jonas Lehmann                   *
// Distributed under the Mozilla Public License                            *
// http://www.mozilla.org/NPL/MPL-1.1.txt                                *
// *************************************************************************
using System.Collections;
namespace SharpPcap.Packets
{
    /// <summary> Information about network link layers.
    /// 
    /// </summary>
    public class LinkLayer
    {
        /// <summary> Fetch the header length associated with various link-layer types.</summary>
        /// <param name="layerType">the link-layer code
        /// </param>
        /// <returns> the length of the header for the specified link-layer
        /// </returns>
        public static int LinkLayerLength(LinkLayers layerType)
        {
            switch (layerType)
            {
                case LinkLayers.ARCNET:
                    return 6;

                case LinkLayers.SLIP:
                    return 16;

                case LinkLayers.SLIP_BSD:
                    return 24;

                case LinkLayers.Null:
                case LinkLayers.Loop:
                    return 4;

                case LinkLayers.PPP:
                case LinkLayers.CiscoHDLC:
                case LinkLayers.PPPSerial:
                    return 4;

                case LinkLayers.PPP_BSD:
                    return 24;

                case LinkLayers.FDDI:
                    return 21;

                case LinkLayers.IEEE802_11:
                    return 22;

                case LinkLayers.ATM_RFC1483:
                    return 8;

                case LinkLayers.Raw:
                    return 0;

                case LinkLayers.ATM_CLIP:
                    return 8;

                case LinkLayers.LinuxSLL:
                    return 16;

                case LinkLayers.Ethernet10Mb:
                default:
                    return 14;
            }
        }

        /// <summary> Fetch the offset into the link-layer header where the protocol code
        /// can be found. Returns -1 if there is no embedded protocol code.
        /// </summary>
        /// <param name="layerType">the link-layer code
        /// </param>
        /// <returns> the offset in bytes
        /// </returns>
        public static int ProtocolOffset(LinkLayers layerType)
        {
            switch (layerType)
            {
                case LinkLayers.ARCNET:
                    return 2;

                case LinkLayers.SLIP:
                    return -1;

                case LinkLayers.SLIP_BSD:
                    return -1;

                case LinkLayers.Null:
                case LinkLayers.Loop:
                    return 0;

                case LinkLayers.PPP:
                case LinkLayers.CiscoHDLC:
                case LinkLayers.PPPSerial:
                    return 2;

                case LinkLayers.PPP_BSD:
                    return 5;

                case LinkLayers.FDDI:
                    return 13;

                case LinkLayers.IEEE802_11:
                    return 14;

                case LinkLayers.ATM_RFC1483:
                    return 6;

                case LinkLayers.Raw:
                    return -1;

                case LinkLayers.ATM_CLIP:
                    return 6;

                case LinkLayers.LinuxSLL:
                    return 14;

                case LinkLayers.Ethernet10Mb:
                default:
                    return 12;
            }
        }

        /// <summary> Fetch a link-layer type description.</summary>
        /// <param name="code">the code associated with the description.
        /// </param>
        /// <returns> a description of the link-layer type.
        /// </returns>
        public static string getDescription(int code)
        {
            if (descriptions.ContainsKey(code))
            {
                //UPGRADE_TODO: Method 'java.util.HashMap.get' was converted to 'System.Collections.Hashtable.Item' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilHashMapget_javalangObject'"
                return descriptions[code].ToString();
            }
            else
            {
                return "unknown";
            }
        }

        /// <summary> 'Human-readable' link-layer type descriptions.</summary>
        private static Hashtable descriptions = new Hashtable();

        static LinkLayer()
        {
            {
                descriptions[(int)LinkLayers.Null] = "No link-layer encapsulation";
                descriptions[(int)LinkLayers.Ethernet10Mb] = "Ethernet (10Mb)";
                descriptions[(int)LinkLayers.ExperimentalEthernet3MB] = "Experimental Ethernet (3Mb)";
                descriptions[(int)LinkLayers.AmateurRadioAX25] = "Amateur Radio AX.25";
                descriptions[(int)LinkLayers.ProteonProNETTokenRing] = "Proteon ProNET Token Ring";
                descriptions[(int)LinkLayers.Chaos] = "Chaos";
                descriptions[(int)LinkLayers.IEEE802] = "IEEE 802 Networks";
                descriptions[(int)LinkLayers.ARCNET] = "ARCNET";
                descriptions[(int)LinkLayers.SLIP] = "Serial Line Internet Protocol";
                descriptions[(int)LinkLayers.PPP] = "Point-to-Point Protocol";
                descriptions[(int)LinkLayers.FDDI] = "FDDI";
                descriptions[(int)LinkLayers.ATM_RFC1483] = "RFC 1483 LLC/SNAP-encapsulated ATM";
                descriptions[(int)LinkLayers.Raw] = "Raw IP";
                descriptions[(int)LinkLayers.SLIP_BSD] = "BSD/OS SLIP";
                descriptions[(int)LinkLayers.PPP_BSD] = "BSD/OS PPP";
                descriptions[(int)LinkLayers.ATM_CLIP] = "Linux classical IP-over-ATM";
                descriptions[(int)LinkLayers.PPPSerial] = "PPP over HDLC";
                descriptions[(int)LinkLayers.CiscoHDLC] = "Cisco HDLC";
                descriptions[(int)LinkLayers.IEEE802_11] = "IEEE 802.11 wireless LAN";
                descriptions[(int)LinkLayers.Loop] = "OpenBSD loopback encapsulation";
                descriptions[(int)LinkLayers.LinuxSLL] = "Linux \"cooked\" capture encapsulation";
                descriptions[(int)LinkLayers.Unknown] = "Unknown link-layer type";
            }
        }
    }
}
