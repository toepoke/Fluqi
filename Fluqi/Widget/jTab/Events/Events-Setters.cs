using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jTab
{

	public partial class Events: Core.Options
	{
		/// <summary>
		/// This event is triggered when tabs is created.
		/// </summary>
		/// <returns>Events object for chainability</returns>
		/// <remarks>See http://api.jqueryui.com/tabs/#event-create for details</remarks>
		public Events SetCreateEvent(string methodSource) {
			this.CreateEvent = methodSource;
			return this;	
		}


		/// <summary>
		/// This event is triggered after clicking a tab.
		/// </summary>
		/// <returns>Events object for chainability</returns>
		/// <remarks>See http://api.jqueryui.com/tabs/#event-beforeActivate for details</remarks>
		public Events SetBeforeActivateEvent(string methodSource) {
			this.BeforeActivateEvent = methodSource;
			return this;	
		}


		/// <summary>
		/// This event is triggered after the content of a remote tab has been loaded.
		/// </summary>
		/// <returns>Events object for chainability</returns>
		/// <remarks>See http://api.jqueryui.com/tabs/#event-load for details</remarks>
		public Events SetLoadEvent(string methodSource) {
			this.LoadEvent = methodSource;
			return this;	
		}


		/// <summary>
		/// This event is triggered when a tab activates (after any animation completes).
		/// </summary>
		/// <returns>Events object for chainability</returns>
		/// <remarks>See http://api.jqueryui.com/tabs/#event-activate for details</remarks>
		public Events SetActivateEvent(string methodSource) {
			this.ActivateEvent = methodSource;
			return this;	
		}


		/// <summary>
		/// This event is triggered when a tab is just about to be loaded.
		/// </summary>
		/// <returns>Events object for chainability</returns>
		/// <remarks>See http://api.jqueryui.com/tabs/#event-beforeLoad for details</remarks>
		public void SetBeforeLoadEvent(string methodSource) {
			this.BeforeLoadEvent = methodSource;
		}


	} // Events

} // ns Fluqi.jTab
