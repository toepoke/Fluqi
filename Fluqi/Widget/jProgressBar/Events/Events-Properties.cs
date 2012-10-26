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
	/// A set of properties to apply to a set of jQuery UI ProgressBar.
	/// </summary>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// This event is triggered when progressbar is created.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/progressbar/#event-create for details</remarks>
		protected internal string CreateEvent { get; set; }
		
		/// <summary>
		/// This event is triggered when the value of the progressbar changes.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/progressbar/#event-change for details</remarks>
		protected internal string ChangeEvent { get; set; }

		/// <summary>
		/// This event is triggered when the value of the progressbar reaches the maximum value of 100.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/progressbar/#event-complete for details</remarks>
		protected internal string CompleteEvent { get; set; }

	} // Events

} // ns Fluqi.jProgressBar
