using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jAutoComplete
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI AutoComplete.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="ac">Autocomplete object to configure events for</param>
		public Events(AutoComplete ac)
		 : base()
		{
			this.AutoComplete = ac;
			this.Reset();
		}

		/// <summary>
		/// Holds a reference to the <see cref="AutoComplete"/> object these options are for
		/// </summary>
		public AutoComplete AutoComplete { get; set; }


		/// <summary>
		/// Used to flag that configuration of <see cref="Events"/> has finished, and 
		/// returns the <see cref="AutoComplete"/> object so we can continue defining Tabs attributes.
		/// </summary>
		/// <returns>Returns <see cref="AutoComplete"/> object to return chaining to the Tabs collection</returns>
		public AutoComplete Finish() {
			return this.AutoComplete;
		}


		/// <summary>
		/// Builds up a set of events the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			options.AddEventHandler("create", "event, ui", this.CreateEvent);
			options.AddEventHandler("search", "event, ui", this.SearchEvent);
			options.AddEventHandler("response", "event, ui", this.ResponseEvent);
			options.AddEventHandler("open", "event, ui", this.OpenEvent);
			options.AddEventHandler("focus", "event, ui", this.FocusEvent);
			options.AddEventHandler("select", "event, ui", this.SelectEvent);
			options.AddEventHandler("close", "event, ui", this.CloseEvent);
			options.AddEventHandler("change", "event, ui", this.ChangeEvent);
		}


		/// <summary>
		/// Resets all the control properties back to their default settings (i.e. the
		/// defaults as documented by jQuery UI library
		/// </summary>
		protected void Reset() {
			this.CreateEvent = "";
			this.SearchEvent = "";
			this.ResponseEvent = "";
			this.OpenEvent = "";
			this.FocusEvent = "";
			this.CloseEvent = "";
			this.ChangeEvent = "";
		}

	} // Events

} // ns Fluqi.jAutoComplete
