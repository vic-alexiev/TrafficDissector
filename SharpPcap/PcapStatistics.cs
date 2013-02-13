using System;
using System.Runtime.InteropServices;

namespace SharpPcap
{
    public class PcapStatistics
    {
        /// <value>
        /// Number of packets received
        /// </value>
        private int receivedPackets;
        public int ReceivedPackets
        {
            get { return receivedPackets; }
            set { receivedPackets = value; }
        }

        /// <value>
        /// Number of packets dropped
        /// </value>
        private int droppedPackets;
        public int DroppedPackets
        {
            get { return droppedPackets; }
            set { droppedPackets = value; }
        }

        /// <value>
        /// Number of interface dropped packets
        /// </value>
        private int interfaceDroppedPackets;
        public int InterfaceDroppedPackets
        {
            get { return interfaceDroppedPackets; }
            set { interfaceDroppedPackets = value; }
        }

        /// <summary>
        /// Retrieve pcap statistics from the adapter
        /// </summary>
        /// <param name="pcap_t">
        /// pcap_t* for the adapter
        /// A <see cref="IntPtr"/>
        /// </param>
        internal PcapStatistics(IntPtr pcap_t)
        {
            IntPtr stat;

            if (Environment.OSVersion.Platform == PlatformID.Unix)
            {
                // allocate memory for the struct
                stat = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PcapUnmanagedStructures.pcap_stat_unix)));
            }
            else
            {
                // allocate memory for the struct
                stat = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PcapUnmanagedStructures.pcap_stat_windows)));
            }

            // retrieve the stats
            PcapUnmanagedStructures.PcapStatReturnValue result =
                (PcapUnmanagedStructures.PcapStatReturnValue)SafeNativeMethods.pcap_stats(pcap_t, stat);

            // process the return value
            switch (result)
            {
                case PcapUnmanagedStructures.PcapStatReturnValue.Error:
                    // retrieve the error information
                    string error = PcapDevice.GetLastError(pcap_t);

                    // free the stats memory so we don't leak before we throw
                    Marshal.FreeHGlobal(stat);

                    throw new PcapStatisticsException(error);
                case PcapUnmanagedStructures.PcapStatReturnValue.Success:
                    // nothing to do upon success
                    break;
            }

            // marshal the unmanaged memory into an object of the proper type
            if (Environment.OSVersion.Platform == PlatformID.Unix)
            {
                PcapUnmanagedStructures.pcap_stat_unix managedStat =
                    (PcapUnmanagedStructures.pcap_stat_unix)Marshal.PtrToStructure(stat,
                                                                                                 typeof(PcapUnmanagedStructures.pcap_stat_unix));

                // copy the values
                this.ReceivedPackets = (int)managedStat.ps_recv;
                this.DroppedPackets = (int)managedStat.ps_drop;
                //                this.InterfaceDroppedPackets = (int)managedStat.ps_ifdrop;                
            }
            else
            {
                PcapUnmanagedStructures.pcap_stat_windows managedStat =
                    (PcapUnmanagedStructures.pcap_stat_windows)Marshal.PtrToStructure(stat,
                                                                                                    typeof(PcapUnmanagedStructures.pcap_stat_windows));

                // copy the values
                this.ReceivedPackets = (int)managedStat.ps_recv;
                this.DroppedPackets = (int)managedStat.ps_drop;
                //                this.InterfaceDroppedPackets = (int)managedStat.ps_ifdrop;
            }

            // NOTE: Not supported on unix or winpcap, no need to
            //       put a bogus value in this field
            this.InterfaceDroppedPackets = 0;

            // free the stats
            Marshal.FreeHGlobal(stat);
        }

        public override string ToString()
        {
            return string.Format("[PcapStatistics: ReceivedPackets={0}, DroppedPackets={1}, InterfaceDroppedPackets={2}]",
                                 ReceivedPackets, DroppedPackets, InterfaceDroppedPackets);
        }
    }
}
