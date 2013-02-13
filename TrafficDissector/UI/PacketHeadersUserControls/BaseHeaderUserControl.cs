using System;
using System.Windows.Forms;

namespace TrafficDissector.UI.PacketHeadersUserControls
{
    public partial class BaseHeaderUserControl : UserControl
    {
        #region Constructor

        public BaseHeaderUserControl()
        {
            InitializeComponent();
        }

        #endregion


        #region Protected Methods

        /// <summary>
        /// Generates a random packet
        /// </summary>
        protected static byte[] GetRandomPacketData(int size)
        {
            byte[] packetData = new byte[size];
            Random rand = new Random();
            rand.NextBytes(packetData);
            return packetData;
        }

        #endregion
    }
}
