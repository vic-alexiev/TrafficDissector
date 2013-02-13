using SharpPcap;
using System.Text;

namespace TrafficDissector.UI
{
    public partial class SummaryForm : BaseForm
    {
        #region Constructor

        public SummaryForm(PcapDevice device)
        {
            InitializeComponent();

            richTextBoxSummary.Text = GetStatistics(device);
        }

        #endregion


        #region Private Methods

        private string GetStatistics(PcapDevice device)
        {
            StringBuilder statBuilder = new StringBuilder();

            statBuilder.Append("Pcap Statistics\n");
            statBuilder.Append("=====================================\n");
            statBuilder.AppendFormat(" Received Packets .............. : {0}\n",
                device.Statistics().ReceivedPackets);
            statBuilder.AppendFormat(" Dropped Packets ............... : {0}\n",
                device.Statistics().DroppedPackets);
            statBuilder.AppendFormat(" Interface Dropped Packets ..... : {0}\n",
                device.Statistics().InterfaceDroppedPackets);

            return statBuilder.ToString();
        }

        #endregion
    }
}
