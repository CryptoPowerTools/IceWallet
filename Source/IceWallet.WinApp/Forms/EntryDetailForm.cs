using CryptoTools.Common.Logging;
using CryptoTools.Common.Serialization;
using IceWallet.Engine.Models;
using IceWallet.WinCore;
using IceWallet.WinCore.Helpers;
using IceWallet.WinCore.Skins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceWallet.WinApp
{
	public partial class EntryDetailForm : Form
	{
		ILog Log = Logger.CreateInstance(typeof(EntryDetailForm));


		public WalletEntry CurrentEntry { get; set; }
		
		public EntryDetailForm()
		{
			InitializeComponent();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{

			Log.Debug("test");
			Log.Error("error");

			// Verify Data
			bool verifyFaild = false;
			if(string.IsNullOrEmpty(EntryTypeComboBox.Text))
			{
				EntryTypeComboBox.Focus();
				verifyFaild = true;
			}
			if (string.IsNullOrEmpty(EntryNameTextBox.Text))
			{
				EntryNameTextBox.Focus();
				verifyFaild = true;
			}
			if (string.IsNullOrEmpty(EntryPublicAddressTextBox.Text))
			{
				EntryPublicAddressTextBox.Focus();
				verifyFaild = true;
			}
			if (string.IsNullOrEmpty(EntryPrivateKeyTextBox.Text))
			{
				EntryPrivateKeyTextBox.Focus();
				verifyFaild = true;
			}
			if(verifyFaild)
			{
				MessageBox.Show(this, "You must enter coin details");
				return;
			}
			


			try
			{
				//Wallet Data Populate
				WalletEntry entry = new WalletEntry
				{
					Name = this.EntryNameTextBox.Text,
					Description = EntryDescriptionTextBox.Text,
					PublicAddress = EntryPublicAddressTextBox.Text,
					PrivateKey = EntryPrivateKeyTextBox.Text,
					Type = EntryTypeComboBox.Text,
					DateCreated = DateTime.Now.ToShortDateString()

				};

				// Add the new entry to the datafile
				CoreContext.WalletEngine.AddWalletDataEntry(entry);



			}
			catch(Exception exception)
			{
				MessageBox.Show("Error Saving Data - " + exception.Message);
				return;
			}

		   			 		  		  

			DialogResult = DialogResult.OK;


			Close();
		}

		private void SaveData(WalletData walletData)
		{

			JsonSerializer.WriteToJsonFile("WalletData.json", walletData);



		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Label9_Click(object sender, EventArgs e)
		{

		}

		private void Label8_Click(object sender, EventArgs e)
		{

		}

		private void Label7_Click(object sender, EventArgs e)
		{

		}

		private void Label6_Click(object sender, EventArgs e)
		{

		}

		private void Label5_Click(object sender, EventArgs e)
		{

		}

		private void EntryDetailForm_Load(object sender, EventArgs e)
		{
			CenterToParent();

			//ConfigSkins();
			SkinApplicator.ApplySkin(this);
		}


		private void ConfigSkins()
		{
			//foreach (Control control in Controls)
			//{
			//	if(control is Label)
			//	{
			//		(control as Label).ForeColor = SkinColors.LightGray;
			//	}
			//}

			this.BackColor = SkinColors.White;

			SaveButton.BackColor = SkinColors.GoGreen;

			AddSymbolLinkLabel.ForeColor = SkinColors.DarkMainColor;
			GenerateLinkLabel.ForeColor = SkinColors.DarkMainColor;


		}

		private void EntryPublicAddress_KeyDown(object sender, KeyEventArgs e)
		{

			// prevent from typing you should paste your code in here
			e.SuppressKeyPress = true;

		}

		private void EntryPrivateKey_KeyPress(object sender, KeyPressEventArgs e)
		{
			// prevent from typing you should paste your code in here
			e.Handled = true;

		}

		private void PublicAddressPasteButton_Click(object sender, EventArgs e)
		{			
			EntryPublicAddressTextBox.Text = ClipboardHelper.GetText(); 
		}

		private void PrivateKeyButton_Click(object sender, EventArgs e)
		{
			EntryPrivateKeyTextBox.Text = ClipboardHelper.GetText();
		}
	}
}
