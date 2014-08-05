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

namespace Fluqi.Widget.jSelectMenu
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI SelectMenu.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// Triggered when the control changes.
		/// </summary>
		public Events SetChangeEvent(string changeEvent) {
		  this.ChangeEvent = changeEvent;
		  return this;
		}

		/// <summary>
		/// Triggered when the control is created.
		/// </summary>
		public Events SetCreateEvent(string createEvent) {
		  this.CreateEvent = createEvent;
		  return this;
		}

		/// <summary>
		/// Triggered when the control is closed.
		/// </summary>
		public Events SetCloseEvent(string closeEvent) {
		  this.CloseEvent = closeEvent;
		  return this;
		}

		/// <summary>
		/// Triggered when the control gains focus or when any menu item is activated.
		/// </summary>
		public Events SetFocusEvent(string focusEvent) {
		  this.FocusEvent = focusEvent;
		  return this;
		}

		/// <summary>
		/// Triggered when an item is selected.
		/// </summary>
		public Events SetSelectEvent(string selectEvent) {
		  this.SelectEvent = selectEvent;
		  return this;
		}
		
		/// <summary>
		/// Triggered when the control item is opened.
		/// </summary>
		public Events SetOpenEvent(string openEvent) {
		  this.OpenEvent = openEvent;
		  return this;
		}

	} // Events

} // ns 
