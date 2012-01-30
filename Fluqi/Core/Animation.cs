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
	/// Models the Animation options available as standard with jQuery UI components
	/// </summary>
	public class Animation
	{
#pragma warning disable 1591
		/// <summary>
		/// Models the Animation options available as standard with jQuery UI components
		/// (as defined in the jQuery documentation - http://docs.jquery.com/UI/Effects/effect#option-effect)
		/// </summary>
		public enum eAnimation: byte {
			None = 0,
			Blind = 1,
			Bounce = 2,
			Clip = 3,
			Drop = 4,
			Explode = 5,
			Fade = 6,
			Fold = 7,
			Highlight = 8,
			Puff = 9,
			Pulsate = 10,
			Scale = 11,
			Shake = 12,
			Size = 13,
			Slide = 14,
			Transfer = 15,
			Show = 16,

			LBound = Blind,
			UBound = Show
		}
#pragma warning restore 1591


		/// <summary>
		/// Converts the Animation option into a string.
		/// </summary>
		/// <param name="animation">Animation option to convert</param>
		/// <returns>Converted string</returns>
		public static string AnimationToString(eAnimation animation) {
			switch (animation) {
				case eAnimation.None: return "";
				case eAnimation.Blind: return "blind";
				case eAnimation.Bounce: return "bounce";
				case eAnimation.Clip: return "clip";
				case eAnimation.Drop: return "drop";
				case eAnimation.Explode: return "explode";
				case eAnimation.Fade: return "fade";
				case eAnimation.Fold: return "fold";
				case eAnimation.Highlight: return "highlight";
				case eAnimation.Puff: return "puff";
				case eAnimation.Pulsate: return "pulsate";
				case eAnimation.Scale: return "scale";
				case eAnimation.Shake: return "shake";
				case eAnimation.Size: return "size";
				case eAnimation.Slide: return "slide";
				case eAnimation.Transfer: return "transfer";
			}

			throw new ArgumentException(string.Format("Animation has an invalid value ({0}).", animation.ToString()));
		}

		/// <summary>
		/// Converts the Animation option into a string.
		/// </summary>
		/// <param name="nAnimation">Animation option to convert</param>
		/// <returns>Converted string</returns>
		public static string AnimationToString(int nAnimation) {
			return AnimationToString( (eAnimation) nAnimation );
		}


		/// <summary>
		/// Returns all the enumeration items as list;
		/// </summary>
		/// <returns></returns>
		public static List<string> ToList() {
			List<string> animations = new List<string>( Enum.GetNames(typeof(eAnimation)) );
				
			// Remove the LBound/UBound
			animations.Remove("LBound");
			animations.Remove("UBound");

			return animations;
		}


		/// <summary>
		/// Converts a string into an Animation into an enum option.
		/// </summary>
		/// <param name="animation">String to convert</param>
		/// <returns>Converted option</returns>
		public static eAnimation StringToAnimation(string animation) {
			if (string.IsNullOrEmpty(animation))
				return eAnimation.None;

			eAnimation col = (eAnimation) Enum.Parse(typeof(eAnimation), animation, true/*ignoreCase*/);
			return col;
		}


		/// <summary>
		/// Converts a list of Animations into a (space) separated string.  Note Animations
		/// specified as "None" are excluded.
		/// </summary>
		/// <param name="animations"></param>
		/// <returns></returns>
		public static string AnimationsToString(List<eAnimation> animations) {
			List<string> strAnimations = (
				from p 
					in animations
				where p != eAnimation.None
				select AnimationToString(p)
			).ToList<string>();

			return strAnimations.ToSeparated(" ");
		}

	} // Animation
	
} // ns

