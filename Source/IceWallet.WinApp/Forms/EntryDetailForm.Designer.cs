namespace IceWallet.WinApp
{
	partial class EntryDetailForm
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
			this.EntryPublicAddressTextBox = new System.Windows.Forms.TextBox();
			this.EntryPrivateKeyTextBox = new System.Windows.Forms.TextBox();
			this.EntryNameTextBox = new System.Windows.Forms.TextBox();
			this.EntryDescriptionTextBox = new System.Windows.Forms.TextBox();
			this.EntryTypeComboBox = new System.Windows.Forms.ComboBox();
			this.AddSymbolLinkLabel = new System.Windows.Forms.LinkLabel();
			this.SaveButton = new System.Windows.Forms.Button();
			this.CancelAddButton = new System.Windows.Forms.Button();
			this.PublicAddressHelpLabel = new System.Windows.Forms.Label();
			this.PrivateKeyHelpLabel = new System.Windows.Forms.Label();
			this.SymbolHelpLabel = new System.Windows.Forms.Label();
			this.GenerateLinkLabel = new System.Windows.Forms.LinkLabel();
			this.CoinSymbolLabel = new System.Windows.Forms.Label();
			this.PublicAddressLabel = new System.Windows.Forms.Label();
			this.PrivateKeyLabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.DescriptionLabel = new System.Windows.Forms.Label();
			this.NameHelpLabel = new System.Windows.Forms.Label();
			this.DesciptionHelpLabel = new System.Windows.Forms.Label();
			this.PrivateKeyButton = new System.Windows.Forms.Button();
			this.PublicAddressPasteButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// EntryPublicAddressTextBox
			// 
			this.EntryPublicAddressTextBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EntryPublicAddressTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.EntryPublicAddressTextBox.Location = new System.Drawing.Point(125, 47);
			this.EntryPublicAddressTextBox.Name = "EntryPublicAddressTextBox";
			this.EntryPublicAddressTextBox.Size = new System.Drawing.Size(266, 24);
			this.EntryPublicAddressTextBox.TabIndex = 2;
			this.EntryPublicAddressTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntryPublicAddress_KeyDown);
			// 
			// EntryPrivateKeyTextBox
			// 
			this.EntryPrivateKeyTextBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EntryPrivateKeyTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.EntryPrivateKeyTextBox.Location = new System.Drawing.Point(125, 77);
			this.EntryPrivateKeyTextBox.Name = "EntryPrivateKeyTextBox";
			this.EntryPrivateKeyTextBox.Size = new System.Drawing.Size(351, 24);
			this.EntryPrivateKeyTextBox.TabIndex = 3;
			this.EntryPrivateKeyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntryPrivateKey_KeyPress);
			// 
			// EntryNameTextBox
			// 
			this.EntryNameTextBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EntryNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.EntryNameTextBox.Location = new System.Drawing.Point(125, 107);
			this.EntryNameTextBox.Name = "EntryNameTextBox";
			this.EntryNameTextBox.Size = new System.Drawing.Size(382, 24);
			this.EntryNameTextBox.TabIndex = 4;
			// 
			// EntryDescriptionTextBox
			// 
			this.EntryDescriptionTextBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EntryDescriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.EntryDescriptionTextBox.Location = new System.Drawing.Point(124, 137);
			this.EntryDescriptionTextBox.Multiline = true;
			this.EntryDescriptionTextBox.Name = "EntryDescriptionTextBox";
			this.EntryDescriptionTextBox.Size = new System.Drawing.Size(382, 71);
			this.EntryDescriptionTextBox.TabIndex = 5;
			// 
			// EntryTypeComboBox
			// 
			this.EntryTypeComboBox.Font = new System.Drawing.Font("Arial", 11F);
			this.EntryTypeComboBox.FormattingEnabled = true;
			this.EntryTypeComboBox.Location = new System.Drawing.Point(125, 16);
			this.EntryTypeComboBox.Name = "EntryTypeComboBox";
			this.EntryTypeComboBox.Size = new System.Drawing.Size(296, 25);
			this.EntryTypeComboBox.TabIndex = 1;
			// 
			// AddSymbolLinkLabel
			// 
			this.AddSymbolLinkLabel.AutoSize = true;
			this.AddSymbolLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.AddSymbolLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.AddSymbolLinkLabel.Location = new System.Drawing.Point(427, 22);
			this.AddSymbolLinkLabel.Name = "AddSymbolLinkLabel";
			this.AddSymbolLinkLabel.Size = new System.Drawing.Size(63, 13);
			this.AddSymbolLinkLabel.TabIndex = 20;
			this.AddSymbolLinkLabel.TabStop = true;
			this.AddSymbolLinkLabel.Text = "Add Symbol";
			// 
			// SaveButton
			// 
			this.SaveButton.BackColor = System.Drawing.Color.PaleGreen;
			this.SaveButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.SaveButton.Location = new System.Drawing.Point(124, 231);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(103, 28);
			this.SaveButton.TabIndex = 6;
			this.SaveButton.Tag = "action";
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = false;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// CancelAddButton
			// 
			this.CancelAddButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CancelAddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.CancelAddButton.Location = new System.Drawing.Point(242, 231);
			this.CancelAddButton.Name = "CancelAddButton";
			this.CancelAddButton.Size = new System.Drawing.Size(103, 28);
			this.CancelAddButton.TabIndex = 7;
			this.CancelAddButton.Text = "Cancel";
			this.CancelAddButton.UseVisualStyleBackColor = true;
			this.CancelAddButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// PublicAddressHelpLabel
			// 
			this.PublicAddressHelpLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PublicAddressHelpLabel.ForeColor = System.Drawing.Color.Gray;
			this.PublicAddressHelpLabel.Location = new System.Drawing.Point(520, 45);
			this.PublicAddressHelpLabel.Name = "PublicAddressHelpLabel";
			this.PublicAddressHelpLabel.Size = new System.Drawing.Size(221, 21);
			this.PublicAddressHelpLabel.TabIndex = 8;
			this.PublicAddressHelpLabel.Text = "Paste in Public Address (DO NOT TYPE)";
			// 
			// PrivateKeyHelpLabel
			// 
			this.PrivateKeyHelpLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PrivateKeyHelpLabel.ForeColor = System.Drawing.Color.Gray;
			this.PrivateKeyHelpLabel.Location = new System.Drawing.Point(520, 83);
			this.PrivateKeyHelpLabel.Name = "PrivateKeyHelpLabel";
			this.PrivateKeyHelpLabel.Size = new System.Drawing.Size(221, 24);
			this.PrivateKeyHelpLabel.TabIndex = 9;
			this.PrivateKeyHelpLabel.Text = "Paste in Private Key (DO NOT TYPE)";
			// 
			// SymbolHelpLabel
			// 
			this.SymbolHelpLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SymbolHelpLabel.ForeColor = System.Drawing.Color.Gray;
			this.SymbolHelpLabel.Location = new System.Drawing.Point(520, 16);
			this.SymbolHelpLabel.Name = "SymbolHelpLabel";
			this.SymbolHelpLabel.Size = new System.Drawing.Size(221, 25);
			this.SymbolHelpLabel.TabIndex = 10;
			this.SymbolHelpLabel.Text = "What kind of coin is this?";
			// 
			// GenerateLinkLabel
			// 
			this.GenerateLinkLabel.AutoSize = true;
			this.GenerateLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.GenerateLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.GenerateLinkLabel.Location = new System.Drawing.Point(427, 52);
			this.GenerateLinkLabel.Name = "GenerateLinkLabel";
			this.GenerateLinkLabel.Size = new System.Drawing.Size(51, 13);
			this.GenerateLinkLabel.TabIndex = 300;
			this.GenerateLinkLabel.TabStop = true;
			this.GenerateLinkLabel.Text = "Generate";
			// 
			// CoinSymbolLabel
			// 
			this.CoinSymbolLabel.AutoSize = true;
			this.CoinSymbolLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CoinSymbolLabel.ForeColor = System.Drawing.Color.Gray;
			this.CoinSymbolLabel.Location = new System.Drawing.Point(46, 21);
			this.CoinSymbolLabel.Name = "CoinSymbolLabel";
			this.CoinSymbolLabel.Size = new System.Drawing.Size(76, 14);
			this.CoinSymbolLabel.TabIndex = 18;
			this.CoinSymbolLabel.Text = "Coin Symbol";
			this.CoinSymbolLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.CoinSymbolLabel.Click += new System.EventHandler(this.Label5_Click);
			// 
			// PublicAddressLabel
			// 
			this.PublicAddressLabel.AutoSize = true;
			this.PublicAddressLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PublicAddressLabel.ForeColor = System.Drawing.Color.Gray;
			this.PublicAddressLabel.Location = new System.Drawing.Point(31, 52);
			this.PublicAddressLabel.Name = "PublicAddressLabel";
			this.PublicAddressLabel.Size = new System.Drawing.Size(91, 14);
			this.PublicAddressLabel.TabIndex = 19;
			this.PublicAddressLabel.Text = "Public Address";
			this.PublicAddressLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.PublicAddressLabel.Click += new System.EventHandler(this.Label6_Click);
			// 
			// PrivateKeyLabel
			// 
			this.PrivateKeyLabel.AutoSize = true;
			this.PrivateKeyLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PrivateKeyLabel.ForeColor = System.Drawing.Color.Gray;
			this.PrivateKeyLabel.Location = new System.Drawing.Point(54, 82);
			this.PrivateKeyLabel.Name = "PrivateKeyLabel";
			this.PrivateKeyLabel.Size = new System.Drawing.Size(68, 14);
			this.PrivateKeyLabel.TabIndex = 20;
			this.PrivateKeyLabel.Text = "Private Key";
			this.PrivateKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.PrivateKeyLabel.Click += new System.EventHandler(this.Label7_Click);
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NameLabel.ForeColor = System.Drawing.Color.Gray;
			this.NameLabel.Location = new System.Drawing.Point(46, 111);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(76, 14);
			this.NameLabel.TabIndex = 21;
			this.NameLabel.Text = "Useful Name";
			this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.NameLabel.Click += new System.EventHandler(this.Label8_Click);
			// 
			// DescriptionLabel
			// 
			this.DescriptionLabel.AutoSize = true;
			this.DescriptionLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DescriptionLabel.ForeColor = System.Drawing.Color.Gray;
			this.DescriptionLabel.Location = new System.Drawing.Point(11, 143);
			this.DescriptionLabel.Name = "DescriptionLabel";
			this.DescriptionLabel.Size = new System.Drawing.Size(111, 14);
			this.DescriptionLabel.TabIndex = 22;
			this.DescriptionLabel.Text = "Description / Notes";
			this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.DescriptionLabel.Click += new System.EventHandler(this.Label9_Click);
			// 
			// NameHelpLabel
			// 
			this.NameHelpLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NameHelpLabel.ForeColor = System.Drawing.Color.Gray;
			this.NameHelpLabel.Location = new System.Drawing.Point(520, 111);
			this.NameHelpLabel.Name = "NameHelpLabel";
			this.NameHelpLabel.Size = new System.Drawing.Size(221, 24);
			this.NameHelpLabel.TabIndex = 23;
			this.NameHelpLabel.Text = "Give it a memorable name!";
			// 
			// DesciptionHelpLabel
			// 
			this.DesciptionHelpLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DesciptionHelpLabel.ForeColor = System.Drawing.Color.Gray;
			this.DesciptionHelpLabel.Location = new System.Drawing.Point(520, 143);
			this.DesciptionHelpLabel.Name = "DesciptionHelpLabel";
			this.DesciptionHelpLabel.Size = new System.Drawing.Size(221, 55);
			this.DesciptionHelpLabel.TabIndex = 24;
			this.DesciptionHelpLabel.Text = "Optionally add a description or notes that will make it easy to later recall this" +
    " particular wallet!";
			// 
			// PrivateKeyButton
			// 
			this.PrivateKeyButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PrivateKeyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.PrivateKeyButton.Location = new System.Drawing.Point(476, 77);
			this.PrivateKeyButton.Name = "PrivateKeyButton";
			this.PrivateKeyButton.Size = new System.Drawing.Size(30, 24);
			this.PrivateKeyButton.TabIndex = 301;
			this.PrivateKeyButton.TabStop = false;
			this.PrivateKeyButton.Text = "...";
			this.PrivateKeyButton.UseVisualStyleBackColor = true;
			this.PrivateKeyButton.Click += new System.EventHandler(this.PrivateKeyButton_Click);
			// 
			// PublicAddressPasteButton
			// 
			this.PublicAddressPasteButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PublicAddressPasteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.PublicAddressPasteButton.Location = new System.Drawing.Point(391, 47);
			this.PublicAddressPasteButton.Name = "PublicAddressPasteButton";
			this.PublicAddressPasteButton.Size = new System.Drawing.Size(30, 24);
			this.PublicAddressPasteButton.TabIndex = 302;
			this.PublicAddressPasteButton.TabStop = false;
			this.PublicAddressPasteButton.Text = "...";
			this.PublicAddressPasteButton.UseVisualStyleBackColor = true;
			this.PublicAddressPasteButton.Click += new System.EventHandler(this.PublicAddressPasteButton_Click);
			// 
			// EntryDetailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(753, 277);
			this.Controls.Add(this.PublicAddressPasteButton);
			this.Controls.Add(this.PrivateKeyButton);
			this.Controls.Add(this.DesciptionHelpLabel);
			this.Controls.Add(this.NameHelpLabel);
			this.Controls.Add(this.DescriptionLabel);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.PrivateKeyLabel);
			this.Controls.Add(this.PublicAddressLabel);
			this.Controls.Add(this.CoinSymbolLabel);
			this.Controls.Add(this.GenerateLinkLabel);
			this.Controls.Add(this.SymbolHelpLabel);
			this.Controls.Add(this.PrivateKeyHelpLabel);
			this.Controls.Add(this.PublicAddressHelpLabel);
			this.Controls.Add(this.CancelAddButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.AddSymbolLinkLabel);
			this.Controls.Add(this.EntryTypeComboBox);
			this.Controls.Add(this.EntryDescriptionTextBox);
			this.Controls.Add(this.EntryNameTextBox);
			this.Controls.Add(this.EntryPrivateKeyTextBox);
			this.Controls.Add(this.EntryPublicAddressTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "EntryDetailForm";
			this.Text = "Add New Coin Details";
			this.Load += new System.EventHandler(this.EntryDetailForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox EntryPublicAddressTextBox;
		private System.Windows.Forms.TextBox EntryPrivateKeyTextBox;
		private System.Windows.Forms.TextBox EntryNameTextBox;
		private System.Windows.Forms.TextBox EntryDescriptionTextBox;
		private System.Windows.Forms.ComboBox EntryTypeComboBox;
		private System.Windows.Forms.LinkLabel AddSymbolLinkLabel;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button CancelAddButton;
		private System.Windows.Forms.Label PublicAddressHelpLabel;
		private System.Windows.Forms.Label PrivateKeyHelpLabel;
		private System.Windows.Forms.Label SymbolHelpLabel;
		private System.Windows.Forms.LinkLabel GenerateLinkLabel;
		private System.Windows.Forms.Label CoinSymbolLabel;
		private System.Windows.Forms.Label PublicAddressLabel;
		private System.Windows.Forms.Label PrivateKeyLabel;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label DescriptionLabel;
		private System.Windows.Forms.Label NameHelpLabel;
		private System.Windows.Forms.Label DesciptionHelpLabel;
		private System.Windows.Forms.Button PrivateKeyButton;
		private System.Windows.Forms.Button PublicAddressPasteButton;
	}
}