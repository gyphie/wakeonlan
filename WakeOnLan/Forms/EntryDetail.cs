using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
			this.txtMediaAccessControl.Text = entry.FormattedMac(":");
			this.txtHostName.Text = entry.HostOrIP;
			this.txtPort.Text = entry.PortNumber.ToString();
			this.cbUsePingPacket.Checked = entry.UsePingPacket;
			this.cbUseBroadcast.Checked = entry.UseBroadcast;
			this.txtSecureOnPassword.Text = entry.Password;

			var result = this.ShowDialog();

			if (result == System.Windows.Forms.DialogResult.OK)
			{
				entry.Name = this.txtDescription.Text.Trim();
				entry.HostOrIP = Utilities.IsValidIpAddress(this.txtHostName.Text) ? Utilities.FormatIpAddress(this.txtHostName.Text) : this.txtHostName.Text.Trim();
				entry.MediaAccessControl = Utilities.FormatMediaAccessControl(this.txtMediaAccessControl.Text, "");
				entry.PortNumber = Utilities.ParsePort(this.txtPort.Text);
				entry.UsePingPacket = this.cbUsePingPacket.Checked;
				entry.UseBroadcast = this.cbUseBroadcast.Checked;
				entry.Password = this.txtSecureOnPassword.Text.Trim().ToUpper();

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
			if (string.IsNullOrWhiteSpace(this.txtDescription.Text))
			{
				MessageBox.Show("Invalid Description.", "Validation Error");
				return;
			}
			if (!Utilities.IsValidIpAddress(this.txtHostName.Text) && !Utilities.IsValidateHostName(this.txtHostName.Text))
			{
				MessageBox.Show("Invalid IP/Host name.", "Validation Error");
				return;
			}
			if (!Utilities.IsValidPort(this.txtPort.Text))
			{
				MessageBox.Show("Invalid Port. Must be a value from 0 to 65534.", "Validation Error");
				return;
			}
			if (!Utilities.IsValidateMediaAccessControl(this.txtMediaAccessControl.Text))
			{
				MessageBox.Show("Invalid MAC address.", "Validation Error");
				return;
			}
			if (!Utilities.IsValidSecureOnPassword(this.txtSecureOnPassword.Text))
			{
				MessageBox.Show("Invalid SecureON password. Must be a 12 character hex string.", "Validation Error");
			}

			this.DialogResult = System.Windows.Forms.DialogResult.OK;	// Causes the dialog to hide as well
		}
	}
}
