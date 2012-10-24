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
		public Events SetCreateEvent(string methodSource) {
			this.CreateEvent = methodSource;
			return this;	
		}


		/// <summary>
		/// This event is triggered after clicking a tab.
		/// </summary>
		/// <returns>Events object for chainability</returns>
		public Events SetBeforeActivateEvent(string methodSource) {
			this.BeforeActivateEvent = methodSource;
			return this;	
		}


		/// <summary>
		/// This event is triggered after the content of a remote tab has been loaded.
		/// </summary>
		/// <returns>Events object for chainability</returns>
		public Events SetLoadEvent(string methodSource) {
			this.LoadEvent = methodSource;
			return this;	
		}


		/// <summary>
		/// This event is triggered when a tab activates (after any animation completes).
		/// </summary>
		/// <returns>Events object for chainability</returns>
		public Events SetActivateEvent(string methodSource) {
			this.ActivateEvent = methodSource;
			return this;	
		}


		/// <summary>
		/// This event is triggered when a tab is just about to be loaded.
		/// </summary>
		/// <returns>Events object for chainability</returns>
		public void SetBeforeLoadEvent(string methodSource) {
			this.BeforeLoadEvent = methodSource;
		}


	} // Events

} // ns Fluqi.jTab
