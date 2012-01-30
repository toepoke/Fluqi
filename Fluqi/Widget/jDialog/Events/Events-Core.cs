using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jDialog
{

	/// <summary>
	/// A set of Events to apply to a set of jQuery UI AutoComplete.
	/// </summary>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="dlg">Dialog object to configure events for</param>
		public Events(Dialog dlg)
		 : base()
		{
			this.Dialog = dlg;
			this.Reset();
		}

		/// <summary>
		/// Holds a reference to the <see cref="Dialog"/> object these options are for
		/// </summary>
		public Dialog Dialog { get; set; }

		/// <summary>
		/// Used to flag that configuration of <see cref="Events"/> has finished, and 
		/// returns the <see cref="Dialog"/> object so we can continue defining Tabs attributes.
		/// </summary>
		/// <returns>Returns <see cref="Dialog"/> object to return chaining to the ProgressBar collection</returns>
		public Dialog Finish() {
			return this.Dialog;
		}


		/// <summary>
		/// Builds up a set of events the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			options.AddEventHandler("create", "event, ui", this.CreateEvent);
			options.AddEventHandler("beforeClose", "event, ui", this.BeforeCloseEvent);
			options.AddEventHandler("open", "event, ui", this.OpenEvent);
			options.AddEventHandler("focus", "event, ui", this.FocusEvent);
			options.AddEventHandler("dragStart", "event, ui", this.DragStartEvent);
			options.AddEventHandler("drag", "event, ui", this.DragEvent);
			options.AddEventHandler("dragStop", "event, ui", this.DragStopEvent);
			options.AddEventHandler("resizeStart", "event, ui", this.ResizeStartEvent);
			options.AddEventHandler("resize", "event, ui", this.ResizeEvent);
			options.AddEventHandler("resizeStop", "event, ui", this.ResizeStopEvent);
			options.AddEventHandler("close", "event, ui", this.CloseEvent);
		}


		/// <summary>
		/// Resets all the control properties back to their default settings (i.e. the
		/// defaults as documented by jQuery UI library
		/// </summary>
		protected void Reset() {

		}

	} // Options

} // ns Fluqi.jAutoComplete
