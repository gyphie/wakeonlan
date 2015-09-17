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
			this.preferencesForm = new frmPreferences();

			this.LoadData();
		}


		private frmEntryDetail entryForm;
		private Form aboutForm;
		private frmPreferences preferencesForm;
		private Entry defaults;


		private void LoadData()
		{
			Entry defaults;
			List<Entry> entries;
			if (Persistence.LoadData(out defaults, out entries))
			{
				this.defaults = defaults;
				foreach (var entry in entries)
				{
					this.EntryToListViewItem(this.listEntries, entry);
				}
			}
			else
			{
				this.defaults = new Entry();
				this.defaults.PortNumber = 9;
			}
		}

		private void EntryToListViewItem(ListView lv, Entry entry)
		{
			var item = new ListViewItem(entry.Name);
			item.SubItems.Add(entry.HostOrIP);
			item.SubItems.Add(entry.PortNumber.ToString());
			item.SubItems.Add(entry.FormattedMac(":"));
			item.SubItems.Add(entry.UsePingPacket ? "Y" : "N");
			//item.SubItems.Add(entry.UseBroadcast ? "Y" : "N");
			//item.SubItems.Add(entry.Password);
			item.Tag = entry;

			this.listEntries.Items.Add(item);
		}

		private void newEntry_Click(object sender, EventArgs e)
		{
			var entry = new Entry() { PortNumber = this.defaults.PortNumber, UsePingPacket = this.defaults.UsePingPacket, UseBroadcast = this.defaults.UseBroadcast };
			entry = this.entryForm.ShowEntryDialog(entry);

			if (entry != null)
			{
				this.EntryToListViewItem(this.listEntries, entry);
				this.SaveData();
			}
		}

		private void editEntry_Click(object sender, EventArgs e)
		{
			if (this.listEntries.SelectedItems.Count == 0) return;

			var item = this.listEntries.SelectedItems[0];
			var entry = item.Tag as Entry;
			entry = this.entryForm.ShowEntryDialog(entry);
			if (entry == null) return;

			item.Tag = entry;
			item.SubItems[0].Text = entry.Name;
			item.SubItems[1].Text = entry.HostOrIP;
			item.SubItems[2].Text = entry.PortNumber.ToString();
			item.SubItems[3].Text = entry.FormattedMac(":");
			item.SubItems[4].Text = entry.UsePingPacket ? "Y" : "N";
			//item.SubItems[5].Text = entry.UseBroadcast ? "Y" : "N";
			//item.SubItems[6].Text = entry.Password;

			this.SaveData();
		}

		private void deleteEntry_Click(object sender, EventArgs e)
		{
			if (this.listEntries.SelectedItems.Count == 0) return;

			var item = this.listEntries.SelectedItems[0];
			var entry = item.Tag as Entry;

			this.listEntries.Items.Remove(item);

			this.SaveData();
		}

		private void SaveData()
		{
			List<Entry> entries = new List<Entry>();
			foreach (ListViewItem listViewItem in this.listEntries.Items)
			{
				entries.Add(listViewItem.Tag as Entry);
			}

			Persistence.SaveData(this.defaults, entries);
		}

		private void exitMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.aboutForm.ShowDialog();
		}

		private void contextMenuForList_Opening(object sender, CancelEventArgs e)
		{
			var hasItem = this.listEntries.SelectedItems.Count > 0;
			this.lmiWake.Enabled = hasItem;
			this.lmiEditEntry.Enabled = hasItem;
			this.lmiDeleteEntry.Enabled = hasItem;

			this.fmiWake.Enabled = hasItem;
			this.fmiEditEntry.Enabled = hasItem;
			this.fmiDeleteEntry.Enabled = hasItem;
		}

		private void wakeEntry_Click(object sender, EventArgs e)
		{
			if (this.listEntries.SelectedItems.Count == 0) return;

			var item = this.listEntries.SelectedItems[0];
			var entry = item.Tag as Entry;

			this.readyStatusLabel.Visible = false;
			this.wakingStatusLabel.Visible = true;
			this.wakingStatusLabel.Text = string.Format("Waking...{0}", entry.Name);

			var result = WOL.Wake(entry);

			this.readyStatusLabel.Visible = true;
			this.wakingStatusLabel.Visible = false;

		}

		private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var newDefaults = this.preferencesForm.ShowPreferencesDialog(this.defaults);
			if (newDefaults != null)
			{
				this.defaults = newDefaults;
				this.SaveData();
			}
		}

		private void copyEntryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listEntries.SelectedItems.Count == 0) return;

			var item = this.listEntries.SelectedItems[0];
			var entry = item.Tag as Entry;

			var clone = new Entry()
			{
				Name = entry.Name,
				HostOrIP = entry.HostOrIP,
				PortNumber = entry.PortNumber,
				MediaAccessControl = entry.MediaAccessControl,
				UsePingPacket = entry.UsePingPacket,
				UseBroadcast = entry.UseBroadcast,
				Password = entry.Password
			};

			this.EntryToListViewItem(this.listEntries, clone);
			this.SaveData();
		}
	}
}
