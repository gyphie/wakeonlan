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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.menuMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.newEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteEntryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuForList = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.newEntryToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.editEntryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteEntryToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.newEntryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.listEntries = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.menuMain.SuspendLayout();
			this.contextMenuForList.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 296);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(618, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// menuMain
			// 
			this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuMain.Location = new System.Drawing.Point(0, 0);
			this.menuMain.Name = "menuMain";
			this.menuMain.Size = new System.Drawing.Size(618, 24);
			this.menuMain.TabIndex = 1;
			this.menuMain.Text = "Main Menu";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.newEntryToolStripMenuItem,
            this.editEntryToolStripMenuItem,
            this.deleteEntryToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.toolStripMenuItem1.Text = "&Wake Entry";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
			// 
			// newEntryToolStripMenuItem
			// 
			this.newEntryToolStripMenuItem.Name = "newEntryToolStripMenuItem";
			this.newEntryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.newEntryToolStripMenuItem.Text = "&New Entry...";
			this.newEntryToolStripMenuItem.Click += new System.EventHandler(this.newEntryToolStripMenuItem_Click);
			// 
			// editEntryToolStripMenuItem
			// 
			this.editEntryToolStripMenuItem.Name = "editEntryToolStripMenuItem";
			this.editEntryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.editEntryToolStripMenuItem.Text = "&Edit Entry...";
			this.editEntryToolStripMenuItem.Click += new System.EventHandler(this.editEntry_Click);
			// 
			// deleteEntryToolStripMenuItem
			// 
			this.deleteEntryToolStripMenuItem.Name = "deleteEntryToolStripMenuItem";
			this.deleteEntryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.deleteEntryToolStripMenuItem.Text = "&Delete Entry...";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyEntryToolStripMenuItem,
            this.deleteEntryToolStripMenuItem1,
            this.toolStripSeparator3,
            this.preferencesToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// copyEntryToolStripMenuItem
			// 
			this.copyEntryToolStripMenuItem.Name = "copyEntryToolStripMenuItem";
			this.copyEntryToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.copyEntryToolStripMenuItem.Text = "&Copy Entry";
			// 
			// deleteEntryToolStripMenuItem1
			// 
			this.deleteEntryToolStripMenuItem1.Name = "deleteEntryToolStripMenuItem1";
			this.deleteEntryToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
			this.deleteEntryToolStripMenuItem1.Text = "&Delete Entry";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
			// 
			// preferencesToolStripMenuItem
			// 
			this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
			this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.preferencesToolStripMenuItem.Text = "&Preferences...";
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
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// contextMenuForList
			// 
			this.contextMenuForList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripSeparator4,
            this.newEntryToolStripMenuItem2,
            this.editEntryToolStripMenuItem1,
            this.deleteEntryToolStripMenuItem2});
			this.contextMenuForList.Name = "contextMenuForList";
			this.contextMenuForList.Size = new System.Drawing.Size(147, 98);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(146, 22);
			this.toolStripMenuItem2.Text = "&Wake";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(143, 6);
			// 
			// newEntryToolStripMenuItem2
			// 
			this.newEntryToolStripMenuItem2.Name = "newEntryToolStripMenuItem2";
			this.newEntryToolStripMenuItem2.Size = new System.Drawing.Size(146, 22);
			this.newEntryToolStripMenuItem2.Text = "&New Entry...";
			// 
			// editEntryToolStripMenuItem1
			// 
			this.editEntryToolStripMenuItem1.Name = "editEntryToolStripMenuItem1";
			this.editEntryToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
			this.editEntryToolStripMenuItem1.Text = "&Edit Entry...";
			this.editEntryToolStripMenuItem1.Click += new System.EventHandler(this.editEntry_Click);
			// 
			// deleteEntryToolStripMenuItem2
			// 
			this.deleteEntryToolStripMenuItem2.Name = "deleteEntryToolStripMenuItem2";
			this.deleteEntryToolStripMenuItem2.Size = new System.Drawing.Size(146, 22);
			this.deleteEntryToolStripMenuItem2.Text = "&Delete Entry...";
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
            this.columnHeader5});
			this.listEntries.ContextMenuStrip = this.contextMenuForList;
			this.listEntries.FullRowSelect = true;
			this.listEntries.GridLines = true;
			this.listEntries.Location = new System.Drawing.Point(0, 27);
			this.listEntries.MultiSelect = false;
			this.listEntries.Name = "listEntries";
			this.listEntries.ShowGroups = false;
			this.listEntries.Size = new System.Drawing.Size(618, 266);
			this.listEntries.TabIndex = 2;
			this.listEntries.UseCompatibleStateImageBehavior = false;
			this.listEntries.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Description";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Host";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Port";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "MAC";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Use Ping";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(618, 318);
			this.Controls.Add(this.listEntries);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuMain);
			this.MainMenuStrip = this.menuMain;
			this.MinimumSize = new System.Drawing.Size(270, 140);
			this.Name = "frmMain";
			this.Text = "Wake On Lan";
			this.menuMain.ResumeLayout(false);
			this.menuMain.PerformLayout();
			this.contextMenuForList.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.MenuStrip menuMain;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem newEntryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editEntryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteEntryToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyEntryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteEntryToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuForList;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem newEntryToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem editEntryToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem deleteEntryToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem newEntryToolStripMenuItem1;
		private System.Windows.Forms.ListView listEntries;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
	}
}

