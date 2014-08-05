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

namespace Fluqi.Widget.jSpinner
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Spinner.
	/// </summary>
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="spinner">Spinner to configure options of</param>
		public Options(Spinner spinner)
		 : base()
		{
			this.Spinner = spinner;
			this.Reset();
		}

		/// <summary>
		/// Sets the culture to use for parsing and formatting the value. 
		/// If null, the currently set culture in Globalize is used, see Globalize docs for available cultures. Only 
		/// relevant if the numberFormat option is set. Requires Globalize to be included.
		/// </summary>
		protected internal string Culture { get; set; }

		/// <summary>
		/// Disables (true) or enables (false) the control. Can be set when initialising 
		/// (first creating) the control.
		/// </summary>
		protected internal bool Disabled { get; set; }

		/// <summary>
		/// Icons to use for buttons, matching an icon defined by the jQuery UI CSS Framework.
		/// </summary>
		protected internal string UpIconClass { get; set; }

		/// <summary>
		/// Icons to use for buttons, matching an icon defined by the jQuery UI CSS Framework.
		/// </summary>
		protected internal string DownIconClass { get; set; }


		/// <summary>
		/// Controls the number of steps taken when holding down a spin button.
		/// Supports boolean
		///		- When set to true, the stepping delta will increase when spun incessantly. 
		///		- When set to false, all steps are equal (as defined by the step option).
		///	Supports function
		///		- Receives one parameter: the number of spins that have occurred. 
		///			Must return the number of steps that should occur for the current spin.
		/// </summary>
		protected internal string Incremental { get; set; }

		/// <summary>
		/// The minimum allowed value. The element's min attribute is used if it exists and the option is not explicitly set. 
		/// If null, there is no minimum enforced.
		/// Multiple types supported:
		///   - Number: The minimum value.
		///   - String: If Globalize is included, the min option can be passed as a string which will be parsed based on the 
		///     numberFormat and culture options; otherwise it will fall back to the native parseFloat() method.
		/// </summary>
		protected internal string Min { get; set; }

		/// <summary>
		/// The maximum allowed value. The element's max attribute is used if it exists and the option is not explicitly set.
		/// If null, there is no maximum enforced.
		/// Multiple types supported:
		///   - Number: The maximum value.
		///   - String: If Globalize is included, the max option can be passed as a string which will be parsed based on the 
		///     numberFormat and culture options; otherwise it will fall back to the native parseFloat() method.
		/// </summary>
		protected internal string Max { get; set; }

		/// <summary>
		/// Format of numbers passed to Globalize, if available. 
		/// Most common are "n" for a decimal number and "C" for a currency value. 
		/// Also see the culture option.
		/// </summary>
		protected internal string NumberFormat { get; set; }

		/// <summary>
		/// The number of steps to take when paging via the pageUp/pageDown methods.
		/// </summary>
		protected internal int Page { get; set; }

		/// <summary>
		/// The size of the step to take when spinning via buttons or via the stepUp()/stepDown() methods.
		/// The element's step attribute is used if it exists and the option is not explicitly set.
		/// </summary>
		protected internal string Step { get; set; }

	} // Events

} // ns
