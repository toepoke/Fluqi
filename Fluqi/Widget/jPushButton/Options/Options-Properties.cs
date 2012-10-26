using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

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
		/// Icons to display, with or without text (see text option). The primary icon is 
		/// displayed by default on the left of the label text, the secondary by default is on the right. 
		/// Value for the primary and secondary properties must be a classname (String), eg. "ui-icon-gear". 
		/// For using only one icon: icons: {primary:'ui-icon-locked'}. 
		/// For using two icons: icons: {primary:'ui-icon-gear',secondary:'ui-icon-triangle-1-s'}
		/// </summary>
		protected internal string PrimaryIconClass { get; set; }

		/// <summary>
		/// Icons to display, with or without text (see text option). The primary icon is 
		/// displayed by default on the left of the label text, the secondary by default is on the right. 
		/// Value for the primary and secondary properties must be a classname (String), eg. "ui-icon-gear". 
		/// For using only one icon: icons: {primary:'ui-icon-locked'}. 
		/// For using two icons: icons: {primary:'ui-icon-gear',secondary:'ui-icon-triangle-1-s'}
		/// </summary>
		protected internal string SecondaryIconClass { get; set; }

	} // Options

} // ns Fluqi.jAutoComplete
