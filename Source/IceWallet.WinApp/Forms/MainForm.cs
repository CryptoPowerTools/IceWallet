using CryptoTools.Common.Serialization;
using CryptoTools.Common.Utils;
using IceWallet.Engine;
using IceWallet.Engine.Models;
using IceWallet.WinApp.Forms;
using IceWallet.WinCore;
using IceWallet.WinCore.Helpers;
using IceWallet.WinCore.Skins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceWallet.WinApp
{
	public partial class MainForm : Form
	{

		private bool _dataDirty = false;

		private WalletConfig WalletConfig { get; set; }
		private WalletData WalletData { get; set; }

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

			SkinApplicator.ApplySkin(this);


			
			//ConfigSkins();
			LoadConfig();
			ConfigureGrid();
			LoadGrid();
			ConfigUIState();
		}

		private void ConfigUIState()
		{
			if(CoreContext.WalletEngine.WalletData.Entries.Count < 1)
			{
				AddCoinTipLabel.ForeColor = SkinColors.Red;
				AddCoinTipLabel.Visible = true;
			}
			else
			{
				AddCoinTipLabel.Visible = false;
			}

			if (CoreContext.WalletEngine.IsBackupRequired == true)
			{
				BackupWalletTipLabel.Visible = true;
				BackupWalletTipLabel.ForeColor = SkinColors.Red;
			}
			else
			{
				BackupWalletTipLabel.Visible = false;				
			}
		}

		private void ConfigSkins()
		{			
			//AddCoinTipLabel.ForeColor = SkinColors.LightGray;
			//BackupWalletTipLabel.ForeColor = SkinColors.LightGray;

			//AddButton.BackColor = SkinColors.LightMainColor;
			//this.BackColor = SkinColors.White;

			//PrintPaperWalletButton.ForeColor = SkinColors.LightGray;
			//PrintPaperWalletButton.Enabled = false;

			//BackupWalletDataLinkLabel.ForeColor = SkinColors.DarkMainColor;
			//BackupWalletDataLinkLabel.ActiveLinkColor = SkinColors.DarkMainColor;
			//BackupWalletDataLinkLabel.VisitedLinkColor = SkinColors.LightGray;

			//// Grid Skins Colors
			//WalletEntriesGridView.BackgroundColor = SkinColors.LightMainColor;
			//WalletEntriesGridView.GridColor = SkinColors.DarkMainColor;
		}

		private void LoadConfig()
		{		
		}


		private void ConfigureGrid()
		{
			// Add Columns (Only once)
			if (WalletEntriesGridView.ColumnCount < 1)
			{
				// Name
				DataGridViewColumn name = new DataGridViewTextBoxColumn();
				name.DataPropertyName = "Name";
				name.Name = "Wallet Name";
				//name.MinimumWidth = 10;
				name.FillWeight = 30;
				name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

				//name.AutoSizeMode = AutoSizeMode.;
				//name.DefaultHeaderCellType
				WalletEntriesGridView.Columns.Add(name);
				//WalletEntriesGridView.AutoResizeColumn(0);

				// Type
				DataGridViewColumn type = new DataGridViewTextBoxColumn();
				type.DataPropertyName = "Type";
				type.Name = "Wallet Type";
				//type.MinimumWidth = 8;
				type.FillWeight = 10;
				type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

				WalletEntriesGridView.Columns.Add(type);
				//WalletEntriesGridView.AutoResizeColumn(1);

				// Public Address
				DataGridViewColumn pubAddress = new DataGridViewTextBoxColumn();
				pubAddress.DataPropertyName = "PublicAddress";
				pubAddress.Name = "Public Address";
				//pubAddress.MinimumWidth = 45;
				pubAddress.FillWeight = 50;
				pubAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				WalletEntriesGridView.Columns.Add(pubAddress);
				//WalletEntriesGridView.AutoResizeColumn(2);
				//WalletEntriesGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

				// Date Created
				DataGridViewColumn date = new DataGridViewTextBoxColumn();
				date.DataPropertyName = "DateCreated";
				date.Name = "Date";
				//date.MinimumWidth = 30;
				date.FillWeight = 10;
				date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				WalletEntriesGridView.Columns.Add(date);
				//WalletEntriesGridView.AutoResizeColumn(3);
				//WalletEntriesGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

				// Configure Grid
				WalletEntriesGridView.RowHeadersVisible = false;
				WalletEntriesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
				WalletEntriesGridView.ReadOnly = true;
				WalletEntriesGridView.AutoGenerateColumns = false;

			}

			// Need to do this because every time you add new data it add these columns back.....
			// Might need to move this after LoadGrid....
			try
			{
				// rEMOVE UNWANTED cOLUMN hEADERS
				WalletEntriesGridView.Columns.Remove("PrivateKey");
				WalletEntriesGridView.Columns.Remove("PrivateKeyObfuscated");
				WalletEntriesGridView.Columns.Remove("Description");
			}
			catch (Exception)
			{ }
		}

		private void LoadGrid()
		{
			// Clear Grid
			WalletEntriesGridView.DataSource = null;

			// Add the Data 

			var entries = CoreContext.WalletEngine.WalletData.Entries;
			entries.OrderBy(d => d.DateCreated);
			WalletEntriesGridView.DataSource = entries;
		
		}

		

		private void AddButton_Click(object sender, EventArgs e)
		{
			EntryDetailForm modal = new EntryDetailForm();
			DialogResult result = modal.ShowDialog(this);

			if(result == DialogResult.OK)
			{
				//CoreContext.WalletEngine.RefreshWalletData();
			}				
			LoadGrid();
			ConfigUIState();
		}

		private void AddCoinTipLabel_Click(object sender, EventArgs e)
		{
		}

		private void BackupWalletDataLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			BackupWalletForm backupForm = new BackupWalletForm();
			backupForm.ShowDialog();



		}

		private void WalletEntriesGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > 0)
			{
				var selectedEntry = WalletEntriesGridView.SelectedRows[0].DataBoundItem as WalletEntry;
				string details = FormatWalletEntryToText(selectedEntry);
				EntryDetailTextBox.Text = details;
			}


		}

		private void WalletEntriesGridView_MouseDown(object sender, MouseEventArgs e)
		{

		}

		private void WalletEntriesGridView_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
		{

		}

		private void WalletEntriesGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{

			if (e.Button == MouseButtons.Right)
			{
				// Add this
				WalletEntriesGridView.CurrentCell = WalletEntriesGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
				// Can leave these here - doesn't hurt
				WalletEntriesGridView.Rows[e.RowIndex].Selected = true;
				WalletEntriesGridView.Focus();
			}

		}

		private void CopyPublicAddressToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var selectedEntry = WalletEntriesGridView.SelectedRows[0].DataBoundItem as WalletEntry;
			ClipboardHelper.SetText(selectedEntry.PublicAddress);
		}

		private void CopyPrivateKeyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var selectedEntry = WalletEntriesGridView.SelectedRows[0].DataBoundItem as WalletEntry;
			ClipboardHelper.SetText(selectedEntry.PrivateKey);
		}

		private void CopyFullDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var selectedEntry = WalletEntriesGridView.SelectedRows[0].DataBoundItem as WalletEntry;
			string details = FormatWalletEntryToText(selectedEntry);
			ClipboardHelper.SetText(details);
		}

		private string FormatWalletEntryToText(WalletEntry entry)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append($@"Name: {entry.Name}{Environment.NewLine}Type: {entry.Type}{Environment.NewLine}Public Address: {entry.PublicAddress}{Environment.NewLine}Private Key: {entry.PublicAddress}{Environment.NewLine}Date Created: {entry.PublicAddress}{Environment.NewLine}Description: {entry.PublicAddress}");
			return builder.ToString();

		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			if(CoreContext.WalletEngine.IsBackupRequired)
			{
				MessageBox.Show("You need to backup");
			}
			else
			{
				Close();
			}
			
		}
	}
}
