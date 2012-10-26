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
		protected internal string CreateEvent { get; set; }

		/// <summary>
		/// This event is triggered after clicking a tab.
		/// </summary>
		protected internal string BeforeActivateEvent { get; set; }

		/// <summary>
		/// This event is triggered after the content of a remote tab has been loaded.
		/// </summary>
		protected internal string LoadEvent { get; set; }

		/// <summary>
		/// This event is triggered when a tab is activated (after any animation has completed).
		/// </summary>
		protected internal string ActivateEvent { get; set; }

		/// <summary>
		/// This event is triggered when a remote tab is about to be loaded, after the before the
		/// beforeActivate event.  Can be cancelled to prevent the tab panel from loading content; 
		/// though the panel will still be activated.
		/// This event is triggered just before the Ajax request is made, so modifications can be 
		/// made to ui.jQXHR and ui.ajaxSettings.
		/// </summary>
		protected internal string BeforeLoadEvent { get; set; }

	} // Options

} // ns Fluqi.jTab
