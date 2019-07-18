using CryptoTools.Common.FileSystems;
using IceWallet.WinCore;
using IceWallet.WinCore.Skins;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace IceWallet.WinApp.Forms
{
	public partial class BackupWalletForm : Form
	{

		private enum FormState
		{
			BackupSuccess = 0,
			BackupNotStarted=1
		};

		private string _locationFolder = "";
		private FormState _formState = FormState.BackupNotStarted;


		public string LocationFolder
		{
			get
			{
				return _locationFolder;
			}
			set
			{
				_locationFolder = value;
				BackupLocationTextBox.Text = _locationFolder;
			}
		}


		public BackupWalletForm()
		{
			InitializeComponent();
		}

		private void ConfigFormState(FormState state)
		{
			_formState = state;

			switch(state)
			{
				case FormState.BackupNotStarted:

					SuccessExitButton.Visible = false;
					SuccessImportantLabel.Visible = false;
					SuccessTipLabel.Visible = false;
					this.Size = new Size(Size.Width, 245);


					return;

				case FormState.BackupSuccess:
					SuccessExitButton.Visible = true;
					SuccessImportantLabel.Visible = true;
					SuccessTipLabel.Visible = true;
					this.Size = new Size(Size.Width, 382);
					BackupButton.Enabled = false;
					BackupButton.BackColor = SkinColors.LightGray;
					CancelButton.BackColor = SkinColors.LightGray;


					return;

				default:
					return;
			}


		}


		private void BackupWalletForm_Load(object sender, EventArgs e)
		{
			CenterToParent();
			ConfigFormState(FormState.BackupNotStarted);
		}

		private void BrowseButton_Click(object sender, EventArgs e)
		{
			FileManager fileMan = new FileManager();

			FolderBrowserDialog browser = new FolderBrowserDialog();



			// Preset the location if its available
			string location = BackupLocationTextBox.Text;
			if(!fileMan.DirectoryExists(location))
			{
				//NOTE: This needs to be tested i cant get  aUSB drive on my VM
				// get the USB path
				location = GetUSBDrivePath();
				if(!fileMan.DirectoryExists(location))
				{
					location = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
				}			
			}

			browser.SelectedPath = location;
			browser.RootFolder = Environment.SpecialFolder.MyComputer;
			DialogResult result = browser.ShowDialog();

			if(result == DialogResult.OK)
			{
				LocationFolder = browser.SelectedPath;
			}

		}


		private string GetUSBDrivePath()
		{
			string path = "";
			DriveInfo[] allDrives = DriveInfo.GetDrives();
			foreach (DriveInfo d in allDrives)
			{
				if (d.DriveType == DriveType.Removable)
				{
					path = d.Name;
				}
			}
			return path;
		}

		private void BackupButton_Click(object sender, EventArgs e)
		{
			try
			{
				CoreContext.WalletEngine.BackupWalletData(LocationFolder);


				ConfigFormState(FormState.BackupSuccess);
			}
			catch(Exception exception)
			{

			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void SuccessExitButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BackupLocationTextBox_Leave(object sender, EventArgs e)
		{
			LocationFolder = BackupLocationTextBox.Text;
		}
	}
}
