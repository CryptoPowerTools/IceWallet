using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceWallet.WinCore.Skins
{
	public class SkinApplicator
	{
		public static void ApplySkin(Form form)
		{			
			// Apply Skin Colors to this Form
			form.BackColor = SkinColors.FormBackColor;
			form.ForeColor = SkinColors.FormForeColor;


			// Apply Skin Colors to Child Controls
			foreach (Control ctl in form.Controls)
			{
				if (ctl is Button)
				{
					Button button = ctl as Button;
					if ((button.Tag != null) && (string.Compare(button.Tag.ToString(), "action", true) == 0))
					{
						button.BackColor = SkinColors.ActionControlBackColor;
						button.ForeColor = SkinColors.ButtonForeColor;
					}
					else
					{
						button.BackColor = SkinColors.ButtonBackColor;
						button.ForeColor = SkinColors.ButtonForeColor;
					}


				}
				else if (ctl is Label)
				{
					(ctl as Label).ForeColor = SkinColors.LabelForeColor;


				}
				else if (ctl is LinkLabel)
				{
					(ctl as LinkLabel).LinkColor = SkinColors.LinkLabelColor;



				}
				else if (ctl is TextBox)
				{
					TextBox textBox = ctl as TextBox;
					textBox.ForeColor = SkinColors.TextControlForeColor;


				}

			}

		}
	}
}
