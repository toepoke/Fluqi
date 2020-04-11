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
	public partial class Events: Core.Options
	{
		/// <summary>
		/// This event is triggered when button is created.
		/// </summary>
		protected internal string CreateEvent { get; set; }

		/// <summary>
		/// This event doesn't actually exist as part of jQuery UI (no seriously, have a look for yourself
		/// https://api.jqueryui.com/button/) or at the very least isn't documented.
		/// But it's a button, chances are you want an event, so we're adding one just for you :)
		/// </summary>
		protected internal string ClickEvent { get; set; }

	} // Events

} // ns Fluqi.jAutoComplete
