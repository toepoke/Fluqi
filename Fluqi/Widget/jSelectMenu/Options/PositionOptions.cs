using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Core;

namespace Fluqi.Widget.jSelectMenu {
	
	/// <summary>
	/// Models the Position child for setting placement of the SelectMenu control.
	/// </summary>
	public class PositionOptions {
		
		/// <summary>
		/// Reference to the SelectMenu object to return control to.
		/// </summary>
		protected internal jSelectMenu.Options _SelectMenuOptions { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="options">SelectMenu options object</param>
		public PositionOptions(Options options) 
		 : base()
		{
			_SelectMenuOptions = options;
			Options = new Utilities.jPosition.Options(null);
		}

		/// <summary>
		/// Flags the end of the options configuration and returns the Fluent interface back to the SelectMenu
		/// object.
		/// </summary>
		/// <returns>Control back to the SelectMenu object</returns>
		public jSelectMenu.Options Finish() {
			return _SelectMenuOptions;
		}

		/// <summary>
		/// Holds the Position options object for configuration.
		/// </summary>
		protected internal Utilities.jPosition.Options Options 
		{ 
			get; 
			private set; 
		}

		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/position/ for details</remarks>
		public PositionOptions SetMy(Core.Position.ePosition pos) {
			this.Options.SetMy(pos);
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/position/ for details</remarks>
		public PositionOptions SetMy(Core.Position.ePosition pos1, Core.Position.ePosition pos2) {
			if (pos1 != Position.ePosition.Left && pos2 != Position.ePosition.Top) {
				// avoid menu default position of "left top"
				this.Options.SetMy(pos1, pos2);
			}
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/position/ for details</remarks>
		public PositionOptions SetMy(string pos) {
			this.Options.SetMy(pos);
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/position/ for details</remarks>
		public PositionOptions SetMy(string pos1, string pos2) {
			if (pos1 != "left" && pos2 != "top") {
				// avoid menu default position of "left top"
				this.Options.SetMy(pos1, pos2);
			}
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/position/ for details</remarks>
		public PositionOptions SetAt(Core.Position.ePosition pos) {
			this.Options.SetAt(pos);
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/position/ for details</remarks>
		public PositionOptions SetAt(Core.Position.ePosition pos1, Core.Position.ePosition pos2) {
			if (pos1 != Position.ePosition.Right && pos2 != Position.ePosition.Top) {
				// avoid menu default position of "right top"
				this.Options.SetAt(pos1, pos2);
			}
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/position/ for details</remarks>
		public PositionOptions SetAt(string pos) {
			this.Options.SetAt(pos);
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/position/ for details</remarks>
		public PositionOptions SetAt(string pos1, string pos2) {
			if (pos1 != "right" && pos2 != "top") {
				// avoid menu default position of "right top"
				this.Options.SetAt(pos1, pos2);
			}
			return this;
		}


		/// <summary>
		/// Element to position against. If you provide a selector, the first matching element 
		/// will be used. If you provide a jQuery object, the first element will be used. If you 
		/// provide an event object, the pageX and pageY properties will be used. Example: "#top-menu"
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/position/ for details</remarks>
		public PositionOptions SetOf(string of) {
			this.Options.SetOf(of);
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
		/// <remarks>See http://api.jqueryui.com/position/ for details</remarks>
		public PositionOptions SetCollision(Collision.eCollision colli) {
			this.Options.SetCollision(colli);
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
		/// <remarks>See http://api.jqueryui.com/position/ for details</remarks>
		public PositionOptions SetCollision(Collision.eCollision colli1, Collision.eCollision colli2) {
			this.Options.SetCollision(colli1, colli2);
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
		/// <remarks>See http://api.jqueryui.com/position/ for details</remarks>
		public PositionOptions SetCollision(string colli) {
			this.Options.SetCollision(colli);
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
		/// <remarks>See http://api.jqueryui.com/position/ for details</remarks>
		public PositionOptions SetCollision(string colli1, string colli2) {
			this.Options.SetCollision(colli1, colli2);
			return this;
		}


		/// <summary>
		/// When specified the actual property setting is delegated to this callback. Receives a 
		/// single parameter which is a hash of top and left values for the position that should be set.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/position/ for details</remarks>
		public PositionOptions SetUsingFunction(string usingFunc) {
			this.Options.SetUsingFunction(usingFunc);
			return this;		
		}		

	}

}
