using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jProgressBar
{

	/// <summary>
	/// A set of events to apply to a set of jQuery UI AutoComplete.
	/// </summary>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="pb">ProgressBar object to configure events for</param>
		public Events(ProgressBar pb)
		 : base()
		{
			this.ProgressBar = pb;
			// initialise the Position object 
			// ... (we won't be calling the Render directly, so we're OK giving it no valid data)
			this.Reset();
		}

		/// <summary>
		/// Holds a reference to the <see cref="ProgressBar"/> object these events are for
		/// </summary>
		public ProgressBar ProgressBar { get; set; }


		/// <summary>
		/// Used to flag that configuration of <see cref="Events"/> has finished, and 
		/// returns the <see cref="ProgressBar"/> object so we can continue defining Tabs attributes.
		/// </summary>
		/// <returns>Returns <see cref="ProgressBar"/> object to return chaining to the ProgressBar collection</returns>
		public ProgressBar Finish() {
			return this.ProgressBar;
		}


		/// <summary>
		/// Builds up a set of events the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			options.AddEventHandler("create", "event, ui", this.CreateEvent);
			options.AddEventHandler("change", "event, ui", this.ChangeEvent);
			options.AddEventHandler("complete", "event, ui", this.CompleteEvent);
		}


		/// <summary>
		/// Resets all the control properties back to their default settings (i.e. the
		/// defaults as documented by jQuery UI library
		/// </summary>
		protected void Reset() {
			this.CreateEvent = "";
			this.ChangeEvent = "";
			this.CompleteEvent = "";
		}

	} // Events

} // ns Fluqi.jAutoComplete
