using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fluqi.Extension.Helpers;
using System.Text;

namespace Fluqi.Core
{
	/// <summary>
	/// Models the Orientation options for the Slider control
	/// </summary>
	public class Orientation
	{

		/// <summary>
		/// Models the Orientation options for the Slider control
		/// </summary>
		public enum eOrientation: byte {
			/// <summary>Flags that the Slider should be rendered horizonally</summary>
			Horizontal = 0,

			/// <summary>Flags that the Slider should be rendered vertically</summary>
			Vertical = 1
		}


		/// <summary>
		/// Converts the provided option into a string, used for rendering the Slider control.
		/// </summary>
		/// <param name="orientation">Option to convert</param>
		/// <returns>Converted option as string</returns>
		public static string OrientationToString(Orientation.eOrientation orientation) {
			switch(orientation) {
				case eOrientation.Horizontal: return "horizontal";
				case eOrientation.Vertical: return "vertical";
			}

			throw new ArgumentException(string.Format("Orientation has an invalid value ({0}).", orientation.ToString()));
		}


		/// <summary>
		/// Converts the provided option into the equivalent enumeration value.
		/// </summary>
		/// <param name="orientation">String to convert</param>
		/// <returns>String converted to the corresponding enumeration</returns>
		public static Orientation.eOrientation StringToOrientation(string orientation) {
			eOrientation ori = (eOrientation) Enum.Parse(typeof(eOrientation), orientation, true/*ignoreCase*/);
			return ori;
		}

		/// <summary>
		/// Returns all the enumeration items as list;
		/// </summary>
		/// <returns></returns>
		public static List<string> ToList() {
			List<string> orientations = new List<string>( Enum.GetNames(typeof(eOrientation)) );
				
			return orientations;
		}

	} // Orientation
	
} // ns

