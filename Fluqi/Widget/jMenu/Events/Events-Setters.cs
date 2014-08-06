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

namespace Fluqi.Widget.jMenu
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Menu.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// Triggered when the menu loses focus.
		/// </summary>
		public Events SetBlurEvent(string blurEvent) {
		  this.BlurEvent = blurEvent;
		  return this;
		}

		/// <summary>
		/// Triggered when the menu is created.
		/// </summary>
		public Events SetCreateEvent(string createEvent) {
		  this.CreateEvent = createEvent;
		  return this;
		}

		/// <summary>
		/// Triggered when the menu loses focus.
		/// </summary>
		public Events SetFocusEvent(string focusEvent) {
		  this.FocusEvent = focusEvent;
		  return this;
		}

		/// <summary>
		/// Triggered when a menu item is selected.
		/// </summary>
		public Events SetSelectEvent(string selectEvent) {
		  this.SelectEvent = selectEvent;
		  return this;
		}
		

	} // Events

} // ns 
