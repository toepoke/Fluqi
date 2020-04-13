using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fluqi.Extension;

namespace Fluqi.Core {
	
	/// <summary>
	/// Models the Icon Postion options available as stanadard with jQuery UI components
	/// </summary>
	public class IconPosition {

		/// <summary>
		/// Models the icon position options available as standard with jQuery UI components
		/// (as defined in the jQuery UI documentation - https://api.jqueryui.com/button/#option-iconPosition)
		/// </summary>
		public enum eIconPosition: byte {
			/// <summary>
			/// Icon to left (or right when RTL)
			/// </summary>
			Beginning = 0,

			/// <summary>
			/// Icon to right (or left when RTL)
			/// </summary>
			End = 1,

			/// <summary>
			/// Icon to top
			/// </summary>
			Top = 2,

			/// <summary>
			/// Icon to bottom
			/// </summary>
			Bottom = 3
		}

		/// <summary>
		/// Converts the icon position option into a string.
		/// </summary>
		/// <param name="iconPosition">Icon position option to convert</param>
		/// <returns>Converted string</returns>
		public static string IconPositionToString(eIconPosition iconPosition) {
			switch (iconPosition) {
				case eIconPosition.Beginning: return "beginning";
				case eIconPosition.End: return "end";
				case eIconPosition.Top: return "top";
				case eIconPosition.Bottom: return "bottom";
			}

			throw new ArgumentException(string.Format("IconPosition has an invalid value ({0}).", iconPosition.ToString()));
		}

		/// <summary>
		/// Converts an <see cref="eIconPosition"/> enumeration value into a string representing
		/// the given option.
		/// </summary>
		/// <param name="iconPosition">Icon position to get string of</param>
		/// <returns>Icon position as a string</returns>
		public static string ByEnum(eIconPosition iconPosition) {
			return ByIndex((int)iconPosition);
		}

		/// <summary>
		/// Converts an int version of <see cref="eIconPosition"/> ernumation value into a string
		/// used by the jQuery UI API.
		/// </summary>
		/// <param name="iconPosition">Icon position to convert</param>
		/// <returns>String used by the jQuery UI API</returns>
		public static string ByIndex(int iconPosition) {
			return IconPosition.ToList()[iconPosition];
		}

		/// <summary>
		/// Converts the IconPosition option into a s string.
		/// </summary>
		/// <param name="iconPosition">IconPosition option to convert</param>
		/// <returns>Converted string</returns>
		public static string IconPositionToString(int iconPosition) {
			return IconPositionToString( (eIconPosition) iconPosition );
		}

		/// <summary>
		/// Returns all available Icon Position options as a string list.
		/// </summary>
		/// <returns>List of options</returns>
		public static List<string> ToList() {
			List<string> iconPositions = new List<string>( Enum.GetNames(typeof(eIconPosition)) );

			return iconPositions;
		}

		/// <summary>
		/// Converts a string into an icon position enum.
		/// </summary>
		/// <param name="iconPosition">String to convert</param>
		/// <returns>Converted option</returns>
		public static eIconPosition StringToIconPosition(string iconPosition) {
			if (string.IsNullOrEmpty(iconPosition)) {
				return eIconPosition.Beginning;
			}

			eIconPosition pos = (eIconPosition) Enum.Parse(typeof(eIconPosition), iconPosition, ignoreCase:true);
			return pos;
		}

		/// <summary>
		/// Convers a list of IconPosition into a (space) separated string.
		/// </summary>
		/// <param name="iconPositions">Items to string separate</param>
		/// <returns>Space separated list of icon positions</returns>
		public static string IconPositionToString(List<eIconPosition> iconPositions) {
			List<string> strIconPositions = (
				from ip
				  in iconPositions
				select IconPositionToString(ip)
			).ToList<string>();

			return strIconPositions.ToSeparated(" ");
		}

	}
}
