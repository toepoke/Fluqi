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
	/// A set of properties to apply to a set of jQuery UI AutoComplete.
	/// </summary>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// This event is triggered when progressbar is created.
		/// </summary>
		/// <returns>Events object for chainability</returns>
		public Events SetCreateEvent(string methodSource) {
			this.CreateEvent = methodSource;
			return this;	
		}

		
		/// <summary>
		/// This event is triggered when the value of the progressbar changes.
		/// </summary>
		/// <param name="methodSource">Source code to use when the event is called</param>
		/// <returns>Events object for chainability</returns>
		public Events SetChangeEvent(string methodSource) {
			this.ChangeEvent = methodSource;
			return this;	
		}


		/// <summary>
		/// This event is triggered when progressbar is created.
		/// </summary>
		/// <param name="methodSource">Source code to use when the event is called</param>
		/// <returns>Events object for chainability</returns>
		public Events SetCompleteEvent(string methodSource) {
			this.CompleteEvent = methodSource;
			return this;
		}

	} // Events

} // ns Fluqi.jAutoComplete
