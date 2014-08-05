using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jSelectMenu {
	
	/// <summary>
	/// The "Methods" are called after the control has been initialised.  If for instance you want to change
	/// the value of a property, or invoke "some" action on the control (e.g. "open" or "close") you 
	/// call the "Method" rather than through the "Options" (as Options is about the initialisation of the control).
	/// </summary>
	public partial class Methods: Core.Methods {

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="selectMenu">SelectMenu object to call</param>
		public Methods(SelectMenu selectMenu) : base(selectMenu)
		{
		}		


		/// <summary>
		/// Closes the control.
		/// </summary>
		public void Close() {
		  this.RenderMethodCall("close");
		}

		/// <summary>
		/// Removes the control functionality completely. This will return the element back to its pre-init state.
		/// </summary>		
		public void Destroy() {
		  this.RenderMethodCall("destroy");
		}

		/// <summary>
		/// Disables the control.
		/// </summary>
		public void Disable() {
		  this.RenderMethodCall("disable");
		}

		/// <summary>
		/// Enables the control.
		/// </summary>
		public void Enable() {
		  this.RenderMethodCall("enable");
		}

		/// <summary>
		/// Retrieves the selectmenu's instance object. If the element does not have an associated instance, undefined is returned
		/// </summary>
		public void Instance() {
		  this.RenderMethodCall("instance");
		}

		/// <summary>
		/// Returns a jQuery object containing the menu element.
		/// </summary>
		public void MenuWidget() {
			// bit of a cheat this, but hey ... it works :)
		  this.RenderMethodCall("menuWidget");
		}

		/// <summary>
		/// Opens the control
		/// </summary>
		public void Open() {
		  this.RenderMethodCall("open");
		}

		/// <summary>
		/// Parses the original element and re-renders the menu. Processes any &gt;option&lt; or &gt;optgroup&lt; elements that were added, removed or disabled.
		/// </summary>
		public void Refresh() {
		  this.RenderMethodCall("refresh");
		}

		/// <summary>
		/// Returns a jQuery object containing the control.
		/// </summary>
		public void Widget() {
		  this.RenderMethodCall("widget");
		}

	}

}
