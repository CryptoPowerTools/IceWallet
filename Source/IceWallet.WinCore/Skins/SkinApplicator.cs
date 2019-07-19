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
					button.FlatStyle = FlatStyle.Flat;

					if ((button.Tag != null) && (string.Compare(button.Tag.ToString(), "action", true) == 0))
					{
						button.BackColor = SkinColors.FormActionButtonBackColor;
						button.ForeColor = SkinColors.FormActionButtonForeColor;
						button.FlatAppearance.MouseOverBackColor = SkinColors.FormActionButtonHoverBackColor;
					}
					else
					{
						button.BackColor = SkinColors.FormButtonBackColor;
						button.ForeColor = SkinColors.FormButtonForeColor;
						button.FlatAppearance.MouseOverBackColor = SkinColors.FormControlBackColor;
					}

					// Make Flat Style
					button.FlatAppearance.BorderColor = SkinColors.FormButtonBorderColor;
					//button.FlatAppearance.MouseOverBackColor = SkinColors.FormControlBackColor;
				}
				else if (ctl is Label)
				{
					if(ctl is LinkLabel)
					{
						(ctl as LinkLabel).LinkColor = SkinColors.FormLinkLabelForeColor;
						(ctl as LinkLabel).BackColor = SkinColors.FormLinkLabelBackColor;
						(ctl as LinkLabel).ActiveLinkColor = SkinColors.FormLinkLabelActiveForeColor;
						//(ctl as LinkLabel).ForeColor = SkinColors.FormLinkLabelForeColor;
						continue;
					}
									   
					(ctl as Label).ForeColor = SkinColors.FormLabelForeColor;
					(ctl as Label).BackColor = SkinColors.FormLabelBackColor;


				}
				else if (ctl is LinkLabel)
				{
					



				}
				else if (ctl is TextBox)
				{
					TextBox textBox = ctl as TextBox;
					textBox.ForeColor = SkinColors.FormEditControlForeColor;
					textBox.BackColor = SkinColors.FormEditControlBackColor;

				}

			}

		}
	}
}
