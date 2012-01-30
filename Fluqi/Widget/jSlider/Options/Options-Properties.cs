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
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="sldr">Slider to configure options of</param>
		public Options(Slider sldr)
		 : base()
		{
			this.Slider = sldr;
			this.Reset();
		}

		/// <summary>
		/// Disables (true) or enables (false) the control. Can be set when initialising 
		/// (first creating) the control.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#option-disabled for details</remarks>
		protected internal bool Disabled { get; set; }

		/// <summary>
		/// Whether to slide handle smoothly when user click outside handle on the bar. Will 
		/// also accept a string representing one of the three predefined speeds ("slow", 
		/// "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000)
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#option-animate for details</remarks>
		protected internal string Animate { get; set; }

		/// <summary>
		/// The maximum value of the slider.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#option-max for more details</remarks>
		protected internal int Max { get; set; }
			
		/// <summary>
		/// The minimum value of the slider.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#option-min for more details</remarks>
		protected internal int Min { get; set; }

		/// <summary>
		/// This option determines whether the slider has the min at the left, the max at the right or 
		/// the min at the bottom, the max at the top. Possible values: 'horizontal', 'vertical'.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#option-orientation for details</remarks>
		protected internal Core.Orientation.eOrientation Orientation { get; set; }

		/// <summary>
		/// Sets the size (it's a string, so whatever units you want) of the slider.  For 
		/// horizontal slider this is the width or the div (100%), for vertical slider this is the
		/// height of the div (default 5em).
		/// </summary>
		protected internal string Size { get; set; }

		/// <summary>
		/// If set to true, the slider will detect if you have two handles and create a stylable 
		/// range element between these two. Two other possible values are 'min' and 'max'. A 
		/// min range goes from the slider min to one handle. A max range goes from one handle 
		/// to the slider max.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#option-buttonimage for details</remarks>
		protected internal string Range { get; set; }

		/// <summary>
		/// Determines the size or amount of each interval or step the slider takes between min and max. 
		/// The full specified value range of the slider (max - min) needs to be evenly divisible 
		/// by the step.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#option-step for details</remarks>
		protected internal int Step { get; set; }

		/// <summary>
		/// Determines the value of the slider, if there's only one handle. If there is more than one handle, 
		/// determines the value of the first handle.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#option-calculateweek for details</remarks>
		protected internal int Value { get; set; }

		/// <summary>
		/// This option can be used to specify multiple handles. If range is set to true, the length of 
		/// 'values' should be 2.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#option-changemonth for details</remarks>
		protected internal List<int> Values { get; set; }

	} // Events

} // ns Fluqi.jAutoComplete
