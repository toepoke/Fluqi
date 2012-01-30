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
	public partial class Events: Core.Options
	{
		/// <summary>
		/// Holds a reference to the <see cref="Slider"/> object these events are for
		/// </summary>
		public Slider Slider { get; set; }


		/// <summary>
		/// Used to flag that configuration of <see cref="Events"/> has finished, and 
		/// returns the <see cref="Slider"/> object so we can continue defining Tabs attributes.
		/// </summary>
		/// <returns>Returns <see cref="Slider"/> object to return chaining to the Tabs collection</returns>
		public Slider Finish() {
			return this.Slider;
		}


		/// <summary>
		/// Builds up a set of events the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			options.AddEventHandler("create", "event, ui", this.CreateEvent);
			options.AddEventHandler("start", "event, ui", this.StartEvent);
			options.AddEventHandler("slide", "event, ui", this.SlideEvent);
			options.AddEventHandler("change", "event, ui", this.ChangeEvent);
			options.AddEventHandler("stop", "event, ui", this.StopEvent);
		}


		/// <summary>
		/// Resets all the control properties back to their default settings (i.e. the
		/// defaults as documented by jQuery UI library
		/// </summary>
		protected void Reset() {
			this.CreateEvent = "";
			this.StartEvent = "";
			this.SlideEvent = "";
			this.ChangeEvent = "";
			this.StopEvent = "";
		}

	} // Events

} // ns Fluqi.jSlider
