using SharpPcap.Packets;
using System;
using System.Collections;
using System.Net;
using System.Windows.Forms;

namespace TrafficDissector.UI.PacketHeadersUserControls
{
    internal partial class IPv4HeaderUserControl : BaseHeaderUserControl
    {
        #region Constructor

        public IPv4HeaderUserControl()
        {
            InitializeComponent();
            FillComboBoxIPProtocols();
        }

        #endregion


        #region Private Methods

        private void FillComboBoxIPProtocols()
        {
            comboBoxIPProtocols.DataSource = new BindingSource(IPProtocol.Messages, null);
            comboBoxIPProtocols.ValueMember = "Key";
            comboBoxIPProtocols.DisplayMember = "Value";
            comboBoxIPProtocols.SelectedIndex = -1;
        }

        #endregion


        #region Public Methods

        public void SetComboBoxSelectedIndex(IPProtocol.IPProtocolType ipProtocolType)
        {
            for (int i = 0; i < comboBoxIPProtocols.Items.Count; i++)
            {
                object item = comboBoxIPProtocols.Items[i];
                if ((IPProtocol.IPProtocolType)((DictionaryEntry)item).Key == ipProtocolType)
                {
                    comboBoxIPProtocols.SelectedIndex = i;
                    break;
                }
            }
        }

        public void SetComboBoxEnabledState(bool enabled)
        {
            comboBoxIPProtocols.Enabled = enabled;
        }

        public IPv4Packet CreateIPv4Packet(EthernetPacket ethernetHeader)
        {
            int ipv4PacketTotalLength = Int32.Parse(textBoxTotalLength.Text);
            byte[] bytes = new byte[EthernetFields_Fields.ETH_HEADER_LEN + ipv4PacketTotalLength];

            IPv4Packet ipv4Packet = new IPv4Packet(
                EthernetFields_Fields.ETH_HEADER_LEN,
                bytes);

            // Ethernet fields
            ipv4Packet.EthernetHeader = ethernetHeader.Bytes;

            // IP fields
            ipv4Packet.Version = 4;
            ipv4Packet.IPHeaderLength = IPv4Fields_Fields.IP_HEADER_LEN;
            ipv4Packet.TypeOfService = Int32.Parse(textBoxDS.Text);
            ipv4Packet.IPTotalLength = ipv4PacketTotalLength;
            ipv4Packet.Id = 0;
            ipv4Packet.FragmentFlags = Int32.Parse(textBoxFlags.Text);
            ipv4Packet.FragmentOffset = 0;
            ipv4Packet.TimeToLive = Int32.Parse(textBoxTTL.Text);
            ipv4Packet.IPProtocol = (IPProtocol.IPProtocolType)((DictionaryEntry)comboBoxIPProtocols.SelectedItem).Key;
            ipv4Packet.SourceAddress = IPAddress.Parse(textBoxSourceAddress.Text);
            ipv4Packet.DestinationAddress = IPAddress.Parse(textBoxDestinationAddress.Text);

            ipv4Packet.ComputeIPChecksum(true);

            ipv4Packet.IPData = GetRandomPacketData(ipv4Packet.IPPayloadLength);

            return ipv4Packet;
        }

        public bool ValidateUserInput()
        {
            bool result = true;
            errorProvider.Clear();

            // Validate the Differentiated Services field. The field is 8 bits
            // long, so the permissible values are the integers between 0 and 255.
            int dsValue;
            if (!Int32.TryParse(textBoxDS.Text, out dsValue) ||
                !(dsValue >= 0 && dsValue <= 255))
            {
                errorProvider.SetError(textBoxDS, "DS must be an integer between 0 and 255.");
                result = false;
            }

            // Validate the Total Length field. The field is 16 bits long,
            // so the permissible values are the integers between 0 and 65 535.
            // Actually the minimum-length datagram is 20 bytes 
            // (20-byte header + 0 bytes data).
            int totalLength;
            if (!Int32.TryParse(textBoxTotalLength.Text, out totalLength) ||
                !(totalLength >= 20 && totalLength <= 65535))
            {
                errorProvider.SetError(textBoxTotalLength, "Total length must be an integer between 20 and 65 535.");
                result = false;
            }

            // Validate the Flags field. It is 3 bits long, so the
            // permissible values are the integers between 0 and 7.
            int flags;
            if (!Int32.TryParse(textBoxFlags.Text, out flags) ||
                !(flags >= 0 && flags <= 7))
            {
                errorProvider.SetError(textBoxFlags, "Flags must be an integer between 0 and 7.");
                result = false;
            }

            // Validate the Time to live field. The field is 8 bits long,
            // so the permissible values are the integers between 0 and 255.
            int ttl;
            if (!Int32.TryParse(textBoxTTL.Text, out ttl) ||
                !(ttl >= 0 && ttl <= 255))
            {
                errorProvider.SetError(textBoxTTL, "Time to live must be an integer between 0 and 255.");
                result = false;
            }

            // An IP protocol must be chosen
            if (comboBoxIPProtocols.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBoxIPProtocols, "A protocol must be chosen.");
                result = false;
            }

            // Validate the source IP address field.
            IPAddress sourceAddress;
            if (!IPAddress.TryParse(textBoxSourceAddress.Text, out sourceAddress))
            {
                errorProvider.SetError(textBoxSourceAddress, "Incorrect source IP address.");
                result = false;
            }

            // Validate the destination IP address field.
            IPAddress destinationAddress;
            if (!IPAddress.TryParse(textBoxDestinationAddress.Text, out destinationAddress))
            {
                errorProvider.SetError(textBoxDestinationAddress, "Incorrect source IP address.");
                result = false;
            }

            return result;
        }

        #endregion
    }
}
