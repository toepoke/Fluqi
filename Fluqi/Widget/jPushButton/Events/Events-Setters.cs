using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jPushButton
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Button.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// This event is triggered when Button is created.
		/// </summary>
		/// <returns>Events object for chainability</returns>
		public Events SetCreateEvent(string methodSource) {
			this.CreateEvent = methodSource;
			return this;	
		}

		/// <summary>
		/// This event doesn't actually exist as part of jQuery UI (no seriously, have a look for yourself
		/// https://jqueryui.com/demos/button/#events) or at the very least isn't documented.
		/// But it's a button, chances are you want an event, so we're adding one just for you :)
		/// </summary>
		/// <remarks>This is a Fluqi created event, no associated jQuery UI documentation</remarks>
		public Events SetClickEvent(string methodSource) {
			this.ClickEvent = methodSource;
			return this;
		}
		
	} // Events

} // ns Fluqi.jButton
