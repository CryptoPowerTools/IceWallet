using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceWallet.WinCore.Helpers
{
	public static class ClipboardHelper
	{


		public static void SetText(string text)
		{
			Clipboard.SetText(text);
		}
		public static string GetText()
		{
			return Clipboard.GetText(TextDataFormat.Text);
		}
	}
}
