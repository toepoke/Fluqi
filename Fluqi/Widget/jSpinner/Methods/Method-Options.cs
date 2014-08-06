using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jSpinner {
	
	/// <summary>
	/// Methods for changing options (after initialisation).
	/// </summary>
	public partial class Methods: Core.Methods {

		/// <summary>
		/// Returns [in JavaScript] the current "culture" setting.
		/// </summary>
		public void GetCulture() {
		  this.RenderGetOptionCall("culture");
		}

		/// <summary>
		/// Sets the culture to use for parsing and formatting the value. 
		/// If null, the currently set culture in Globalize is used, see Globalize docs for available cultures. 
		/// Only relevant if the <see cref="SetNumberFormat"/> option is set. Requires Globalize to be included.
		/// </summary>
		/// <param name="culture"></param>
		public void SetCulture(string culture) {
			this.RenderSetOptionCall("culture", culture.InDoubleQuotes());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "disabled" setting.
		/// </summary>
		public void GetDisabled() {
			this.RenderGetOptionCall("disabled");
		}

		/// <summary>
		/// Disables the spinner.
		/// </summary>
		public void SetDisabled(bool disabled) {
			this.RenderSetOptionCall("disabled", disabled);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "icons" setting.
		/// </summary>
		public void GetIcons() {
			this.RenderGetOptionCall("icons");
		}

		/// <summary>
		/// Icons to use for buttons, matching an icon defined by the jQuery UI CSS Framework.
		/// </summary>
		/// <param name="downIcon">Icon to use for the down</param>
		/// <param name="upIcon">Icon to use for the up</param>
		public void SetIcons(string downIcon, string upIcon) {
			downIcon = downIcon ?? "";
			upIcon = upIcon ?? "";

			this.RenderSetOptionCall("icons", 
				string.Format("{{ down:\"{0}\", up:\"{1}\" }}", downIcon, upIcon)
			);
		}

		/// <summary>
		/// Icons to use for buttons, matching an icon defined by the jQuery UI CSS Framework.
		/// </summary>
		/// <param name="downIcon">Icon to use for the down</param>
		/// <param name="upIcon">Icon to use for the up</param>
		public void SetIcons(Core.Icons.eIconClass downIcon, Core.Icons.eIconClass upIcon) {
			string down = Core.Icons.ByEnum(downIcon);
			string up = Core.Icons.ByEnum(upIcon);

			this.SetIcons(down, up);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "incremental" setting.
		/// </summary>
		public void GetIncremental() {
			this.RenderGetOptionCall("incremental");
		}

		/// <summary>
		/// Controls the number of steps taken when holding down a spin button.
		///	- When set to true, the stepping delta will increase when spun incessantly. 
		///	- When set to false, all steps are equal (as defined by the step option).
		/// </summary>
		public void SetIncremental(bool inc) {
			this.RenderSetOptionCall("incremental", inc);
		}

		/// <summary>
		/// Controls the number of steps taken when holding down a spin button.
		///	- Receives one parameter: the number of spins that have occurred. 
		///		Must return the number of steps that should occur for the current spin.
		/// </summary>
		public void SetIncremental(string incMethod) {
			this.RenderSetOptionCall("incremental", incMethod);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "min" setting.
		/// </summary>
		public void GetMin() {
			this.RenderGetOptionCall("min");
		}

		/// <summary>
		/// The minimum allowed value
		/// </summary>
		/// <param name="value">The minimum value</param>
		public void SetMin(int value) {
			this.RenderSetOptionCall("min", value);
		}

		/// <summary>
		/// The minimum allowed value
		/// </summary>
		/// <param name="value">
		/// If Globalize is included, the min option can be passed as a string which will be parsed based on the 
		/// numberFormat and culture options; otherwise it will fall back to the native parseFloat() method.
		/// </param>
		public void SetMin(string value) {
			this.RenderSetOptionCall("min", value.InDoubleQuotes());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "max" setting.
		/// </summary>
		public void GetMax() {
			this.RenderGetOptionCall("max");
		}

		/// <summary>
		/// The maximum allowed value
		/// </summary>
		/// <param name="value">The maximum value</param>
		public void SetMax(int value) {
			this.RenderSetOptionCall("max", value);
		}

		/// <summary>
		/// The maximum allowed value
		/// </summary>
		/// <param name="value">
		/// If Globalize is included, the min option can be passed as a string which will be parsed based on the 
		/// numberFormat and culture options; otherwise it will fall back to the native parseFloat() method.
		/// </param>
		public void SetMax(string value) {
			this.RenderSetOptionCall("max", value.InDoubleQuotes());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "numberFormat" setting.
		/// </summary>
		public void GetNumberFormat() {
			this.RenderGetOptionCall("numberFormat");
		}

		/// <summary>
		/// Format of numbers passed to Globalize, if available. 
		/// </summary>
		/// <param name="value">
		/// Most common are "n" for a decimal number and "C" for a currency value. 
		/// Also see the culture option.
		/// </param>
		public void SetNumberFormat(string value) {
			this.RenderSetOptionCall("numberFormat", value.InDoubleQuotes());
		}
		
		/// <summary>
		/// Returns [in JavaScript] the current "page" setting.
		/// </summary>
		public void GetPage() {
			this.RenderGetOptionCall("page");
		}

		/// <summary>
		/// The number of steps to take when paging via the pageUp/pageDown methods.
		/// </summary>
		/// <param name="value">New value</param>
		public void SetPage(int value) {
			this.RenderSetOptionCall("page", value);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "step" setting.
		/// </summary>
		public void GetStep() {
			this.RenderGetOptionCall("step");
		}

		/// <summary>
		/// The size of the step to take when spinning via buttons or via the stepUp()/stepDown() methods. 
		/// The element's step attribute is used if it exists and the option is not explicitly set.
		/// </summary>
		/// <param name="value">The size of the step</param>
		public void SetStep(int value) {
			this.RenderSetOptionCall("step", value);
		}

		/// <summary>
		/// The size of the step to take when spinning via buttons or via the stepUp()/stepDown() methods. 
		/// The element's step attribute is used if it exists and the option is not explicitly set.
		/// </summary>
		/// <param name="value">
		/// If Globalize is included, the step option can be passed as a string which will be parsed based on 
		/// the numberFormat and culture options, otherwise it will fall back to the native parseFloat.
		/// </param>
		public void SetStep(string value) {
			this.RenderSetOptionCall("step", value.InDoubleQuotes());
		}

	}

}
