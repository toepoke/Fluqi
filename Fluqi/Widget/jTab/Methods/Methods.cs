using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jTab {
	
	/// <summary>
	/// The "Methods" are called after the control has been initialised.  If for instance you want to change
	/// the value of a property, or invoke "some" action on the control (e.g. "open" or "close") you 
	/// call the "Method" rather than through the "Options" (as Options is about the initialisation of the control).
	/// </summary>
	public partial class Methods: Core.Methods {

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="tabs">Tabs object to call</param>
		public Methods(Tabs tabs) : base(tabs)
		{
		}		

		/// <summary>
		/// Remove the tabs functionality completely. This will return the element back to its pre-init state.
		/// </summary>
		public void Destroy() {
			this.RenderMethodCall("destroy");
		}	

		/// <summary>
		/// Disable the tabs.
		/// </summary>
		public void Disable() {
			this.RenderMethodCall("disable");
		}	

		/// <summary>
		/// Disable a tab. The selected tab cannot be disabled. To disable more than one tab at once use:
		/// $('#example').tabs("option","disabled", [1, 2, 3]);
		/// The second argument is the zero-based index of the tab to be disabled.
		/// </summary>
		public void Disable(params int[] indexes) {
			if (indexes.Count() == 1)
				this.RenderMethodCall("disable", indexes[0] );
			else 
				this.RenderMethodCall("disable", indexes.JsArray() );
		}	

		/// <summary>
		/// Enable the tabs.
		/// </summary>
		public void Enable() {
			this.RenderMethodCall("enable");
		}	

		/// <summary>
		/// Enable a disabled tab. The second argument is the zero-based index of the tab to be enabled.
		/// </summary>
		public void Enable(int index) {
			this.RenderMethodCall("enable", index);
		}	

		/// <summary>
		/// Returns the .ui-tabs element.
		/// </summary>
		public void Widget() {
			this.RenderMethodCall("widget");
		}	

		/// <summary>
		/// Process any tabs that were added or removed directly in the DOM and recompute the height of the 
		/// tab panels. Results depend on the content and the heightStyle option.
		/// </summary>
		public void Refresh() {
			this.RenderMethodCall("refresh");
		}

		/// <summary>
		/// Reload the content of an Ajax tab programmatically. This method always loads the tab content 
		/// from the remote location, even if cache is set to true. Note the remote location is the href
		/// in the header of the tab.
		/// <param name="index">
		/// Zero-based index of the tab to be reloaded.
		/// </param>
		/// </summary>
		public void Load(int index) {
			this.RenderMethodCall("load", index);
		}	

	}

}
