// ************************************************************************
// Copyright (C) 2001, Patrick Charles and Jonas Lehmann                   *
// Distributed under the Mozilla Public License                            *
// http://www.mozilla.org/NPL/MPL-1.1.txt                                *
// *************************************************************************
namespace SharpPcap.Packets
{
    /// <summary> ICMP message utility class.
    /// 
    /// </summary>
    public class ICMPMessage : ICMPMessages
    {
        /// <summary> Fetch an ICMP message.</summary>
        /// <param name="code">the code associated with the message.
        /// </param>
        /// <returns> a message describing the significance of the ICMP code.
        /// </returns>
        public static string getDescription(int code)
        {
            if (messages.ContainsKey(code))
            {
                //UPGRADE_TODO: Method 'java.util.HashMap.get' was converted to 'System.Collections.Hashtable.Item' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilHashMapget_javalangObject'"
                return messages[code].ToString();
            }
            else
            {
                return "unknown";
            }
        }

        /// <summary> 'Human-readable' ICMP messages.</summary>
        //UPGRADE_TODO: Class 'java.util.HashMap' was converted to 'System.Collections.Hashtable' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilHashMap'"
        private static System.Collections.Hashtable messages = new System.Collections.Hashtable();

        static ICMPMessage()
        {
            {
                messages[ICMPMessages_Fields.ECHO_REPLY] = "Echo (ping) reply";
                messages[ICMPMessages_Fields.ECHO] = "Echo (ping) request";
                messages[ICMPMessages_Fields.UNREACH_NET] = "Destination network unreachable";
                messages[ICMPMessages_Fields.UNREACH_HOST] = "Destination host unreachable";
                messages[ICMPMessages_Fields.UNREACH_PROTOCOL] = "Destination protocol unreachable";
                messages[ICMPMessages_Fields.UNREACH_PORT] = "Destination port unreachable";
                messages[ICMPMessages_Fields.UNREACH_NEEDFRAG] = "Fragmentation required, and DF flag set";
                messages[ICMPMessages_Fields.UNREACH_SRCFAIL] = "Source route failed";
                messages[ICMPMessages_Fields.UNREACH_NET_UNKNOWN] = "Destination network unknown";
                messages[ICMPMessages_Fields.UNREACH_HOST_UNKNOWN] = "Destination host unknown";
                messages[ICMPMessages_Fields.UNREACH_ISOLATED] = "Source host isolated";
                messages[ICMPMessages_Fields.UNREACH_NET_PROHIB] = "Network administratively prohibited";
                messages[ICMPMessages_Fields.UNREACH_HOST_PROHIB] = "Host administratively prohibited";
                messages[ICMPMessages_Fields.UNREACH_TOSNET] = "Network unreachable for TOS";
                messages[ICMPMessages_Fields.UNREACH_TOSHOST] = "Host unreachable for TOS";
                messages[ICMPMessages_Fields.COMMUNICATION_PROHIB] = "Communication administratively prohibited";
                messages[ICMPMessages_Fields.SOURCE_QUENCH] = "Source quench";
                messages[ICMPMessages_Fields.REDIRECT_NET] = "Redirect Datagram for the Network";
                messages[ICMPMessages_Fields.REDIRECT_HOST] = "Redirect Datagram for the Host";
                messages[ICMPMessages_Fields.REDIRECT_TOSNET] = "Redirect Datagram for the TOS & network";
                messages[ICMPMessages_Fields.REDIRECT_TOSHOST] = "Redirect Datagram for the TOS & host";
                messages[ICMPMessages_Fields.ROUTER_ADVERT] = "Router Advertisement";
                messages[ICMPMessages_Fields.ROUTER_SOLICIT] = "Router discovery/selection/solicitation";
                messages[ICMPMessages_Fields.TIME_EXCEED_IN_TRANS] = "TTL expired in transit";
                messages[ICMPMessages_Fields.TIME_EXCEED_REASS] = "Fragment reassembly time exceeded";
                messages[ICMPMessages_Fields.PARAM_PROB_POINTER] = "Bad IP header: Pointer indicates the error";
                messages[ICMPMessages_Fields.PARAM_PROB_OPTION_ABSENT] = "Bad IP header: Missing a required option";
                messages[ICMPMessages_Fields.PARAM_PROB_BAD_LEN] = "Bad IP header: Bad length";
                messages[ICMPMessages_Fields.TSTAMP] = "Timestamp";
                messages[ICMPMessages_Fields.TSTAMP_REPLY] = "Timestamp reply";
                messages[ICMPMessages_Fields.IREQ] = "Information Request";
                messages[ICMPMessages_Fields.IREQ_REPLY] = "Information Reply";
                messages[ICMPMessages_Fields.MASK_REQ] = "Address Mask Request";
                messages[ICMPMessages_Fields.MASK_REPLY] = "Address Mask Reply";
            }
        }
    }
}
