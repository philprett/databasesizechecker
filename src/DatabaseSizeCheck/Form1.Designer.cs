namespace DatabaseSizeCheck
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.colServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatabase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataFileMaxSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTLogFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTLogUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTLogFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTLogMaxSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.databasesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::DatabaseSizeCheck.Properties.Resources.door_in;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = global::DatabaseSizeCheck.Properties.Resources.arrow_refresh;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.updateToolStripMenuItem.Text = "&Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // databasesToolStripMenuItem
            // 
            this.databasesToolStripMenuItem.Image = global::DatabaseSizeCheck.Properties.Resources.database_edit;
            this.databasesToolStripMenuItem.Name = "databasesToolStripMenuItem";
            this.databasesToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.databasesToolStripMenuItem.Text = "&Databases";
            this.databasesToolStripMenuItem.Click += new System.EventHandler(this.databasesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.creditsToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::DatabaseSizeCheck.Properties.Resources.help;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Image = global::DatabaseSizeCheck.Properties.Resources.help;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "&Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.creditsToolStripMenuItem.Text = "&About";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.BackgroundColor = System.Drawing.Color.White;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colServer,
            this.colDatabase,
            this.colDataFilename,
            this.colDataFileSize,
            this.colDataFileMaxSize,
            this.colTLogFilename,
            this.colTLogUsed,
            this.colTLogFileSize,
            this.colTLogMaxSize});
            this.Grid.Location = new System.Drawing.Point(0, 27);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersVisible = false;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid.Size = new System.Drawing.Size(1063, 392);
            this.Grid.TabIndex = 1;
            // 
            // colServer
            // 
            this.colServer.HeaderText = "Server";
            this.colServer.Name = "colServer";
            this.colServer.ReadOnly = true;
            this.colServer.Width = 75;
            // 
            // colDatabase
            // 
            this.colDatabase.HeaderText = "Database";
            this.colDatabase.Name = "colDatabase";
            this.colDatabase.ReadOnly = true;
            this.colDatabase.Width = 75;
            // 
            // colDataFilename
            // 
            this.colDataFilename.HeaderText = "Data Filename";
            this.colDataFilename.Name = "colDataFilename";
            this.colDataFilename.ReadOnly = true;
            this.colDataFilename.Width = 250;
            // 
            // colDataFileSize
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "#,###,###,###,##0";
            dataGridViewCellStyle1.NullValue = null;
            this.colDataFileSize.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDataFileSize.HeaderText = "Size KB";
            this.colDataFileSize.Name = "colDataFileSize";
            this.colDataFileSize.ReadOnly = true;
            this.colDataFileSize.Width = 75;
            // 
            // colDataFileMaxSize
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "#,###,###,###,##0";
            this.colDataFileMaxSize.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDataFileMaxSize.HeaderText = "Max Size KB";
            this.colDataFileMaxSize.Name = "colDataFileMaxSize";
            this.colDataFileMaxSize.ReadOnly = true;
            this.colDataFileMaxSize.Width = 75;
            // 
            // colTLogFilename
            // 
            this.colTLogFilename.HeaderText = "TLog Filename";
            this.colTLogFilename.Name = "colTLogFilename";
            this.colTLogFilename.ReadOnly = true;
            this.colTLogFilename.Width = 250;
            // 
            // colTLogUsed
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,###,###,###,##0";
            this.colTLogUsed.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTLogUsed.HeaderText = "Used KB";
            this.colTLogUsed.Name = "colTLogUsed";
            this.colTLogUsed.ReadOnly = true;
            this.colTLogUsed.Width = 75;
            // 
            // colTLogFileSize
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "#,###,###,###,##0";
            this.colTLogFileSize.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTLogFileSize.HeaderText = "Size KB";
            this.colTLogFileSize.Name = "colTLogFileSize";
            this.colTLogFileSize.ReadOnly = true;
            this.colTLogFileSize.Width = 75;
            // 
            // colTLogMaxSize
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#,###,###,###,##0";
            this.colTLogMaxSize.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTLogMaxSize.HeaderText = "Max Size KB";
            this.colTLogMaxSize.Name = "colTLogMaxSize";
            this.colTLogMaxSize.ReadOnly = true;
            this.colTLogMaxSize.Width = 75;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1063, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 444);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1079, 391);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Size Checker";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.ToolStripMenuItem databasesToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatabase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataFilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataFileMaxSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTLogFilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTLogUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTLogFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTLogMaxSize;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

