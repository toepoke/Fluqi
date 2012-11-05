
namespace Fluqi.Widget.jMenuItem {
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Fluqi.Extension.Helpers;
	
	/// <summary>
	/// Defines the logic for sub-menu items.
	/// </summary>
	public class MenuItems: Core.ControlBase {

		public MenuItems(MenuItem owner)
		: this(owner, "")
		{
		}	

		public MenuItems(MenuItem owner, string id) {
			this.Parent = owner;
			this._MenuItems = new List<MenuItem>();	
			base.WithID(id);		
		}

		/// <summary>
		/// Container Html Tag to use (by default this is a "UL").
		/// </summary>
		public string Tag { 
			get {
				return this.Parent.Menu.Options.Menus;
			}
		}

		/// <summary>
		/// Holds a reference to the menu the item is on
		/// </summary>
		protected internal MenuItem Parent { get; set; }

		/// <summary>
		/// Holds the list of sub-menu items.
		/// </summary>
		/// <remarks>
		/// This is delberately hidden from the user so they only see what they need to see.
		/// </remarks>
		protected internal List<MenuItem> _MenuItems { get; set;}

		/// <summary>
		/// Entry point for adding sub-menu items using the fluent API.
		/// </summary>
		/// <returns></returns>
		public MenuItems SubMenu() {
			return _MenuItems.LastOrDefault().Children;
		}

		/// <summary>
		/// Adds a new item to the menu
		/// </summary>
		/// <param name="title">Text to appear in the URL (within the LI container)</param>
		/// <returns>Sub-menu list for chainability</returns>
		/// <remarks>
		/// This entry point has no URL on click.  The hyperlink will have a URL of "#".
		/// </remarks>
		public MenuItems Add(string title) {
			return this.Add(title, "");
		}
		
		/// <summary>
		/// Adds a new item to the menu.
		/// </summary>
		/// <param name="title">Text to appear in the hyperlink</param>
		/// <param name="url">URL to navigate to upon selecting the menu item.</param>
		/// <param name="icon">Icon to display next to the menu item</param>
		/// <returns>Sub-menu list for chainability</returns>
		public MenuItems Add(string title, Core.Icons.eIconClass icon) {
			return this.Add(title, "", icon);
		}
		
		/// <summary>
		/// Adds a new item to the menu.
		/// </summary>
		/// <param name="title">Text to appear in the hyperlink</param>
		/// <param name="url">URL to navigate to upon selecting the menu item.</param>
		/// <returns>Sub-menu list for chainability</returns>
		public MenuItems Add(string title, string url) {
			MenuItem i = new MenuItem(this.Parent)
				.SetTitle(title)
				.SetTargetURL(url)
			;
			_MenuItems.Add(i);
			return this;
		}

		/// <summary>
		/// Adds a new item to the menu.
		/// </summary>
		/// <param name="title">Text to appear in the hyperlink</param>
		/// <param name="url">URL to navigate to upon selecting the menu item.</param>
		/// <param name="icon">Icon to display next to the menu item</param>
		/// <returns>Sub-menu list for chainability</returns>
		public MenuItems Add(string title, string url, Core.Icons.eIconClass icon) {
			MenuItem i = new MenuItem(this.Parent)
				.SetTitle(title)
				.SetTargetURL(url)
				.SetIcon(icon)
			;
			_MenuItems.Add(i);
			return this;
		}

		/// <summary>
		/// Adds a divider into the menu.  Useful if you want to group certain items
		/// </summary>
		/// <returns>Sub-menu list for chainability</returns>
		public MenuItems AddDivider() {
			MenuItem i = new MenuItem(this.Parent)
				.SetAsDivider()
			;
			_MenuItems.Add(i);	
			return this;
		}

		/// <summary>
		/// Adds a new item to the menu, this replaces the hyperlink, but not the LI (or defined separator).
		/// </summary>
		/// <param name="markup">HTML to use</param>
		/// <returns>Sub-menu list for chainability</returns>
		public MenuItems AddHtml(string markup) {
			MenuItem i = new MenuItem(this.Parent) {
				Html = markup
			};
			_MenuItems.Add(i);
			return this;
		} 

		/// <summary>
		/// Adds a new item to the menu, this replaces the hyperlink, but not the LI (or defined separator).
		/// This overloads allows a "string.Format" set of parameters to be passed in
		/// </summary>
		/// <param name="markup">HTML to use (including {0}, {1}, etc)</param>
		/// <param name="args">Arguments used to build up the markup</param>
		/// <returns>Sub-menu list for chainability</returns>
		public MenuItems AddHtml(string markup, params object[] args) {
			return this.AddHtml(string.Format(markup, args));
		}

		/// <summary>
		/// Returns control to the parent sub-menu (allows the user to continue adding further menu items
		/// at the previous level).
		/// </summary>
		/// <returns>Sub-menu list for chainability</returns>
		public MenuItems Back() {
			if (this.Parent.Parent != null)
				// handle the nested SubMenu first
				return this.Parent.Parent.Children;

			// failing that we're at the root, so don't nav back too far
			return this.Parent.Children;
		}

		/// <summary>
		/// Provides an entry point to continue configuring the MenuItem that has just been defined.
		/// This allows an Icon to be added for instance.
		/// </summary>
		/// <returns>Last added MenuItem</returns>
		public MenuItem Configure() {
			return _MenuItems.LastOrDefault();
		}

		/// <summary>
		/// Returns control back to the underlying menu widget.  This in essence says "I've finished
		/// defining the menu items" and returns the fluent API back to the menu.
		/// </summary>
		/// <returns>Menu object to continue chaining</returns>
		public jMenu.Menu Finish() {			
			return this.Parent.Menu;
		}


	}

}
