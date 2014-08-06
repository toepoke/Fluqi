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
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// Triggered when a tooltip is closed, triggered on focusout or mouseleave.
		/// </summary>
		public Events SetCloseEvent(string closeEvent) {
		  this.CloseEvent = closeEvent;
		  return this;
		}

		/// <summary>
		/// This event is triggered when tooltip is created.
		/// </summary>
		public Events SetCreateEvent(string createEvent) {
		  this.CreateEvent = createEvent;
		  return this;
		}


		/// <summary>
		/// Triggered when a tooltip is shown, triggered on focusin or mouseover.
		/// </summary>
		public Events SetOpenEvent(string openEvent) {
		  this.OpenEvent = openEvent;
		  return this;
		}

	} // Events

} // ns 
