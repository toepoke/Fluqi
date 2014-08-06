using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;
using Microsoft.VisualBasic;

namespace Fluqi.Widget.jToolTip
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI ToolTip.
	/// </summary>
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Defines animation properties when the tab shows.
		/// </summary>
		public AnimationOptions ShowAnimation { get; set; }

		/// <summary>
		/// Defines animation properties when the tab hides.
		/// </summary>
		public AnimationOptions HideAnimation { get; set; }
		
		/// <summary>
		/// Content of the tooltip
		/// </summary>
		protected internal string Content { get; set; }

		/// <summary>
		/// Disables (true) or enables (false) the control. Can be set when initialising 
		/// (first creating) the control.
		/// </summary>
		protected internal bool Disabled { get; set; }

		/// <summary>
		/// A selector indicating which items should show tooltips. 
		/// Customize if you're using something other then the title attribute for the tooltip content, or 
		/// if you need a different selector for event delegation.
		/// When changing this option, you likely need to also change the content option.
		/// </summary>
		protected internal string Items { get; set; }

		/// <summary>
		/// Configuration for the Position utility. The of property defaults to the target element, but can also be overriden.
		/// Note: In 1.9.0, the default value was { my: "left+15 center", at: "right center", collision: "flipfit" }, 
		/// but this was changed to more closely match native tooltip positioning.
		/// </summary>
		public PositionOptions Position { get; set; }

		/// <summary>
		/// A class to add to the widget, can be used to display various tooltip types, like warnings or errors.
		/// </summary>
		/// <remarks>
		/// This may get replaced by the classes option.
		/// </remarks>
		protected internal string ToolTipClass { get; set; }

		/// <summary>
		/// Whether the tooltip should track (follow) the mouse.
		/// </summary>
		protected internal bool Track { get; set; }

	} // Events

} // ns
