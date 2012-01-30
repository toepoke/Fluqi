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
		/// <remarks>See http://jqueryui.com/demos/position/#option-my for details</remarks>
		public Options SetMy(Core.Position.ePosition pos) {
			this.My.Clear();
			this.My.Add(pos);
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/position/#option-my for details</remarks>
		public Options SetMy(Core.Position.ePosition pos1, Core.Position.ePosition pos2) {
			this.My.Clear();
			this.My.Add(pos1);
			this.My.Add(pos2);
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/position/#option-my for details</remarks>
		public Options SetMy(string pos) {
			this.My.Clear();
			this.My.Add( Core.Position.StringToPosition(pos) );
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/position/#option-my for details</remarks>
		public Options SetMy(string pos1, string pos2) {
			this.My.Clear();
			this.My.Add( Core.Position.StringToPosition(pos1) );
			this.My.Add( Core.Position.StringToPosition(pos2) );
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/position/#option-my for details</remarks>
		public Options SetAt(Core.Position.ePosition pos) {
			this.At.Clear();
			this.At.Add(pos);
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/position/#option-my for details</remarks>
		public Options SetAt(Core.Position.ePosition pos1, Core.Position.ePosition pos2) {
			this.At.Clear();
			this.At.Add(pos1);
			this.At.Add(pos2);
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/position/#option-my for details</remarks>
		public Options SetAt(string pos) {
			this.At.Clear();
			this.At.Add( Core.Position.StringToPosition(pos) );
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/position/#option-my for details</remarks>
		public Options SetAt(string pos1, string pos2) {
			this.At.Clear();
			this.At.Add( Core.Position.StringToPosition(pos1) );
			this.At.Add( Core.Position.StringToPosition(pos2) );
			return this;
		}


		/// <summary>
		/// Element to position against. If you provide a selector, the first matching element 
		/// will be used. If you provide a jQuery object, the first element will be used. If you 
		/// provide an event object, the pageX and pageY properties will be used. Example: "#top-menu"
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/position/#option-offset for details</remarks>
		public Options SetOf(string of) {
			this.Of = of;
			return this;
		}


		/// <summary>
		/// Add these left-top values to the calculated position, eg. "50 50" (left top) 
		/// A single value such as "50" will apply to both.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/position/#option-offset for details</remarks>
		public Options SetOffset(int both) {
			this.Offset.Clear();
			// just add the once to maintain the interface to jQuery
			// jQuery will actually double them up for us
			this.Offset.Add(both);
			return this;
		}


		/// <summary>
		/// Add these left-top values to the calculated position, eg. "50 50" (left top) 
		/// A single value such as "50" will apply to both.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/position/#option-offset for details</remarks>
		public Options SetOffset(int left, int top) {
			this.Offset.Clear();
			this.Offset.Add(left);
			this.Offset.Add(top);
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
		/// <remarks>See http://jqueryui.com/demos/position/#option-collision for details</remarks>
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
		/// <remarks>See http://jqueryui.com/demos/position/#option-collision for details</remarks>
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
		/// <remarks>See http://jqueryui.com/demos/position/#option-collision for details</remarks>
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
		/// <remarks>See http://jqueryui.com/demos/position/#option-collision for details</remarks>
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
		/// <remarks>See http://jqueryui.com/demos/position/#option-using for details</remarks>
		public Options SetUsingFunction(string usingFunc) {
			this.UsingFunction = usingFunc;
			return this;		
		}		

	} // Options

} // ns Fluqi.jPosition
