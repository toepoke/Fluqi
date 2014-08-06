using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;
using Fluqi.Core;

namespace Fluqi.Utilities.jPosition
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Position.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		public Options SetMy(Core.Position.ePosition pos) {
			this.SetMy(Core.Position.PositionToString(pos));
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		public Options SetMy(Core.Position.ePosition pos1, Core.Position.ePosition pos2) {
			string pos1String = Core.Position.PositionToString(pos1);
			string pos2String = Core.Position.PositionToString(pos2);
			this.SetMy( pos1String, pos2String );
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		public Options SetMy(string pos) {
			this.My = pos;
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		public Options SetMy(string pos1, string pos2) {
			this.My = EvalPositionSetting(pos1, pos2);
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		public Options SetAt(Core.Position.ePosition pos) {
			this.SetAt( Core.Position.PositionToString(pos) );
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		public Options SetAt(Core.Position.ePosition pos1, Core.Position.ePosition pos2) {
			string pos1String = Core.Position.PositionToString(pos1);
			string pos2String = Core.Position.PositionToString(pos2);
			this.SetAt( pos1String, pos2String);
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		public Options SetAt(string pos) {
			this.At = pos;
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		public Options SetAt(string pos1, string pos2) {
			this.At = EvalPositionSetting(pos1, pos2);
			return this;
		}


		/// <summary>
		/// Element to position against. If you provide a selector, the first matching element 
		/// will be used. If you provide a jQuery object, the first element will be used. If you 
		/// provide an event object, the pageX and pageY properties will be used. Example: "#top-menu"
		/// </summary>
		public Options SetOf(string of) {
			this.Of = of;
			return this;
		}


		/// <summary>
		/// Element to position within, affecting collision detection. If you provide a selector or 
		/// jQuery object, the first matching element will be used.
		/// </summary>
		public Options SetWithin(string within) {
			this.Within = within;
			return this;
		}


		/// <summary>
		/// When the positioned element overflows the window in some direction, move it to an 
		/// alternative position. Similar to my and at, this accepts a single value or a pair for 
		/// horizontal/vertical, eg. "flip", "fit", "fit flip", "fit none". 
		/// <list>
		///   <item>
		///     flip: to the opposite side and the collision detection is run again to see if it 
		///     will fit. If it won't fit in either position, the center option should be used as a fall back. 
		///   </item>
		///   <item>
		///     fit: so the element keeps in the desired direction, but is re-positioned so it fits. 
		///   </item>
		///   <item>
		///     none: not do collision detection.
		///   </item>
		/// </list>
		/// </summary>
		public Options SetCollision(Collision.eCollision colli) {
			this.Collision.Clear();
			this.Collision.Add(colli);
			return this;
		}


		/// <summary>
		/// When the positioned element overflows the window in some direction, move it to an 
		/// alternative position. Similar to my and at, this accepts a single value or a pair for 
		/// horizontal/vertical, eg. "flip", "fit", "fit flip", "fit none". 
		/// <list>
		///   <item>
		///     flip: to the opposite side and the collision detection is run again to see if it 
		///     will fit. If it won't fit in either position, the center option should be used as a fall back. 
		///   </item>
		///   <item>
		///     fit: so the element keeps in the desired direction, but is re-positioned so it fits. 
		///   </item>
		///   <item>
		///     none: not do collision detection.
		///   </item>
		/// </list>
		/// </summary>
		public Options SetCollision(Collision.eCollision colli1, Collision.eCollision colli2) {
			this.Collision.Clear();
			this.Collision.Add(colli1);
			this.Collision.Add(colli2);
			return this;
		}


		/// <summary>
		/// When the positioned element overflows the window in some direction, move it to an 
		/// alternative position. Similar to my and at, this accepts a single value or a pair for 
		/// horizontal/vertical, eg. "flip", "fit", "fit flip", "fit none". 
		/// <list>
		///   <item>
		///     flip: to the opposite side and the collision detection is run again to see if it 
		///     will fit. If it won't fit in either position, the center option should be used as a fall back. 
		///   </item>
		///   <item>
		///     fit: so the element keeps in the desired direction, but is re-positioned so it fits. 
		///   </item>
		///   <item>
		///     none: not do collision detection.
		///   </item>
		/// </list>
		/// </summary>
		public Options SetCollision(string colli) {
			this.Collision.Clear();
			this.Collision.Add( Core.Collision.StringToCollision(colli) );
			return this;
		}


		/// <summary>
		/// When the positioned element overflows the window in some direction, move it to an 
		/// alternative position. Similar to my and at, this accepts a single value or a pair for 
		/// horizontal/vertical, eg. "flip", "fit", "fit flip", "fit none". 
		/// <list>
		///   <item>
		///     flip: to the opposite side and the collision detection is run again to see if it 
		///     will fit. If it won't fit in either position, the center option should be used as a fall back. 
		///   </item>
		///   <item>
		///     fit: so the element keeps in the desired direction, but is re-positioned so it fits. 
		///   </item>
		///   <item>
		///     none: not do collision detection.
		///   </item>
		/// </list>
		/// </summary>
		public Options SetCollision(string colli1, string colli2) {
			this.Collision.Clear();
			this.Collision.Add( Core.Collision.StringToCollision(colli1) );
			this.Collision.Add( Core.Collision.StringToCollision(colli2) );
			return this;
		}


		/// <summary>
		/// When specified the actual property setting is delegated to this callback. Receives a 
		/// single parameter which is a hash of top and left values for the position that should be set.
		/// </summary>
		public Options SetUsingFunction(string usingFunc) {
			this.UsingFunction = usingFunc;
			return this;		
		}		


		/// <summary>
		/// Evaluates the incoming strings to ensure they are both populated with something sensible,
		/// and handles the fact they may not be (used by SetMy and SetAt which need this setting sensilbly
		/// otherwise nonsense gets assigned to the underlying properties.
		/// </summary>
		/// <param name="s1">String1</param>
		/// <param name="s2">String2</param>
		/// <returns>
		/// Combination of both s1 and s2 if both are populated, or just the individual string, or empty 
		/// string if neither are populated.
		/// </returns>
		protected internal string EvalPositionSetting(string s1, string s2) {
			if (!string.IsNullOrEmpty(s1) && !string.IsNullOrEmpty(s2))
				// cool, both are populated
				return string.Format("{0} {1}", s1, s2);
			else if (!string.IsNullOrEmpty(s1))
				// just s1
				return s1;
			else if (!string.IsNullOrEmpty(s2))
				// just s2
				return s2;
			else 
				// neither
				return "";
		}

	} // Options

} // ns Fluqi.jPosition
