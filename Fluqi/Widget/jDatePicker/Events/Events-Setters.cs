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

namespace Fluqi.Widget.jDatePicker
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI DatePicker.
	/// </summary>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// This event is triggered when datepicker is created.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/datepicker/#event-create for details</remarks>
		public Events SetCreateEvent(string createEvent) {
			this.CreateEvent = createEvent;
			return this;
		}

		/// <summary>
		/// Can be a function that takes an input field and current datepicker instance and returns an 
		/// events object to update the datepicker with. It is called just before the datepicker is displayed.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/datepicker/#event-beforeShow for details</remarks>
		public Events SetBeforeShowEvent(string beforeShowEvent) {
			this.BeforeShowEvent = beforeShowEvent;
			return this;
		}

		/// <summary>
		/// The function takes a date as a parameter and must return an array with [0] equal to true/false 
		/// indicating whether or not this date is selectable, [1] equal to a CSS class name(s) or '' for 
		/// the default presentation, and [2] an optional popup tooltip for this date. It is called for 
		/// each day in the datepicker before it is displayed.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/datepicker/#event-beforeShow for details</remarks>
		public Events SetBeforeShowDayEvent(string beforeShowDayEvent) {
			this.BeforeShowDayEvent = beforeShowDayEvent;
			return this;
		}

		/// <summary>
		/// Allows you to define your own event when the datepicker moves to a new month and/or year. The 
		/// function receives the selected year, month (1-12), and the datepicker instance as parameters. 
		/// this refers to the associated input field.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/datepicker/#event-onChangeMonthYear for details</remarks>
		public Events SetOnChangeMonthYearEvent(string onChangeMonthYearEvent) {
			this.OnChangeMonthYearEvent = onChangeMonthYearEvent;
			return this;
		}

		/// <summary>
		/// Allows you to define your own event when the datepicker is closed, whether or not a date is 
		/// selected. The function receives the selected date as text ('' if none) and the datepicker instance 
		/// as parameters. this refers to the associated input field.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/datepicker/#event-onClose for details</remarks>
		public Events SetOnCloseEvent(string onCloseEvent) {
			this.OnCloseEvent = onCloseEvent;
			return this;
		}

		/// <summary>
		/// Allows you to define your own event when the datepicker is selected. The function receives the 
		/// selected date as text and the datepicker instance as parameters. this refers to the associated 
		/// input field.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/datepicker/#event-onSelect for details</remarks>
		public Events SetOnSelectEvent(string onSelectEvent) {
			this.OnSelectEvent = onSelectEvent;
			return this;
		}

	} // Events

} // ns Fluqi.jAutoComplete
