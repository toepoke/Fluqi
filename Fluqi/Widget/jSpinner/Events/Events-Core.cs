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
		/// Holds a reference to the <see cref="Spinner"/> object these events are for
		/// </summary>
		public Spinner Spinner { get; set; }


		/// <summary>
		/// Used to flag that configuration of <see cref="Events"/> has finished, and 
		/// returns the <see cref="Spinner"/> object so we can continue defining attributes.
		/// </summary>
		/// <returns>Returns <see cref="Spinner"/> object to return chaining to the collection</returns>
		public Spinner Finish() {
			return this.Spinner;
		}


		/// <summary>
		/// Builds up a set of events the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			options.AddEventHandler("change", "event, ui", this.ChangeEvent);
			options.AddEventHandler("create", "event, ui", this.CreateEvent);
			options.AddEventHandler("spin", "event, ui", this.SpinEvent);
			options.AddEventHandler("start", "event, ui", this.StartEvent);
			options.AddEventHandler("stop", "event, ui", this.StopEvent);
		}


		/// <summary>
		/// Resets all the control properties back to their default settings (i.e. the
		/// defaults as documented by jQuery UI library
		/// </summary>
		protected void Reset() {
			this.ChangeEvent = "";
			this.CreateEvent = "";
			this.StartEvent = "";
			this.SpinEvent = "";
			this.StopEvent = "";
		}

	} // Events

} // ns