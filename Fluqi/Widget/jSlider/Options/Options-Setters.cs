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

namespace Fluqi.Widget.jSlider
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Slider.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Disables (true) or enables (false) the control. Can be set when initialising 
		/// (first creating) the control.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/slider/#option-disabled for details</remarks>
		public Options SetDisabled(bool disabled) {
			this.Disabled = disabled;
			return this;
		}


		/// <summary>
		/// Flags wether the slide handle smoothly when user clicks outside the handle on the bar.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/slider/#option-changemonth for details</remarks>
		public Options SetAnimate(bool animate) {
			this.Animate = animate.ToString();
			return this;
		}


		/// <summary>
		/// Whether to slide handle smoothly when user click outside handle on the bar. Will 
		/// accept a string representing one of the three predefined speeds ("slow", 
		/// "normal", or "fast") 
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/slider/#option-animate for details</remarks>
		public Options SetAnimate(string animate) {
			this.Animate = animate;
			return this;
		}


		/// <summary>
		/// Whether to slide handle smoothly when user click outside handle on the bar. 
		/// Currently can be the constants defined by jQuery - "slow", "normal", or "fast".
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/slider/#option-animate for details</remarks>
		public Options SetAnimate(Core.Speed.eSpeed speed) {
			string speedStr = Core.Speed.SpeedToString(speed);
			this.Animate = speedStr;
			return this;
		}


		/// <summary>
		/// Whether to slide handle smoothly when user click outside handle on the bar. 
		/// The number of milliseconds to run the animation (e.g. 1000)
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/slider/#option-animate for details</remarks>
		public Options SetAnimate(int animateMillis) {
			this.Animate = animateMillis.ToString();
			return this;
		}


		/// <summary>
		/// The minimum value of the slider.
		/// </summary>		
		/// <remarks>See http://api.jqueryui.com/slider/#option-min for details</remarks>
		public Options SetMin(int min) {
			this.Min = min;
			return this;
		}


		/// <summary>
		/// The maximum value of the slider.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/slider/#option-max for details</remarks>
		public Options SetMax(int max) {
			this.Max = max;
			return this;
		}
			

		/// <summary>
		/// This option determines whether the slider has the min at the left, the max at the right or 
		/// the min at the bottom, the max at the top. Possible values: 'horizontal', 'vertical'.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/slider/#option-orientation for details</remarks>
		public Options SetOrientation(Core.Orientation.eOrientation orientation) {
			this.Orientation = orientation;
			return this;
		}


		/// <summary>
		/// This option determines whether the slider has the min at the left, the max at the right or 
		/// the min at the bottom, the max at the top. Possible values: 'horizontal', 'vertical'.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/slider/#option-orientation for details</remarks>
		public Options SetOrientation(string orientation) {
			this.Orientation = Fluqi.Core.Orientation.StringToOrientation(orientation);
			return this;
		}


		/// <summary>
		/// Sets the size (it's a string, so whatever units you want) of the slider.  For 
		/// horizontal slider this is the width or the div (100%), for vertical slider this is the
		/// height of the div (default 5em).
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/slider/#option-size for details</remarks>
		public Options SetSize(string size) {
			this.Size = size;
			return this;
		}


		/// <summary>
		/// If set to true, the slider will detect if you have two handles and create a stylable 
		/// range element between these two. Two other possible values are 'min' and 'max'. A 
		/// min range goes from the slider min to one handle. A max range goes from one handle 
		/// to the slider max.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/slider/#option-range for details</remarks>
		public Options SetRange(bool range) {
			this.Range = range.ToString();
			return this;
		}


		/// <summary>
		/// If set to true, the slider will detect if you have two handles and create a stylable 
		/// range element between these two. Two other possible values are 'min' and 'max'. A 
		/// min range goes from the slider min to one handle. A max range goes from one handle 
		/// to the slider max.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/slider/#option-range for details</remarks>
		public Options SetRange(string range) {
			this.Range = range;
			return this;
		}


		/// <summary>
		/// Determines the size or amount of each interval or step the slider takes between min and max. 
		/// The full specified value range of the slider (max - min) needs to be evenly divisible 
		/// by the step.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/slider/#option-step for details</remarks>
		public Options SetStep(int step) {
			this.Step = step;
			return this;
		}


		/// <summary>
		/// The text to display on the trigger button. Use in conjunction with showOn equal to 'button' or 'both'.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/slider/#option-value for details</remarks>
		public Options SetValue(int value) {
			this.Value = value;
			return this;
		}


		/// <summary>
		/// This option can be used to specify multiple handles. If range is set to true, the length of 
		/// 'values' should be 2.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/slider/#option-values for details</remarks>
		public Options SetValues(List<int> values) {
			this.Values = values;
			return this;
		}


		/// <summary>
		/// This option can be used to specify multiple handles. If range is set to true, the length of 
		/// 'values' should be 2.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/slider/#option-values for details</remarks>
		public Options SetValues(params int[] values) {
			this.Values = new List<int>(values);
			return this;
		}


		/// <summary>
		/// This option can be used to specify multiple handles. If range is set to true, the length of 
		/// 'values' should be 2.
		/// This entry point expects a number separated list (e.g. "1,3,5")
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/slider/#option-values for details</remarks>
		public Options SetValues(string values) {
			if (string.IsNullOrEmpty(values))
				// nothing to see here
				return this;

			string[] strValues = values.Split(new char[] {','});
			this.Values = (from v in strValues select int.Parse(v) ).ToList<int>();

			return this;
		}

	} // Options

} // ns Fluqi.jAutoComplete
