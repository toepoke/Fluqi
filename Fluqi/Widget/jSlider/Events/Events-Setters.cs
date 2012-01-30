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
	public partial class Events: Core.Options
	{
		/// <summary>
		/// This event is triggered when slider is created.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#event-create for details</remarks>
		public Events SetCreateEvent(string createEvent) {
			this.CreateEvent = createEvent;
			return this;
		}


		/// <summary>
		/// This event is triggered when the user starts sliding.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#event-start for details</remarks>
		public Events SetStartEvent(string startEvent) {
			this.StartEvent = startEvent;
			return this;
		}


		/// <summary>
		/// This event is triggered on every mouse move during slide. Use ui.value (single-handled 
		/// sliders) to obtain the value of the current handle, $(..).slider('value', index) 
		/// to get another handles' value.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#event-slide for details</remarks>
		public Events SetSlideEvent(string slideEvent) {
			this.SlideEvent = slideEvent;
			return this;
		}


		/// <summary>
		/// This event is triggered on slide stop, or if the value is changed programmatically (by 
		/// the value method). Takes arguments event and ui. Use event.orginalEvent to detect 
		/// whether the value changed by mouse, keyboard, or programmatically. Use ui.value 
		/// (single-handled sliders) to obtain the value of the current handle, 
		/// $(this).slider('values', index) to get another handle's value.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#event-change for details</remarks>
		public Events SetChangeEvent(string changeEvent) {
			this.ChangeEvent = changeEvent;
			return this;
		}


		/// <summary>
		/// This event is triggered when the user stops sliding.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/slider/#event-stop for details</remarks>
		public Events SetStopEvent(string stopEvent) {
			this.StopEvent = stopEvent;
			return this;
		}

	} // Events

} // ns Fluqi.jAutoComplete
