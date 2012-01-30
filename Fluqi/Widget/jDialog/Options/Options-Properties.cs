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
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Disables (true) or enables (false) the dialog. Can be set when initialising (first creating) the dialog.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#option-disabled for details</remarks>
		protected internal bool Disabled { get; set; }

		/// <summary>
		/// When autoOpen is true the dialog will open automatically when dialog is called. If false it will stay 
		/// hidden until .dialog("open") is called on it.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#option-autoOpen for details</remarks>
		protected internal bool AutoOpen { get; set; }

		/// <summary>
		/// Specifies whether the dialog should close when it has focus and the user presses 
		/// the esacpe (ESC) key.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#option-closeOnEscape for details</remarks>
		protected internal bool CloseOnEscape { get; set; }

		/// <summary>
		/// Specifies the text for the close button. Note that the close text is visibly hidden 
		/// when using a standard theme.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#option-closeText for details</remarks>
		protected internal string CloseText { get; set; }

		/// <summary>
		/// The specified class name(s) will be added to the dialog, for additional theming.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#option-dialogClass for details</remarks>
		protected internal string DialogClass { get; set; }

		/// <summary>
		/// If set to true, the dialog will be draggable will be draggable by the titlebar.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#option-draggable for details</remarks>
		protected internal bool Draggable { get; set; }

		/// <summary>
		/// The height of the dialog, in pixels. Specifying 'auto' is also supported to make 
		/// the dialog adjust based on its content.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#option-height for details</remarks>
		protected internal string Height { get; set; }

		/// <summary>
		/// The effect to be used when the dialog is closed.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#option-hide for details</remarks>
		protected internal string Hide { get; set; }

		/// <summary>
		/// The maximum height to which the dialog can be resized, in pixels.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#option-maxHeight for details</remarks>
		protected internal string MaxHeight { get; set; }

		/// <summary>
		/// The maximum width to which the dialog can be resized, in pixels.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#option-maxWidth for details</remarks>
		protected internal string MaxWidth { get; set; }

		/// <summary>
		/// The minimum height to which the dialog can be resized, in pixels.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#option-minHeight for details</remarks>
		protected internal int MinHeight { get; set; }

		/// <summary>
		/// The minimum width to which the dialog can be resized, in pixels.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#option-minWidth for details</remarks>
		protected internal int MinWidth { get; set; }

		/// <summary>
		/// If set to true, the dialog will have modal behavior; other items on the page will be 
		/// disabled (i.e. cannot be interacted with). Modal dialogs create an overlay below the 
		/// dialog but above other page elements.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#option-modal for details</remarks>
		protected internal bool Modal { get; set; }

		/// <summary>
		/// Specifies where the dialog should be displayed. Possible values: 
		///   1) a single string representing position within viewport: 'center', 'left', 'right', 'top', 'bottom'. 
		///   2) an array containing an x,y coordinate pair in pixel offset from left, top corner of viewport (e.g. [350,100]) 
		///   3) an array containing x,y
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#option-position for details</remarks>
		protected internal List<string> Position { get; set; }

		/// <summary>
		/// If set to true, the dialog will be resizable.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#option-resizable for details</remarks>
		protected internal bool Resizable { get; set; }

		/// <summary>
		/// The effect to be used when the dialog is opened.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#option-show for details</remarks>
		protected internal string Show { get; set; }

		/// <summary>
		/// Specifies whether the dialog will stack on top of other dialogs. This will cause 
		/// the dialog to move to the front of other dialogs when it gains focus.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#option-stack for details</remarks>
		protected internal bool Stack { get; set; }

		/// <summary>
		/// Specifies the title of the dialog. Any valid HTML may be set as the title. 
		/// The title can also be specified by the title attribute on the dialog source element.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#option-title for details</remarks>
		protected internal string Title { get; set; }

		/// <summary>
		/// The width of the dialog, in pixels.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#option-width for details</remarks>
		protected internal int Width { get; set; }

		/// <summary>
		/// The starting z-index for the dialog.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/dialog/#option-zindex for details</remarks>
		protected internal int ZIndex { get; set; }
		
	} // Options

} // ns Fluqi.jProgressBar
