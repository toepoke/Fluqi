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
	/// Models the Position options available for the controls (e.g. where the dialog appears, where the 
	/// AutoComplete menu appears in correlation to the input textbox).
	/// </summary>
	public class Position
	{
		/// <summary>
		/// Models the Position options available for the controls (e.g. where the dialog appears, where the 
		/// AutoComplete menu appears in correlation to the input textbox).
		/// </summary>
		public enum ePosition: byte {
			
			/// <summary>Position isn't appropriate</summary>
			None = 0,

			/// <summary>Centred positioning</summary>
			Centre = 1,

			/// <summary>Centred positioning - same as Centre ... here to accommodate our American friends :)</summary>
			Center = 1,

			/// <summary>Position at top</summary>
			Top = 2,

			/// <summary>Position at bottom</summary>
			Bottom = 3,

			/// <summary>Position at left</summary>
			Left = 4,

			/// <summary>Position at right</summary>
			Right = 5
		}


		/// <summary>
		/// Converts the enumeration into a string (for rendering the option).
		/// </summary>
		/// <param name="position">Option to be converted</param>
		/// <returns>Converted string</returns>
		public static string PositionToString(ePosition position) {
			switch (position) {
				case ePosition.None: return "";
				case ePosition.Bottom: return "bottom";
				case ePosition.Centre: return "center";
				case ePosition.Left: return "left";
				case ePosition.Right: return "right";
				case ePosition.Top: return "top";
			}

			throw new ArgumentException(string.Format("Position has an invalid value ({0}).", position.ToString()));
		}


		/// <summary>
		/// Converts a string into the enumeration
		/// </summary>
		/// <param name="position">String to be converted</param>
		/// <returns>Converted enumeration option</returns>
		public static ePosition StringToPosition(string position) {
			if (string.IsNullOrEmpty(position))
				return ePosition.None;

			ePosition pos = (ePosition) Enum.Parse(typeof(ePosition), position, true/*ignoreCase*/);
			return pos;
		}


		/// <summary>
		/// Converts the list of positions into a space separated string (note any with
		/// a position of "None").
		/// </summary>
		/// <param name="positions">Positions to convert to a string</param>
		/// <returns>Any non "None" (eh?) positions as a space separated string</returns>
		public static string PositionsToString(List<ePosition> positions) {
			List<string> strPositions = (
				from p 
					in positions 
				where p != ePosition.None
				select PositionToString(p)
			).ToList<string>();

			return strPositions.ToSeparated(" ");
		}


		/// <summary>
		/// Returns all the enumeration items as list;
		/// </summary>
		/// <returns></returns>
		public static List<string> ToList() {
			List<string> positions = new List<string>( Enum.GetNames(typeof(ePosition)) );
				
			return positions;
		}

	} // Position
	
} // ns

