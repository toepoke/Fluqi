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
	/// A set of properties to apply to a set of jQuery UI Slider.
	/// </summary>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="spin">Spinner object to configure events for</param>
		public Events(Spinner spin)
		 : base()
		{
			this.Spinner = spin;
			this.Reset();
		}

		/// <summary>
		/// Triggered when the value of the spinner has changed and the input is no longer focused.
		/// </summary>
		protected internal string ChangeEvent { get; set; }

		/// <summary>
		/// Triggered when the spinner is created.
		/// </summary>
		protected internal string CreateEvent { get; set; }

		/// <summary>
		/// Triggered during increment/decrement (to determine direction of spin compare current value with ui.value).
		/// Can be canceled, preventing the value from being updated.
		/// </summary>
		protected internal string SpinEvent { get; set; }

		/// <summary>
		/// Triggered before a spin. Can be canceled, preventing the spin from occurring.
		/// </summary>
		protected internal string StartEvent { get; set; }

		/// <summary>
		/// Triggered after a spin.
		/// </summary>
		protected internal string StopEvent { get; set; }

	} // Events

} // ns Fluqi.jAutoComplete
