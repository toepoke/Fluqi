using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jAutoComplete
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
		/// Flags whether the "disabled" flag is on or off (default is "false").
		/// </summary>
		protected internal bool Disabled { get; set; }

		/// <summary>
		/// Which element the menu should be appended to.
		/// </summary>
		protected internal string AppendTo { get; set; }

		/// <summary>
		/// If set to true the first item will be automatically focused.
		/// </summary>
		protected internal bool AutoFocus { get; set; }

		/// <summary>
		/// The delay in milliseconds the Autocomplete waits after a keystroke to activate itself. A zero-delay 
		/// makes sense for local data (more responsive), but can produce a lot of load for remote data, 
		/// while being less responsive.
		/// </summary>
		protected internal int Delay { get; set; }

		/// <summary>
		/// The minimum number of characters a user has to type before the Autocomplete activates. Zero is 
		/// useful for local data with just a few items. Should be increased when there are a lot of items, 
		/// where a single character would match a few thousand items.
		/// </summary>
		protected internal int MinimumLength { get; set; }

		/// <summary>
		/// Defines the data to use, must be specified.
		/// </summary>
		protected internal string Source { get; set; }

	} // Options

} // ns Fluqi.jAutoComplete
