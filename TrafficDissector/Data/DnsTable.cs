using System.Collections;
using System.Net;

namespace TrafficDissector.Data
{
    internal static class DnsTable
    {
        #region Private Fields

        private static Hashtable dnsNames = new Hashtable();

        #endregion


        #region Public Methods

        public static string GetHostByAddress(IPAddress ipAddress)
        {
            if (!dnsNames.Contains(ipAddress))
            {
                try
                {
                    IPHostEntry host = Dns.GetHostEntry(ipAddress);
                    dnsNames.Add(ipAddress, host.HostName);
                }
                catch
                {
                    dnsNames.Add(ipAddress, ipAddress.ToString());
                }
            }

            return dnsNames[ipAddress].ToString();
        }

        #endregion
    }
}
