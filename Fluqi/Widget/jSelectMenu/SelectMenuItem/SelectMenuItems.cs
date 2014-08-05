
namespace Fluqi.Widget.jSelectMenuItem {
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Fluqi.Extension.Helpers;
	
	/// <summary>
	/// Defines the logic for sub-selectMenu items.
	/// </summary>
	public class SelectMenuItems: Core.ControlBase {

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="owner">SelectMenuItem object _this_ item belongs to</param>
		public SelectMenuItems(SelectMenuItem owner)
		: this(owner, "")
		{
		}	

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="owner">SelectMenuItem object _this_ item belongs to</param>
		/// <param name="id">ID to assign to this menu item</param>
		/// TODO: Does having an ID on the OPTION even make sense?
		public SelectMenuItems(SelectMenuItem owner, string id) {
			this.Parent = owner;
			this._SelectMenuItems = new List<SelectMenuItem>();	
			base.WithID(id);		
		}

		/// <summary>
		/// Container Html Tag to use (by default this is a "UL").
		/// </summary>
		public string Tag { 
			get {
				return this.Parent.SelectMenu.Options.SelectTag;
			}
		}

		/// <summary>
		/// Holds a reference to the menu the item is on
		/// </summary>
		protected internal SelectMenuItem Parent { get; set; }

		/// <summary>
		/// Holds the list of sub-menu items.
		/// </summary>
		/// <remarks>
		/// This is delberately hidden from the user so they only see what they need to see.
		/// </remarks>
		protected internal List<SelectMenuItem> _SelectMenuItems { get; set;}

		/// <summary>
		/// Entry point for adding sub-menu items using the fluent API.
		/// </summary>
		/// <returns></returns>
		public SelectMenuItems SubMenu() {
			return _SelectMenuItems.LastOrDefault().Children;
		}

		/// <summary>
		/// Adds a new item to the menu
		/// </summary>
		/// <param name="title">Text to appear in the URL (within the LI container)</param>
		/// <returns>Sub-menu list for chainability</returns>
		/// <remarks>
		/// This entry point has no URL on click.  The hyperlink will have a URL of "#".
		/// </remarks>
		public SelectMenuItems Add(string title) {
			return this.Add(title, "");
		}
		
		/// <summary>
		/// Adds a new item to the menu
		/// </summary>
		/// <param name="title">Text to appear in the list</param>
		/// <param name="value">Value associated with the item</param>
		/// <returns>SelectMenuItem for chainability</returns>
		public SelectMenuItems Add(string title, object value) {
			SelectMenuItem i = new SelectMenuItem(this.Parent)
				.SetTitle(title)
				.SetValue(value)
			;
			_SelectMenuItems.Add(i);
			return this;
		}

		/// <summary>
		/// Provides an entry point to continue configuring the MenuItem that has just been defined.
		/// This allows an Icon to be added for instance.
		/// </summary>
		/// <returns>Last added MenuItem</returns>
		public SelectMenuItem Configure() {
			return _SelectMenuItems.LastOrDefault();
		}

		/// <summary>
		/// Returns control back to the underlying menu widget.  This in essence says "I've finished
		/// defining the menu items" and returns the fluent API back to the menu.
		/// </summary>
		/// <returns>Menu object to continue chaining</returns>
		public jSelectMenu.SelectMenu Finish() {			
			return this.Parent.SelectMenu;
		}

	}

}
