using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jTab
{

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
		/// Flags whether the "disabled" flag is on or off (default is "false").
		/// </summary>
		protected internal bool Disabled { get; set; }

		/// <summary>
		/// An array containing the position of the tabs (zero-based index) that should be disabled on initialization.
		/// </summary>
		protected internal List<int> DisabledArray { get; set; }

		/// <summary>
		/// Stores whether the tabs are initialised with the collapsible option on or off (default is "false").
		/// </summary>
		protected internal bool Collapsible { get; set; }

		/// <summary>
		/// Stores the event [override] to be used when opening/closing tabs (default is "click").
		/// </summary>
		protected internal string Evt { get; set; }

		/// <summary>
		/// Stores the height of the tab panel.  Possible values are "auto", "fill" and "content".
		/// </summary>
		protected internal string HeightStyle { get; set; }

	} // Options

} // ns Fluqi.jTab
