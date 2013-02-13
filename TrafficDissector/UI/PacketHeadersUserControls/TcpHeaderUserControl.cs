using SharpPcap.Packets;
using System;
using System.Windows.Forms;

namespace TrafficDissector.UI.PacketHeadersUserControls
{
    internal partial class TcpHeaderUserControl : UserControl
    {
        #region Constructor

        public TcpHeaderUserControl()
        {
            InitializeComponent();
        }

        #endregion


        #region Public Methods

        public TCPPacket CreateTcpPacket(IPv4Packet ipv4Packet)
        {
            TCPPacket tcpPacket = new TCPPacket(
                EthernetFields_Fields.ETH_HEADER_LEN,
                ipv4Packet.Bytes);

            // TCP fields
            tcpPacket.SourcePort = Int32.Parse(textBoxSourcePort.Text);
            tcpPacket.DestinationPort = Int32.Parse(textBoxDestinationPort.Text);
            tcpPacket.SequenceNumber = Int64.Parse(textBoxSeqNumber.Text);
            tcpPacket.AcknowledgmentNumber = Int64.Parse(textBoxAckNumber.Text);
            // AllFlags field includes TCPHeaderLength field, so it must be set first
            tcpPacket.AllFlags = Int32.Parse(textBoxFlags.Text);
            tcpPacket.TCPHeaderLength = Int32.Parse(textBoxHeaderLength.Text);
            tcpPacket.WindowSize = Int32.Parse(textBoxWindowSize.Text);
            tcpPacket.UrgentPointer = Int32.Parse(textBoxUrgentPointer.Text);

            // Calculate checksum
            tcpPacket.ComputeTCPChecksum(true);

            return tcpPacket;
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

            // Validate the Sequence Number field. The field is 32 bits long,
            // so the permissible values are the integers between 0 and 4 294 967 295.
            long seqNumber;
            if (!Int64.TryParse(textBoxSeqNumber.Text, out seqNumber) ||
                !(seqNumber >= 0 && seqNumber <= 4294967295))
            {
                errorProvider.SetError(textBoxSeqNumber, "Seq number must be an integer between 0 and 4 294 967 295.");
                result = false;
            }

            // Validate the Acknowledgment Number field. The field is 32 bits long,
            // so the permissible values are the integers between 0 and 4 294 967 295.
            long ackNumber;
            if (!Int64.TryParse(textBoxAckNumber.Text, out ackNumber) ||
                !(ackNumber >= 0 && ackNumber <= 4294967295))
            {
                errorProvider.SetError(textBoxAckNumber, "Ack number must be an integer between 0 and 4 294 967 295.");
                result = false;
            }

            // Validate the Header Length  field. The field is 4 bits long,
            // but the length is in 32-bit words and we will take the length in bytes.
            // The minimum size header is 5 words and the maximum is 15 words thus giving
            // the minimum size of 20 bytes and maximum of 60 bytes, allowing for up to 
            // 40 bytes of options in the header. 
            int headerLength;
            if (!Int32.TryParse(textBoxHeaderLength.Text, out headerLength) ||
                !(headerLength >= 20 && headerLength <= 60))
            {
                errorProvider.SetError(textBoxHeaderLength, "Data offset must be an integer between 20 and 60.");
                result = false;
            }

            // Validate the Flags field. The field is 8 bits long,
            // so the permissible values are the integers between 0 and 255.
            int flags;
            if (!Int32.TryParse(textBoxFlags.Text, out flags) ||
                !(flags >= 0 && flags <= 255))
            {
                errorProvider.SetError(textBoxFlags, "Flags must be an integer between 0 and 255.");
                result = false;
            }

            // Validate the Window Size field. The field is 16 bits long,
            // so the permissible values are the integers between 0 and 65 535.
            int windowSize;
            if (!Int32.TryParse(textBoxWindowSize.Text, out windowSize) ||
                !(windowSize >= 0 && windowSize <= 65535))
            {
                errorProvider.SetError(textBoxWindowSize, "Window size must be an integer between 0 and 65 535.");
                result = false;
            }

            // Validate the Urgent pointer field. The field is 16 bits long,
            // so the permissible values are the integers between 0 and 65 535.
            int urgentPointer;
            if (!Int32.TryParse(textBoxUrgentPointer.Text, out urgentPointer) ||
                !(urgentPointer >= 0 && urgentPointer <= 65535))
            {
                errorProvider.SetError(textBoxUrgentPointer, "Urgent pointer must be an integer between 0 and 65 535.");
                result = false;
            }

            return result;
        }

        #endregion
    }
}
