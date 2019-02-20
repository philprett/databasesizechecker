using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSizeCheck
{
    public partial class FormDatabase : Form
    {
        public string Host { get { return txtHost.Text; } set { txtHost.Text = value; } }
        public string Database { get { return txtDatabase.Text; } set { txtDatabase.Text = value; } }
        public string Username { get { return txtUsername.Text; } set { txtUsername.Text = value; } }
        public string Password { get { return txtPassword.Text; } set { txtPassword.Text = value; } }
        public bool IntegratedSecurity { get { return cmbUserType.SelectedIndex == 1; } set { cmbUserType.SelectedIndex = value ? 1 : 0; } }

        public FormDatabase()
        {
            InitializeComponent();
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
