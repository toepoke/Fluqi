using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jProgressBar
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
		/// Disables (true) or enables (false) the progressbar. Can be set when initialising (first creating) the progressbar.
		/// </summary>
		/// <param name="disable">Whether the control is disabled or not</param>
		/// <returns>Options object for chainability</returns>
		public Options SetDisabled(bool disable) {
			this.Disabled = disable;
			return this;
		}


		/// <summary>
		/// The value of the progressbar.
		/// </summary>
		/// <param name="value">Element to append menu to (selector to the element, e.g. #my-element)</param>
		/// <returns>Options object for chainability</returns>
		public Options SetValue(int value) {
			this.Value = value;
			return this;
		}

	} // Options

} // ns Fluqi.jAutoComplete
