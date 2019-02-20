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
    public partial class FormDatabases : Form
    {
        public FormDatabases()
        {
            InitializeComponent();
            InitController();
        }

        private void FormDatabases_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void lstDatabases_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            ListBox lb = (ListBox)sender;
            Connection obj = (Connection)lb.Items[e.Index];
            string text = obj.ShortName;

            e.DrawBackground();

            Graphics g = e.Graphics;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                g.FillRectangle(SystemBrushes.Highlight, e.Bounds);
            }
            else
            {
                g.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
            }
            g.DrawString(text, e.Font, new SolidBrush(e.ForeColor), new PointF(e.Bounds.X, e.Bounds.Y));

            e.DrawFocusRectangle();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            AddDatabase();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            EditDatabase();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            DeleteDatabases();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void lstDatabases_DoubleClick(object sender, EventArgs e)
        {
            EditDatabase();
        }
    }
}
