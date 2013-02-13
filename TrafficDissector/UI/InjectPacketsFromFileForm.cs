using SharpPcap;
using SharpPcap.Packets;
using System;
using System.Windows.Forms;

namespace TrafficDissector.UI
{
    internal partial class InjectPacketsFromFileForm : BaseForm
    {
        #region Constructor

        public InjectPacketsFromFileForm()
        {
            InitializeComponent();
        }

        #endregion


        #region Event Handlers

        private void buttonBrowseCaptureFile_Click(object sender, EventArgs e)
        {
            if (openCaptureFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxCaptureFile.Text = openCaptureFileDialog.FileName;
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            SendCaptureFile();
        }

        #endregion


        #region Private Methods

        private bool ValidateUserInput()
        {
            bool result = true;
            errorProvider.Clear();

            if (String.IsNullOrEmpty(textBoxCaptureFile.Text))
            {
                errorProvider.SetError(groupBoxCaptureFile, "A capture file must be chosen.");
                result = false;
            }

            if (!chooseDeviceUserControl.ValidateChosenDevice())
            {
                result = false;
            }

            return result;
        }

        private void SendCaptureFile()
        {
            if (!ValidateUserInput())
            {
                return;
            }

            // Get the network device through which the packets will be sent.
            PcapDevice device = chooseDeviceUserControl.Device;

            // Get an offline file pcap device
            PcapDevice offlineDevice = new PcapOfflineDevice(textBoxCaptureFile.Text);

            PcapSendQueue sendQueue = null;

            bool isDeviceOpenedInThisForm = false;

            try
            {
                Cursor = Cursors.WaitCursor;

                if (!device.Opened)
                {
                    device.Open();
                    isDeviceOpenedInThisForm = true;
                }

                // Open the device for capturing 
                offlineDevice.Open();

                // Allocate a new send queue 
                sendQueue = new PcapSendQueue
                    ((int)((PcapOfflineDevice)offlineDevice).FileSize);

                Packet packet;

                // Go through all packets in the file and add to the queue 
                while ((packet = offlineDevice.GetNextPacket()) != null)
                {
                    if (!sendQueue.Add(packet))
                    {
                        MessageBox.Show(
                            "Packet buffer too small, not all the packets will be sent.",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        break;
                    }
                }

                if (device.PcapDataLink != offlineDevice.PcapDataLink)
                {
                    DialogResult answer = MessageBox.Show(
                        "The datalink of the capture differs from the one of the" +
                        "\nselected interface. Do you want to continue?",
                        "Question",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (answer == DialogResult.No)
                    {
                        return;
                    }
                }

                int bytesSent = device.SendQueue(sendQueue, false);

                if (bytesSent < sendQueue.CurrentLength)
                {
                    MessageBox.Show(
                        String.Format("An error occurred sending the packets: {0}.\nOnly {1} bytes were sent.", device.LastError, bytesSent),
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the pcap device 
                offlineDevice.Close();

                // Free the queue
                if (sendQueue != null)
                {
                    sendQueue.Dispose();
                }

                if (isDeviceOpenedInThisForm)
                {
                    device.Close();
                }

                Cursor = Cursors.Default;
            }
        }

        #endregion
    }
}