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
		/// This event is triggered when clicking a tab.
		/// </summary>
		/// <returns>Events object for chainability</returns>
		public Events SetSelectEvent(string methodSource) {
			this.SelectEvent = methodSource;
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
		/// This event is triggered when a tab is shown.
		/// </summary>
		/// <returns>Events object for chainability</returns>
		public Events SetShowEvent(string methodSource) {
			this.ShowEvent = methodSource;
			return this;	
		}


		/// <summary>
		/// This event is triggered when a tab is added.
		/// </summary>
		/// <returns>Events object for chainability</returns>
		public Events SetAddEvent(string methodSource) {
			this.AddEvent = methodSource;
			return this;	
		}


		/// <summary>
		/// This event is triggered when a tab is removed.
		/// </summary>
		/// <returns>Events object for chainability</returns>
		public Events SetRemoveEvent(string methodSource) {
			this.RemoveEvent = methodSource;
			return this;	
		}

		
		/// <summary>
		/// This event is triggered when a tab is enabled.
		/// </summary>
		/// <returns>Events object for chainability</returns>
		public Events SetEnableEvent(string methodSource) {
			this.EnableEvent = methodSource;
			return this;	
		}


		/// <summary>
		/// This event is triggered when a tab is disabled.
		/// </summary>
		/// <returns>Events object for chainability</returns>
		public Events SetDisableEvent(string methodSource) {
			this.DisableEvent = methodSource;
			return this;	
		}

	} // Events

} // ns Fluqi.jTab
