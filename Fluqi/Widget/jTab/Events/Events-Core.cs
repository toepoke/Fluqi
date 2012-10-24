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

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Tabs.
	/// </summary>
	/// <remarks>
	/// Properties not supported: 
	///		deselectable (depreciated)
	/// Note "Active" _is_ supported, however it hangs off an individual <see cref="Pane"/>.
	/// </remarks>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="tabs">Tabs object to configure events for</param>
		public Events(Tabs tabs)
		 : base()
		{
			this.Tabs = tabs;
		}

		/// <summary>
		/// Holds a reference to the <see cref="Tabs"/> object these events are for
		/// </summary>
		public Tabs Tabs { get; set; }

		/// <summary>
		/// Used to flag that configuration of <see cref="Options"/> has finished, and 
		/// returns the <see cref="Tabs"/> object so we can continue defining Tabs attributes.
		/// </summary>
		/// <returns>Returns <see cref="Tabs"/> object to return chaining to the Tabs collection</returns>
		public Tabs Finish() {
			return this.Tabs;
		}
		

		/// <summary>
		/// Builds up a set of events the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			options.AddEventHandler("create", "event, ui", this.CreateEvent);
			options.AddEventHandler("beforeActivate", "event, ui", this.BeforeActivateEvent);
			options.AddEventHandler("load", "event, ui", this.LoadEvent);
			options.AddEventHandler("activate", "event, ui", this.ActivateEvent);
			options.AddEventHandler("add", "event, ui", this.AddEvent);
			options.AddEventHandler("remove", "event, ui", this.RemoveEvent);
			options.AddEventHandler("enable", "event, ui", this.EnableEvent);
			options.AddEventHandler("disable", "event, ui", this.DisableEvent);
			options.AddEventHandler("beforeLoad", "event, ui", this.BeforeLoadEvent);
		}

	} // Options

} // ns Fluqi.jTab
