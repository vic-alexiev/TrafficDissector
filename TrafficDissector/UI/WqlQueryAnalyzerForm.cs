using System;
using System.Management;
using System.Windows.Forms;

namespace TrafficDissector.UI
{
    public partial class WqlQueryAnalyzerForm : BaseForm
    {
        #region Constructor

        public WqlQueryAnalyzerForm()
        {
            InitializeComponent();
        }

        #endregion


        #region Event Handlers

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (!ValidateUserInput())
            {
                return;
            }

            ExecuteQuery();
        }

        #endregion


        #region Private Methods

        private bool ValidateUserInput()
        {
            bool result = true;
            errorProvider.Clear();

            if (String.IsNullOrEmpty(textBoxHost.Text))
            {
                errorProvider.SetError(textBoxHost, "Enter a valid host name.");
                result = false;
            }

            if (String.IsNullOrEmpty(textBoxQuery.Text))
            {
                errorProvider.SetError(buttonExecute, "Enter a valid query.");
                result = false;
            }

            return result;
        }

        private void ExecuteQuery()
        {
            ConnectionOptions options = new ConnectionOptions();

            if (!String.IsNullOrEmpty(textBoxPassword.Text) &&
               !String.IsNullOrEmpty(textBoxUsername.Text))
            {
                options.Username = String.Format("{0}\\{1}",
                    textBoxHost.Text, textBoxUsername.Text);
                options.Password = textBoxPassword.Text;
            }

            try
            {
                Cursor = Cursors.WaitCursor;

                ManagementScope scope = new ManagementScope(
                    String.Format("\\\\{0}\\root\\cimv2", textBoxHost.Text),
                    options);
                scope.Connect();

                ObjectQuery query = new ObjectQuery(textBoxQuery.Text);
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher(scope, query);

                ManagementObjectCollection itemsCollection;

                itemsCollection = searcher.Get();
                listViewWMI.Clear();
                listViewWMI.Columns.Clear();
                listViewWMI.View = View.Details;

                foreach (ManagementBaseObject item in itemsCollection)
                {
                    if (listViewWMI.Columns.Count == 0)
                    {
                        foreach (PropertyData wmiProperty in item.Properties)
                        {
                            listViewWMI.Columns.Add(
                                wmiProperty.Name,
                                listViewWMI.Width / 4,
                                HorizontalAlignment.Left);
                        }
                    }

                    ListViewItem listViewItem = new ListViewItem();
                    bool firstColumn = true;
                    foreach (PropertyData wmiProperty in item.Properties)
                    {
                        if (firstColumn)
                        {
                            listViewItem.SubItems[0].Text = wmiProperty.Value + "";
                            firstColumn = false;
                        }
                        else
                        {
                            listViewItem.SubItems.Add(wmiProperty.Value + "");
                        }
                    }

                    listViewWMI.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                listViewWMI.View = View.LargeIcon;
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        #endregion
    }
}