using TrafficDissector.PortScanning;
using SharpPcap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TrafficDissector.UI
{
    internal enum ScannerType
    {
        PortScanner,
        PortSweeper
    }

    internal enum ScanMethod
    {
        SynScan,
        TcpScan,
        UdpScan
    }

    public partial class PortScannerForm : BaseForm
    {
        #region Private Fields

        private ScanMethod scanMethod;
        private ScannerType scannerType;
        private int delay;
        private int timeout;
        private IPHostEntry[] hostEntries;
        private int fromPort;
        private int toPort;
        private PcapDevice device;
        private IPAddress gateway;
        private NetworkInterface[] nics;

        private Dictionary<ScannerType, string> scannerTypeDictionary;
        private Dictionary<ScanMethod, string> scanMethodDictionary;

        #endregion


        #region Delegates

        private delegate string ScanMethodDelegate(IPEndPoint ipEndPoint);

        #endregion


        #region Constructor

        public PortScannerForm()
        {
            InitializeComponent();
            InitializeComboBoxScannerType();
            InitializeComboBoxScanMethod();

            nics = NetworkInterface.GetAllNetworkInterfaces();
        }

        #endregion


        #region Event Handlers

        private void comboBoxScannerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxScannerType.SelectedIndex == -1)
            {
                return;
            }

            textBoxToPort.Visible = (ScannerType)comboBoxScannerType.SelectedValue != ScannerType.PortSweeper;
            labelColon.Visible = textBoxToPort.Visible;
        }

        private void buttonStartScan_Click(object sender, EventArgs e)
        {
            if (!ValidateUserInput())
            {
                return;
            }

            try
            {
                StartScan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveLog_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxScanResult.Text))
            {
                return;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = File.Create(saveFileDialog.FileName))
                {
                    UTF8Encoding utf8Encoding = new UTF8Encoding(true);
                    Byte[] info = utf8Encoding.GetBytes(textBoxScanResult.Text);
                    // Add the information to the file.
                    fileStream.Write(info, 0, info.Length);
                }
            }
        }

        #region BackgroundWorker

        private void backgroundWorkerScan_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = PerformScan();
        }

        private void backgroundWorkerScan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            textBoxScanResult.Text = e.Result.ToString();
            buttonStartScan.Enabled = true;
            buttonSaveLog.Enabled = true;
        }

        private void backgroundWorkerScan_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarScanProgress.Value = e.ProgressPercentage;
        }

        #endregion

        #endregion


        #region Private Methods

        private void InitializeComboBoxScannerType()
        {
            scannerTypeDictionary = new Dictionary<ScannerType, string>();
            scannerTypeDictionary[ScannerType.PortScanner] = "Port Scanner";
            scannerTypeDictionary[ScannerType.PortSweeper] = "Port Sweeper";

            comboBoxScannerType.DataSource = new BindingSource(scannerTypeDictionary, null);
            comboBoxScannerType.ValueMember = "Key";
            comboBoxScannerType.DisplayMember = "Value";
            comboBoxScannerType.SelectedIndex = -1;

            comboBoxScannerType.SelectedIndexChanged += new EventHandler(comboBoxScannerType_SelectedIndexChanged);
        }

        private void InitializeComboBoxScanMethod()
        {
            scanMethodDictionary = new Dictionary<ScanMethod, string>();

            scanMethodDictionary[ScanMethod.TcpScan] = "TCP Scan";
            scanMethodDictionary[ScanMethod.UdpScan] = "UDP Scan";
            scanMethodDictionary[ScanMethod.SynScan] = "SYN Scan";

            comboBoxScanMethod.DataSource = new BindingSource(scanMethodDictionary, null);
            comboBoxScanMethod.ValueMember = "Key";
            comboBoxScanMethod.DisplayMember = "Value";
            comboBoxScanMethod.SelectedIndex = -1;
        }

        private string SynScan(IPEndPoint ipEndPoint)
        {
            var synConnectCall = new SynConnectCall(timeout, device, gateway);

            ScanMessage message = synConnectCall.Connect(ipEndPoint);

            switch (message)
            {
                case ScanMessage.PortClosed:
                    return String.Format("{0} is closed.\r\n", ipEndPoint.Port);
                case ScanMessage.PortOpened:
                    return String.Format("{0} is opened.\r\n", ipEndPoint.Port);
                case ScanMessage.Timeout:
                    return String.Format("{0} is filtered.\r\n", ipEndPoint.Port);
                case ScanMessage.Unknown:
                default:
                    return String.Format("{0} is in unknown state.\r\n", ipEndPoint.Port);
            }
        }

        private string TcpScan(IPEndPoint ipEndPoint)
        {
            ScanMessage message = TcpConnectCall.Connect(ipEndPoint, timeout);

            switch (message)
            {
                case ScanMessage.PortClosed:
                    return String.Format("{0} is closed.\r\n", ipEndPoint.Port);
                case ScanMessage.PortOpened:
                    return String.Format("{0} is opened.\r\n", ipEndPoint.Port);
                case ScanMessage.Timeout:
                    return String.Format("{0} is filtered.\r\n", ipEndPoint.Port);
                case ScanMessage.Unknown:
                default:
                    return String.Format("{0} is in unknown state.\r\n", ipEndPoint.Port);
            }
        }

        private string UdpScan(IPEndPoint ipEndPoint)
        {
            ScanMessage message = UdpConnectCall.Connect(ipEndPoint, timeout);

            switch (message)
            {
                case ScanMessage.PortClosed:
                    return String.Format("{0} is closed.\r\n", ipEndPoint.Port);
                case ScanMessage.PortOpened:
                    return String.Format("{0} is opened.\r\n", ipEndPoint.Port);
                case ScanMessage.Timeout:
                    return String.Format("{0} is open/filtered.\r\n", ipEndPoint.Port);
                case ScanMessage.Unknown:
                default:
                    return String.Format("{0} is in unknown state.\r\n", ipEndPoint.Port);
            }
        }

        private string InvokeScanMethod(ScanMethodDelegate scanMethodDelegate, IPAddress ipAddress, int port)
        {
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, port);
            return scanMethodDelegate(ipEndPoint);
        }

        private string PerformScan()
        {
            var timeElapsed = new Stopwatch();
            timeElapsed.Start();

            StringBuilder logBuilder = new StringBuilder();

            ScanMethodDelegate scanMethodDelegate = null;

            //Determining the appropriate delegate to use
            switch (scanMethod)
            {
                case ScanMethod.TcpScan:
                    scanMethodDelegate = new ScanMethodDelegate(TcpScan);
                    break;
                case ScanMethod.UdpScan:
                    scanMethodDelegate = new ScanMethodDelegate(UdpScan);
                    break;
                case ScanMethod.SynScan:
                    scanMethodDelegate = new ScanMethodDelegate(SynScan);
                    break;
                default:
                    return String.Empty;
            }

            logBuilder.Append("# Port Scanner/Sweeper\r\n");
            logBuilder.AppendFormat("# Scanner type used in current scan: {0}\r\n", scannerTypeDictionary[scannerType]);
            logBuilder.AppendFormat("# {0} initiated at: {1}\r\n", scanMethodDictionary[scanMethod], DateTime.Now);

            if (scannerType == ScannerType.PortScanner)
            {
                IPAddress hostIPAddress = hostEntries[0].AddressList[0];

                for (int port = fromPort; port <= toPort; port++)
                {
                    Thread.Sleep(delay);

                    string message = InvokeScanMethod(scanMethodDelegate, hostIPAddress, port);
                    logBuilder.Append(message);

                    if (fromPort == toPort)
                    {
                        backgroundWorkerScan.ReportProgress(100);
                    }
                    else
                    {
                        float quota = (float)(port - fromPort) / (toPort - fromPort);
                        int percentComplete = (int)(quota * 100);
                        backgroundWorkerScan.ReportProgress(percentComplete);
                    }
                }
            }
            else // scannerType is ScannerType.PortSweeper
            {
                logBuilder.AppendFormat("Port sweeped: {0}\r\n", fromPort);

                for (int i = 0; i < hostEntries.Length; i++)
                {
                    Thread.Sleep(delay);

                    IPAddress hostAddress = hostEntries[i].AddressList[0];
                    string message = InvokeScanMethod(scanMethodDelegate, hostAddress, fromPort);

                    logBuilder.AppendFormat("Host {0}: {1}",
                        hostAddress,
                        message);

                    float quota = (float)(i + 1) / hostEntries.Length;
                    int percentComplete = (int)(quota * 100);
                    backgroundWorkerScan.ReportProgress(percentComplete);
                }
            }

            timeElapsed.Stop();

            logBuilder.AppendFormat("# Scan ended successfully after {0} minutes and {1} seconds.\r\n",
                timeElapsed.Elapsed.Minutes,
                timeElapsed.Elapsed.Seconds);

            return logBuilder.ToString();
        }

        private bool ValidateUserInput()
        {
            bool result = true;
            errorProvider.Clear();

            // A scanner type must be chosen
            if (comboBoxScannerType.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBoxScannerType, "A scanner type must be chosen.");
                result = false;
            }

            // A scan method must be chosen
            if (comboBoxScanMethod.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBoxScanMethod, "A scan method must be chosen.");
                result = false;
            }

            // Validate the delay field. It must be a non-negative integer.
            int delay;
            if (!Int32.TryParse(textBoxDelay.Text, out delay) || delay < 0)
            {
                errorProvider.SetError(textBoxDelay, "The delay must be a non-negative integer.");
                result = false;
            }

            // Validate the timeout field. It must be a non-negative integer.
            int timeout;
            if (!Int32.TryParse(textBoxTimeout.Text, out timeout) || timeout < 0)
            {
                errorProvider.SetError(textBoxTimeout, "The timeout must be a non-negative integer.");
                result = false;
            }

            // Validate the host
            string error;
            if (!ValidateHosts(out error))
            {
                errorProvider.SetError(textBoxHost, error);
                result = false;
            }

            // Validate the "from" port. 
            // It must be an integer between 0 and 65 535 (2 ^ 16).
            int fromPort;
            if (!Int32.TryParse(textBoxFromPort.Text, out fromPort) ||
                !(fromPort >= 0 && fromPort <= 65535))
            {
                errorProvider.SetError(textBoxFromPort, "The port must be an integer between 0 and 65 535.");
                fromPort = -1;
                result = false;
            }

            if (textBoxToPort.Visible)
            {
                // Validate the "to" port.
                // It must be an integer between 0 and 65 535 (2 ^ 16).
                int toPort;
                if (!Int32.TryParse(textBoxToPort.Text, out toPort) ||
                !(toPort >= 0 && toPort <= 65535))
                {
                    errorProvider.SetError(textBoxToPort, "The port must be an integer between 0 and 65 535.");
                    result = false;
                }
                else if (fromPort != -1 && toPort < fromPort)
                {
                    errorProvider.SetError(textBoxToPort, "The second port number must be greater than the first one.");
                    result = false;
                }
            }

            if (!chooseDeviceUserControl.ValidateChosenDevice())
            {
                result = false;
            }

            return result;
        }

        private bool ValidateHosts(out string error)
        {
            string[] hosts = textBoxHost.Text.Trim().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            if (hosts.Length == 0)
            {
                error = "A host must be chosen.";
                return false;
            }

            foreach (string host in hosts)
            {
                try
                {
                    IPHostEntry hostEntry = Dns.GetHostEntry(host);

                    if (hostEntry.AddressList == null ||
                        hostEntry.AddressList.Length == 0)
                    {
                        error = String.Format("Host {0} could not be found.", host);
                        return false;
                    }
                }
                catch
                {
                    error = String.Format("Host {0} could not be found.", host);
                    return false;
                }
            }

            error = String.Empty;
            return true;
        }

        private void StartScan()
        {
            scannerType = (ScannerType)comboBoxScannerType.SelectedValue;
            scanMethod = (ScanMethod)comboBoxScanMethod.SelectedValue;
            delay = Int32.Parse(textBoxDelay.Text);
            timeout = Int32.Parse(textBoxTimeout.Text);

            string[] hosts = textBoxHost.Text.Trim().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            hostEntries = new IPHostEntry[hosts.Length];

            for (int i = 0; i < hosts.Length; i++)
            {
                hostEntries[i] = Dns.GetHostEntry(hosts[i]);
            }

            fromPort = Int32.Parse(textBoxFromPort.Text);

            if (textBoxToPort.Visible)
            {
                toPort = Int32.Parse(textBoxToPort.Text);
            }

            device = chooseDeviceUserControl.Device;

            // Matching selected interface with .NET's facilities in order to get gateway's ip address
            // that is a property of the network interface of interest.
            NetworkInterface adapter = GetMatchingNetworkInterface(device.Interface, nics);

            if (adapter == null)
            {
                throw new Exception("Network interface not found.");
            }

            if (scanMethod == ScanMethod.SynScan)
            {
                if (device.Opened)
                {
                    MessageBox.Show("The sniffing process must be stopped in order to perform SYN Scan.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                IPInterfaceProperties properties = adapter.GetIPProperties();
                GatewayIPAddressInformationCollection gateways = properties.GatewayAddresses;

                if (gateways.Count > 0)
                {
                    gateway = gateways[0].Address;
                }
                else
                {
                    throw new Exception("No gateway address found.");
                }
            }

            textBoxScanResult.Clear();
            buttonStartScan.Enabled = false;
            buttonSaveLog.Enabled = false;

            backgroundWorkerScan.RunWorkerAsync();
        }

        #endregion
    }
}
