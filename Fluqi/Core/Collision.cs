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
	/// Models the Collision options for when an element overflows the window in some direction
	/// and it gets moved to alternative position.
	/// </summary>
	public class Collision
	{
		/// <summary>
		/// Models the Collision options for when an element overflows the window in some direction
		/// and it gets moved to alternative position.
		/// </summary>
		public enum eCollision: byte {

			/// <summary>
			/// none: not do collision detection.
			/// </summary>
			None = 1,

			/// <summary>
			/// flip: to the opposite side and the collision detection is run again to see if it will fit. 
			/// If it won't fit in either position, the center option should be used as a fall back.
			/// </summary>
			Flip = 2,

			/// <summary>
			/// fit: so the element keeps in the desired direction, but is re-positioned so it fits.
			/// </summary>
			Fit = 3,

			/// <summary>
			/// flipfit: First applies the flip logic, placing the element on whichever side allows more of the 
			/// element to be visible. Then the fit logic is applied to ensure as much of the element is visible 
			/// as possible.
			/// </summary>
			FlipFit = 4
		}


		/// <summary>
		/// Converts the Collision option into a string.
		/// </summary>
		/// <param name="collision">Collision option to convert</param>
		/// <returns>Converted string</returns>
		public static string CollisionToString(eCollision collision) {
			switch (collision) {
				case eCollision.None: return "none";
				case eCollision.Fit: return "fit";
				case eCollision.Flip: return "flip";
				case eCollision.FlipFit: return "flipfit";
			}

			throw new ArgumentException(string.Format("Collision has an invalid value ({0}).", collision.ToString()));
		}


		/// <summary>
		/// Converts a string into a Collision into an enum option.
		/// </summary>
		/// <param name="collision">String to convert</param>
		/// <returns>Converted option</returns>
		public static eCollision StringToCollision(string collision) {
			if (string.IsNullOrEmpty(collision))
				return eCollision.None;

			eCollision col = (eCollision) Enum.Parse(typeof(eCollision), collision, true/*ignoreCase*/);
			return col;
		}


		/// <summary>
		/// Returns all the enumeration items as list;
		/// </summary>
		/// <returns></returns>
		public static List<string> ToList() {
			List<string> collisions = new List<string>( Enum.GetNames(typeof(eCollision)) );
				
			// Remove the LBound/UBound
			collisions.Remove("LBound");
			collisions.Remove("UBound");

			return collisions;
		}


		/// <summary>
		/// Converts a list of Collisions into a (space) separated string.  Note collisions 
		/// specified as "None" are excluded.
		/// </summary>
		/// <param name="collisions"></param>
		/// <returns></returns>
		public static string CollisionsToString(List<eCollision> collisions) {
			List<string> strCollisions = (
				from p 
					in collisions 
				where p != eCollision.None
				select CollisionToString(p)
			).ToList<string>();

			return strCollisions.ToSeparated(" ");
		}

	} // Collision
	
} // ns

