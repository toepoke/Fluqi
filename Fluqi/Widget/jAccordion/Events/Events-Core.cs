using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jAccordion
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Accordion.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	///   header
	/// </remarks>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="accordion">Accordion object to configure events for</param>
		public Events(Accordion accordion)
		 : base()
		{
			this.Accordion = accordion;
			this.Reset();
		}

		/// <summary>
		/// Holds a reference to the <see cref="Accordion"/> object these events are for
		/// </summary>
		public Accordion Accordion { get; set; }

		/// <summary>
		/// Used to flag that configuration of events are completed, and 
		/// returns the <see cref="Accordion"/> object so we can continue defining Accordion attributes.
		/// </summary>
		/// <returns>Returns <see cref="Accordion"/> object to return chaining to the Accordion</returns>
		public Accordion Finish() {
			return this.Accordion;
		}
		

		/// <summary>
		/// Builds up a set of events representing the control events to use when building the JavaScript
		/// initialisation of the Tabs widget.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			options.AddEventHandler("create", "event, ui", this.CreateEvent);
			options.AddEventHandler("change", "event, ui", this.ChangeEvent);
			options.AddEventHandler("beforeActivate", "event, ui", this.BeforeActivateEvent);
		}

		/// <summary>
		/// Resets all the control properties back to their default settings (i.e. the
		/// defaults as documented by jQuery UI library)
		/// </summary>
		protected void Reset() {
			this.CreateEvent = "";
			this.ChangeEvent = "";
			this.BeforeActivateEvent = "";
		}

	} // Events

} // ns Fluqi.jTab
