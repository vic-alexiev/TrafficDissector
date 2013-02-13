using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TrafficDissector.UI
{
    public partial class DnsMXForm : BaseForm
    {
        #region Constructor

        public DnsMXForm()
        {
            InitializeComponent();
        }

        #endregion


        #region Event Handlers

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (!ValidateDnsServerAndDomain())
            {
                return;
            }

            Find();
        }

        #endregion


        #region Private Methods

        private bool ValidateDnsServerAndDomain()
        {
            bool result = true;
            errorProvider.Clear();

            if (String.IsNullOrEmpty(textBoxDnsServer.Text))
            {
                errorProvider.SetError(textBoxDnsServer, "Enter a DNS server name.");
                result = false;
            }

            if (String.IsNullOrEmpty(textBoxDomain.Text))
            {
                errorProvider.SetError(textBoxDomain, "Enter a domain.");
                result = false;
            }

            return result;
        }

        private void Find()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                byte[] dnsQuery;
                byte[] dnsReply;
                UdpClient dnsClient = new UdpClient(textBoxDnsServer.Text, 53);

                dnsQuery = MakeQuery(DateTime.Now.Millisecond * 60,
                    textBoxDomain.Text);

                dnsClient.Send(dnsQuery, dnsQuery.Length);

                IPEndPoint ipEndPoint = null;
                dnsReply = dnsClient.Receive(ref ipEndPoint);

                richTextBoxMXServers.Text = MakeResponse(dnsReply, textBoxDomain.Text);
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private byte[] MakeQuery(int id, string name)
        {
            byte[] data = new byte[512];

            data[0] = (byte)(id >> 8);
            data[1] = (byte)(id & 0xFF);
            data[2] = (byte)1;
            data[3] = (byte)0;
            data[4] = (byte)0;
            data[5] = (byte)1;
            data[6] = (byte)0;
            data[7] = (byte)0;
            data[8] = (byte)0;
            data[9] = (byte)0;
            data[10] = (byte)0;
            data[11] = (byte)0;

            string[] tokens = name.Split(new char[] { '.' });
            string label;
            int position = 12;
            for (int i = 0; i < tokens.Length; i++)
            {
                label = tokens[i];
                data[position++] = (byte)(label.Length & 0xFF);
                byte[] b = Encoding.ASCII.GetBytes(label);
                for (int j = 0; j < b.Length; j++)
                {
                    data[position++] = b[j];
                }
            }

            data[position++] = (byte)0;
            data[position++] = (byte)0;
            data[position++] = (byte)15;
            data[position++] = (byte)0;
            data[position++] = (byte)1;

            byte[] query = new byte[position + 1];
            for (int k = 0; k <= position; k++)
            {
                query[k] = data[k];
            }

            return query;
        }

        private string MakeResponse(byte[] data, string name)
        {
            int domainsCount = ((data[4] & 0xFF) << 8) | (data[5] & 0xFF);
            int mxServersCount = ((data[6] & 0xFF) << 8) | (data[7] & 0xFF);
            int position = 12;
            for (int i = 0; i < domainsCount; ++i)
            {
                name = String.Empty;
                position = ConvertToStandardDotNotation(position, data, ref name);
                position += 4;
            }

            string response = String.Empty;
            for (int i = 0; i < mxServersCount; ++i)
            {
                name = String.Empty;
                position = ConvertToStandardDotNotation(position, data, ref name);
                position += 12;
                name = String.Empty;
                position = ConvertToStandardDotNotation(position, data, ref name);
                response += name + "\r\n";
            }

            return response;
        }

        private int ConvertToStandardDotNotation(int position, byte[] data, ref string name)
        {
            int len = (data[position++] & 0xFF);
            if (len == 0)
            {
                return position;
            }
            int offset;
            do
            {
                if ((len & 0xC0) == 0xC0)
                {
                    if (position >= data.Length)
                    {
                        return -1;
                    }
                    offset = ((len & 0x3F) << 8) | (data[position++] & 0xFF);
                    ConvertToStandardDotNotation(offset, data, ref name);
                    return position;
                }
                else
                {
                    if ((position + len) > data.Length)
                    {
                        return -1;
                    }
                    name += Encoding.ASCII.GetString(data, position, len);
                    position += len;
                }
                if (position > data.Length)
                {
                    return -1;
                }
                len = data[position++] & 0xFF;
                if (len != 0)
                {
                    name += ".";
                }
            }
            while (len != 0);

            return position;
        }

        #endregion
    }
}
