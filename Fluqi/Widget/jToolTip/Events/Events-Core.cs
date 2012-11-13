using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;
using Microsoft.VisualBasic;

namespace Fluqi.Widget.jToolTip
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI ToolTip.
	/// </summary>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// Holds a reference to the <see cref="ToolTip"/> object these events are for
		/// </summary>
		public ToolTip ToolTip { get; set; }


		/// <summary>
		/// Used to flag that configuration of <see cref="Events"/> has finished, and 
		/// returns the <see cref="ToolTip"/> object so we can continue defining attributes.
		/// </summary>
		/// <returns>Returns <see cref="ToolTIp"/> object to return chaining to the collection</returns>
		public ToolTip Finish() {
			return this.ToolTip;
		}


		/// <summary>
		/// Builds up a set of events the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			options.AddEventHandler("close", "event, ui", this.CloseEvent);
			options.AddEventHandler("create", "event, ui", this.CreateEvent);
			options.AddEventHandler("open", "event, ui", this.OpenEvent);
		}


		/// <summary>
		/// Resets all the control properties back to their default settings (i.e. the
		/// defaults as documented by jQuery UI library
		/// </summary>
		protected void Reset() {
			this.CloseEvent = "";
			this.CreateEvent = "";
			this.OpenEvent = "";
		}

	} // Events

} // ns