using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jMenu {
	
	/// <summary>
	/// The "Methods" are called after the control has been initialised.  If for instance you want to change
	/// the value of a property, or invoke "some" action on the control (e.g. "open" or "close") you 
	/// call the "Method" rather than through the "Options" (as Options is about the initialisation of the control).
	/// </summary>
	public partial class Methods: Core.Methods {

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="menu">Menu object to call</param>
		public Methods(Menu menu) : base(menu)
		{
		}		

		/// <summary>
		/// Removes focus from a menu, resets any active element styles and triggers the menu's blur event.
		/// </summary>
		public void Blur() {
		  this.RenderMethodCall("blur");
		}

		/// <summary>
		/// Removes focus from a menu, resets any active element styles and triggers the menu's blur event.
		/// </summary>
		public void Close() {
		  this.RenderMethodCall("close");
		}

		/// <summary>
		/// Closes the currently active sub-menu.
		/// </summary>
		public void Collapse() {
		  this.RenderMethodCall("collapse");
		}

		/// <summary>
		/// Closes all open sub-menus.
		/// </summary>
		public void CollapseAll() {
		  this.RenderMethodCall("collapseAll");
		}

		/// <summary>
		/// Removes the menu functionality completely. This will return the element back to its pre-init state.
		/// </summary>		
		public void Destroy() {
		  this.RenderMethodCall("destroy");
		}

		/// <summary>
		/// Disables the menu.
		/// </summary>
		public void Disable() {
		  this.RenderMethodCall("disable");
		}

		/// <summary>
		/// Enables the menu.
		/// </summary>
		public void Enable() {
		  this.RenderMethodCall("enable");
		}

		/// <summary>
		/// Opens the sub-menu below the currently active item, if one exists.
		/// </summary>
		public void Expand() {
		  this.RenderMethodCall("expand");
		}

		/// <summary>
		/// Activates a particular menu item, begins opening any sub-menu if present and triggers the menu's focus
		/// </summary>
		public void Focus(string itemSelector) {
			// bit of a cheat this, but hey ... it works :)
		  this.RenderMethodCall("focus", " null, " + itemSelector);
		}

		/// <summary>
		/// Returns a boolean value stating whether or not the currently active item is the first item in the menu.
		/// </summary>
		public void IsFirstItem() {
		  this.RenderMethodCall("isFirstItem");
		}

		/// <summary>
		/// Returns a boolean value stating whether or not the currently active item is the last item in the menu.
		/// </summary>
		public void IsLastItem() {
		  this.RenderMethodCall("isLastItem");
		}

		/// <summary>
		/// Moves active state to next menu item.
		/// </summary>
		public void Next() {
		  this.RenderMethodCall("next");
		}

		/// <summary>
		/// Moves active state to first menu item below the bottom of a scrollable menu or the last item if not scrollable.
		/// </summary>
		public void NextPage() {
		  this.RenderMethodCall("nextPage");
		}

		/// <summary>
		/// Moves active state to previous menu item.
		/// </summary>
		public void Previous() {
		  this.RenderMethodCall("previous");
		}

		/// <summary>
		/// Moves active state to first menu item above the top of a scrollable menu or the first item if not scrollable.
		/// </summary>
		public void PreviousPage() {
		  this.RenderMethodCall("previousPage");
		}

		/// <summary>
		/// Initializes sub-menus and menu items that have not already been initialized. 
		/// New menu items, including sub-menus can be added to the menu or all of the contents of the menu 
		/// can be replaced and then initialized with the refresh() method.
		/// </summary>
		public void Refresh() {
		  this.RenderMethodCall("refresh");
		}

		/// <summary>
		/// Selects the currently active menu item, collapses all sub-menus and 
		/// triggers the menu's select event.
		/// </summary>
		public void Select() {
		  this.RenderMethodCall("select");
		}

		/// <summary>
		/// Returns a jQuery object containing the menu.
		/// </summary>
		public void Widget() {
		  this.RenderMethodCall("widget");
		}

	}

}
