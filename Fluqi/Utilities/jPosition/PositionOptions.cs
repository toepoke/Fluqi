using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Core;

namespace Fluqi.Utilities.jPosition {

	/// <summary>
	/// Models the options for the jQuery Position utility
	/// </summary>
	public class PositionOptions {
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="pos">Position object have options configured for</param>
		public PositionOptions(Position pos)
		 : base()
		{
			this.Position = pos;
		}

		/// <summary>
		/// Exposes the Position options object so it can be configured.
		/// </summary>
		protected internal Utilities.jPosition.Options Options { 
			get; 
			set; 
		}

		/// <summary>
		/// Holds a reference to the <see cref="Position"/> object these options are for
		/// </summary>
		public Position Position { get; set; }
		
		/// <summary>
		/// Used to flag that configuration of <see cref="Options"/> has finished, and 
		/// returns the <see cref="Position"/> object so we can continue defining Tabs attributes.
		/// </summary>
		/// <returns>Returns <see cref="Position"/> object to return chaining to the Tabs collection</returns>
		public Position Finish() {
		  return this.Position;
		}

		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/position/#option-my for details</remarks>
		public PositionOptions SetMy(Core.Position.ePosition pos) {
			Options.SetMy(pos);
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
		public PositionOptions SetMy(Core.Position.ePosition pos1, Core.Position.ePosition pos2) {
			Options.SetMy(pos1, pos2);
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
		public PositionOptions SetMy(string pos) {
			Options.SetMy(pos);
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
		public PositionOptions SetMy(string pos1, string pos2) {
			Options.SetMy(pos1, pos2);
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
		public PositionOptions SetAt(Core.Position.ePosition pos) {
			Options.SetAt(pos);
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
		public PositionOptions SetAt(Core.Position.ePosition pos1, Core.Position.ePosition pos2) {
			Options.SetAt(pos1, pos2);
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
		public PositionOptions SetAt(string pos) {
			Options.SetAt(pos);
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
		public PositionOptions SetAt(string pos1, string pos2) {
			Options.SetAt(pos1, pos2);
			return this;
		}


		/// <summary>
		/// Element to position against. If you provide a selector, the first matching element 
		/// will be used. If you provide a jQuery object, the first element will be used. If you 
		/// provide an event object, the pageX and pageY properties will be used. Example: "#top-menu"
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/position/#option-offset for details</remarks>
		public PositionOptions SetOf(string of) {
			Options.SetOf(of);
			return this;
		}


		/// <summary>
		/// Add these left-top values to the calculated position, eg. "50 50" (left top) 
		/// A single value such as "50" will apply to both.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/position/#option-offset for details</remarks>
		public PositionOptions SetOffset(int both) {
			Options.SetOffset(both);
			return this;
		}


		/// <summary>
		/// Add these left-top values to the calculated position, eg. "50 50" (left top) 
		/// A single value such as "50" will apply to both.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/position/#option-offset for details</remarks>
		public PositionOptions SetOffset(int left, int top) {
			Options.SetOffset(left, top);
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
		public PositionOptions SetCollision(Collision.eCollision colli) {
			Options.SetCollision(colli);
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
		public PositionOptions SetCollision(Collision.eCollision colli1, Collision.eCollision colli2) {
			Options.SetCollision(colli1, colli2);
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
		public PositionOptions SetCollision(string colli) {
			Options.SetCollision(colli);
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
		public PositionOptions SetCollision(string colli1, string colli2) {
			Options.SetCollision(colli1, colli2);
			return this;
		}


		/// <summary>
		/// When specified the actual property setting is delegated to this callback. Receives a 
		/// single parameter which is a hash of top and left values for the position that should be set.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/position/#option-using for details</remarks>
		public PositionOptions SetUsingFunction(string usingFunc) {
			Options.SetUsingFunction(usingFunc);
			return this;		
		}		

	}
}
