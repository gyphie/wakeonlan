namespace WakeOnLan.Forms
{
	partial class frmMain
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.readyStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.wakingStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuMain = new System.Windows.Forms.MenuStrip();
			this.mmiFile = new System.Windows.Forms.ToolStripMenuItem();
			this.fileMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.fmiWake = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.fmiNewEntry = new System.Windows.Forms.ToolStripMenuItem();
			this.fmiEditEntry = new System.Windows.Forms.ToolStripMenuItem();
			this.fmiCloneEntry = new System.Windows.Forms.ToolStripMenuItem();
			this.fmiDeleteEntry = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.fmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuForList = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.lmiWake = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.lmiNewEntry = new System.Windows.Forms.ToolStripMenuItem();
			this.lmiEditEntry = new System.Windows.Forms.ToolStripMenuItem();
			this.lmiCloneEntry = new System.Windows.Forms.ToolStripMenuItem();
			this.lmiDeleteEntry = new System.Windows.Forms.ToolStripMenuItem();
			this.newEntryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.listEntries = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.bgwWake = new System.ComponentModel.BackgroundWorker();
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.statusStrip1.SuspendLayout();
			this.menuMain.SuspendLayout();
			this.fileMenu.SuspendLayout();
			this.contextMenuForList.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readyStatusLabel,
            this.wakingStatusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 296);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(677, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// readyStatusLabel
			// 
			this.readyStatusLabel.Name = "readyStatusLabel";
			this.readyStatusLabel.Size = new System.Drawing.Size(39, 17);
			this.readyStatusLabel.Text = "Ready";
			// 
			// wakingStatusLabel
			// 
			this.wakingStatusLabel.Name = "wakingStatusLabel";
			this.wakingStatusLabel.Size = new System.Drawing.Size(56, 17);
			this.wakingStatusLabel.Text = "Waking...";
			this.wakingStatusLabel.Visible = false;
			// 
			// menuMain
			// 
			this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmiFile,
            this.helpToolStripMenuItem});
			this.menuMain.Location = new System.Drawing.Point(0, 0);
			this.menuMain.Name = "menuMain";
			this.menuMain.Size = new System.Drawing.Size(677, 24);
			this.menuMain.TabIndex = 1;
			this.menuMain.Text = "Main Menu";
			// 
			// mmiFile
			// 
			this.mmiFile.DropDown = this.fileMenu;
			this.mmiFile.Name = "mmiFile";
			this.mmiFile.Size = new System.Drawing.Size(37, 20);
			this.mmiFile.Text = "&File";
			// 
			// fileMenu
			// 
			this.fileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fmiWake,
            this.toolStripSeparator2,
            this.fmiNewEntry,
            this.fmiEditEntry,
            this.fmiCloneEntry,
            this.fmiDeleteEntry,
            this.toolStripSeparator1,
            this.preferencesToolStripMenuItem,
            this.toolStripSeparator5,
            this.fmiExit});
			this.fileMenu.Name = "fileMenu";
			this.fileMenu.Size = new System.Drawing.Size(145, 176);
			this.fileMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuForList_Opening);
			// 
			// fmiWake
			// 
			this.fmiWake.Name = "fmiWake";
			this.fmiWake.Size = new System.Drawing.Size(144, 22);
			this.fmiWake.Text = "&Wake";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(141, 6);
			// 
			// fmiNewEntry
			// 
			this.fmiNewEntry.Name = "fmiNewEntry";
			this.fmiNewEntry.Size = new System.Drawing.Size(144, 22);
			this.fmiNewEntry.Text = "&New Entry...";
			this.fmiNewEntry.Click += new System.EventHandler(this.newEntry_Click);
			// 
			// fmiEditEntry
			// 
			this.fmiEditEntry.Name = "fmiEditEntry";
			this.fmiEditEntry.Size = new System.Drawing.Size(144, 22);
			this.fmiEditEntry.Text = "&Edit...";
			this.fmiEditEntry.Click += new System.EventHandler(this.editEntry_Click);
			// 
			// fmiCloneEntry
			// 
			this.fmiCloneEntry.Name = "fmiCloneEntry";
			this.fmiCloneEntry.Size = new System.Drawing.Size(144, 22);
			this.fmiCloneEntry.Text = "&Clone";
			this.fmiCloneEntry.Click += new System.EventHandler(this.copyEntryToolStripMenuItem_Click);
			// 
			// fmiDeleteEntry
			// 
			this.fmiDeleteEntry.Name = "fmiDeleteEntry";
			this.fmiDeleteEntry.Size = new System.Drawing.Size(144, 22);
			this.fmiDeleteEntry.Text = "&Delete";
			this.fmiDeleteEntry.Click += new System.EventHandler(this.deleteEntry_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
			// 
			// preferencesToolStripMenuItem
			// 
			this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
			this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.preferencesToolStripMenuItem.Text = "&Preferences...";
			this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(141, 6);
			// 
			// fmiExit
			// 
			this.fmiExit.Name = "fmiExit";
			this.fmiExit.Size = new System.Drawing.Size(144, 22);
			this.fmiExit.Text = "E&xit";
			this.fmiExit.Click += new System.EventHandler(this.exitMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// contextMenuForList
			// 
			this.contextMenuForList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lmiWake,
            this.toolStripSeparator4,
            this.lmiNewEntry,
            this.lmiEditEntry,
            this.lmiCloneEntry,
            this.lmiDeleteEntry});
			this.contextMenuForList.Name = "contextMenuForList";
			this.contextMenuForList.Size = new System.Drawing.Size(138, 120);
			this.contextMenuForList.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuForList_Opening);
			// 
			// lmiWake
			// 
			this.lmiWake.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lmiWake.Name = "lmiWake";
			this.lmiWake.Size = new System.Drawing.Size(137, 22);
			this.lmiWake.Text = "&Wake";
			this.lmiWake.Click += new System.EventHandler(this.wakeEntry_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(134, 6);
			// 
			// lmiNewEntry
			// 
			this.lmiNewEntry.Name = "lmiNewEntry";
			this.lmiNewEntry.Size = new System.Drawing.Size(137, 22);
			this.lmiNewEntry.Text = "&New Entry...";
			this.lmiNewEntry.Click += new System.EventHandler(this.newEntry_Click);
			// 
			// lmiEditEntry
			// 
			this.lmiEditEntry.Name = "lmiEditEntry";
			this.lmiEditEntry.Size = new System.Drawing.Size(137, 22);
			this.lmiEditEntry.Text = "&Edit...";
			this.lmiEditEntry.Click += new System.EventHandler(this.editEntry_Click);
			// 
			// lmiCloneEntry
			// 
			this.lmiCloneEntry.Name = "lmiCloneEntry";
			this.lmiCloneEntry.Size = new System.Drawing.Size(137, 22);
			this.lmiCloneEntry.Text = "&Clone";
			this.lmiCloneEntry.Click += new System.EventHandler(this.copyEntryToolStripMenuItem_Click);
			// 
			// lmiDeleteEntry
			// 
			this.lmiDeleteEntry.Name = "lmiDeleteEntry";
			this.lmiDeleteEntry.Size = new System.Drawing.Size(137, 22);
			this.lmiDeleteEntry.Text = "&Delete";
			this.lmiDeleteEntry.Click += new System.EventHandler(this.deleteEntry_Click);
			// 
			// newEntryToolStripMenuItem1
			// 
			this.newEntryToolStripMenuItem1.Name = "newEntryToolStripMenuItem1";
			this.newEntryToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.newEntryToolStripMenuItem1.Text = "&New Entry";
			// 
			// listEntries
			// 
			this.listEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
			this.listEntries.ContextMenuStrip = this.contextMenuForList;
			this.listEntries.FullRowSelect = true;
			this.listEntries.GridLines = true;
			this.listEntries.Location = new System.Drawing.Point(0, 27);
			this.listEntries.MultiSelect = false;
			this.listEntries.Name = "listEntries";
			this.listEntries.ShowGroups = false;
			this.listEntries.Size = new System.Drawing.Size(677, 270);
			this.listEntries.TabIndex = 2;
			this.listEntries.UseCompatibleStateImageBehavior = false;
			this.listEntries.View = System.Windows.Forms.View.Details;
			this.listEntries.DoubleClick += new System.EventHandler(this.listEntries_DoubleClick);
			this.listEntries.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listEntries_KeyUp);
			this.listEntries.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listEntries_MouseUp);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Description";
			this.columnHeader1.Width = 135;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Host";
			this.columnHeader2.Width = 120;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Port";
			this.columnHeader4.Width = 50;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "MAC";
			this.columnHeader3.Width = 124;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Use Ping";
			// 
			// bgwWake
			// 
			this.bgwWake.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwWake_DoWork);
			this.bgwWake.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwWake_RunWorkerCompleted);
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Use BC";
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "SecureON";
			this.columnHeader7.Width = 124;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(677, 318);
			this.Controls.Add(this.listEntries);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuMain;
			this.MinimumSize = new System.Drawing.Size(270, 140);
			this.Name = "frmMain";
			this.Text = "Wake On Lan";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuMain.ResumeLayout(false);
			this.menuMain.PerformLayout();
			this.fileMenu.ResumeLayout(false);
			this.contextMenuForList.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.MenuStrip menuMain;
		private System.Windows.Forms.ToolStripMenuItem mmiFile;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fmiWake;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem fmiNewEntry;
		private System.Windows.Forms.ToolStripMenuItem fmiEditEntry;
		private System.Windows.Forms.ToolStripMenuItem fmiDeleteEntry;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem fmiExit;
		private System.Windows.Forms.ContextMenuStrip contextMenuForList;
		private System.Windows.Forms.ToolStripMenuItem lmiWake;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem lmiNewEntry;
		private System.Windows.Forms.ToolStripMenuItem lmiEditEntry;
		private System.Windows.Forms.ToolStripMenuItem lmiDeleteEntry;
		private System.Windows.Forms.ToolStripMenuItem newEntryToolStripMenuItem1;
		private System.Windows.Forms.ListView listEntries;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ContextMenuStrip fileMenu;
		private System.Windows.Forms.ToolStripMenuItem fmiCloneEntry;
		private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripStatusLabel readyStatusLabel;
		private System.Windows.Forms.ToolStripMenuItem lmiCloneEntry;
		private System.Windows.Forms.ToolStripStatusLabel wakingStatusLabel;
		private System.ComponentModel.BackgroundWorker bgwWake;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
	}
}

