using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fluqi.Extension.Helpers;
using System.Text;

namespace Fluqi.Core
{
	/// <summary>
	/// Models the Icons that comes as standard through jQuery UI (see the Framework Icons section
	/// at http://jqueryui.com/themeroller/).  Used for displaying icons in the dialog control for instance.
	/// </summary>
	public class Icons
	{

#pragma warning disable 1591
		/// <summary>
		/// Enumeration for the Icons that come as standard with jQuery UI (see the Framework Icons section
		/// at http://jqueryui.com/themeroller/).
		/// </summary>
		public enum eIconClass: int {
			carat_1_n               =   0,
			carat_1_ne              =   1,
			carat_1_e               =   2,
			carat_1_se              =   3,
			carat_1_s               =   4,
			carat_1_sw              =   5,
			carat_1_w               =   6,
			carat_1_nw              =   7,
			carat_2_n_s             =   8,
			carat_2_e_w             =   9,
			triangle_1_n            =  10,
			triangle_1_ne           =  11,
			triangle_1_e            =  12,
			triangle_1_se           =  13,
			triangle_1_s            =  14,
			triangle_1_sw           =  15,
			triangle_1_w            =  16,
			triangle_1_nw           =  17,
			triangle_2_n_s          =  18,
			triangle_2_e_w          =  19,
			arrow_1_n               =  20,
			arrow_1_ne              =  21,
			arrow_1_e               =  22,
			arrow_1_se              =  23,
			arrow_1_s               =  24,
			arrow_1_sw              =  25,
			arrow_1_w               =  26,
			arrow_1_nw              =  27,
			arrow_2_n_s             =  28,
			arrow_2_ne_sw           =  29,
			arrow_2_e_w             =  30,
			arrow_2_se_nw           =  31,
			arrowstop_1_n           =  32,
			arrowstop_1_e           =  33,
			arrowstop_1_s           =  34,
			arrowstop_1_w           =  35,
			arrowthick_1_n          =  36,
			arrowthick_1_ne         =  37,
			arrowthick_1_e          =  38,
			arrowthick_1_se         =  39,
			arrowthick_1_s          =  40,
			arrowthick_1_sw         =  41,
			arrowthick_1_w          =  42,
			arrowthick_1_nw         =  43,
			arrowthick_2_n_s        =  44,
			arrowthick_2_ne         =  45,
			arrowthick_2_e_w        =  46,
			arrowthick_2_se_nw      =  47,
			arrowthickstop_1_n      =  48,
			arrowthickstop_1_e      =  49,
			arrowthickstop_1_s      =  50,
			arrowthickstop_1_w      =  51,
			arrowreturnthick_1_w    =  52,
			arrowreturnthick_1_n    =  53,
			arrowreturnthick_1_e    =  54,
			arrowreturnthick_1_s    =  55,
			arrowreturn_1_w         =  56,
			arrowreturn_1_n         =  57,
			arrowreturn_1_e         =  58,
			arrowreturn_1_s         =  59,
			arrowrefresh_1_w        =  60,
			arrowrefresh_1_n        =  61,
			arrowrefresh_1_e        =  62,
			arrowrefresh_1_s        =  63,
			arrow_4                 =  64,
			arrow_4_diag            =  65,
			extlink                 =  66,
			newwin                  =  67,
			refresh                 =  68,
			shuffle                 =  69,
			transfer_e_w            =  70,
			transferthick_e_w       =  71,
			folder_collapsed        =  72,
			folder_open             =  73,
			document                =  74,
			document_b              =  75,
			note                    =  76,
			mail_closed             =  77,
			mail_open               =  78,
			suitcase                =  79,
			comment                 =  80,
			person                  =  81,
			print                   =  82,
			trash                   =  83,
			locked                  =  84,
			unlocked                =  85,
			bookmark                =  86,
			tag                     =  87,
			home                    =  88,
			flag                    =  89,
			calculator              =  90,
			cart                    =  91,
			pencil                  =  92,
			clock                   =  93,
			disk                    =  94,
			calendar                =  95,
			zoomin                  =  96,
			zoomout                 =  97,
			search                  =  98,
			wrench                  =  99,
			gear                    = 100,
			heart                   = 101,
			star                    = 102,
			link                    = 103,
			cancel                  = 104,
			plus                    = 105,
			plusthick               = 106,
			minus                   = 107,
			minusthick              = 108,
			close                   = 109,
			closethick              = 110,
			key                     = 111,
			lightbulb               = 112,
			scissors                = 113,
			clipboard               = 114,
			copy                    = 115,
			contact                 = 116,
			image                   = 117,
			video                   = 118,
			script                  = 119,
			alert                   = 120,
			info                    = 121,
			notice                  = 122,
			help                    = 123,
			check                   = 124,
			bullet                  = 125,
			radio_off               = 126,
			radio_on                = 127,
			pin_w                   = 128,
			pin_s                   = 129,
			play                    = 130,
			pause                   = 131,
			seek_next               = 132,
			seek_prev               = 133,
			seek_end                = 134,
			seek_first              = 135,
			stop                    = 136,
			eject                   = 137,
			volume_off              = 138,
			volume_on               = 139,
			power                   = 140,
			signal_diag             = 141,
			signal                  = 142,
			battery_0               = 143,
			battery_1               = 144,
			battery_2               = 145,
			battery_3               = 146,
			circle_plus             = 147,
			circle_minus            = 148,
			circle_close            = 149,
			circle_triangle_e       = 150,
			circle_triangle_s       = 151,
			circle_triangle_w       = 152,
			circle_triangle_n       = 153,
			circle_arrow_e          = 154,
			circle_arrow_s          = 155,
			circle_arrow_w          = 156,
			circle_arrow_n          = 157,
			circle_zoomin           = 158,
			circle_zoomout          = 159,
			circle_check            = 160,
			circlesmall_plus        = 161,
			circlesmall_minus       = 162,
			circlesmall_close       = 163,
			squaresmall_plus        = 164,
			squaresmall_minus       = 165,
			squaresmall_close       = 166,
			grip_dotted_vertical    = 167,
			grip_dotted_horizontal  = 168,
			grip_solid_vertical     = 169,
			grip_solid_horizontal   = 170,
			gripsmall_diagonal_se   = 171,
			grip_diagonal_se        = 172,

			LBound = 0,
			UBound = grip_diagonal_se
		};
#pragma warning restore 1591


		/// <summary>
		/// Converts a number (corresponding to the <see cref="eIconClass"/> enumeration) into a string
		/// representing the CSS class name required to render the corresponding icon.
		/// </summary>
		/// <param name="iconIndex">Icon enumeration (numeric value) of the CSS class to get</param>
		/// <returns>CSS [icon] class name</returns>
		public static string ByIndex(int iconIndex) {
			int lbound = (int)eIconClass.LBound;
			int ubound = (int)eIconClass.UBound;

			if (iconIndex < lbound && iconIndex > ubound) {
				throw new ArgumentException(
					string.Format("{0} is not a valid index, icons between {1}..{2} only are supported.", iconIndex, lbound, ubound)
				);
			}

			return Icons.ToList()[iconIndex];
		}


		/// <summary>
		/// Converts an <see cref="eIconClass"/> enumeration value into a string representing
		/// the CSS class name required to render the corresponding icon.
		/// </summary>
		/// <param name="iconClass">Icon enumeration of the CSS class to get</param>
		/// <returns>CSS [icon] class name</returns>
		public static string ByEnum(eIconClass iconClass) {
			return ByIndex((int)iconClass);
		}

		/// <summary>
		/// Converts the icon option into a string.
		/// </summary>
		/// <param name="icon">Icon option to convert</param>
		/// <returns>Converted string</returns>
		public static string IconToString(int icon) {
			return IconToString((eIconClass) icon);
		}
	
		/// <summary>
		/// Converts the icon option into a string.
		/// </summary>
		/// <param name="icon">Icon option to convert</param>
		/// <returns>Converted string</returns>
		public static string IconToString(eIconClass icon) {
			return ResolveIconName(icon.ToString());
		}

		/// <summary>
		/// Gets the full list of CSS class names available (useful for demo purposes).
		/// </summary>
		/// <returns>Full list of CSS class names</returns>
		public static List<string> ToList() {
			string[] arrNames = ( Enum.GetNames(typeof(eIconClass)) );

			List<string> icons = (
				from name in arrNames
				select ResolveIconName(name)
			).ToList();

			// Remove the LBound/UBound
			icons.Remove("ui-icon-LBound");
			icons.Remove("ui-icon-UBound");
				
			return icons;
		}

		private static string ResolveIconName(string iconName) {
			if (string.IsNullOrEmpty(iconName)) 
				return "";

			return "ui-icon-" + iconName.Replace("_", "-");
		}

		/// <summary>
		/// Returns an HTML list (ul/li set) of all the available icons.
		/// </summary>
		/// <returns>HTML list (ul/li set) of all the available icons.</returns>
		public static string RenderAsList() {
			jStringBuilder sb = new jStringBuilder(true, 1);
			sb.AppendTabsLine("<ul id=\"icons\">");
			List<string>.Enumerator e = Icons.ToList().GetEnumerator();
			while (e.MoveNext()) {
				sb.AppendTabs();
				sb.AppendFormat("<li title=\".{0}\">", e.Current);
				sb.AppendFormat(  "<span class=\"ui-icon {0}\"></span>", e.Current);
				sb.AppendFormat("</li>");
				sb.AppendLine();
			}			 
			sb.AppendTabsLine("</ul>");
			return sb.ToString();
		}


		/// <summary>
		/// Returns an HTML table of all available icons, split into 13 columsn).
		/// </summary>
		/// <returns>An HTML table of all available icons.</returns>
		public static string RenderAsTable() {
			return RenderAsTable(13/*number used in jQuery demo pages*/);
		}


		/// <summary>
		/// Returns an HTML table of all available icons, split into <paramref name="numColumns"/>.
		/// </summary>
		/// <param name="numColumns">Number of columns to split the table into</param>
		/// <returns>HTML table of [rendered] icons</returns>
		public static string RenderAsTable(int numColumns) {
			int currCol = 0;
			jStringBuilder sb = new jStringBuilder(true, 1);
			sb.AppendTabsLine("<table id=\"table-icons\">");
			List<string>.Enumerator e = Icons.ToList().GetEnumerator();
			while (e.MoveNext()) {
				if (currCol == 0)
					sb.Append("<tr>");

				sb.AppendTabs();
				sb.AppendFormat("<td title=\".{0}\">", e.Current);
				sb.AppendFormat(  "<span class=\"ui-icon {0}\"></span>", e.Current);
				sb.AppendFormat("</td>");

				currCol++;

				if (currCol == numColumns) {
					sb.AppendLine("</tr>");
					currCol = 0;
				}
			}			 
			sb.AppendTabsLine("</table>");
			return sb.ToString();
		}
		
	} // IconClasses
	
} // ns

