using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jSlider {
	
	/// <summary>
	/// The "Methods" are called after the control has been initialised.  If for instance you want to change
	/// the value of a property, or invoke "some" action on the control (e.g. "open" or "close") you 
	/// call the "Method" rather than through the "Options" (as Options is about the initialisation of the control).
	/// </summary>
	public class Methods: Core.Methods {

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="sldr">Slider object to call</param>
		public Methods(Slider sldr) : base(sldr)
		{
		}		


		/// <summary>
		/// Remove the slider functionality completely. This will return the element back to its pre-init state.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#method-destroy for details.</remarks>
		public void Destroy() {
			this.RenderMethodCall("destroy");
		}	

		/// <summary>
		/// Disable the slider.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#method-disable for details.</remarks>
		public void Disable() {
			this.RenderMethodCall("disable");
		}	

		/// <summary>
		/// Enable the slider.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#method-enable for details.</remarks>
		public void Enable() {
			this.RenderMethodCall("enable");
		}	

		/// <summary>
		/// Returns the .ui-slider element.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#method-widget for details.</remarks>
		public void Widget() {
			this.RenderMethodCall("widget");
		}	

		/// <summary>
		/// Gets the value of the slider. For single handle sliders.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#method-value for details.</remarks>
		public void GetValue() {
			this.RenderMethodCall("value");
		}	

		/// <summary>
		/// Sets the value of the slider. For single handle sliders.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#method-value for details.</remarks>
		public void SetValue(int newValue) {
			this.RenderMethodCall("value", newValue);
		}

		/// <summary>
		/// Gets the values of the slider. For multiple handle or range sliders.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#method-values for details.</remarks>
		public void GetValue(int index) {
			this.RenderMethodCall("values", index);
		}	

		/// <summary>
		/// Sets the values of the slider. For multiple handle or range sliders.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#method-values for details.</remarks>
		public void SetValue(int index, int newValue) {
			this.RenderMethodCall("values", index, newValue);
		}	

		/// <summary>
		/// Returns [in JavaScript] the current "animate" setting.
		/// </summary>
		public void GetAnimate() {
			this.RenderGetOptionCall("animate");
		}

		/// <summary>
		/// Whether to slide handle smoothly when user click outside handle on the bar. 
		/// </summary>
		/// <param name="newValue">New animate setting - in milliseconds</param>
		public void SetAnimate(int newValue) {
			this.RenderSetOptionCall("animate", newValue.ToString());
		}

		/// <summary>
		/// Whether to slide handle smoothly when user click outside handle on the bar. 
		/// </summary>
		/// <param name="speed">New animate setting - "slow", "normal", or "fast"</param>
		public void SetAnimate(string speed) {
			this.RenderSetOptionCall("animate", speed.InDoubleQuotes() );
		}

		/// <summary>
		/// Whether to slide handle smoothly when user click outside handle on the bar. Will 
		/// </summary>
		/// <param name="speed">New animate setting - "slow", "normal", or "fast"</param>
		public void SetAnimate(Core.Speed.eSpeed speed) {
			this.RenderSetOptionCall("animate", Core.Speed.SpeedToString(speed).InDoubleQuotes() );
		}

		/// <summary>
		/// Returns [in JavaScript] the current "max" setting.
		/// </summary>
		public void GetMax() {
			this.RenderGetOptionCall("max");
		}

		/// <summary>
		/// The maximum value of the slider.
		/// </summary>
		/// <param name="newValue">New max setting</param>
		public void SetMax(int newValue) {
			this.RenderSetOptionCall("max", newValue.ToString());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "min" setting.
		/// </summary>
		public void GetMin() {
			this.RenderGetOptionCall("min");
		}

		/// <summary>
		/// The minimum value of the slider.
		/// </summary>
		/// <param name="newValue">New min setting</param>
		public void SetMin(int newValue) {
			this.RenderSetOptionCall("min", newValue.ToString());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "orientation" setting.
		/// </summary>
		public void GetOrientation() {
			this.RenderGetOptionCall("orientation");
		}

		/// <summary>
		/// This option determines whether the slider has the min at the left, the max 
		/// at the right or the min at the bottom, the max at the top. 
		/// Possible values: 'horizontal', 'vertical'.
		/// </summary>
		/// <param name="newValue">New orientation setting</param>
		public void SetOrientation(Core.Orientation.eOrientation newValue) {
			string orientationStr = Core.Orientation.OrientationToString(newValue);
			this.RenderSetOptionCall("orientation", orientationStr.InDoubleQuotes() );
		}

		/// <summary>
		/// This option determines whether the slider has the min at the left, the max 
		/// at the right or the min at the bottom, the max at the top. 
		/// Possible values: 'horizontal', 'vertical'.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New orientation setting</param>
		public void SetOrientationJS(string newValue) {
			this.RenderSetOptionCall("orientation", newValue );
		}

		/// <summary>
		/// This option determines whether the slider has the min at the left, the max 
		/// at the right or the min at the bottom, the max at the top. 
		/// Possible values: 'horizontal', 'vertical'.
		/// </summary>
		/// <param name="newValue">New orientation setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetOrientation(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("orientation", newValue, inDoubleQuotes );
		}

		/// <summary>
		/// This option determines whether the slider has the min at the left, the max 
		/// at the right or the min at the bottom, the max at the top. 
		/// Possible values: 'horizontal', 'vertical'.
		/// </summary>
		/// <param name="newValue">New orientation setting</param>
		public void SetOrientation(string newValue) {
			this.SetOrientation(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "range" setting.
		/// </summary>
		public void GetRange() {
			this.RenderGetOptionCall("range");
		}

		/// <summary>
		/// If set to true, the slider will detect if you have two handles and create a stylable 
		/// range element between these two. Two other possible values are 'min' and 'max'. 
		/// A min range goes from the slider min to one handle. 
		/// A max range goes from one handle to the slider max.
		/// </summary>
		/// <param name="newValue">New range setting</param>
		public void SetRange(bool newValue) {
			this.RenderSetOptionCall("range", newValue);
		}

		/// <summary>
		/// Min range goes from the slider min to one handle. 
		/// </summary>
		public void SetRangeToMin() {
			this.RenderSetOptionCall("range", "min".InDoubleQuotes());
		}

		/// <summary>
		/// Max range goes from one handle to the slider max.
		/// </summary>
		public void SetRangeToMax() {
			this.RenderSetOptionCall("range", "max".InDoubleQuotes());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "step" setting.
		/// </summary>
		public void GetStep() {
			this.RenderGetOptionCall("step");
		}

		/// <summary>
		/// Determines the size or amount of each interval or step the slider takes between min and max. 
		/// The full specified value range of the slider (max - min) needs to be evenly divisible by the step.
		/// </summary>
		/// <param name="newValue">New step setting</param>
		public void SetStep(int newValue) {
			this.RenderSetOptionCall("step", newValue.ToString());
		}

	}

}
