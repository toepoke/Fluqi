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
		/// Constructor
		/// </summary>
		/// <param name="sldr">Slider object to configure events for</param>
		public Events(Slider sldr)
		 : base()
		{
			this.Slider = sldr;
			this.Reset();
		}

		/// <summary>
		/// This event is triggered when slider is created.
		/// </summary>
		protected internal string CreateEvent { get; set; }

		/// <summary>
		/// This event is triggered when the user starts sliding.
		/// </summary>
		protected internal string StartEvent { get; set; }

		/// <summary>
		/// This event is triggered on every mouse move during slide. Use ui.value (single-handled 
		/// sliders) to obtain the value of the current handle, $(..).slider('value', index) 
		/// to get another handles' value.
		/// </summary>
		protected internal string SlideEvent { get; set; }

		/// <summary>
		/// This event is triggered on slide stop, or if the value is changed programmatically (by 
		/// the value method). Takes arguments event and ui. Use event.orginalEvent to detect 
		/// whether the value changed by mouse, keyboard, or programmatically. Use ui.value 
		/// (single-handled sliders) to obtain the value of the current handle, 
		/// $(this).slider('values', index) to get another handle's value.
		/// </summary>
		protected internal string ChangeEvent { get; set; }

		/// <summary>
		/// This event is triggered when the user stops sliding.
		/// </summary>
		protected internal string StopEvent { get; set; }

	} // Events

} // ns Fluqi.jAutoComplete
