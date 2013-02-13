using SharpPcap;
using SharpPcap.Packets;
using System;
using System.Windows.Forms;

namespace TrafficDissector.UI
{
    public partial class InjectTcpPacketForm : BaseForm
    {
        #region Constructor

        public InjectTcpPacketForm()
        {
            InitializeComponent();
            ethernetHeaderUserControl.SetComboBoxEnabledState(false);
            ethernetHeaderUserControl.SetComboBoxSelectedIndex(EthernetPacketType.IPv4);
            iPv4HeaderUserControl.SetComboBoxEnabledState(false);
            iPv4HeaderUserControl.SetComboBoxSelectedIndex(IPProtocol.IPProtocolType.TCP);
        }

        #endregion


        #region Event Handlers

        private void buttonInject_Click(object sender, EventArgs e)
        {
            bool isEthernetHeaderCorrect =
                ethernetHeaderUserControl.ValidateUserInput();
            bool isIPv4HeaderCorrect =
                iPv4HeaderUserControl.ValidateUserInput();
            bool isTcpHeaderCorrect =
                tcpHeaderUserControl.ValidateUserInput();
            bool isDeviceChosen =
                chooseDeviceUserControl.ValidateChosenDevice();

            if (!isEthernetHeaderCorrect ||
                !isIPv4HeaderCorrect ||
                !isTcpHeaderCorrect ||
                !isDeviceChosen)
            {
                return;
            }

            EthernetPacket ethernetHeader =
                ethernetHeaderUserControl.CreateEthernetPacket(0);

            IPv4Packet ipv4Packet =
                iPv4HeaderUserControl.CreateIPv4Packet(ethernetHeader);

            TCPPacket tcpPacket =
                tcpHeaderUserControl.CreateTcpPacket(ipv4Packet);

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
                device.SendPacket(tcpPacket);

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