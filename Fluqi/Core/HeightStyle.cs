using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fluqi.Extension.Helpers;
using Fluqi.Extension;
using System.Text;

namespace Fluqi.Core
{
	/// <summary>
	/// Models the HeightStyle options available as standard with jQuery UI components
	/// </summary>
	public class HeightStyle
	{
#pragma warning disable 1591
		/// <summary>
		/// Models the HeightStyle options available as standard with jQuery UI components
		/// </summary>
		public enum eHeightStyle: byte {
			None = 0,

			/// <summary>All panels will be set to the height of the tallest panel</summary>
			Auto = 1,

			/// <summary>Each panel will be only as tall as it's content</summary>
			Content = 2,

			/// <summary>The accordion will expand to fill the available space in the accordion's parent</summary>
			Fill = 3,

			LBound = Auto,
			UBound = Fill 
		}
#pragma warning restore 1591


		/// <summary>
		/// Converts the HeightStyle option into a string.
		/// </summary>
		/// <param name="style">HeightStyle option to convert</param>
		/// <returns>Converted string</returns>
		public static string HeightStyleToString(eHeightStyle style) {
			switch (style) {
				case eHeightStyle.None: return "";
				case eHeightStyle.Auto: return "auto";
				case eHeightStyle.Content: return "content";
				case eHeightStyle.Fill: return "fill";
			}

			throw new ArgumentException(string.Format("HeightStyle has an invalid value ({0}).", style.ToString()));
		}

		/// <summary>
		/// Converts the HeightStyle option into a string.
		/// </summary>
		/// <param name="style">HeightStyle option to convert</param>
		/// <returns>Converted string</returns>
		public static string HeightStyleToString(int style) {
			return HeightStyleToString( (eHeightStyle) style );
		}


		/// <summary>
		/// Returns all the enumeration items as list;
		/// </summary>
		/// <returns></returns>
		public static List<string> ToList() {
			List<string> style = new List<string>( Enum.GetNames(typeof(eHeightStyle)) );
				
			// Remove the LBound/UBound
			style.Remove("LBound");
			style.Remove("UBound");

			return style;
		}


		/// <summary>
		/// Converts a string into an HeightStyle into an enum option.
		/// </summary>
		/// <param name="style">String to convert</param>
		/// <returns>Converted option</returns>
		public static eHeightStyle StringToHeightStyle(string style) {
			if (string.IsNullOrEmpty(style))
				return eHeightStyle.None;

			eHeightStyle col = (eHeightStyle) Enum.Parse(typeof(eHeightStyle), style, true/*ignoreCase*/);
			return col;
		}


		/// <summary>
		/// Converts a list of HeightStyles into a (space) separated string.  Note HeightStyles
		/// specified as "None" are excluded.
		/// </summary>
		/// <param name="styles"></param>
		/// <returns></returns>
		public static string HeightStyleToString(List<eHeightStyle> styles) {
			List<string> strStyles = (
				from p 
					in styles
				where p != eHeightStyle.None
				select HeightStyleToString(p)
			).ToList<string>();

			return strStyles.ToSeparated(" ");
		}

	} // Speed
	
} // ns

