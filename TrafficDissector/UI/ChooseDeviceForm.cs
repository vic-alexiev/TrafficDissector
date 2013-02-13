using SharpPcap;
using SharpPcap.Containers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace TrafficDissector.UI
{
    internal partial class ChooseDeviceForm : BaseForm
    {
        #region Events & Raising Events

        public event EventHandler ButtonStopPressed;
        protected void OnButtonStopPressed()
        {
            if (ButtonStopPressed != null)
            {
                ButtonStopPressed(this, EventArgs.Empty);
            }
        }

        #endregion


        #region Fields & Properties

        private NetworkInterface[] nics;

        public PcapDevice Device
        {
            get
            {
                return (PcapDevice)comboBoxDevices.SelectedItem;
            }
        }

        #endregion


        #region Constructor

        public ChooseDeviceForm(PcapDevice device)
        {
            InitializeComponent();

            nics = NetworkInterface.GetAllNetworkInterfaces();

            FillComboBoxDevices();

            comboBoxDevices.SelectedIndexChanged += new EventHandler(comboBoxDevices_SelectedIndexChanged);

            if (comboBoxDevices.Items.Count > 0)
            {
                comboBoxDevices.SelectedItem = device;

                if (device != null)
                {
                    buttonStart.Enabled = !device.Started;
                    buttonStop.Enabled = device.Started;
                }
                else
                {
                    buttonStart.Enabled = false;
                    buttonStop.Enabled = false;
                }
            }
            else
            {
                buttonStart.Enabled = false;
                buttonStop.Enabled = false;
            }
        }

        #endregion


        #region Private Methods

        private void FillComboBoxDevices()
        {
            // Retrieve the device list and set it as the combo box data source
            comboBoxDevices.DataSource = Pcap.GetAllDevices();

            // Set the combo box display member
            comboBoxDevices.DisplayMember = "Description";
        }

        private bool IsThereStartedDevice()
        {
            foreach (object item in comboBoxDevices.Items)
            {
                if (((PcapDevice)item).Started)
                {
                    return true;
                }
            }

            return false;
        }

        private string GetNonAdapterDeviceInfo(PcapDevice device)
        {
            if (device == null)
            {
                return String.Empty;
            }

            StringBuilder infoBuilder = new StringBuilder();

            infoBuilder.Append(device.Interface.Description + "\n");
            infoBuilder.Append("=================================================\n");
            infoBuilder.AppendFormat(" Name ....................... : {0}\n",
                device.Interface.Name);
            infoBuilder.AppendFormat(" Friendly name .............. : {0}\n",
                device.Interface.FriendlyName);
            infoBuilder.Append(" Addresses .................. :\n");
            infoBuilder.Append(GetPcapAddresses(device.Interface.Addresses));
            infoBuilder.AppendFormat(" Flags ...................... : {0}\n",
                device.Interface.Flags);

            return infoBuilder.ToString();
        }

        private string GetDeviceInfo(NetworkInterface adapter)
        {
            if (adapter == null)
            {
                return String.Empty;
            }

            IPInterfaceProperties properties = adapter.GetIPProperties();

            StringBuilder infoBuilder = new StringBuilder();

            infoBuilder.Append(adapter.Description + "\n");
            infoBuilder.Append("=================================================\n");
            infoBuilder.AppendFormat(" ID ......................... : {0}\n",
                adapter.Id);
            infoBuilder.AppendFormat(" Name ....................... : {0}\n",
                adapter.Name);
            infoBuilder.AppendFormat(" Interface type ............. : {0}\n",
                adapter.NetworkInterfaceType);
            infoBuilder.AppendFormat(" Physical Address ........... : {0}\n",
                       BitConverter.ToString(adapter.GetPhysicalAddress().GetAddressBytes()));
            infoBuilder.AppendFormat(" Operational status ......... : {0}\n",
                adapter.OperationalStatus);
            infoBuilder.AppendFormat(" Speed ...................... : {0} Mb/s\n",
                adapter.Speed / 1000000);

            string versions = String.Empty;

            // Create a display string for the supported IP versions.
            if (adapter.Supports(NetworkInterfaceComponent.IPv4))
            {
                versions = "IPv4";
            }
            if (adapter.Supports(NetworkInterfaceComponent.IPv6))
            {
                if (versions.Length > 0)
                {
                    versions += " ";
                }
                versions += "IPv6";
            }

            infoBuilder.AppendFormat(" IP version ................. : {0}\n",
                versions);

            infoBuilder.Append(GetIPAddresses(properties));

            // The following information is not useful for loopback adapters.
            if (adapter.NetworkInterfaceType == NetworkInterfaceType.Loopback)
            {
                return infoBuilder.ToString();
            }

            infoBuilder.AppendFormat(" DNS suffix ................. : {0}\n",
                properties.DnsSuffix);

            if (adapter.Supports(NetworkInterfaceComponent.IPv4))
            {
                IPv4InterfaceProperties ipv4 = properties.GetIPv4Properties();

                infoBuilder.AppendFormat(" Index ...................... : {0}\n",
                    ipv4.Index);
                infoBuilder.AppendFormat(" MTU ........................ : {0}\n",
                    ipv4.Mtu);
                infoBuilder.AppendFormat(" APIPA active ............... : {0}\n",
                    ipv4.IsAutomaticPrivateAddressingActive);
                infoBuilder.AppendFormat(" APIPA enabled .............. : {0}\n",
                    ipv4.IsAutomaticPrivateAddressingEnabled);
                infoBuilder.AppendFormat(" DHCP enabled ............... : {0}\n",
                    ipv4.IsDhcpEnabled);
                infoBuilder.AppendFormat(" Forwarding enabled.......... : {0}\n",
                    ipv4.IsForwardingEnabled);
                infoBuilder.AppendFormat(" Uses WINS .................. : {0}\n",
                    ipv4.UsesWins);

                if (ipv4.UsesWins)
                {
                    IPAddressCollection winsServers = properties.WinsServersAddresses;
                    if (winsServers.Count > 0)
                    {
                        foreach (IPAddress winsServer in winsServers)
                        {
                            infoBuilder.AppendFormat(" WINS Server ................ : {0}\n",
                                winsServer);
                        }
                    }
                }
            }

            if (adapter.Supports(NetworkInterfaceComponent.IPv6))
            {
                IPv6InterfaceProperties ipv6 = properties.GetIPv6Properties();

                infoBuilder.AppendFormat(" Index ...................... : {0}\n",
                    ipv6.Index);
                infoBuilder.AppendFormat(" MTU ........................ : {0}\n",
                    ipv6.Mtu);
            }

            infoBuilder.AppendFormat(" DNS enabled ................ : {0}\n",
                properties.IsDnsEnabled);
            infoBuilder.AppendFormat(" Dynamically configured DNS . : {0}\n",
                properties.IsDynamicDnsEnabled);
            infoBuilder.AppendFormat(" Receive Only ............... : {0}\n",
                adapter.IsReceiveOnly);
            infoBuilder.AppendFormat(" Multicast .................. : {0}\n",
                adapter.SupportsMulticast);

            return infoBuilder.ToString();
        }

        private string GetDeviceIPv4Statistics(NetworkInterface adapter)
        {
            if (adapter == null)
            {
                return String.Empty;
            }

            IPv4InterfaceStatistics ipv4Stat = adapter.GetIPv4Statistics();

            StringBuilder ipv4StatBuilder = new StringBuilder();

            ipv4StatBuilder.Append("IPv4 Statistics\n");
            ipv4StatBuilder.Append("=================================================\n");

            ipv4StatBuilder.AppendFormat(" Bytes received .................. : {0}\n",
                ipv4Stat.BytesReceived);
            ipv4StatBuilder.AppendFormat(" Unicast packets received ........ : {0}\n",
                ipv4Stat.UnicastPacketsReceived);
            ipv4StatBuilder.AppendFormat(" Non-Unicast packets received .... : {0}\n",
                ipv4Stat.NonUnicastPacketsReceived);
            ipv4StatBuilder.AppendFormat(" Incoming packets discarded ...... : {0}\n",
                ipv4Stat.IncomingPacketsDiscarded);
            ipv4StatBuilder.AppendFormat(" Incoming packets with errors .... : {0}\n",
                ipv4Stat.IncomingPacketsWithErrors);
            ipv4StatBuilder.AppendFormat(" Bytes sent ...................... : {0}\n",
                ipv4Stat.BytesSent);
            ipv4StatBuilder.AppendFormat(" Unicast packets sent ............ : {0}\n",
                ipv4Stat.UnicastPacketsSent);
            ipv4StatBuilder.AppendFormat(" Non-Unicast packets sent ........ : {0}\n",
                ipv4Stat.NonUnicastPacketsSent);
            ipv4StatBuilder.AppendFormat(" Outgoing packets discarded ...... : {0}\n",
                ipv4Stat.OutgoingPacketsDiscarded);
            ipv4StatBuilder.AppendFormat(" Outgoing packets with errors .... : {0}\n",
                ipv4Stat.OutgoingPacketsWithErrors);
            ipv4StatBuilder.AppendFormat(" Incoming unknown protocol packets : {0}\n",
                ipv4Stat.IncomingUnknownProtocolPackets);
            ipv4StatBuilder.AppendFormat(" Output queue length ............. : {0}\n",
                ipv4Stat.OutputQueueLength);

            return ipv4StatBuilder.ToString();
        }

        private string GetIPAddresses(IPInterfaceProperties adapterProperties)
        {
            StringBuilder ipAddressesBuilder = new StringBuilder();
            IPAddressCollection dnsServers = adapterProperties.DnsAddresses;
            if (dnsServers.Count > 0)
            {
                foreach (IPAddress dns in dnsServers)
                {
                    ipAddressesBuilder.AppendFormat(" DNS Server ................. : {0}\n",
                        dns.ToString());
                }
            }

            GatewayIPAddressInformationCollection gateways = adapterProperties.GatewayAddresses;
            if (gateways.Count > 0)
            {
                foreach (GatewayIPAddressInformation gatewayAddresssInfo in gateways)
                {
                    ipAddressesBuilder.AppendFormat(" Gateway Address ............ : {0}\n",
                        gatewayAddresssInfo.Address);
                }
            }

            IPAddressCollection dhcpServers = adapterProperties.DhcpServerAddresses;
            if (dhcpServers.Count > 0)
            {
                foreach (IPAddress dhcpServer in dhcpServers)
                {
                    ipAddressesBuilder.AppendFormat(" DHCP Server ................ : {0}\n",
                        dhcpServer);
                }
            }

            IPAddressInformationCollection anyCast = adapterProperties.AnycastAddresses;
            if (anyCast.Count > 0)
            {
                foreach (IPAddressInformation any in anyCast)
                {
                    ipAddressesBuilder.AppendFormat(" Anycast Address ............ : {0} {1} {2}\n",
                        any.Address,
                        any.IsTransient ? "Transient" : String.Empty,
                        any.IsDnsEligible ? "DNS Eligible" : String.Empty);
                }
            }

            MulticastIPAddressInformationCollection multiCast = adapterProperties.MulticastAddresses;
            if (multiCast.Count > 0)
            {
                foreach (IPAddressInformation multi in multiCast)
                {
                    ipAddressesBuilder.AppendFormat(" Multicast Address .......... : {0} {1} {2}\n",
                        multi.Address,
                        multi.IsTransient ? "Transient" : String.Empty,
                        multi.IsDnsEligible ? "DNS Eligible" : String.Empty);
                }

            }

            UnicastIPAddressInformationCollection uniCast = adapterProperties.UnicastAddresses;
            if (uniCast.Count > 0)
            {
                string lifeTimeFormat = "dddd, MMMM dd, yyyy  hh:mm:ss tt";
                foreach (UnicastIPAddressInformation uni in uniCast)
                {
                    DateTime when;

                    ipAddressesBuilder.AppendFormat(" Unicast Address ............ : {0}\n",
                        uni.Address);
                    ipAddressesBuilder.AppendFormat("  Prefix Origin ............. : {0}\n",
                        uni.PrefixOrigin);
                    ipAddressesBuilder.AppendFormat("  Suffix Origin ............. : {0}\n",
                        uni.SuffixOrigin);
                    ipAddressesBuilder.AppendFormat("  Duplicate Address Detection : {0}\n",
                        uni.DuplicateAddressDetectionState);

                    // Format the lifetimes as Saturday, March 13, 2010 11:33:44 PM
                    // if en-us is the current culture.

                    // Calculate the date and time at the end of the lifetimes.    
                    when = DateTime.UtcNow + TimeSpan.FromSeconds(uni.AddressValidLifetime);
                    when = when.ToLocalTime();
                    ipAddressesBuilder.AppendFormat("  Valid Life Time ........... : {0}\n",
                        when.ToString(lifeTimeFormat, new CultureInfo("en-US")));
                    when = DateTime.UtcNow + TimeSpan.FromSeconds(uni.AddressPreferredLifetime);
                    when = when.ToLocalTime();
                    ipAddressesBuilder.AppendFormat("  Preferred life time ....... : {0}\n",
                        when.ToString(lifeTimeFormat, new CultureInfo("en-US")));

                    when = DateTime.UtcNow + TimeSpan.FromSeconds(uni.DhcpLeaseLifetime);
                    when = when.ToLocalTime();
                    ipAddressesBuilder.AppendFormat("  DHCP Leased Life Time ..... : {0}\n",
                        when.ToString(lifeTimeFormat, new CultureInfo("en-US")));
                }
            }

            return ipAddressesBuilder.ToString();
        }

        private string GetPcapAddresses(List<PcapAddress> addresses)
        {
            StringBuilder addressesBuilder = new StringBuilder();

            foreach (PcapAddress pcapAddress in addresses)
            {
                addressesBuilder.Append(pcapAddress);
            }

            return addressesBuilder.ToString();
        }

        #endregion


        #region Event Handlers

        private void comboBoxDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = ((ComboBox)sender).SelectedItem;

            if (selectedItem == null)
            {
                return;
            }

            PcapDevice device = (PcapDevice)selectedItem;

            if (IsThereStartedDevice())
            {
                buttonStart.Enabled = false;
                buttonStop.Enabled = device.Started;
            }
            else
            {
                buttonStart.Enabled = true;
                buttonStop.Enabled = false;
            }

            NetworkInterface adapter =
                GetMatchingNetworkInterface(device.Interface, nics);

            if (adapter == null)
            {
                richTextBoxDeviceProperties.Text = GetNonAdapterDeviceInfo(device);
                richTextBoxDeviceStatistics.Text = String.Empty;
            }
            else
            {
                richTextBoxDeviceProperties.Text = GetDeviceInfo(adapter);
                richTextBoxDeviceStatistics.Text = GetDeviceIPv4Statistics(adapter);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            OnButtonStopPressed();

            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }

        #endregion
    }
}