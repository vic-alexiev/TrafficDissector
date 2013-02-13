using SharpPcap.Packets;
using System;
using System.Collections;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TrafficDissector.UI.PacketHeadersUserControls
{
    internal partial class EthernetHeaderUserControl : BaseHeaderUserControl
    {
        #region Constructor

        public EthernetHeaderUserControl()
        {
            InitializeComponent();
            FillComboBox();
        }

        #endregion


        #region Private Methods

        private void FillComboBox()
        {
            comboBoxEthernetProtocols.DataSource = new BindingSource(DataStructures.EthernetTypes, null);
            comboBoxEthernetProtocols.ValueMember = "Key";
            comboBoxEthernetProtocols.DisplayMember = "Value";
            comboBoxEthernetProtocols.SelectedIndex = -1;
        }

        private bool ValidateHwAddress(string address)
        {
            if (String.IsNullOrEmpty(address))
            {
                return false;
            }

            string hyphenatedHwAddressPattern = @"(?:[0-9A-F]{2}-){5}[0-9A-F]{2}";
            string digitsOnlyHwAddressPattern = @"[0-9A-F]{12}";

            Match hyphenatedMatch = Regex.Match(address, hyphenatedHwAddressPattern);
            if (hyphenatedMatch.Success)
            {
                return true;
            }

            Match digitsOnlyMatch = Regex.Match(address, digitsOnlyHwAddressPattern);
            if (digitsOnlyMatch.Success)
            {
                return true;
            }

            return false;
        }

        #endregion


        #region Public Methods

        public void SetComboBoxSelectedIndex(EthernetPacketType ethernetType)
        {
            for (int i = 0; i < comboBoxEthernetProtocols.Items.Count; i++)
            {
                object item = comboBoxEthernetProtocols.Items[i];
                if ((EthernetPacketType)((DictionaryEntry)item).Key == ethernetType)
                {
                    comboBoxEthernetProtocols.SelectedIndex = i;
                    break;
                }
            }
        }

        public void SetComboBoxEnabledState(bool enabled)
        {
            comboBoxEthernetProtocols.Enabled = enabled;
        }

        public bool ValidateUserInput()
        {
            bool result = true;
            errorProvider.Clear();

            if (!ValidateHwAddress(textBoxDestinationHwAddress.Text.Trim()))
            {
                errorProvider.SetError(textBoxDestinationHwAddress, "Incorrect physical address.");
                result = false;
            }

            if (!ValidateHwAddress(textBoxSourceHwAddress.Text.Trim()))
            {
                errorProvider.SetError(textBoxSourceHwAddress, "Incorrect physical address.");
                result = false;
            }

            if (comboBoxEthernetProtocols.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBoxEthernetProtocols, "A type must be chosen.");
                result = false;
            }

            return result;
        }

        public EthernetPacket CreateEthernetPacket(int payloadLength)
        {
            byte[] payload = null;
            if (payloadLength > 0)
            {
                payload = GetRandomPacketData(payloadLength);
            }

            EthernetPacket packet = new EthernetPacket(
                PhysicalAddress.Parse(textBoxSourceHwAddress.Text),
                PhysicalAddress.Parse(textBoxDestinationHwAddress.Text),
                (EthernetPacketType)((DictionaryEntry)comboBoxEthernetProtocols.SelectedItem).Key,
                payload);

            return packet;
        }

        #endregion
    }
}
