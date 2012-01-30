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
	/// Models the Speed options available as standard with jQuery UI components
	/// </summary>
	public class Speed
	{
#pragma warning disable 1591
		/// <summary>
		/// Models the Speed options available as standard with jQuery UI components
		/// </summary>
		public enum eSpeed: byte {
			None = 0,
			Slow = 1,
			Normal = 2,
			Fast = 3,

			LBound = Slow,
			UBound = Fast
		}
#pragma warning restore 1591


		/// <summary>
		/// Converts the Speed option into a string.
		/// </summary>
		/// <param name="speed">Speed option to convert</param>
		/// <returns>Converted string</returns>
		public static string SpeedToString(eSpeed speed) {
			switch (speed) {
				case eSpeed.None: return "";
				case eSpeed.Slow: return "slow";
				case eSpeed.Normal: return "normal";
				case eSpeed.Fast: return "fast";
			}

			throw new ArgumentException(string.Format("Speed has an invalid value ({0}).", speed.ToString()));
		}

		/// <summary>
		/// Converts the speed option into a string.
		/// </summary>
		/// <param name="nSpeed">Speed option to convert</param>
		/// <returns>Converted string</returns>
		public static string SpeedToString(int nSpeed) {
			return SpeedToString( (eSpeed) nSpeed );
		}


		/// <summary>
		/// Returns all the enumeration items as list;
		/// </summary>
		/// <returns></returns>
		public static List<string> ToList() {
			List<string> speed = new List<string>( Enum.GetNames(typeof(eSpeed)) );
				
			// Remove the LBound/UBound
			speed.Remove("LBound");
			speed.Remove("UBound");

			return speed;
		}


		/// <summary>
		/// Converts a string into an Speed into an enum option.
		/// </summary>
		/// <param name="speed">String to convert</param>
		/// <returns>Converted option</returns>
		public static eSpeed StringToSpeed(string speed) {
			if (string.IsNullOrEmpty(speed))
				return eSpeed.None;

			eSpeed col = (eSpeed) Enum.Parse(typeof(eSpeed), speed, true/*ignoreCase*/);
			return col;
		}


		/// <summary>
		/// Converts a list of Speeds into a (space) separated string.  Note Speeds
		/// specified as "None" are excluded.
		/// </summary>
		/// <param name="speeds"></param>
		/// <returns></returns>
		public static string SpeedsToString(List<eSpeed> speeds) {
			List<string> strSpeeds = (
				from p 
					in speeds
				where p != eSpeed.None
				select SpeedToString(p)
			).ToList<string>();

			return strSpeeds.ToSeparated(" ");
		}

	} // Speed
	
} // ns

