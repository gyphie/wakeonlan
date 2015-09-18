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
				this.listEntries.Focus();
				if (this.listEntries.Items.Count > 0)
				{
					this.listEntries.Items[0].Selected = true;
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
			item.SubItems.Add(entry.UsePingPacket ? "Yes" : "No");
			item.SubItems.Add(entry.UseBroadcast ? "Yes" : "No");
			item.SubItems.Add(entry.Password);
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
			item.SubItems[4].Text = entry.UsePingPacket ? "Yes" : "No";
			item.SubItems[5].Text = entry.UseBroadcast ? "Yes" : "No";
			item.SubItems[6].Text = entry.Password;

			this.SaveData();
		}

		private void deleteEntry_Click(object sender, EventArgs e)
		{
			if (this.listEntries.SelectedItems.Count == 0) return;

			if (MessageBox.Show("Are you sure you want to delete this entry?", "Delete Entry?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
			{
				var item = this.listEntries.SelectedItems[0];
				this.listEntries.Items.Remove(item);
				this.SaveData();
			}
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
			this.lmiWake.Font = new Font(this.lmiWake.Font, hasItem ? FontStyle.Bold : FontStyle.Regular);
			this.lmiEditEntry.Enabled = hasItem;
			this.lmiDeleteEntry.Enabled = hasItem;
			this.lmiCloneEntry.Enabled = hasItem;

			this.fmiWake.Enabled = hasItem;
			this.fmiEditEntry.Enabled = hasItem;
			this.fmiDeleteEntry.Enabled = hasItem;
			this.fmiCloneEntry.Enabled = hasItem;
		}

		private void wakeEntry_Click(object sender, EventArgs e)
		{
			if (this.bgwWake.IsBusy)
			{
				return;
			}

			if (this.listEntries.SelectedItems.Count == 0) return;

			var item = this.listEntries.SelectedItems[0];
			var entry = item.Tag as Entry;

			this.readyStatusLabel.Visible = false;
			this.wakingStatusLabel.Visible = true;
			this.wakingStatusLabel.Text = string.Format("Waking...{0}", entry.Name);

			this.bgwWake.RunWorkerAsync(entry);


		}

		private void bgwWake_DoWork(object sender, DoWorkEventArgs e)
		{
			var entry = e.Argument as Entry;
			var result = WOL.Wake(entry);

			if (result == WOL.Results.Sent)
			{
				System.Threading.Thread.Sleep(1500);
			}

			e.Result = result;
		}

		private void bgwWake_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			WOL.Results result = (WOL.Results)e.Result;

			if (result != WOL.Results.Sent)
			{
				this.wakingStatusLabel.Text = "Could not send wake packet";
			}
			else
			{
				this.readyStatusLabel.Visible = true;
				this.wakingStatusLabel.Visible = false;
			}
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

		private void listEntries_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
			{
				this.wakeEntry_Click(sender, null);
				e.Handled = true;
			}
			else if (e.KeyCode == Keys.Delete)
			{
				this.deleteEntry_Click(sender, null);
				e.Handled = true;
			}
		}

		private void listEntries_DoubleClick(object sender, EventArgs e)
		{
			if (this.listEntries.SelectedItems.Count == 0)
			{
				newEntry_Click(sender, e);
			}
			else
			{
				wakeEntry_Click(sender, e);
			};
		}

		int previousClick = SystemInformation.DoubleClickTime;
		private void listEntries_MouseUp(object sender, MouseEventArgs e)
		{
			// Adapted from https://msdn.microsoft.com/en-us/library/ms172533%28v=vs.90%29.aspx
			var s = sender as Control;
			int now = System.Environment.TickCount;
			
			// A double-click is detected if the time elapsed 
			// since the last click is within DoubleClickTime. 
			if (now - previousClick <= SystemInformation.DoubleClickTime)
			{
				// Raise the DoubleClick event. 
				listEntries_DoubleClick(sender, EventArgs.Empty);
			}

			// Set previousClick to now so that  
			// subsequent double-clicks can be detected.
			previousClick = now;

			// Allow the base class to raise the regular Click event. 
			base.OnClick(e);
		}

	}
}
