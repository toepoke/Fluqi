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
		protected internal string My { get; set; }

		/// <summary>
		/// Defines which position on the target element to align the positioned element 
		/// against: "horizontal vertical" alignment. A single value such as "right" will 
		/// default to "right center", "top" will default to "center top" (following CSS 
		/// convention). Acceptable values: "top", "center", "bottom", "left", "right". 
		/// Example: "left top" or "center center"
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/position/#option-at for details</remarks>
		protected internal string At { get; set; }

		/// <summary>
		/// Element to position against. If you provide a selector, the first matching element 
		/// will be used. If you provide a jQuery object, the first element will be used. 
		/// If you provide an event object, the pageX and pageY properties will be used. 
		/// Example: "#top-menu"
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/position/#option-of for details</remarks>
		protected internal string Of { get; set; }
		
		/// <summary>
		/// Element to position within, affecting collision detection. If you provide a selector or 
		/// jQuery object, the first matching element will be used.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/position/ for details</remarks>
		protected internal string Within { get; set; }

		/// <summary>
		/// Add these left-top values to the calculated position, eg. "50 50" (left top) A 
		/// single value such as "50" will apply to both.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/position/#option-offset for details</remarks>
		protected internal List<int> Offset { get; set; }

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
		protected internal List<Collision.eCollision> Collision { get; set; }

		/// <summary>
		/// When specified the actual property setting is delegated to this callback. Receives a 
		/// single parameter which is a hash of top and left values for the position that should be set.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/position/#option-using for details</remarks>
		protected internal string UsingFunction { get; set; }

	} // Options

} // ns Fluqi.jPosition
