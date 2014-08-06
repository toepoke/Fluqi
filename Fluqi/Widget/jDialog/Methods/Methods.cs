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
		public void Destroy() {
			this.RenderMethodCall("destroy");
		}	

		/// <summary>
		/// Disable the dialog.
		/// </summary>
		public void Disable() {
			this.RenderMethodCall("disable");
		}	

		/// <summary>
		/// Enable the dialog.
		/// </summary>
		public void Enable() {
			this.RenderMethodCall("enable");
		}	

		/// <summary>
		/// Returns the .ui-dialog element.
		/// </summary>
		public void Widget() {
			this.RenderMethodCall("widget");
		}	

		/// <summary>
		/// Returns true if the dialog is currently open.
		/// </summary>
		public void IsOpen() {
			this.RenderMethodCall("isOpen");
		}	

		/// <summary>
		/// Moves the dialog to the top of the dialog stack.
		/// </summary>
		public void MoveToTop() {
			this.RenderMethodCall("moveToTop");
		}	

		/// <summary>
		/// Opens the dialog.
		/// </summary>
		public void Open() {
			this.RenderMethodCall("open");
		}
		
		/// <summary>
		/// Closes the dialog.
		/// </summary>
		public void Close() {
			this.RenderMethodCall("close");
		}	
		
	}

}
