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
	/// Models the different render options for the Button control.
	/// </summary>
	public class ButtonType
	{
#pragma warning disable 1591
		/// <summary>
		/// Options available for how the Button control is rendered.
		/// </summary>
		public enum eButtonType: byte {
			Hyperlink = 0,
			Button = 1,
			Submit = 2,
			Reset = 3,
			LBound = Hyperlink,
			UBound = Reset
		}
#pragma warning restore 1591


		/// <summary>
		/// Converts the given button type into a string (used for rendering the button).
		/// </summary>
		/// <param name="buttonType">Type of button</param>
		/// <returns></returns>
		public static string ButtonTypeToString(eButtonType buttonType) {
			switch (buttonType) {
				case eButtonType.Button: return "button";
				case eButtonType.Hyperlink: return "a";
				case eButtonType.Reset: return "reset";
				case eButtonType.Submit: return "submit";				
			}

			throw new ArgumentException(string.Format("ButtonType has an invalid value ({0}).", buttonType.ToString()));
		}


		/// <summary>
		/// Converts a string into a ButtonType.
		/// </summary>
		/// <param name="buttonType">Button type to convert</param>
		/// <returns>Converts the given string into a ButtonType</returns>
		public static eButtonType StringToButtonType(string buttonType) {
			if (buttonType == "a")
				// We match "a" <--> "Hyperlink" (which will fail)
				return eButtonType.Hyperlink;

			eButtonType col = (eButtonType) Enum.Parse(typeof(eButtonType), buttonType, true/*ignoreCase*/);
			return col;
		}


		/// <summary>
		/// Returns all the enumeration items as list;
		/// </summary>
		/// <returns></returns>
		public static List<string> ToList() {
			List<string> buttonTypes = new List<string>( Enum.GetNames(typeof(eButtonType)) );
				
			// Remove the LBound/UBound
			buttonTypes.Remove("LBound");
			buttonTypes.Remove("UBound");

			return buttonTypes;
		}


		/// <summary>
		/// Queries if the provided ButtonType will be rendered using an "input" tag.
		/// </summary>
		/// <param name="buttonType">ButtonType to query</param>
		/// <returns></returns>
		public static bool IsInputButton(eButtonType buttonType) {
			return (buttonType == eButtonType.Reset || buttonType == eButtonType.Submit);
		}

	} // ButtonType
	
} // ns
