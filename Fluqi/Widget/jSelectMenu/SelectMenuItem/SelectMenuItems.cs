namespace Fluqi.Widget.jSelectMenuItem {
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Fluqi.Extension.Helpers;
	using System.Web.Mvc;
	
	/// <summary>
	/// Defines the logic for sub-selectMenu items.
	/// </summary>
	public class SelectMenuItems: Core.ControlBase {

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="owner">SelectMenuItem object _this_ item belongs to</param>
		public SelectMenuItems(SelectMenuItemBase owner)
		: this(owner, "")
		{
		}	

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="owner">SelectMenuItem object _this_ item belongs to</param>
		/// <param name="id">ID to assign to this menu item</param>
		/// TODO: Does having an ID on the OPTION even make sense?
		public SelectMenuItems(SelectMenuItemBase owner, string id) {
			this.Parent = owner;
			this._SelectMenuItems = new List<SelectMenuItemBase>();	
			base.WithID(id);		
		}

		/// <summary>
		/// Holds a reference to the menu the item is on
		/// </summary>
		protected internal SelectMenuItemBase Parent { get; set; }

		/// <summary>
		/// Holds the list of sub-menu items.
		/// </summary>
		/// <remarks>
		/// This is delberately hidden from the user so they only see what they need to see.
		/// </remarks>
		protected internal List<SelectMenuItemBase> _SelectMenuItems { get; set;}

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
		/// <param name="isSelected">Flags whether this is the selected item in the list</param>
		/// <returns>Sub-menu list for chainability</returns>
		/// <remarks>
		/// This entry point has no URL on click.  The hyperlink will have a URL of "#".
		/// </remarks>
		public SelectMenuItems Add(string title, bool isSelected = false) {
			return this.Add(title, "");
		}
		
		/// <summary>
		/// Adds a new item to the menu
		/// </summary>
		/// <param name="title">Text to appear in the list</param>
		/// <param name="value">Value associated with the item</param>
		/// <param name="isSelected">Flags whether this is the selected item in the list</param>
		/// <returns>SelectMenuItems for chainability</returns>
		public SelectMenuItems Add(string title, object value, bool isSelected = false) {
			SelectMenuItem i = new SelectMenuItem(this.Parent)
				.SetTitle(title)
				.SetValue(value)
				.SetSelected(isSelected)
			;
			_SelectMenuItems.Add(i);
			return this;
		}

		/// <summary>
		/// Adds an OptGroup to the SelectMenu
		/// </summary>
		/// <param name="label">Label of the group</param>
		/// <param name="isDisabled">
		/// Whether the group (and all it's child options) are disabled
		/// Note: I'm not sure if the jQuery UI select-menu supports this however
		/// </param>
		/// <returns>SelectMenuItems for chainability</returns>
		public SelectMenuItems AddGroup(string label, bool isDisabled = false) {
			SelectMenuOptGroup optGroup = new SelectMenuOptGroup(this.Parent)
				.SetLabel(label)
			;
			if (isDisabled) {
				optGroup.SetDisabled();
			}
			_SelectMenuItems.Add(optGroup);
			return optGroup.Children;
		}

		/// <summary>
		/// Stipulates that all options have been added for this OptGroup.
		/// Control is returned to the SelectMenu control to allow further items
		/// (or further OptGroups to be defined).
		/// </summary>
		/// <returns></returns>
		public SelectMenuItems FinishGroup() {
			return this.Parent.Parent.Children;
		}

		/// <summary>
		/// Adds a collection of options to the menu.
		/// The "Key" becomes the "value" attribute of the OPTION (in the SELECT tag)
		/// The "Value" becomes the readable text of the OPTION (what the user sees in the dropdown)
		/// </summary>
		/// <param name="dict">Dictionary of options to add</param>
		/// <returns>SelectMenuItem for chainability</returns>
		public SelectMenuItems Add(Dictionary<string, string> dict) {
			foreach (KeyValuePair<string, string> keyValue in dict) {
				this.Add(keyValue.Value, keyValue.Key);
			}

			return this;
		}

		/// <summary>
		/// Adds a list of SelectListItems to the menu
		/// </summary>
		/// <param name="options">List of items</param>
		/// <returns>SelectMenuItem for chainability</returns>
		public SelectMenuItems Add(SelectList options) {
			foreach (SelectListItem i in options) {
				this.Add(i.Text, i.Value, i.Selected);
			}

			return this;
		}

		/// <summary>
		/// Provides an entry point to continue configuring the MenuItem that has just been defined.
		/// This allows an Icon to be added for instance.
		/// </summary>
		/// <returns>Last added MenuItem</returns>
		public SelectMenuItem ConfigureItem() {
			var lastAddedItem = _SelectMenuItems.LastOrDefault();
			if (lastAddedItem is SelectMenuItem) {
				return (SelectMenuItem)lastAddedItem;
			} else {
				throw new ArgumentException("ConfigureItem can only be used when adding items, not optGroup.");
			}
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
