namespace IceWallet.WinApp.Forms
{
	partial class BackupWalletForm
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
			this.CancelBackupButton = new System.Windows.Forms.Button();
			this.BackupButton = new System.Windows.Forms.Button();
			this.BackupLocationTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BrowseButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.SuccessTipLabel = new System.Windows.Forms.Label();
			this.SuccessImportantLabel = new System.Windows.Forms.Label();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.PrivateKeyHelpLabel = new System.Windows.Forms.Label();
			this.SuccessExitButton = new System.Windows.Forms.Button();
			this.OpenBackupLocationLinkLabel = new System.Windows.Forms.LinkLabel();
			this.BackupLocationLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// CancelBackupButton
			// 
			this.CancelBackupButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CancelBackupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.CancelBackupButton.Location = new System.Drawing.Point(432, 151);
			this.CancelBackupButton.Name = "CancelBackupButton";
			this.CancelBackupButton.Size = new System.Drawing.Size(103, 28);
			this.CancelBackupButton.TabIndex = 30;
			this.CancelBackupButton.Text = "Cancel";
			this.CancelBackupButton.UseVisualStyleBackColor = true;
			this.CancelBackupButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// BackupButton
			// 
			this.BackupButton.BackColor = System.Drawing.Color.PaleGreen;
			this.BackupButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BackupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BackupButton.Location = new System.Drawing.Point(314, 151);
			this.BackupButton.Name = "BackupButton";
			this.BackupButton.Size = new System.Drawing.Size(103, 28);
			this.BackupButton.TabIndex = 29;
			this.BackupButton.Tag = "action";
			this.BackupButton.Text = "Backup";
			this.BackupButton.UseVisualStyleBackColor = false;
			this.BackupButton.Click += new System.EventHandler(this.BackupButton_Click);
			// 
			// BackupLocationTextBox
			// 
			this.BackupLocationTextBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BackupLocationTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BackupLocationTextBox.Location = new System.Drawing.Point(31, 53);
			this.BackupLocationTextBox.Name = "BackupLocationTextBox";
			this.BackupLocationTextBox.Size = new System.Drawing.Size(452, 24);
			this.BackupLocationTextBox.TabIndex = 37;
			this.BackupLocationTextBox.Leave += new System.EventHandler(this.BackupLocationTextBox_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Gray;
			this.label1.Location = new System.Drawing.Point(28, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 14);
			this.label1.TabIndex = 38;
			this.label1.Text = "Backup To";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// BrowseButton
			// 
			this.BrowseButton.Location = new System.Drawing.Point(483, 53);
			this.BrowseButton.Name = "BrowseButton";
			this.BrowseButton.Size = new System.Drawing.Size(52, 24);
			this.BrowseButton.TabIndex = 39;
			this.BrowseButton.Text = "Browse";
			this.BrowseButton.UseVisualStyleBackColor = true;
			this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Gray;
			this.label2.Location = new System.Drawing.Point(28, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(249, 14);
			this.label2.TabIndex = 40;
			this.label2.Text = "Encryption Options  (NOT IMPLEMENTED YET)";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Enabled = false;
			this.checkBox1.Location = new System.Drawing.Point(46, 122);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(125, 17);
			this.checkBox1.TabIndex = 42;
			this.checkBox1.Text = "Zip File w/ Password";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(395, 96);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(140, 17);
			this.checkBox2.TabIndex = 43;
			this.checkBox2.Text = "Remember this Location";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.Visible = false;
			// 
			// SuccessTipLabel
			// 
			this.SuccessTipLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SuccessTipLabel.ForeColor = System.Drawing.Color.DarkRed;
			this.SuccessTipLabel.Location = new System.Drawing.Point(12, 242);
			this.SuccessTipLabel.Name = "SuccessTipLabel";
			this.SuccessTipLabel.Size = new System.Drawing.Size(542, 47);
			this.SuccessTipLabel.TabIndex = 44;
			this.SuccessTipLabel.Text = "Your file will be ENCRYPTED and you can feel safe to  save this file to a USB thu" +
    "mb drive, a Cloud drive etc. for safe keeping! ";
			// 
			// SuccessImportantLabel
			// 
			this.SuccessImportantLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SuccessImportantLabel.ForeColor = System.Drawing.Color.Black;
			this.SuccessImportantLabel.Location = new System.Drawing.Point(27, 303);
			this.SuccessImportantLabel.Name = "SuccessImportantLabel";
			this.SuccessImportantLabel.Size = new System.Drawing.Size(175, 27);
			this.SuccessImportantLabel.TabIndex = 45;
			this.SuccessImportantLabel.Text = "Backup SUCCESS";
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Enabled = false;
			this.checkBox3.Location = new System.Drawing.Point(46, 145);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(179, 17);
			this.checkBox3.TabIndex = 46;
			this.checkBox3.Text = "Include IceDecrypt.exe in zip file";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// PrivateKeyHelpLabel
			// 
			this.PrivateKeyHelpLabel.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PrivateKeyHelpLabel.ForeColor = System.Drawing.Color.Gray;
			this.PrivateKeyHelpLabel.Location = new System.Drawing.Point(71, 165);
			this.PrivateKeyHelpLabel.Name = "PrivateKeyHelpLabel";
			this.PrivateKeyHelpLabel.Size = new System.Drawing.Size(115, 14);
			this.PrivateKeyHelpLabel.TabIndex = 47;
			this.PrivateKeyHelpLabel.Text = "Highly recommended";
			// 
			// SuccessExitButton
			// 
			this.SuccessExitButton.BackColor = System.Drawing.Color.PaleGreen;
			this.SuccessExitButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SuccessExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.SuccessExitButton.Location = new System.Drawing.Point(218, 301);
			this.SuccessExitButton.Name = "SuccessExitButton";
			this.SuccessExitButton.Size = new System.Drawing.Size(103, 28);
			this.SuccessExitButton.TabIndex = 48;
			this.SuccessExitButton.Tag = "action";
			this.SuccessExitButton.Text = "Exit ";
			this.SuccessExitButton.UseVisualStyleBackColor = false;
			this.SuccessExitButton.Click += new System.EventHandler(this.SuccessExitButton_Click);
			// 
			// OpenBackupLocationLinkLabel
			// 
			this.OpenBackupLocationLinkLabel.AutoSize = true;
			this.OpenBackupLocationLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.OpenBackupLocationLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.OpenBackupLocationLinkLabel.Location = new System.Drawing.Point(12, 218);
			this.OpenBackupLocationLinkLabel.Name = "OpenBackupLocationLinkLabel";
			this.OpenBackupLocationLinkLabel.Size = new System.Drawing.Size(117, 13);
			this.OpenBackupLocationLinkLabel.TabIndex = 49;
			this.OpenBackupLocationLinkLabel.TabStop = true;
			this.OpenBackupLocationLinkLabel.Text = "Open Backup Location";
			this.OpenBackupLocationLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenBackupLocationLinkLabel_LinkClicked);
			// 
			// BackupLocationLabel
			// 
			this.BackupLocationLabel.AutoSize = true;
			this.BackupLocationLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BackupLocationLabel.ForeColor = System.Drawing.Color.Gray;
			this.BackupLocationLabel.Location = new System.Drawing.Point(135, 217);
			this.BackupLocationLabel.Name = "BackupLocationLabel";
			this.BackupLocationLabel.Size = new System.Drawing.Size(0, 14);
			this.BackupLocationLabel.TabIndex = 50;
			this.BackupLocationLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// BackupWalletForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 343);
			this.Controls.Add(this.BackupLocationLabel);
			this.Controls.Add(this.OpenBackupLocationLinkLabel);
			this.Controls.Add(this.SuccessExitButton);
			this.Controls.Add(this.PrivateKeyHelpLabel);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.SuccessImportantLabel);
			this.Controls.Add(this.SuccessTipLabel);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BrowseButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BackupLocationTextBox);
			this.Controls.Add(this.CancelBackupButton);
			this.Controls.Add(this.BackupButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "BackupWalletForm";
			this.Load += new System.EventHandler(this.BackupWalletForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button CancelBackupButton;
		private System.Windows.Forms.Button BackupButton;
		private System.Windows.Forms.TextBox BackupLocationTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BrowseButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Label SuccessTipLabel;
		private System.Windows.Forms.Label SuccessImportantLabel;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.Label PrivateKeyHelpLabel;
		private System.Windows.Forms.Button SuccessExitButton;
		private System.Windows.Forms.LinkLabel OpenBackupLocationLinkLabel;
		private System.Windows.Forms.Label BackupLocationLabel;
	}
}