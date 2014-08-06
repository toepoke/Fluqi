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
	/// A set of properties to apply to a set of jQuery UI AutoComplete.
	/// </summary>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// This event is triggered when Dialog is created.
		/// </summary>
		/// <returns>Events object for chainability</returns>
		public Events SetCreateEvent(string methodSource) {
			this.CreateEvent = methodSource;
			return this;	
		}

		
		/// <summary>
		/// This event is triggered when a dialog attempts to close. If the beforeClose event 
		/// handler (callback function) returns false, the close will be prevented.
		/// </summary>
		public Events SetBeforeCloseEvent(string methodSource) {
			this.BeforeCloseEvent = methodSource;
			return this;	
		}


		/// <summary>
		/// This event is triggered when dialog is opened.
		/// </summary>
		/// <param name="methodSource">Source code to use when the event is called</param>
		/// <returns>Events object for chainability</returns>
		public Events SetOpenEvent(string methodSource) {
			this.OpenEvent = methodSource;
			return this;
		}


		/// <summary>
		/// This event is triggered when the dialog gains focus.
		/// </summary>
		/// <param name="methodSource">Source code to use when the event is called</param>
		/// <returns>Events object for chainability</returns>
		public Events SetFocusEvent(string methodSource) {
			this.FocusEvent = methodSource;
			return this;
		}


		/// <summary>
		/// This event is triggered at the beginning of the dialog being dragged.
		/// </summary>
		/// <param name="methodSource">Source code to use when the event is called</param>
		/// <returns>Events object for chainability</returns>
		public Events SetDragStartEvent(string methodSource) {
			this.DragStartEvent = methodSource;
			return this;
		}


		/// <summary>
		/// This event is triggered when the dialog is dragged.
		/// </summary>
		/// <param name="methodSource">Source code to use when the event is called</param>
		/// <returns>Events object for chainability</returns>
		public Events SetDragEvent(string methodSource) {
			this.DragEvent = methodSource;
			return this;
		}


		/// <summary>
		/// This event is triggered after the dialog has been dragged.
		/// </summary>
		/// <param name="methodSource">Source code to use when the event is called</param>
		/// <returns>Events object for chainability</returns>
		public Events SetDragStopEvent(string methodSource) {
			this.DragStopEvent = methodSource;
			return this;
		}


		/// <summary>
		/// This event is triggered at the beginning of the dialog being resized.
		/// </summary>
		/// <param name="methodSource">Source code to use when the event is called</param>
		/// <returns>Events object for chainability</returns>
		public Events SetResizeStartEvent(string methodSource) {
			this.ResizeStartEvent = methodSource;
			return this;
		}


		/// <summary>
		/// This event is triggered when the dialog is resized.
		/// </summary>
		/// <param name="methodSource">Source code to use when the event is called</param>
		/// <returns>Events object for chainability</returns>
		public Events SetResizeEvent(string methodSource) {
			this.ResizeEvent = methodSource;
			return this;
		}


		/// <summary>
		/// This event is triggered after the dialog has been resized.
		/// </summary>
		/// <param name="methodSource">Source code to use when the event is called</param>
		/// <returns>Events object for chainability</returns>
		public Events SetResizeStopEvent(string methodSource) {
			this.ResizeStopEvent = methodSource;
			return this;
		}


		/// <summary>
		/// This event is triggered when the dialog is closed.
		/// </summary>
		/// <param name="methodSource">Source code to use when the event is called</param>
		/// <returns>Events object for chainability</returns>
		public Events SetCloseEvent(string methodSource) {
			this.CloseEvent = methodSource;
			return this;
		}

	} // Events

} // ns Fluqi.jAutoComplete
