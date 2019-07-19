using IceWallet.Engine.Utils;
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

namespace IceWallet.WinApp.Forms
{
	public partial class ErrorForm : Form
	{
		public string ErrorMessage { get; set; }
		public string TitleBarMessage { get; set; }
		public string ErrorHeaderMessage { get; set; }
		public Exception DebugException { get; set; }

		public ErrorForm()
		{
			InitializeComponent();
		}

		public static void Show(string errorMessage, string errorHeaderMessage, string titleBarMessage, Exception exception)
		{
			ErrorForm error = new ErrorForm
			{
				ErrorMessage = errorMessage,
				ErrorHeaderMessage = errorHeaderMessage,
				TitleBarMessage = titleBarMessage,
				DebugException = exception
			};

			error.ShowDialog();

		}

		public static void Show(string errorMessage, Exception exception)
		{

			Show(errorMessage, "Error", "You have encountered an error!", exception);
			
		}



		private void ErrorForm_Load(object sender, EventArgs e)
		{
			SkinApplicator.ApplySkin(this);
			this.Text = TitleBarMessage;
			this.ErrorMessageLabel.Text = ErrorMessage;
			this.ErrorHeaderLabel.Text = ErrorHeaderMessage;
		}

		private void OkButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ShowDebugDataCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if(ShowDebugDataCheckBox.Checked)
			{
				this.Size = new Size(Width, 362);

				DebugInfoTextBox.Text = "";

				string details = ExceptionUtil.GetExceptionDetails(DebugException);

				DebugInfoTextBox.Text = details;
			}
			else
			{
				this.Size = new Size(Width, 182);

			}
		}

		private void ErrorMessageLabel_Click(object sender, EventArgs e)
		{

		}
	}
}
