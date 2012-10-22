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
	/// Models the Easing options available as standard with jQuery UI components
	/// </summary>
	public class Ease
	{
#pragma warning disable 1591
		/// <summary>
		/// Models the Easing options available as standard with jQuery UI components
		/// (as defined in the jQuery documentation - http://api.jqueryui.com/easings/)
		/// </summary>
		public enum eEase: byte {
			None = 0,
			linear = 1,
			swing = 2,
			easeInQuad = 3,
			easeOutQuad = 4,
			easeInOutQuad = 5,
			easeInCubic = 6,
			easeInOutCubic = 7,
			easeInQuery = 8,
			easeOutQuart = 9,
			easeInOutQuery = 10,
			easeInQuint = 11,
			easeOutQuint = 12,
			easeInExpo = 13,
			easeOutExpo = 14,
			easeInOutExpo = 15,
			easeInSine = 16,
			easeOutSine = 17,
			easeInOutSine = 18,
			easeInCirc = 19,
			easeOutCirc = 20,
			easeInOutCirc = 21,
			easeInElastic = 22,
			easeOutElastic = 23,
			easeInOutElastic = 24,
			easeInBack = 25,
			easeOutBack = 26,
			easeInOutBack = 27,
			easeInBounce = 28,
			easeOutBounce = 29,
			easeInOutBounce = 30,

			LBound = linear,
			UBound = easeInOutBounce
		}
#pragma warning restore 1591


		/// <summary>
		/// Converts the Easing option into a string.
		/// </summary>
		/// <param name="ease">Easing option to convert</param>
		/// <returns>Converted string</returns>
		public static string EaseToString(eEase ease) {
			switch (ease) {
				case eEase.None: return "";
				case eEase.linear: return "linear";
				case eEase.swing: return "swing";
				case eEase.easeInQuad: return "easeInQuad";
				case eEase.easeOutQuad: return "easeOutQuad";
				case eEase.easeInOutQuad: return "easeInOutQuad";
				case eEase.easeInCubic: return "easeInCubic";
				case eEase.easeInOutCubic: return "easeInOutCubic";
				case eEase.easeInQuery: return "easeInQuery";
				case eEase.easeOutQuart: return "easeOutQuart";
				case eEase.easeInOutQuery: return "easeInOutQuery";
				case eEase.easeInQuint: return "easeInQuint";
				case eEase.easeOutQuint: return "easeOutQuint";
				case eEase.easeInExpo: return "easeInExpo";
				case eEase.easeOutExpo: return "easeOutExpo";
				case eEase.easeInOutExpo: return "easeInOutExpo";
				case eEase.easeInSine: return "easeInSine";
				case eEase.easeOutSine: return "easeOutSine";
				case eEase.easeInOutSine: return "easeInOutSine";
				case eEase.easeInCirc: return "easeInCirc";
				case eEase.easeOutCirc: return "easeOutCirc";
				case eEase.easeInOutCirc: return "easeInOutCirc";
				case eEase.easeInElastic: return "easeInElastic";
				case eEase.easeOutElastic: return "easeOutElastic";
				case eEase.easeInOutElastic: return "easeInOutElastic";
				case eEase.easeInBack: return "easeInBack";
				case eEase.easeOutBack: return "easeOutBack";
				case eEase.easeInOutBack: return "easeInOutBack";
				case eEase.easeInBounce: return "easeInBounce";
				case eEase.easeOutBounce: return "easeOutBounce";
				case eEase.easeInOutBounce: return "easeInOutBounce";
			}

			throw new ArgumentException(string.Format("Easing has an invalid value ({0}).", ease.ToString()));
		}

		/// <summary>
		/// Converts the Easing option into a string.
		/// </summary>
		/// <param name="nEase">Easing option to convert</param>
		/// <returns>Converted string</returns>
		public static string EaseToString(int nEase) {
			return EaseToString( (eEase) nEase );
		}


		/// <summary>
		/// Returns all the enumeration items as list;
		/// </summary>
		/// <returns></returns>
		public static List<string> ToList() {
			List<string> easings = new List<string>( Enum.GetNames(typeof(eEase)) );
				
			// Remove the LBound/UBound
			easings.Remove("LBound");
			easings.Remove("UBound");

			return easings;
		}


		/// <summary>
		/// Converts a string into an Easing into an enum option.
		/// </summary>
		/// <param name="ease">String to convert</param>
		/// <returns>Converted option</returns>
		public static eEase StringToEase(string ease) {
			if (string.IsNullOrEmpty(ease))
				return eEase.None;

			eEase col = (eEase) Enum.Parse(typeof(eEase), ease, true/*ignoreCase*/);
			return col;
		}


		/// <summary>
		/// Converts a list of Easing functions into a (space) separated string.  Note Easings
		/// specified as "None" are excluded.
		/// </summary>
		/// <param name="easings"></param>
		/// <returns></returns>
		public static string EaseToString(List<eEase> ease) {
			List<string> strEases = (
				from p 
					in ease
				where p != eEase.None
				select EaseToString(p)
			).ToList<string>();

			return strEases.ToSeparated(" ");
		}

	} // Animation
	
} // ns

