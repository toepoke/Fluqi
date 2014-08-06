using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jPushButton {
	
	/// <summary>
	/// The "Methods" are called after the control has been initialised.  If for instance you want to change
	/// the value of a property, or invoke "some" action on the control (e.g. "open" or "close") you 
	/// call the "Method" rather than through the "Options" (as Options is about the initialisation of the control).
	/// </summary>
	public partial class Methods: Core.Methods {

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="btn">PushButton object to call</param>
		public Methods(PushButton btn) : base(btn)
		{
		}		

		/// <summary>
		/// Remove the Button functionality completely. This will return the element back to its pre-init state.
		/// </summary>
		public void Destroy() {
			base.RenderMethodCall("destroy");
		}	


		/// <summary>
		/// Disable the Button.
		/// </summary>
		public void Disable() {
			base.RenderMethodCall("disable");
		}	


		/// <summary>
		/// Enable the Button.
		/// </summary>
		public void Enable() {
			base.RenderMethodCall("enable");
		}	


		/// <summary>
		/// Returns the .ui-button element.
		/// </summary>
		public void Widget() {
			base.RenderMethodCall("widget");
		}	
		

		/// <summary>
		/// Refreshes the visual state of the button. Useful for updating button state after the native 
		/// element's checked or disabled state is changed programatically.
		/// </summary>
		public void Refresh() {
			base.RenderMethodCall("refresh");
		}	

	}

}
