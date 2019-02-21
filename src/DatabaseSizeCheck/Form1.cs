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
    public partial class Form1 : Form
    {
        public bool FormActivated { get; set; }
        public Form1()
        {
            FormActivated = false;
            InitializeComponent();
            InitController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (FormActivated) return;
            ApplySettingsWindowsDetails();
            FormActivated = true;
            RefreshForm();
        }

        private void databasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDatabases();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAbout();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowHelp();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateSettingsWithWindowDetails();
        }
    }
}
