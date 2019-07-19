namespace IceWallet.WinApp.Forms
{
	partial class ErrorForm
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
			this.OkButton = new System.Windows.Forms.Button();
			this.ErrorMessageLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ErrorHeaderLabel = new System.Windows.Forms.Label();
			this.ShowDebugDataCheckBox = new System.Windows.Forms.CheckBox();
			this.DebugInfoTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// OkButton
			// 
			this.OkButton.BackColor = System.Drawing.Color.PaleGreen;
			this.OkButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OkButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.OkButton.Location = new System.Drawing.Point(16, 104);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(103, 28);
			this.OkButton.TabIndex = 51;
			this.OkButton.Tag = "action";
			this.OkButton.Text = "Ok";
			this.OkButton.UseVisualStyleBackColor = false;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// ErrorMessageLabel
			// 
			this.ErrorMessageLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ErrorMessageLabel.ForeColor = System.Drawing.Color.Black;
			this.ErrorMessageLabel.Location = new System.Drawing.Point(12, 43);
			this.ErrorMessageLabel.Name = "ErrorMessageLabel";
			this.ErrorMessageLabel.Size = new System.Drawing.Size(393, 61);
			this.ErrorMessageLabel.TabIndex = 50;
			this.ErrorMessageLabel.Text = "Your Error Message Here";
			this.ErrorMessageLabel.Click += new System.EventHandler(this.ErrorMessageLabel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Gray;
			this.label1.Location = new System.Drawing.Point(-63, -47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 14);
			this.label1.TabIndex = 49;
			this.label1.Text = "Backup To";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// ErrorHeaderLabel
			// 
			this.ErrorHeaderLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ErrorHeaderLabel.ForeColor = System.Drawing.Color.DarkRed;
			this.ErrorHeaderLabel.Location = new System.Drawing.Point(12, 11);
			this.ErrorHeaderLabel.Name = "ErrorHeaderLabel";
			this.ErrorHeaderLabel.Size = new System.Drawing.Size(393, 23);
			this.ErrorHeaderLabel.TabIndex = 52;
			this.ErrorHeaderLabel.Text = "Error ";
			// 
			// ShowDebugDataCheckBox
			// 
			this.ShowDebugDataCheckBox.AutoSize = true;
			this.ShowDebugDataCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ShowDebugDataCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ShowDebugDataCheckBox.Location = new System.Drawing.Point(299, 114);
			this.ShowDebugDataCheckBox.Name = "ShowDebugDataCheckBox";
			this.ShowDebugDataCheckBox.Size = new System.Drawing.Size(106, 17);
			this.ShowDebugDataCheckBox.TabIndex = 53;
			this.ShowDebugDataCheckBox.Text = "Show Debug Info";
			this.ShowDebugDataCheckBox.UseVisualStyleBackColor = true;
			this.ShowDebugDataCheckBox.CheckedChanged += new System.EventHandler(this.ShowDebugDataCheckBox_CheckedChanged);
			// 
			// DebugInfoTextBox
			// 
			this.DebugInfoTextBox.Location = new System.Drawing.Point(8, 151);
			this.DebugInfoTextBox.Multiline = true;
			this.DebugInfoTextBox.Name = "DebugInfoTextBox";
			this.DebugInfoTextBox.Size = new System.Drawing.Size(399, 162);
			this.DebugInfoTextBox.TabIndex = 54;
			// 
			// ErrorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 143);
			this.Controls.Add(this.DebugInfoTextBox);
			this.Controls.Add(this.ShowDebugDataCheckBox);
			this.Controls.Add(this.ErrorHeaderLabel);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.ErrorMessageLabel);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ErrorForm";
			this.Text = "You have encountered an error!";
			this.Load += new System.EventHandler(this.ErrorForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Label ErrorMessageLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label ErrorHeaderLabel;
		private System.Windows.Forms.CheckBox ShowDebugDataCheckBox;
		private System.Windows.Forms.TextBox DebugInfoTextBox;
	}
}