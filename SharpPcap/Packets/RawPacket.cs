using System;
using SharpPcap.Packets.Util;

namespace SharpPcap.Packets
{
    /// <summary>
    /// Raw packet as loaded from a pcap device or file
    /// </summary>
    public class RawPacket
    {
        private LinkLayers linkLayerType;
        public LinkLayers LinkLayerType
        {
            get { return linkLayerType; }
            set { linkLayerType = value; }
        }

        /// <value>
        /// The unix timeval when the packet was created
        /// </value>
        private Timeval timeval;
        public Timeval Timeval
        {
            get
            {
                return timeval;
            }

            set
            {
                timeval = value;
            }
        }

        /// <summary> Fetch data portion of the packet.</summary>
        private byte[] data;
        public virtual byte[] Data
        {
            get { return data; }
            set { data = value; }
        }

        public RawPacket(LinkLayers LinkLayerType,
                         Timeval Timeval,
                         byte[] Data)
        {
            this.LinkLayerType = LinkLayerType;
            this.Timeval = Timeval;
            this.Data = Data;
        }

        public override string ToString()
        {
            return string.Format("[RawPacket: LinkLayerType={0}, Timeval={1}, Data={2}]", LinkLayerType, Timeval, Data);
        }
    }
}
