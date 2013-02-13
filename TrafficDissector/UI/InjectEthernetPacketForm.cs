using SharpPcap;
using SharpPcap.Packets;
using System;
using System.Windows.Forms;

namespace TrafficDissector.UI
{
    public partial class InjectEthernetPacketForm : BaseForm
    {
        #region Private Fields

        private int packetLength = 0;

        #endregion


        #region Constructor

        public InjectEthernetPacketForm()
        {
            InitializeComponent();
        }

        #endregion


        #region Event Handlers

        private void buttonInject_Click(object sender, EventArgs e)
        {
            bool isEthernetHeaderCorrect =
                ethernetHeaderUserControl.ValidateUserInput();
            bool isPacketLengthValid = ValidatePacketLength();
            bool isDeviceChosen =
                chooseDeviceUserControl.ValidateChosenDevice();

            if (!isEthernetHeaderCorrect ||
                !isPacketLengthValid ||
                !isDeviceChosen)
            {
                return;
            }

            int payloadLength = packetLength - EthernetFields_Fields.ETH_HEADER_LEN;

            // Create an Ethernet packet.
            EthernetPacket ethernetPacket =
                ethernetHeaderUserControl.CreateEthernetPacket(payloadLength);

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
                device.SendPacket(ethernetPacket);

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


        #region Private Methods

        private bool ValidatePacketLength()
        {
            errorProvider.Clear();

            if (!Int32.TryParse(textBoxPacketLength.Text, out packetLength) ||
                packetLength < 64 && packetLength > 1514)
            {
                errorProvider.SetError(textBoxPacketLength, "Length must be an integer between 64 and 1514.");
                return false;
            }

            return true;
        }

        #endregion
    }
}