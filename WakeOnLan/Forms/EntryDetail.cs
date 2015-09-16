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
	public partial class frmEntryDetail : Form
	{
		public frmEntryDetail()
		{
			InitializeComponent();
		}

		public Entry ShowEntryDialog(Entry entry = null)
		{
			if (entry == null) entry = new Entry();

			this.txtDescription.Text = entry.Name;
			this.txtMediaAccessControl.Text = entry.MediaAccessControl;
			this.txtHostName.Text = entry.HostOrIP;
			this.txtPort.Text = entry.PortNumber.ToString();
			this.cbUsePingPacket.Checked = entry.UsePingPacket;

			var result = this.ShowDialog();

			if (result == System.Windows.Forms.DialogResult.OK)
			{
				entry.Name = this.txtDescription.Text.Trim();
				entry.HostOrIP = Utilities.IsValidIpAddress(this.txtHostName.Text) ? Utilities.FormatIpAddress(this.txtHostName.Text) : this.txtHostName.Text.Trim();
				entry.MediaAccessControl = Utilities.FormatMediaAccessControl(this.txtMediaAccessControl.Text);
				entry.PortNumber = Convert.ToUInt16(this.txtPort.Text);
				entry.UsePingPacket = this.cbUsePingPacket.Checked;
				entry.UseBroadcast = false;


				// Write the values to the entry object
				return entry;
			}
			else
			{
				return null;
			}
		}

		private void frmEntryDetail_Shown(object sender, EventArgs e)
		{
			this.txtDescription.Focus();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			// Validate the form



			this.DialogResult = System.Windows.Forms.DialogResult.OK;	// Causes the dialog to hide as well
		}
	}
}
