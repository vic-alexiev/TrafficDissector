using SharpPcap.Packets;
using System;
using System.Windows.Forms;

namespace TrafficDissector.UI.PacketHeadersUserControls
{
    public partial class UdpHeaderUserControl : UserControl
    {
        #region Constructor

        public UdpHeaderUserControl()
        {
            InitializeComponent();
        }

        #endregion


        #region Public Methods

        public UDPPacket CreateUdpPacket(IPv4Packet ipv4Packet)
        {
            UDPPacket udpPacket = new UDPPacket(
                EthernetFields_Fields.ETH_HEADER_LEN,
                ipv4Packet.Bytes);

            // UDP fields
            udpPacket.SourcePort = Int32.Parse(textBoxSourcePort.Text);
            udpPacket.DestinationPort = Int32.Parse(textBoxDestinationPort.Text);
            udpPacket.Length = Int32.Parse(textBoxLength.Text);

            // Calculate checksum
            udpPacket.ComputeUDPChecksum(true);

            return udpPacket;
        }

        public bool ValidateUserInput()
        {
            bool result = true;
            errorProvider.Clear();

            // Validate the Source Port field. The field is 16 bits long,
            // so the permissible values are the integers between 0 and 65 535.
            int sourcePort;
            if (!Int32.TryParse(textBoxSourcePort.Text, out sourcePort) ||
                !(sourcePort >= 0 && sourcePort <= 65535))
            {
                errorProvider.SetError(textBoxSourcePort, "Src port must be an integer between 0 and 65 535.");
                result = false;
            }

            // Validate the Destination Port field. The field is 16 bits long,
            // so the permissible values are the integers between 0 and 65 535.
            int destinationPort;
            if (!Int32.TryParse(textBoxDestinationPort.Text, out destinationPort) ||
                !(destinationPort >= 0 && destinationPort <= 65535))
            {
                errorProvider.SetError(textBoxDestinationPort, "Dst port must be an integer between 0 and 65 535.");
                result = false;
            }

            // Validate the Length field. The field is 16 bits long.
            // The field size sets a theoretical limit of 65,535 bytes 
            // (8 byte header + 65 527 bytes of data) for a UDP datagram. 
            // The practical limit for the data length which is imposed by 
            // the underlying IPv4 protocol is 65 507 bytes.
            int length;
            if (!Int32.TryParse(textBoxLength.Text, out length) ||
                !(length >= 8 && length <= 65507))
            {
                errorProvider.SetError(textBoxLength, "Length must be an integer between 0 and 65 507.");
                result = false;
            }

            return result;
        }

        #endregion
    }
}
