using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WakeOnLan.Business;

namespace WakeOnLan.Forms
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();

			this.entryForm = new frmEntryDetail();
			this.aboutForm = new frmAbout();
		}

		private frmEntryDetail entryForm;
		private Form aboutForm;

		private void newEntryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var entry = this.entryForm.ShowEntryDialog();

			if (entry != null)
			{
				var item = new ListViewItem(entry.Name);
				item.SubItems.Add(entry.HostOrIP);
				item.SubItems.Add(entry.PortNumber.ToString());
				item.SubItems.Add(entry.MediaAccessControl);
				item.SubItems.Add(entry.UsePingPacket ? "Y" : "N");
				item.Tag = entry;

				this.listEntries.Items.Add(item);
			}
		}

		private void editEntry_Click(object sender, EventArgs e)
		{
			if (this.listEntries.SelectedItems.Count == 0) return;

			var item = this.listEntries.SelectedItems[0];
			var entry = item.Tag as Entry;
			this.entryForm.ShowEntryDialog(entry);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.aboutForm.ShowDialog();
		}

	}
}
