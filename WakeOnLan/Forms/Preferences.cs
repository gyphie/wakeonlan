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
	public partial class frmPreferences : Form
	{
		public frmPreferences()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			// Validate Port
			if (!Utilities.IsValidPort(this.txtPortNumber.Text))
			{
				MessageBox.Show("Port number must be a value from 0 to 65534.", "Invalid Information");
				return;
			}

			this.DialogResult = DialogResult.OK;
		}

		public Entry ShowPreferencesDialog(Entry entry = null)
		{
			if (entry == null) entry = new Entry();

			this.cbUsePingPacket.Checked = entry.UsePingPacket;
			this.txtPortNumber.Text = entry.PortNumber.ToString();

			var result = this.ShowDialog();

			if (result == System.Windows.Forms.DialogResult.OK)
			{
				entry.PortNumber = Utilities.ParsePort(this.txtPortNumber.Text);
				entry.UsePingPacket = this.cbUsePingPacket.Checked;
				entry.UseBroadcast = false;

				return entry;
			}
			else
			{
				return null;
			}
		}

	}
}
