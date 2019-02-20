using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSizeCheck
{
    public partial class FormDatabases : Form
    {
        Settings settings;
        public void InitController()
        {
            settings = new Settings();
        }

        public void RefreshForm()
        {
            lstDatabases.Items.Clear();

            foreach (Connection db in settings.Databases)
            {
                lstDatabases.Items.Add(db);
            }
        }

        public void AddDatabase()
        {
            FormDatabase f = new FormDatabase();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Connection c = new Connection
                {
                    Host = f.Host,
                    Database = f.Database,
                    Username = f.Username,
                    Password = f.Password,
                    IntegratedSecurity = f.IntegratedSecurity,
                };
                settings.Databases.Add(c);
                settings.Save();
                RefreshForm();
            }
        }

        public void EditDatabase()
        {
            if (lstDatabases.SelectedItems.Count != 1) return;

            Connection c = (Connection)lstDatabases.SelectedItems[0];

            FormDatabase f = new FormDatabase
            {
                Host = c.Host,
                Database = c.Database,
                Username = c.Username,
                Password = c.Password,
                IntegratedSecurity = c.IntegratedSecurity,
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                c.Host = f.Host;
                c.Database = f.Database;
                c.Username = f.Username;
                c.Password = f.Password;
                c.IntegratedSecurity = f.IntegratedSecurity;
                settings.Save();
                RefreshForm();
            }
        }

        public void DeleteDatabases()
        {
            if (lstDatabases.SelectedItems.Count != 1) return;

            if (MessageBox.Show("Do you really want to delete this database connection?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Connection c = (Connection)lstDatabases.SelectedItems[0];
                settings.Databases.Remove(c);
                settings.Save();
                RefreshForm();
            }
        }

        public void CloseForm()
        {
            Close();
        }
    }
}
