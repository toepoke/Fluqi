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
		/// Disables (true) or enables (false) the autocomplete. Can be set when initialising (first creating) the autocomplete.	
		/// </summary>
		/// <param name="disable">Whether the control is disabled or not</param>
		/// <returns>Options object for chainability</returns>
		public Options SetDisabled(bool disable) {
			this.Disabled = disable;
			return this;
		}


		/// <summary>
		/// Which element the menu should be appended to.
		/// </summary>
		/// <param name="appendTo">Element to append menu to (selector to the element, e.g. #my-element)</param>
		/// <returns>Options object for chainability</returns>
		/// <remarks>See http://api.jqueryui.com/autocomplete/#option-appendTo for details</remarks>
		public Options SetAppendTo(string appendTo) {
			this.AppendTo = appendTo;
			return this;
		}


		/// <summary>
		/// If set to true the first item will be automatically focused.
		/// </summary>
		/// <param name="autoFocus">Flag</param>
		/// <returns>Options object for chainability</returns>
		/// <remarks>See http://api.jqueryui.com/autocomplete/#option-autoFocus for details</remarks>
		public Options SetAutoFocus(bool autoFocus) {
			this.AutoFocus = autoFocus;
			return this;
		}


		/// <summary>
		/// The delay in milliseconds the Autocomplete waits after a keystroke to activate itself. A zero-delay 
		/// makes sense for local data (more responsive), but can produce a lot of load for remote data, 
		/// while being less responsive.
		/// </summary>
		/// <param name="delay">Delay (in milliseconds).  By default this is 300</param>
		/// <returns>Options object for chainability</returns>
		/// <remarks>See http://api.jqueryui.com/autocomplete/#option-delay for details</remarks>
		public Options SetDelay(int delay) {
			this.Delay = delay;
			return this;
		}


		/// <summary>
		/// The minimum number of characters a user has to type before the Autocomplete activates. Zero is 
		/// useful for local data with just a few items. Should be increased when there are a lot of items, 
		/// where a single character would match a few thousand items.
		/// </summary>
		/// <param name="minLength">Min length (default is 1)</param>
		/// <returns>Options object for chainability</returns>
		/// <remarks>See http://api.jqueryui.com/autocomplete/#option-minLength for details</remarks>
		public Options SetMinimumLength(int minLength) {
			this.MinimumLength = minLength;
			return this;
		}


	} // Options

} // ns Fluqi.jAutoComplete
