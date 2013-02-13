using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TrafficDissector.UI
{
    public partial class PingForm : BaseForm
    {
        #region Constructor

        public PingForm()
        {
            InitializeComponent();
        }

        #endregion


        #region Event Handlers

        private void buttonPing_Click(object sender, EventArgs e)
        {
            if (!ValidateHostNameOrAddress())
            {
                return;
            }

            PingHost();
        }

        private void textBoxHost_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxHost.Text))
            {
                buttonPing.Enabled = false;
            }
            else
            {
                buttonPing.Enabled = true;
            }
        }

        #endregion


        #region Private Methods

        private bool ValidateHostNameOrAddress()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                IPHostEntry host = Dns.GetHostEntry(textBoxHost.Text);

                if (host.AddressList == null ||
                    host.AddressList.Length == 0)
                {
                    richTextBoxResult.Text =
                        String.Format("Ping request could not find host {0}. Please check the name and try again.", textBoxHost.Text);
                    return false;
                }

                return true;
            }
            catch
            {
                richTextBoxResult.Text =
                        String.Format("Ping request could not find host {0}. Please check the name and try again.", textBoxHost.Text);
                return false;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void PingHost()
        {
            buttonPing.Enabled = false;

            string who = textBoxHost.Text;
            AutoResetEvent waiter = new AutoResetEvent(false);

            Ping pingSender = new Ping();

            // When the PingCompleted event is raised,
            // the PingCompletedCallback method is called.
            pingSender.PingCompleted += new PingCompletedEventHandler(PingCompletedCallback);

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);

            // Wait 12 seconds for a reply.
            int timeout = 12000;

            // Set options for transmission:
            // The data can go through 64 gateways or routers
            // before it is destroyed, and the data packet
            // cannot be fragmented.
            PingOptions options = new PingOptions(64, true);

            // Send the ping asynchronously.
            // Use the waiter as the user token.
            // When the callback completes, it can wake up this thread.
            pingSender.SendAsync(who, timeout, buffer, options, waiter);
        }

        private void PingCompletedCallback(object sender, PingCompletedEventArgs e)
        {
            buttonPing.Enabled = true;

            // If the operation was canceled, display a message to the user.
            if (e.Cancelled)
            {
                richTextBoxResult.Text = "Ping canceled.";

                // Let the main thread resume. 
                // UserToken is the AutoResetEvent object that the main thread 
                // is waiting for.
                ((AutoResetEvent)e.UserState).Set();
            }

            // If an error occurred, display the exception to the user.
            if (e.Error != null)
            {
                richTextBoxResult.Text =
                    String.Format("Ping failed: {0}", e.Error.ToString());

                // Let the main thread resume. 
                ((AutoResetEvent)e.UserState).Set();
            }

            PingReply reply = e.Reply;

            DisplayReply(reply);

            // Let the main thread resume.
            ((AutoResetEvent)e.UserState).Set();
        }

        private void DisplayReply(PingReply reply)
        {
            if (reply == null)
                return;

            StringBuilder replyBuilder = new StringBuilder();

            replyBuilder.AppendFormat(" Reply status ...... : {0}\n", GetStatusString(reply.Status));

            if (reply.Status == IPStatus.Success)
            {
                replyBuilder.AppendFormat(" Reply from ........ : {0}\n", reply.Address.ToString());
                replyBuilder.AppendFormat(" Bytes (buffer size) : {0}\n", reply.Buffer.Length);
                replyBuilder.AppendFormat(" Roundtrip time .... : {0} ms\n", reply.RoundtripTime);
                replyBuilder.AppendFormat(" Time to live (TTL)  : {0}\n", reply.Options.Ttl);
                replyBuilder.AppendFormat(" Don't fragment .... : {0}\n", reply.Options.DontFragment);
            }

            richTextBoxResult.Text = replyBuilder.ToString();
        }

        private string GetStatusString(IPStatus status)
        {
            switch (status)
            {
                case IPStatus.BadDestination:
                    return "Bad destination";
                case IPStatus.BadHeader:
                    return "Invalid ICMP header";
                case IPStatus.BadOption:
                    return "Invalid ICMP option";
                case IPStatus.BadRoute:
                    return "There is no valid route to destination.";
                case IPStatus.DestinationHostUnreachable:
                    return "Destination host unreachable.";
                case IPStatus.DestinationNetworkUnreachable:
                    return "Destination network unreachable.";
                case IPStatus.DestinationPortUnreachable:
                    return "Destination port unreachable.";
                case IPStatus.DestinationProtocolUnreachable:
                    return "Destination protocol unreachable.";
                case IPStatus.DestinationScopeMismatch:
                    return "Destination scope mismatch.";
                case IPStatus.DestinationUnreachable:
                    return "Destination computer unreachable.";
                case IPStatus.HardwareError:
                    return "Hardware error.";
                case IPStatus.IcmpError:
                    return "ICMP error.";
                case IPStatus.NoResources:
                    return "Insufficient network resources.";
                case IPStatus.PacketTooBig:
                    return "Packet too big.";
                case IPStatus.ParameterProblem:
                    return "Parameter problem";
                case IPStatus.SourceQuench:
                    return "Source quench.";
                case IPStatus.Success:
                    return "Ping succeeded.";
                case IPStatus.TimeExceeded:
                    return "TTL exceeded.";
                case IPStatus.TimedOut:
                    return "Request timed out.";
                case IPStatus.TtlExpired:
                    return "TTL expired.";
                case IPStatus.TtlReassemblyTimeExceeded:
                    return "TTL reassembly time exceeded";
                case IPStatus.Unknown:
                    return "Ping failed for an unknown reason.";
                case IPStatus.UnrecognizedNextHeader:
                    return "Unrecognized next header.";
                default:
                    return "Ping failed.";
            }
        }

        #endregion
    }
}