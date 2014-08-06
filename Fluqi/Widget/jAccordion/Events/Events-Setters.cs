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
	/// A set of events to apply to a set of jQuery UI Accordion.
	/// </summary>
	public partial class Events: Core.Options {

		/// <summary>
		/// This event is triggered every time the accordion changes. If the accordion is 
		/// animated, the event will be triggered upon completion of the animation; otherwise, 
		/// it is triggered immediately.
		/// </summary>
		/// <returns>Events object for chainability</returns>
		public Events SetActivateEvent(string methodSource) {
			this.ActivateEvent = methodSource;
			return this;	
		}


		/// <summary>
		/// This event is triggered every time the accordion starts to change.
		/// </summary>
		/// <returns>Events object for chainability</returns>
		public Events SetBeforeActivateEvent(string methodSource) {
			this.BeforeActivateEvent = methodSource;
			return this;	
		}


		/// <summary>
		/// This event is triggered when accordion is created.
		/// </summary>
		/// <returns>Events object for chainability</returns>
		public Events SetCreateEvent(string methodSource) {
			this.CreateEvent = methodSource;
			return this;	
		}
		
	} // Events

} // ns Fluqi.jTab
