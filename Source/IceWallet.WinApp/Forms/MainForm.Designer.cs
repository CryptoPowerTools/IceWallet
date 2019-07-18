namespace IceWallet.WinApp
{
	partial class MainForm
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
			this.BackupWalletTipLabel = new System.Windows.Forms.Label();
			this.PrintPaperWalletButton = new System.Windows.Forms.Button();
			this.BackupWalletDataLinkLabel = new System.Windows.Forms.LinkLabel();
			this.AddButton = new System.Windows.Forms.Button();
			this.WalletEntriesGridView = new System.Windows.Forms.DataGridView();
			this.GridMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CopyPublicAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CopyPrivateKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CopyFullDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PaperWalletPictureBox = new System.Windows.Forms.PictureBox();
			this.ExitButton = new System.Windows.Forms.Button();
			this.AddCoinTipLabel = new System.Windows.Forms.Label();
			this.EntryDetailTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.WalletEntriesGridView)).BeginInit();
			this.GridMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PaperWalletPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// BackupWalletTipLabel
			// 
			this.BackupWalletTipLabel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BackupWalletTipLabel.Location = new System.Drawing.Point(429, 10);
			this.BackupWalletTipLabel.Name = "BackupWalletTipLabel";
			this.BackupWalletTipLabel.Size = new System.Drawing.Size(240, 28);
			this.BackupWalletTipLabel.TabIndex = 21;
			this.BackupWalletTipLabel.Text = "Backup your Wallet Data for safe keeping ->";
			// 
			// PrintPaperWalletButton
			// 
			this.PrintPaperWalletButton.BackColor = System.Drawing.Color.PaleGreen;
			this.PrintPaperWalletButton.Enabled = false;
			this.PrintPaperWalletButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PrintPaperWalletButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.PrintPaperWalletButton.Location = new System.Drawing.Point(12, 552);
			this.PrintPaperWalletButton.Name = "PrintPaperWalletButton";
			this.PrintPaperWalletButton.Size = new System.Drawing.Size(103, 28);
			this.PrintPaperWalletButton.TabIndex = 17;
			this.PrintPaperWalletButton.Text = "Print";
			this.PrintPaperWalletButton.UseVisualStyleBackColor = false;
			// 
			// BackupWalletDataLinkLabel
			// 
			this.BackupWalletDataLinkLabel.AutoSize = true;
			this.BackupWalletDataLinkLabel.Location = new System.Drawing.Point(673, 12);
			this.BackupWalletDataLinkLabel.Name = "BackupWalletDataLinkLabel";
			this.BackupWalletDataLinkLabel.Size = new System.Drawing.Size(103, 13);
			this.BackupWalletDataLinkLabel.TabIndex = 16;
			this.BackupWalletDataLinkLabel.Text = "Backup Wallet Data";
			this.BackupWalletDataLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackupWalletDataLinkLabel_LinkClicked);
			// 
			// AddButton
			// 
			this.AddButton.BackColor = System.Drawing.Color.PaleGreen;
			this.AddButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.AddButton.Location = new System.Drawing.Point(12, 7);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(103, 28);
			this.AddButton.TabIndex = 100;
			this.AddButton.Text = "+  New Coin";
			this.AddButton.UseVisualStyleBackColor = false;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// WalletEntriesGridView
			// 
			this.WalletEntriesGridView.AllowUserToAddRows = false;
			this.WalletEntriesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.WalletEntriesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.WalletEntriesGridView.BackgroundColor = System.Drawing.Color.MintCream;
			this.WalletEntriesGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.WalletEntriesGridView.CausesValidation = false;
			this.WalletEntriesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			this.WalletEntriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.WalletEntriesGridView.ContextMenuStrip = this.GridMenuStrip;
			this.WalletEntriesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.WalletEntriesGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
			this.WalletEntriesGridView.Location = new System.Drawing.Point(12, 40);
			this.WalletEntriesGridView.MultiSelect = false;
			this.WalletEntriesGridView.Name = "WalletEntriesGridView";
			this.WalletEntriesGridView.ReadOnly = true;
			this.WalletEntriesGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.WalletEntriesGridView.Size = new System.Drawing.Size(776, 297);
			this.WalletEntriesGridView.TabIndex = 200;
			this.WalletEntriesGridView.TabStop = false;
			this.WalletEntriesGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.WalletEntriesGridView_CellMouseDown);
			this.WalletEntriesGridView.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.WalletEntriesGridView_RowContextMenuStripNeeded);
			this.WalletEntriesGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.WalletEntriesGridView_RowEnter);
			this.WalletEntriesGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WalletEntriesGridView_MouseDown);
			// 
			// GridMenuStrip
			// 
			this.GridMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyPublicAddressToolStripMenuItem,
            this.CopyPrivateKeyToolStripMenuItem,
            this.CopyFullDetailsToolStripMenuItem});
			this.GridMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.GridMenuStrip.Name = "GridMenuStrip";
			this.GridMenuStrip.Size = new System.Drawing.Size(184, 70);
			// 
			// CopyPublicAddressToolStripMenuItem
			// 
			this.CopyPublicAddressToolStripMenuItem.Name = "CopyPublicAddressToolStripMenuItem";
			this.CopyPublicAddressToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.CopyPublicAddressToolStripMenuItem.Text = "Copy Public Address";
			this.CopyPublicAddressToolStripMenuItem.Click += new System.EventHandler(this.CopyPublicAddressToolStripMenuItem_Click);
			// 
			// CopyPrivateKeyToolStripMenuItem
			// 
			this.CopyPrivateKeyToolStripMenuItem.Name = "CopyPrivateKeyToolStripMenuItem";
			this.CopyPrivateKeyToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.CopyPrivateKeyToolStripMenuItem.Text = "Copy Private Key";
			this.CopyPrivateKeyToolStripMenuItem.Click += new System.EventHandler(this.CopyPrivateKeyToolStripMenuItem_Click);
			// 
			// CopyFullDetailsToolStripMenuItem
			// 
			this.CopyFullDetailsToolStripMenuItem.Name = "CopyFullDetailsToolStripMenuItem";
			this.CopyFullDetailsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.CopyFullDetailsToolStripMenuItem.Text = "Copy Full Details";
			this.CopyFullDetailsToolStripMenuItem.Click += new System.EventHandler(this.CopyFullDetailsToolStripMenuItem_Click);
			// 
			// PaperWalletPictureBox
			// 
			this.PaperWalletPictureBox.Location = new System.Drawing.Point(12, 586);
			this.PaperWalletPictureBox.Name = "PaperWalletPictureBox";
			this.PaperWalletPictureBox.Size = new System.Drawing.Size(775, 17);
			this.PaperWalletPictureBox.TabIndex = 24;
			this.PaperWalletPictureBox.TabStop = false;
			// 
			// ExitButton
			// 
			this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ExitButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ExitButton.Location = new System.Drawing.Point(684, 466);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(103, 28);
			this.ExitButton.TabIndex = 300;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = false;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// AddCoinTipLabel
			// 
			this.AddCoinTipLabel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddCoinTipLabel.Location = new System.Drawing.Point(119, 10);
			this.AddCoinTipLabel.Name = "AddCoinTipLabel";
			this.AddCoinTipLabel.Size = new System.Drawing.Size(240, 28);
			this.AddCoinTipLabel.TabIndex = 26;
			this.AddCoinTipLabel.Text = "<- Add your first coin to the wallet";
			this.AddCoinTipLabel.Click += new System.EventHandler(this.AddCoinTipLabel_Click);
			// 
			// EntryDetailTextBox
			// 
			this.EntryDetailTextBox.Location = new System.Drawing.Point(12, 343);
			this.EntryDetailTextBox.Multiline = true;
			this.EntryDetailTextBox.Name = "EntryDetailTextBox";
			this.EntryDetailTextBox.ReadOnly = true;
			this.EntryDetailTextBox.Size = new System.Drawing.Size(776, 117);
			this.EntryDetailTextBox.TabIndex = 27;
			this.EntryDetailTextBox.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 505);
			this.Controls.Add(this.EntryDetailTextBox);
			this.Controls.Add(this.AddCoinTipLabel);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.PaperWalletPictureBox);
			this.Controls.Add(this.WalletEntriesGridView);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.BackupWalletTipLabel);
			this.Controls.Add(this.PrintPaperWalletButton);
			this.Controls.Add(this.BackupWalletDataLinkLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.Text = "Ice Wallet - Cryptocurrency Cold Wallet";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.WalletEntriesGridView)).EndInit();
			this.GridMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PaperWalletPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label BackupWalletTipLabel;
		private System.Windows.Forms.Button PrintPaperWalletButton;
		private System.Windows.Forms.LinkLabel BackupWalletDataLinkLabel;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.DataGridView WalletEntriesGridView;
		private System.Windows.Forms.PictureBox PaperWalletPictureBox;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Label AddCoinTipLabel;
		private System.Windows.Forms.TextBox EntryDetailTextBox;
		private System.Windows.Forms.ContextMenuStrip GridMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem CopyPublicAddressToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CopyPrivateKeyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CopyFullDetailsToolStripMenuItem;
	}
}

