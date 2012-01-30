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
	/// A set of properties to apply to a set of jQuery UI Dialog.
	/// </summary>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// This event is triggered when dialog is created.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#event-create for details</remarks>
		protected internal string CreateEvent { get; set; }
		
		/// <summary>
		/// This event is triggered when a dialog attempts to close. If the beforeClose event 
		/// handler (callback function) returns false, the close will be prevented.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#event-beforeClose for details</remarks>
		protected internal string BeforeCloseEvent { get; set; }

		/// <summary>
		/// This event is triggered when dialog is opened.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#event-open for details</remarks>
		protected internal string OpenEvent { get; set; }

		/// <summary>
		/// This event is triggered when the dialog gains focus.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#event-focus for details</remarks>
		protected internal string FocusEvent { get; set; }

		/// <summary>
		/// This event is triggered at the beginning of the dialog being dragged.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#event-dragStart for details</remarks>
		protected internal string DragStartEvent { get; set; }

		/// <summary>
		/// This event is triggered when the dialog is dragged.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#event-drag for details</remarks>
		protected internal string DragEvent { get; set; }

		/// <summary>
		/// This event is triggered after the dialog has been dragged.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#event-dragStop for details</remarks>
		protected internal string DragStopEvent { get; set; }

		/// <summary>
		/// This event is triggered at the beginning of the dialog being resized.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#event-resizeStart for details</remarks>
		protected internal string ResizeStartEvent { get; set; }

		/// <summary>
		/// This event is triggered when the dialog is resized.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#event-resize for details</remarks>
		protected internal string ResizeEvent { get; set; }

		/// <summary>
		/// This event is triggered after the dialog has been resized.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#event-resizeStop for details</remarks>
		protected internal string ResizeStopEvent { get; set; }

		/// <summary>
		/// This event is triggered when the dialog is closed.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#event- for details</remarks>
		protected internal string CloseEvent { get; set; }

	} // Options

} // ns Fluqi.jProgressBar
