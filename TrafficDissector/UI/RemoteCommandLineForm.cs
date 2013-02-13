using System;
using System.Management;
using System.Windows.Forms;

namespace TrafficDissector.UI
{
    public partial class RemoteCommandLineForm : BaseForm
    {
        #region Constructor

        public RemoteCommandLineForm()
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

            Execute();
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

            if (String.IsNullOrEmpty(textBoxExecute.Text))
            {
                errorProvider.SetError(textBoxExecute, "Enter a valid command.");
                result = false;
            }

            return result;
        }

        private void Execute()
        {
            ConnectionOptions options = new ConnectionOptions();
            if (!String.IsNullOrEmpty(textBoxPassword.Text) &&
                !String.IsNullOrEmpty(textBoxUsername.Text))
            {
                options.Username = String.Format("{0}\\{1}", textBoxHost.Text, textBoxUsername.Text);
                options.Password = textBoxPassword.Text;
            }

            try
            {
                Cursor = Cursors.WaitCursor;

                ManagementScope scope = new ManagementScope(
                    String.Format("\\\\{0}\\root\\cimv2", textBoxHost.Text),
                    options);

                scope.Connect();

                ManagementClass win32ProcessClass =
                    new ManagementClass("Win32_Process");

                ManagementBaseObject inParameters =
                    win32ProcessClass.GetMethodParameters("Create");

                win32ProcessClass.Scope = scope;

                inParameters["CommandLine"] = textBoxExecute.Text;

                win32ProcessClass.InvokeMethod("Create", inParameters, null);
            }
            catch (Exception ex)
            {
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