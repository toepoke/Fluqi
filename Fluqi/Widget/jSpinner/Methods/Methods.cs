using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jSpinner {
	
	/// <summary>
	/// The "Methods" are called after the control has been initialised.  If for instance you want to change
	/// the value of a property, or invoke "some" action on the control (e.g. "open" or "close") you 
	/// call the "Method" rather than through the "Options" (as Options is about the initialisation of the control).
	/// </summary>
	public partial class Methods: Core.Methods {

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="spinner">Spinner object to call</param>
		public Methods(Spinner spinner) : base(spinner)
		{
		}		


		/// <summary>
		/// Removes the spinner functionality completely. This will return the element back to its pre-init state.
		/// </summary>
		public void Destroy() {
		  this.RenderMethodCall("destroy");
		}

		/// <summary>
		/// Disables the spinner.
		/// </summary>
		public void Disable() {
		  this.RenderMethodCall("disable");
		}	

		/// <summary>
		/// Enable the spinner.
		/// </summary>
		public void Enable() {
		  this.RenderMethodCall("enable");
		}	

		/// <summary>
		/// Returns a jQuery object containing the generated wrapper.
		/// </summary>
		public void Widget() {
		  this.RenderMethodCall("widget");
		}	

		/// <summary>
		/// Decrements the value by the specified number of pages, as defined by the page option. 
		/// Without the parameter, a single page is decremented.
		/// </summary>
		public void PageDown(int value = 1) {
		  this.RenderSetOptionCall("pageDown", value);
		}	

		/// <summary>
		/// Decrements the value by the specified number of pages, as defined by the page option. 
		/// Without the parameter, a single page is decremented.
		/// </summary>
		public void PageUp(int value = 1) {
		  this.RenderSetOptionCall("pageUp", value);
		}	

		/// <summary>
		/// Decrements the value by the specified number of steps. Without the parameter, a single step is decremented. 
		/// If the resulting value is above the max, below the min, or reuslts in a step mismatch, 
		/// the value will be adjusted to the closest valid value.
		/// </summary>
		public void StepDown(int value = 1) {
		  this.RenderSetOptionCall("stepDown", value);
		}	

		/// <summary>
		/// Increments the value by the specified number of steps. Without the parameter, a single step is incremented. 
		/// If the resulting value is above the max, below the min, or reuslts in a step mismatch, 
		/// the value will be adjusted to the closest valid value.
		/// </summary>
		public void StepUp(int value = 1) {
		  this.RenderSetOptionCall("stepUp", value);
		}	

		/// <summary>
		/// Gets the current value as a number.
		/// The value is parsed based on the numberFormat and culture options.
		/// </summary>
		public void GetValue() {
			this.RenderGetOptionCall("value");
		}

		/// <summary>
		/// Sets the value
		/// </summary>
		/// <param name="value">The value to set</param>
		public void SetValue(int value) {
			this.RenderSetOptionCall("value", value);
		}

		/// <summary>
		/// Sets the value
		/// </summary>
		/// <param name="value">The value is parsed based on the numberFormat and culture options.</param>
		public void SetValue(string value) {
			this.RenderSetOptionCall("value", value.InDoubleQuotes());
		}

		/// <summary>
		/// Returns whether the Spinner's value is valid given its min, max, and step.
		/// </summary>
		public void GetIsValid() {
			this.RenderMethodCall("isValid");
		}

	}

}
