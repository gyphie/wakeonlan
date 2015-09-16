namespace WakeOnLan.Forms
{
	partial class frmEntryDetail
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
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtMediaAccessControl = new System.Windows.Forms.TextBox();
			this.txtHostName = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblMediaAccessControl = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.lblPort = new System.Windows.Forms.Label();
			this.cbUsePingPacket = new System.Windows.Forms.CheckBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtDescription
			// 
			this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescription.Location = new System.Drawing.Point(111, 6);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(232, 20);
			this.txtDescription.TabIndex = 1;
			// 
			// txtMediaAccessControl
			// 
			this.txtMediaAccessControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMediaAccessControl.Location = new System.Drawing.Point(111, 32);
			this.txtMediaAccessControl.Name = "txtMediaAccessControl";
			this.txtMediaAccessControl.Size = new System.Drawing.Size(232, 20);
			this.txtMediaAccessControl.TabIndex = 3;
			// 
			// txtHostName
			// 
			this.txtHostName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtHostName.Location = new System.Drawing.Point(111, 58);
			this.txtHostName.Name = "txtHostName";
			this.txtHostName.Size = new System.Drawing.Size(232, 20);
			this.txtHostName.TabIndex = 5;
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(12, 9);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(63, 13);
			this.lblDescription.TabIndex = 0;
			this.lblDescription.Text = "&Description:";
			// 
			// lblMediaAccessControl
			// 
			this.lblMediaAccessControl.AutoSize = true;
			this.lblMediaAccessControl.Location = new System.Drawing.Point(12, 35);
			this.lblMediaAccessControl.Name = "lblMediaAccessControl";
			this.lblMediaAccessControl.Size = new System.Drawing.Size(74, 13);
			this.lblMediaAccessControl.TabIndex = 2;
			this.lblMediaAccessControl.Text = "&MAC Address:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "&IP or Host Name:";
			// 
			// txtPort
			// 
			this.txtPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPort.Location = new System.Drawing.Point(111, 84);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(98, 20);
			this.txtPort.TabIndex = 7;
			// 
			// lblPort
			// 
			this.lblPort.AutoSize = true;
			this.lblPort.Location = new System.Drawing.Point(12, 87);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new System.Drawing.Size(29, 13);
			this.lblPort.TabIndex = 6;
			this.lblPort.Text = "&Port:";
			// 
			// cbUsePingPacket
			// 
			this.cbUsePingPacket.AutoSize = true;
			this.cbUsePingPacket.Location = new System.Drawing.Point(20, 125);
			this.cbUsePingPacket.Name = "cbUsePingPacket";
			this.cbUsePingPacket.Size = new System.Drawing.Size(106, 17);
			this.cbUsePingPacket.TabIndex = 8;
			this.cbUsePingPacket.Text = "&Use Ping Packet";
			this.cbUsePingPacket.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(190, 167);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 9;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(271, 167);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// frmEntryDetail
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(358, 197);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.cbUsePingPacket);
			this.Controls.Add(this.lblPort);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblMediaAccessControl);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.txtHostName);
			this.Controls.Add(this.txtMediaAccessControl);
			this.Controls.Add(this.txtDescription);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEntryDetail";
			this.Text = "Host Entry";
			this.Shown += new System.EventHandler(this.frmEntryDetail_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.TextBox txtMediaAccessControl;
		private System.Windows.Forms.TextBox txtHostName;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label lblMediaAccessControl;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Label lblPort;
		private System.Windows.Forms.CheckBox cbUsePingPacket;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
	}
}