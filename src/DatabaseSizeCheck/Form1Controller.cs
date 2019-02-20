using SimpleImpersonation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSizeCheck
{
    public partial class Form1 : Form
    {
        Settings settings;
        public void InitController()
        {
            settings = new Settings();
        }

        public void RefreshForm()
        {
            RefreshGrid();
        }

        public void SetStatusMessage(string message)
        {
            toolStripStatusLabel.Text = message;
            Application.DoEvents();
        }

        public void RefreshGrid()
        {
            Grid.Rows.Clear();

            foreach (Connection db in settings.Databases)
            {
                SetStatusMessage(string.Format("Connecting to {0}...", db.ShortName));

                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                cell.Value = db.Host.Contains(".") ? db.Host.Substring(0, db.Host.IndexOf(".")) : db.Host;
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell();
                cell.Value = db.Database;
                row.Cells.Add(cell);

                Statistics stats = null;
                if (db.IntegratedSecurity && !string.IsNullOrWhiteSpace(db.Username))
                {
                    // This can cause problems with the impersonated user and returns an exception with HRESULT: 0x8000FFFF
                    // Fix it by giving the user access to registry items:
                    //     HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Lockdown_Zones
                    //     HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones
                    var credentials = new UserCredentials(db.Username, db.Password);
                    Impersonation.RunAsUser(credentials, LogonType.Interactive, () => {
                        db.Open();
                        stats = db.Statistics;
                        db.Close();
                    });
                }
                else
                {
                    stats = db.Statistics;
                }
                cell = new DataGridViewTextBoxCell();
                cell.Value = stats.DataFilename;
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell();
                cell.Value = stats.DataSize == -1 ? "Unlimited" : stats.DataSize.ToString("#,###,###,###,##0");
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell();
                cell.Value = stats.DataMaxSize;
                cell.Value = stats.DataMaxSize == -1 ? "Unlimited" : stats.DataMaxSize.ToString("#,###,###,###,##0");
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell();
                cell.Value = stats.TLogFilename;
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell();
                cell.Value = stats.TLogUsed;
                cell.Value = stats.TLogUsed == -1 ? "Unlimited" : stats.TLogUsed.ToString("#,###,###,###,##0");
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell();
                cell.Value = stats.TLogSize;
                cell.Value = stats.TLogSize == -1 ? "Unlimited" : stats.TLogSize.ToString("#,###,###,###,##0");
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell();
                cell.Value = stats.TLogMaxSize;
                cell.Value = stats.TLogMaxSize == -1 ? "Unlimited" : stats.TLogMaxSize.ToString("#,###,###,###,##0");
                row.Cells.Add(cell);

                Grid.Rows.Add(row);
            }
            SetStatusMessage("All database information updated.");
        }

        public void ShowDatabases()
        {
            FormDatabases f = new FormDatabases();
            f.ShowDialog();
            RefreshForm();
        }

        public void ShowHelp()
        {

        }

        public void ShowAbout()
        {
            FormAbout f = new FormAbout();
            f.ShowDialog();
        }
    }
}
