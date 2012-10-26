using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jAccordion
{

	/// <summary>
	/// A set of events to apply to a set of jQuery UI Accordion.
	/// </summary>
	public partial class Events: Core.Options	{

		/// <summary>
		/// This event is triggered when accordion is created.
		/// </summary>
		protected internal string CreateEvent { get; set; }

		/// <summary>
		/// This event is triggered every time the accordion changes. If the accordion is animated, 
		/// the event will be triggered upon completion of the animation; otherwise, it is triggered immediately.
		/// </summary>
		protected internal string ActivateEvent { get; set; }

		/// <summary>
		/// This event is triggered every time the accordion starts to change.
		/// </summary>
		protected internal string BeforeActivateEvent { get; set; }

	} // Options

} // ns Fluqi.jTab
