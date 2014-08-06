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

namespace Fluqi.Widget.jSelectMenu
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI SelectMenu.
	/// </summary>
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Disables the control if set to true.
		/// </summary>
		protected internal bool Disabled { get; set; }

		/// <summary>
		/// Icons to use for opening the control, matching an icon defined by the jQuery UI CSS Framework.
		/// (string, default: "ui-icon-triangle-1-s")
		/// </summary>
		protected internal string Icons { get; set; }

		/// <summary>
		/// Which element to append the menu to
		/// </summary>
		protected internal string AppendTo { get; set; }

		/// <summary>
		/// Identifies the position of the menu in relation to the associated button element
		/// </summary>
		public PositionOptions Position { get; set; }

		/// <summary>
		/// The width of the menu, in pixels
		/// </summary>
		protected internal int? Width { get; set; }

	} 

} // ns
