using SharpPcap;
using SharpPcap.Packets;
using System;
using System.Windows.Forms;

namespace TrafficDissector.UI
{
    public partial class InjectUdpPacketForm : BaseForm
    {
        #region Constructor

        public InjectUdpPacketForm()
        {
            InitializeComponent();
            ethernetHeaderUserControl.SetComboBoxEnabledState(false);
            ethernetHeaderUserControl.SetComboBoxSelectedIndex(EthernetPacketType.IPv4);
            iPv4HeaderUserControl.SetComboBoxEnabledState(false);
            iPv4HeaderUserControl.SetComboBoxSelectedIndex(IPProtocol.IPProtocolType.UDP);
        }

        #endregion


        #region Event Handlers

        private void buttonInject_Click(object sender, EventArgs e)
        {
            bool isEthernetHeaderCorrect =
                ethernetHeaderUserControl.ValidateUserInput();
            bool isIPv4HeaderCorrect =
                iPv4HeaderUserControl.ValidateUserInput();
            bool isUdpHeaderCorrect =
                udpHeaderUserControl.ValidateUserInput();
            bool isDeviceChosen =
                chooseDeviceUserControl.ValidateChosenDevice();

            if (!isEthernetHeaderCorrect ||
                !isIPv4HeaderCorrect ||
                !isUdpHeaderCorrect ||
                !isDeviceChosen)
            {
                return;
            }

            EthernetPacket ethernetHeader =
                ethernetHeaderUserControl.CreateEthernetPacket(0);

            IPv4Packet ipv4Packet =
                iPv4HeaderUserControl.CreateIPv4Packet(ethernetHeader);

            UDPPacket udpPacket =
                udpHeaderUserControl.CreateUdpPacket(ipv4Packet);

            PcapDevice device = chooseDeviceUserControl.Device;

            bool isDeviceOpenedInThisForm = false;
            try
            {
                if (!device.Opened)
                {
                    device.Open();
                    isDeviceOpenedInThisForm = true;
                }

                // Send the packet out the network device 
                device.SendPacket(udpPacket);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (isDeviceOpenedInThisForm)
                {
                    device.Close();
                }
            }
        }

        #endregion
    }
}