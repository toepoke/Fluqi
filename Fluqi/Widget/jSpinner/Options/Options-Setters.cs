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
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Sets the culture to use for parsing and formatting the value. 
		/// If null, the currently set culture in Globalize is used, see Globalize docs for available cultures. 
		/// Only relevant if the <see cref="SetNumberFormat"/> option is set. Requires Globalize to be included.
		/// </summary>
		/// <param name="culture"></param>
		/// <remarks>See http://api.jqueryui.com/spinner/#option-culture for details.</remarks>
		public Options SetCulture(string culture) {
			this.Culture = culture;
			return this;
		}


		/// <summary>
		/// Disables the spinner.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/spinner/#option--disabled for details</remarks>
		public Options SetDisabled(bool disabled) {
		  this.Disabled = disabled;
		  return this;
		}

		/// <summary>
		/// Icons to use for buttons, matching an icon defined by the jQuery UI CSS Framework.
		/// </summary>
		/// <param name="downIcon">Icon to use for the down</param>
		/// <param name="upIcon">Icon to use for the up</param>
		/// <remarks>See http://api.jqueryui.com/spinner/#option-icons for details.</remarks>
		public Options SetIcons(string downIcon, string upIcon) {
			this.UpIconClass = upIcon;
			this.DownIconClass = downIcon;
			return this;
		}

		/// <summary>
		/// Icons to use for buttons, matching an icon defined by the jQuery UI CSS Framework.
		/// </summary>
		/// <param name="downIcon">Icon to use for the down</param>
		/// <param name="upIcon">Icon to use for the up</param>
		/// <remarks>See http://api.jqueryui.com/spinner/#option-icons for details.</remarks>
		public Options SetIcons(Core.Icons.eIconClass downIcon, Core.Icons.eIconClass upIcon) {
			this.UpIconClass = Core.Icons.ByEnum(upIcon);
			this.DownIconClass = Core.Icons.ByEnum(downIcon);
			return this;
		}

		/// <summary>
		/// Controls the number of steps taken when holding down a spin button.
		///	- When set to true, the stepping delta will increase when spun incessantly. 
		///	- When set to false, all steps are equal (as defined by the step option).
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/dialog/#option-incremental for details</remarks>
		public Options SetIncremental(bool inc) {
			this.Incremental = inc.JsBool();
			return this;
		}

		/// <summary>
		/// Controls the number of steps taken when holding down a spin button.
		///	- Receives one parameter: the number of spins that have occurred. 
		///		Must return the number of steps that should occur for the current spin.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/dialog/#option-incremental for details</remarks>
		public Options SetIncremental(string incMethod) {
			this.Incremental = incMethod;
			return this;
		}

		/// <summary>
		/// The minimum allowed value
		/// </summary>
		/// <param name="value">The minimum value</param>
		/// <remarks>See http://api.jqueryui.com/dialog/#option-min for details</remarks>
		public Options SetMin(int value) {
			this.Min = value.ToString();
			return this;
		}

		/// <summary>
		/// The minimum allowed value
		/// </summary>
		/// <param name="value">
		/// If Globalize is included, the min option can be passed as a string which will be parsed based on the 
		/// numberFormat and culture options; otherwise it will fall back to the native parseFloat() method.
		/// </param>
		/// <remarks>See http://api.jqueryui.com/dialog/#option-min for details</remarks>
		public Options SetMin(string value) {
			this.Min = value;
			return this;
		}

		/// <summary>
		/// The maximum allowed value
		/// </summary>
		/// <param name="value">The maximum value</param>
		/// <remarks>See http://api.jqueryui.com/dialog/#option-max for details</remarks>
		public Options SetMax(int value) {
			this.Max = value.ToString();
			return this;
		}

		/// <summary>
		/// The maximum allowed value
		/// </summary>
		/// <param name="value">
		/// If Globalize is included, the min option can be passed as a string which will be parsed based on the 
		/// numberFormat and culture options; otherwise it will fall back to the native parseFloat() method.
		/// </param>
		/// <remarks>See http://api.jqueryui.com/dialog/#option-max for details</remarks>
		public Options SetMax(string value) {
			this.Max = value;
			return this;
		}

		/// <summary>
		/// Format of numbers passed to Globalize, if available. 
		/// </summary>
		/// <param name="value">
		/// Most common are "n" for a decimal number and "C" for a currency value. 
		/// Also see the culture option.
		/// </param>
		/// <remarks>See http://api.jqueryui.com/dialog/#option-numberFormat for details</remarks>
		public Options SetNumberFormat(string value) {
			this.NumberFormat = value;
			return this;
		}

		/// <summary>
		/// The number of steps to take when paging via the pageUp/pageDown methods.
		/// </summary>
		/// <param name="value">New value</param>
		/// <remarks>See http://api.jqueryui.com/dialog/#option-page for details</remarks>
		public Options SetPage(int value) {
			this.Page = value;
			return this;
		}

		/// <summary>
		/// The size of the step to take when spinning via buttons or via the stepUp()/stepDown() methods. 
		/// The element's step attribute is used if it exists and the option is not explicitly set.
		/// </summary>
		/// <param name="step">The size of the step</param>
		/// <remarks>See http://api.jqueryui.com/dialog/#option-step for details</remarks>
		public Options SetStep(int step) {
			this.Step = step.ToString();
			return this;
		}

		/// <summary>
		/// The size of the step to take when spinning via buttons or via the stepUp()/stepDown() methods. 
		/// The element's step attribute is used if it exists and the option is not explicitly set.
		/// </summary>
		/// <param name="step">
		/// If Globalize is included, the step option can be passed as a string which will be parsed based on 
		/// the numberFormat and culture options, otherwise it will fall back to the native parseFloat.
		/// </param>
		/// <remarks>See http://api.jqueryui.com/dialog/#option-step for details</remarks>
		public Options SetStep(string step) {
			this.Step = step;
			return this;
		}

	} // Options

} // ns
