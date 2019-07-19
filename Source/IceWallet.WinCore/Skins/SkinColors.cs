using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace IceWallet.WinCore.Skins
{
	public class SkinColors
	{		
		// GREAT site to get Color gradients and variations
		// http://colorglower.com/

		// Another class to consider
		// http://richnewman.wordpress.com/hslcolor-class/

		#region Theme Classic Windows
		/////////////////////////////////////////////////////////
		//// THEME - Classic Windows
		/////////////////////////////////////////////////////////
		public static Color Darkest { get { return GetHtmlColor("#333333"); } }
		public static Color Darker { get { return GetHtmlColor("#505050"); } }
		public static Color Dark { get { return GetHtmlColor("#666666"); } }
		public static Color MediumDark { get { return GetHtmlColor("#7B7B7B"); } }
		public static Color Medium { get { return GetHtmlColor("#999999"); } }
		public static Color MediumLight { get { return GetHtmlColor("#ABABAB"); } }
		public static Color Light { get { return GetHtmlColor("#CCCCCC"); } }
		public static Color Lighter { get { return GetHtmlColor("#EBEBEB"); } }
		public static Color Lightest { get { return Color.WhiteSmoke; } }
		public static Color Red { get { return GetHtmlColor("#FF0000"); } }
		public static Color Yellow { get { return GetHtmlColor("#FFFF00"); } }
		public static Color Blue { get { return GetHtmlColor("#0055FF"); } }
		public static Color Orange { get { return GetHtmlColor("#FFAA55"); } }
		public static Color Green { get { return GetHtmlColor("#55FF7F"); } }
		public static Color White { get { return GetHtmlColor("#ffffff"); } }
		public static Color Black { get { return GetHtmlColor("#000000"); } }
		public static Color DarkGrey { get { return GetHtmlColor("#333333"); } }
		public static Color Grey { get { return GetHtmlColor("#999999"); } }
		public static Color LightGrey { get { return GetHtmlColor("#DCDCDC"); } }
		public static Color Transparent { get { return Color.Transparent; } }
		#endregion

		#region Theme Classis Blues
		/////////////////////////////////////////////////////////
		//// THEME - Classic Blues
		/////////////////////////////////////////////////////////
		//public static Color Darkest { get { return GetHtmlColor("#000033"); } }
		//public static Color Darker { get { return GetHtmlColor("#0036c2"); } }
		//public static Color Dark { get { return GetHtmlColor("#0073FF"); } }
		//public static Color MediumDark { get { return GetHtmlColor("#4fc2ff"); } }
		//public static Color Medium { get { return GetHtmlColor("#4fc2ff"); } }
		//public static Color MediumLight { get { return GetHtmlColor("#859fdf"); } }
		//public static Color Light { get { return GetHtmlColor("#eaffff"); } }
		//public static Color Lighter { get { return GetHtmlColor("#eaffff"); } }
		//public static Color Lightest { get { return GetHtmlColor("#eaffff"); } }
		//public static Color Red { get { return GetHtmlColor("#ffffff"); } }
		//public static Color Yellow { get { return GetHtmlColor("#ffffff"); } }
		//public static Color Blue { get { return GetHtmlColor("#0073ff"); } }
		//public static Color Orange { get { return GetHtmlColor("#ffffff"); } }
		//public static Color Green { get { return GetHtmlColor("#ffffff"); } }
		//public static Color White { get { return GetHtmlColor("#ffffff"); } }
		//public static Color Black { get { return GetHtmlColor("#000000"); } }
		//public static Color DarkGrey { get { return GetHtmlColor("#5B5B5B"); } }
		//public static Color Grey { get { return GetHtmlColor("#A0A0A0"); } }
		//public static Color LightGrey { get { return GetHtmlColor("#F2F2F2"); } }
		//public static Color Transparent { get { return Color.Transparent; } }
		#endregion

		#region Theme Midnight Blue
		/////////////////////////////////////////////////////////
		//// THEME - Midnight Blue
		/////////////////////////////////////////////////////////
		//public static Color Darkest { get { return GetHtmlColor("#00001e"); } }
		//public static Color Darker { get { return GetHtmlColor("#000037"); } }
		//public static Color Dark { get { return GetHtmlColor("#011b5b"); } }
		//public static Color MediumDark { get { return GetHtmlColor("#1d3777"); } }
		//public static Color Medium { get { return GetHtmlColor("#506aaa"); } }
		//public static Color MediumLight { get { return GetHtmlColor("#859fdf"); } }
		//public static Color Light { get { return GetHtmlColor("#f1f8ff"); } }
		//public static Color Lighter { get { return GetHtmlColor("#f8fdff"); } }
		//public static Color Lightest { get { return GetHtmlColor("#fdffff"); } }
		//public static Color Red { get { return GetHtmlColor("#ffffff"); } }
		//public static Color Yellow { get { return GetHtmlColor("#ffffff"); } }
		//public static Color Blue { get { return GetHtmlColor("#ffffff"); } }
		//public static Color Orange { get { return GetHtmlColor("#ffffff"); } }
		//public static Color Green { get { return GetHtmlColor("#ffffff"); } }
		//public static Color DarkGrey { get { return GetHtmlColor("#5B5B5B"); } }
		//public static Color Grey { get { return GetHtmlColor("#A0A0A0"); } }
		//public static Color White { get { return GetHtmlColor("#ffffff"); } }
		//public static Color Black { get { return GetHtmlColor("#000000"); } }
		//public static Color Transparent { get { return Color.Transparent; } }
		#endregion

		#region Theme Seventies Tan
		//public static Color Darkest { get { return GetHtmlColor("#221a0f"); } }
		//public static Color Darker { get { return GetHtmlColor("#eee6db"); } }
		//public static Color Dark { get { return GetHtmlColor("#7e766b"); } }
		//public static Color MediumDark { get { return GetHtmlColor("#aca499"); } }
		//public static Color Medium { get { return GetHtmlColor("#dad2c7"); } }
		//public static Color MediumLight { get { return GetHtmlColor("#e1d9ce"); } }
		//public static Color Light { get { return GetHtmlColor("#faf7f2"); } }
		//public static Color Lighter { get { return GetHtmlColor("#fffcf7"); } }
		//public static Color Lightest { get { return GetHtmlColor("#fffffc"); } }
		//public static Color Red { get { return GetHtmlColor("#7d3944"); } }
		//public static Color Yellow { get { return GetHtmlColor("#f6fc62"); } }
		//public static Color Blue { get { return GetHtmlColor("#2726a4"); } }
		//public static Color Orange { get { return GetHtmlColor("#ff930d"); } }
		//public static Color Green { get { return GetHtmlColor("#0dc723"); } }
		//public static Color Grey { get { return GetHtmlColor("#A0A0A0"); } }
		//public static Color LightGrey { get { return GetHtmlColor("#F2F2F2"); } }
		//public static Color White { get { return GetHtmlColor("#ffffff"); } }
		//public static Color Black { get { return GetHtmlColor("#000000"); } }
		//public static Color Transparent { get { return Color.Transparent; } }
		#endregion

		#region Theme - Black and White
		///////////////////////////////////////////////////////
		//public static Color Darkest { get { return GetHtmlColor("#000000"); } }
		//public static Color Darker { get { return GetHtmlColor("#1e1e1c"); } }
		//public static Color Dark { get { return GetHtmlColor("#383836"); } }
		//public static Color MediumDark { get { return GetHtmlColor("#aca499"); } }
		//public static Color Medium { get { return GetHtmlColor("#ff3f3f"); } }
		//public static Color MediumLight { get { return GetHtmlColor("#e1d9ce"); } }
		//public static Color Light { get { return GetHtmlColor("#efefef"); } }
		//public static Color Lighter { get { return GetHtmlColor("#fafafa"); } }
		//public static Color Lightest { get { return GetHtmlColor("#fcfcfc"); } }
		//public static Color Red { get { return GetHtmlColor("#810505"); } }
		//public static Color Yellow { get { return GetHtmlColor("#f6fc62"); } }
		//public static Color Blue { get { return GetHtmlColor("#171b63"); } }
		//public static Color Orange { get { return GetHtmlColor("#ff930d"); } }
		//public static Color Green { get { return GetHtmlColor("#ce744f"); } }
		//public static Color White { get { return GetHtmlColor("#ffffff"); } }
		//public static Color Black { get { return GetHtmlColor("#000000"); } }
		//public static Color Grey { get { return GetHtmlColor("#A0A0A0"); } }
		//public static Color LightGrey { get { return GetHtmlColor("#F2F2F2"); } }
		//public static Color Transparent { get { return Color.Transparent; } }
		#endregion

		#region LIGHT Form Colors  (To invert the colors for a night mode use the DARK Form Colors
		////////////////////////////////////////////////////////////////////////////////////
		// Form Colors - These Generally Should Be Derived from the Base Colors Above
		////////////////////////////////////////////////////////////////////////////////////
		public static Color HeaderPanelBackColor { get { return Grey; } }
		public static Color FrameworkBackColor { get { return Dark; } }
		public static Color FrameworkForeColor { get { return White; } }
		public static Color FrameworkTitleForeColor { get { return White; } }
		public static Color FrameworkSubTitleForeColor { get { return White; } }
		public static Color FormBackColor { get { return White; } }
		public static Color FormForeColor { get { return Darkest; } }
		public static Color FormControlBackColor { get { return Light; } }
		public static Color FormControlForeColor { get { return Darkest; } }		
		public static Color FormLabelBackColor { get { return Transparent; } }
		public static Color FormLabelForeColor { get { return Dark; } }
		public static Color FormLinkLabelBackColor { get { return Transparent; } }
		public static Color FormLinkLabelForeColor { get { return Blue; } }
		public static Color FormLinkLabelActiveForeColor { get { return Blue; } }
		public static Color FormEditControlBackColor { get { return White; } }
		public static Color FormEditControlBorderColor { get { return Medium; } }
		public static Color FormEditControlFocusedBorderColor { get { return Dark; } }
		public static Color FormEditControlForeColor { get { return Darkest; } }
		public static Color FormActionButtonHoverBackColor { get { return AdjustBrightness(Green, -.1f); } }		
		public static Color FormActionButtonBackColor { get { return Green; } }
		public static Color FormActionButtonForeColor { get { return Black; } }
		public static Color FormButtonBackColor { get { return Lightest; } }
		public static Color FormButtonForeColor { get { return Darkest; } }
		public static Color FormButtonBorderColor { get { return FormEditControlBorderColor; } }
		public static Color FormButtonFocusedBackColor { get { return FormEditControlFocusedBorderColor; } }
		public static Color FormButtonHoverBorderColor { get { return Darkest; } }
		public static Color FormButtonFocusedBorderColor { get { return FormEditControlFocusedBorderColor; } }
		#endregion
			
		#region Private Helpers
		private static Color GetRgb(int r, int g, int b)
		{
			return Color.FromArgb(((int)(((byte)(r)))), ((int)(((byte)(g)))), ((int)(((byte)(b)))));
		}

		private static Color GetHtmlColor(string htmlHexColor)
		{
			return ColorTranslator.FromHtml(htmlHexColor);
		}

		private static Color AdjustBrightness(Color color, float correctionFactor)
		{
			float red = (float)color.R;
			float green = (float)color.G;
			float blue = (float)color.B;

			if (correctionFactor < 0)
			{
				correctionFactor = 1 + correctionFactor;
				red *= correctionFactor;
				green *= correctionFactor;
				blue *= correctionFactor;
			}
			else
			{
				red = (255 - red) * correctionFactor + red;
				green = (255 - green) * correctionFactor + green;
				blue = (255 - blue) * correctionFactor + blue;
			}

			return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
		}
		#endregion
	}

}