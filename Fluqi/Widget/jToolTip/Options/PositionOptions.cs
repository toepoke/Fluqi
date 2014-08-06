using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Core;

namespace Fluqi.Widget.jToolTip {
	
	/// <summary>
	/// Models the Position child for setting placement of the tooltip control.
	/// </summary>
	public class PositionOptions {
#pragma warning disable 1591
		public const string DEFAULT_POSITION_MY = "left top+15";
		public const string DEFAULT_POSITION_AT = "left bottom";
		public const string DEFAULT_POSITION_COLLISION = "flipfit";
#pragma warning restore 1591
		
		/// <summary>
		/// Reference to the Tooltip object to return control to.
		/// </summary>
		protected internal jToolTip.Options _TipOptions { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="options">Tooltip options object</param>
		public PositionOptions(Options options) 
		 : base()
		{
			_TipOptions = options;
			Options = new Utilities.jPosition.Options(null);
			this.Options.MyDefault = DEFAULT_POSITION_MY;
			this.Options.AtDefault = DEFAULT_POSITION_AT;
			this.Options.CollisionDefault = DEFAULT_POSITION_COLLISION;
		}

		/// <summary>
		/// Flags the end of the options configuration and returns the Fluent interface back to the tooltip
		/// object.
		/// </summary>
		/// <returns>Control back to the ToolTip object</returns>
		public jToolTip.Options Finish() {
			return _TipOptions;
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
		public PositionOptions SetMy(Core.Position.ePosition pos1, Core.Position.ePosition pos2) {
			this.Options.SetMy(pos1, pos2);
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
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
		public PositionOptions SetMy(string pos1, string pos2) {
			this.Options.SetMy(pos1, pos2);
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
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
		public PositionOptions SetAt(Core.Position.ePosition pos1, Core.Position.ePosition pos2) {
			this.Options.SetAt(pos1, pos2);
			return this;
		}


		/// <summary>
		/// Defines which position on the element being positioned to align with the target 
		/// element: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
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
		public PositionOptions SetAt(string pos1, string pos2) {
			this.Options.SetAt(pos1, pos2);
			return this;
		}


		/// <summary>
		/// Element to position against. If you provide a selector, the first matching element 
		/// will be used. If you provide a jQuery object, the first element will be used. If you 
		/// provide an event object, the pageX and pageY properties will be used. Example: "#top-menu"
		/// </summary>
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
		public PositionOptions SetCollision(string colli1, string colli2) {
			this.Options.SetCollision(colli1, colli2);
			return this;
		}


		/// <summary>
		/// When specified the actual property setting is delegated to this callback. Receives a 
		/// single parameter which is a hash of top and left values for the position that should be set.
		/// </summary>
		public PositionOptions SetUsingFunction(string usingFunc) {
			this.Options.SetUsingFunction(usingFunc);
			return this;		
		}		

	}

}
