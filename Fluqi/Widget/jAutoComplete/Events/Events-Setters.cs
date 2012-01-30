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
	/// A set of events to apply to a set of jQuery UI AutoComplete.
	/// </summary>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// This event is triggered when autocomplete is created.
		/// </summary>
		/// <returns>Events object for chainability</returns>
		public Events SetCreateEvent(string methodSource) {
			this.CreateEvent = methodSource;
			return this;	
		}

		
		/// <summary>
		/// Specifies the code that should be used when event is called from jQuery.
		/// Note that you shouldn't include any function prototype information as Fluqi does
		/// this part for you.
		/// </summary>
		/// <param name="methodSource">Source code to use when the event is called</param>
		/// <returns>Events object for chainability</returns>
		public Events SetSearchEvent(string methodSource) {
			this.SearchEvent = methodSource;
			return this;
		}


		/// <summary>
		/// Triggered when the suggestion menu is opened.
		/// </summary>
		/// <param name="methodSource">Source code to use when the event is called</param>
		/// <returns>Events object for chainability</returns>
		public Events SetOpenEvent(string methodSource) {
			this.OpenEvent = methodSource;
			return this;	
		}


		/// <summary>
		/// Before focus is moved to an item (not selecting), ui.item refers to the focused item. 
		/// The default action of focus is to replace the text field's value with the value of the 
		/// focused item, though only if the focus event was triggered by a keyboard interaction. 
		/// Canceling this event prevents the value from being updated, but does not prevent 
		/// the menu item from being focused.
		/// </summary>
		/// <param name="methodSource">Source code to use when the event is called</param>
		/// <returns>Events object for chainability</returns>
		public Events SetFocusEvent(string methodSource) {
			this.FocusEvent = methodSource;
			return this;	
		}


		/// <summary>
		/// Triggered when an item is selected from the menu; ui.item refers to the selected item. 
		/// The default action of select is to replace the text field's value with the value of 
		/// the selected item. Canceling this event prevents the value from being updated, but 
		/// does not prevent the menu from closing.
		/// </summary>
		/// <param name="methodSource">Source code to use when the event is called</param>
		/// <returns>Events object for chainability</returns>
		public Events SetSelectEvent(string methodSource) {
			this.SelectEvent = methodSource;
			return this;	
		}


		/// <summary>
		/// When the list is hidden - doesn't have to occur together with a change.
		/// </summary>
		/// <param name="methodSource">Source code to use when the event is called</param>
		/// <returns>Events object for chainability</returns>
		public Events SetCloseEvent(string methodSource) {
			this.CloseEvent = methodSource;
			return this;	
		}


		/// <summary>
		/// Triggered when the field is blurred, if the value has changed; ui.item refers to the selected item.
		/// </summary>
		/// <param name="methodSource">Source code to use when the event is called</param>
		/// <returns>Events object for chainability</returns>
		public Events SetChangeEvent(string methodSource) {
			this.ChangeEvent = methodSource;
			return this;	
		}

	} // Events

} // ns Fluqi.jAutoComplete
