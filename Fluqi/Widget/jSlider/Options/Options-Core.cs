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
#pragma warning disable 1591
		public const Core.Orientation.eOrientation DEFAULT_ORIENTATION = Core.Orientation.eOrientation.Horizontal;
		public const int    DEFAULT_VALUE = 0;
		public const int    DEFAULT_STEP = 1;
		public const int    DEFAULT_MIN = 0;
		public const int    DEFAULT_MAX = 100;
		public const bool   DEFAULT_ANIMATE = false;
		public const string DEFAULT_SIZE = "100%";
#pragma warning restore 1591

		/// <summary>
		/// Holds a reference to the <see cref="Slider"/> object these options are for
		/// </summary>
		public Slider Slider { get; set; }


		/// <summary>
		/// Used to flag that configuration of <see cref="Options"/> has finished, and 
		/// returns the <see cref="Slider"/> object so we can continue defining Tabs attributes.
		/// </summary>
		/// <returns>Returns <see cref="Slider"/> object to return chaining to the Tabs collection</returns>
		public Slider Finish() {
			return this.Slider;
		}


		/// <summary>
		/// Builds up a set of options the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			bool bValue = false; int nValue = 0;

			// properties
			options.Add(this.Disabled, "disabled", this.Disabled.JsBool());
			if (bool.TryParse(this.Animate, out bValue)) { 
				options.Add( bValue, "animate", bValue.JsBool() );
			} else if (int.TryParse(this.Animate, out nValue)) {
				options.Add( "animate", nValue.ToString() ); 
			} else {
				options.Add( "animate", this.Animate.InDoubleQuotes());
			}
			options.Add(this.Min != DEFAULT_MIN, "min", this.Min.ToString());
			options.Add(this.Max != DEFAULT_MAX, "max", this.Max.ToString());
			options.Add(this.Orientation != DEFAULT_ORIENTATION, "orientation", Core.Orientation.OrientationToString(this.Orientation).InDoubleQuotes());
			if (bool.TryParse(this.Range, out bValue)) {
				options.Add(bValue, "range", bValue.JsBool());
			} else {
				options.Add(!this.IsNullOrEmpty(this.Range), "range", this.Range.InDoubleQuotes());
			}
			options.Add(this.Step != DEFAULT_STEP, "step", this.Step.ToString());
			options.Add(this.Value != DEFAULT_VALUE, "value", this.Value.ToString());
			options.Add(this.Values != null && this.Values.Any(), "values", this.Values.JsArray());
		}


		/// <summary>
		/// Resets all the control properties back to their default settings (i.e. the
		/// defaults as documented by jQuery UI library
		/// </summary>
		protected void Reset() {
			this.Disabled = false;
			this.Animate = DEFAULT_ANIMATE.ToString();
			this.Min = DEFAULT_MIN;
			this.Max = DEFAULT_MAX;
			this.Orientation = DEFAULT_ORIENTATION;
			this.Range = false.ToString();
			this.Step = DEFAULT_STEP;
			this.Value = DEFAULT_VALUE;
			this.Values = new List<int>();
			this.Size = DEFAULT_SIZE;
		}

	} // Options

} // ns Fluqi.jSlider
