using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jDialog {
	
	/// <summary>
	/// The "Methods" are called after the control has been initialised.  If for instance you want to change
	/// the value of a property, or invoke "some" action on the control (e.g. "open" or "close") you 
	/// call the "Method" rather than through the "Options" (as Options is about the initialisation of the control).
	/// </summary>
	public partial class Methods: Core.Methods {

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="dlg">Dialog object to call</param>
		public Methods(Dialog dlg) : base(dlg)
		{
		}		

		/// <summary>
		/// Remove the dialog functionality completely. This will return the element back to its pre-init state.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/dialog/#method-destroy for details</remarks>
		public void Destroy() {
			this.RenderMethodCall("destroy");
		}	

		/// <summary>
		/// Disable the dialog.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/dialog/#method-disable for details</remarks>
		public void Disable() {
			this.RenderMethodCall("disable");
		}	

		/// <summary>
		/// Enable the dialog.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/dialog/#method-enable for details</remarks>
		public void Enable() {
			this.RenderMethodCall("enable");
		}	

		/// <summary>
		/// Returns the .ui-dialog element.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/dialog/#method-widget for details</remarks>
		public void Widget() {
			this.RenderMethodCall("widget");
		}	

		/// <summary>
		/// Returns true if the dialog is currently open.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/dialog/#method-isOpen</remarks>
		public void IsOpen() {
			this.RenderMethodCall("isOpen");
		}	

		/// <summary>
		/// Moves the dialog to the top of the dialog stack.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/dialog/#method-moveToTop for details</remarks>
		public void MoveToTop() {
			this.RenderMethodCall("moveToTop");
		}	

		/// <summary>
		/// Opens the dialog.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/dialog/#method-open for details</remarks>
		public void Open() {
			this.RenderMethodCall("open");
		}
		
		/// <summary>
		/// Closes the dialog.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/dialog/#method-close for details</remarks>
		public void Close() {
			this.RenderMethodCall("close");
		}	
		
	}

}
