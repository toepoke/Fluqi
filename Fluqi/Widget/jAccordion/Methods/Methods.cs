using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jAccordion {
	
	/// <summary>
	/// The "Methods" are called after the control has been initialised.  If for instance you want to change
	/// the value of a property, or invoke "some" action on the control (e.g. "open" or "close") you 
	/// call the "Method" rather than through the "Options" (as Options is about the initialisation of the control).
	/// </summary>
	public partial class Methods: Core.Methods {

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="ac">Accordion object to call</param>
		public Methods(Accordion ac) 
			: base(ac) 
		{
		}		

		
		/// <summary>
		/// Activate a content part of the Accordion programmatically.
		/// <param name="panelIndex">
		/// zero-indexed number to match the position of the header to activate. 
		/// </param>
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/accordion/#option-active for details</remarks>
		public void Active(int panelIndex) {
			this.RenderSetOptionCall("active", panelIndex);
		}

		/// <summary>
		/// Remove the accordion functionality completely. This will return the element back to its pre-init state.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/accordion/#method-destroy for details</remarks>
		public void Destroy() {
			this.RenderMethodCall("destroy");
		}	


		/// <summary>
		/// Disable the accordion.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/accordion/#method-disable for details</remarks>
		public void Disable() {
			this.RenderMethodCall("disable");
		}	


		/// <summary>
		/// Enable the accordion.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/accordion/#method-enable for details</remarks>
		public void Enable() {
			this.RenderMethodCall("enable");
		}	


		/// <summary>
		/// Recompute heights of the accordion contents when using the heightStyle option and the 
		/// container height changed. For example, when the container is a resizable, this method 
		/// should be called by its resize-event.
		/// </summary>
		/// <remarks>
		/// See http://api.jqueryui.com/accordion/#method-refresh for details.
		/// Note previous to jQuery 1.9 this was called the "resize" method
		/// </remarks>
		public void Refresh() {
			this.RenderMethodCall("refresh");
		}	

		/// <summary>
		/// Returns the .ui-accordion element.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/accordion/#method-widget for details</remarks>
		public void Widget() {
			this.RenderMethodCall("widget");
		}	


		/// <summary>
		/// Selects the given content part (the "Select" method is the same as "Activate"
		/// and is here for ease of discover).
		/// <param name="panelIndex">
		/// zero-indexed number to match the position of the header to activate. 
		/// </param>
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#method-activate for details.</remarks>
		public void Select(int panelIndex) {
			this.Active(panelIndex);
		}

		/// <summary>
		/// Collapses all accordion panels (only possible when collapsible is true).
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#method-activate for details.</remarks>
		public void CollapseAll() {
			this.RenderMethodCall("active", "false");
		}
		
	}

}
