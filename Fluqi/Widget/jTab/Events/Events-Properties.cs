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
		/// <remarks>See http://jqueryui.com/demos/tabs/#event-create for details</remarks>
		protected internal string CreateEvent { get; set; }

		/// <summary>
		/// This event is triggered when clicking a tab.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#event-select for details</remarks>
		protected internal string SelectEvent { get; set; }

		/// <summary>
		/// This event is triggered after the content of a remote tab has been loaded.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#event-load for details</remarks>
		protected internal string LoadEvent { get; set; }

		/// <summary>
		/// This event is triggered when a tab is shown.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#event-show for details</remarks>
		protected internal string ShowEvent { get; set; }

		/// <summary>
		/// This event is triggered when a tab is added.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#event-add for details</remarks>
		protected internal string AddEvent { get; set; }

		/// <summary>
		/// This event is triggered when a tab is removed.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#event-remove for details</remarks>
		protected internal string RemoveEvent { get; set; }

		/// <summary>
		/// This event is triggered when a tab is enabled.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#event-enable for details</remarks>
		protected internal string EnableEvent { get; set; }

		/// <summary>
		/// This event is triggered when a tab is disabled.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#event-disable for details</remarks>
		protected internal string DisableEvent { get; set; }

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
