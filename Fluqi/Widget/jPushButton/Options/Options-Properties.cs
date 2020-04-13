using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;
using static Fluqi.Core.IconPosition;

namespace Fluqi.Widget.jPushButton
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI AutoComplete.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Disables (true) or enables (false) the button. Can be set when initialising (first creating) 
		/// the button.
		/// </summary>
		protected internal bool Disabled { get; set; }

		/// <summary>
		/// Whether to show any text - when set to false (display no text), icons (see icons option) 
		/// must be enabled, otherwise it'll be ignored.
		/// </summary>
		protected internal bool Text { get; set; }

		/// <summary>
		/// Icon to display, with or without text (see text option). 
		/// </summary>
		protected internal string Icon { get; set; }

		/// <summary>
		/// Where to display the icon: Valid values are "beginning", "end", "top" and "bottom". 
		/// In a left-to-right (LTR) display, "beginning" refers to the left, in a right-to-left 
		/// (RTL, e.g. in Hebrew or Arabic), it refers to the right.
		/// </summary>
		protected internal string IconPosition { get; set; }

	} // Options

} // ns Fluqi.jAutoComplete
