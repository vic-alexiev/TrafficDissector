using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TrafficDissector.UI
{
    public partial class WhoIsForm : BaseForm
    {
        #region Constructor

        public WhoIsForm()
        {
            InitializeComponent();
        }

        #endregion


        #region Event Handlers

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (!ValidateServerAndQuery())
            {
                return;
            }

            Send();
        }

        #endregion


        #region Private Methods

        private void Send()
        {
            byte[] query = Encoding.ASCII.GetBytes(textBoxQuery.Text + "\n");

            try
            {
                Cursor = Cursors.WaitCursor;

                TcpClient clientSocket = new TcpClient(textBoxServer.Text, 43);

                using (NetworkStream networkStream = clientSocket.GetStream())
                {
                    networkStream.Write(query, 0, query.GetLength(0));
                    using (StreamReader response = new StreamReader(networkStream))
                    {
                        richTextBoxStatus.Text = response.ReadToEnd();
                    }
                }
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

        private bool ValidateServerAndQuery()
        {
            bool result = true;
            errorProvider.Clear();

            if (String.IsNullOrEmpty(textBoxServer.Text))
            {
                errorProvider.SetError(textBoxServer, "Enter a server name.");
                result = false;
            }

            if (String.IsNullOrEmpty(textBoxQuery.Text))
            {
                errorProvider.SetError(textBoxQuery, "Enter a query.");
                result = false;
            }

            return result;
        }

        #endregion
    }
}