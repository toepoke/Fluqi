
namespace Fluqi.Widget.jMenuItem {
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Fluqi.Extension.Helpers;

	/// <summary>
	/// Defines the logic and rendering of a single menu item (which may also have a sub-menu 
	/// of items (<see cref="MenuItems"/>).
	/// </summary>
	public partial class MenuItem: Core.ControlBase {

		/// <summary>
		/// Tag to use [by default] for a menu item, by default this is an "LI" but can be _something_else_
		/// </summary>
		public const string DEFAULT_SINGLE_TAG = "li";

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="owner">Menu object _this_ item belongs to</param>
		/// <param name="id">ID to assign to the MenuItem object</param>
		public MenuItem(jMenu.Menu owner, string id)
		{
			this.Menu = owner;
			this.Tag = DEFAULT_SINGLE_TAG;
			this.Children = new MenuItems(this, id);
			this.Parent = null;
			this.IsDisabled = false;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="parent">MenuItem object _this_ item belongs to</param>
		public MenuItem(MenuItem parent) {
			this.Parent = parent;
			this.Menu = parent.Menu;
			this.Tag = DEFAULT_SINGLE_TAG;
			this.Children = new MenuItems(this);
			this.IsDisabled = false;
		}

		/// <summary>
		/// Holds a reference to the menu the item is on
		/// </summary>
		protected internal jMenu.Menu Menu { get; set; }

		/// <summary>
		/// Specifies that the rendered menu item should be disabled.
		/// </summary>
		protected internal bool IsDisabled { get; set; }

		/// <summary>
		/// Flags that this menu-item is a divider
		/// </summary>
		protected internal bool IsDivider { get; set; }

		/// <summary>
		/// Text to appear in the item
		/// </summary>
		protected internal string Title { get; set; }

		/// <summary>
		/// Icon to appear alongside the menu item
		/// ToDo: Can these appear on the left hand and right hand side?
		/// </summary>
		protected internal string Icon { get; set; }

		/// <summary>
		/// Destination of the menu item
		/// </summary>
		protected internal string TargetURL { get; set; }

		/// <summary>
		/// Html to use in the menu item 
		/// </summary>
		/// <remarks>If specified, this overrides the Title, Icon and TargetURL properties</remarks>
		protected internal string Html { get; set; }

		/// <summary>
		/// Html tag to use for containing menu-items.  By default this is LI.
		/// </summary>
		protected internal string Tag { get; set; }

		/// <summary>
		/// Set of sub MenuItems for this item of the menu.
		/// </summary>
		protected internal MenuItems Children { get; set; }

		/// <summary>
		/// Navigates to the MenuItem this MenuItem is contained within.
		/// </summary>
		protected internal MenuItem Parent { get; set; }

		/// <summary>
		/// Flags whether this MenuItem is the root of the menu.
		/// </summary>
		protected bool _IsRoot { get; set; }

		/// <summary>
		/// Changes the title that appears in the menu item.
		/// </summary>
		/// <returns>this for chainability</returns>
		/// <remarks>
		/// Dunno why you'd want to do this after it's already been defined when adding the menu item
		/// but I'm leaving it here if only for the sake of consistency with the API.
		/// </remarks>
		public MenuItem SetTitle(string value) {
			this.Title = value;
			return this;
		}

		/// <summary>
		/// Sets the icon which appears to the left of the menu title.
		/// </summary>
		/// <returns>this for chainability</returns>
		/// <remarks>
		/// Use this for adding your own icon.  The "ui-icon" jQuery UI class will still be added first
		/// (so you can use this for sizing), but the "ui-icon" prefix won't be added in front of your CSS class.
		/// </remarks>
		/// <returns>this for chainability</returns>
		public MenuItem SetIcon(string cssClass) {
			this.Icon = cssClass;
			return this;
		}

		/// <summary>
		/// Sets the icon which appears to the left of the menu item.  This is one of the built in
		/// icons provdided by the jQuery UI framework.
		/// </summary>
		/// <returns>this for chainability</returns>
		public MenuItem SetIcon(Core.Icons.eIconClass value) {
			return this.SetIcon( Core.Icons.ByEnum(value) );
		}

		/// <summary>
		/// Sets the URL to navigate to from the menu (this replaces the default "#" href).
		/// </summary>
		/// <returns>this for chainability</returns>
		public MenuItem SetTargetURL(string value) {
			this.TargetURL = value;
			return this;
		}

		/// <summary>
		/// Sets the LI tag to use
		/// </summary>
		/// <returns>this for chainability</returns>
		public MenuItem SetTag(string value) {
			this.Tag = value;
			return this;
		}
			
		/// <summary>
		/// Sets this menu item as disabled
		/// </summary>
		/// <returns>this for chainability</returns>
		public MenuItem SetDisabled() {
			this.IsDisabled = true;
			return this;
		}

		/// <summary>
		/// Sets this menu-item as a divider.
		/// </summary>
		/// <returns>this for chainability</returns>
		public MenuItem SetAsDivider() {
			this.IsDivider = true;
			return this;
		}

		/// <summary>
		/// Ends configuration of the menu item just added and brings the fluent API back a level to 
		/// allow further menu items to be added.
		/// </summary>
		/// <returns>Parent MenuItems object to maintain fluent API reference point</returns>
		public MenuItems Finish() {
			return this.Parent.Children;
		}

		/// <summary>
		/// Convenience function for eastablishing if there are any child/sub-menu items off this menu item.
		/// </summary>
		/// <returns></returns>
		protected internal bool HasChildren() {
			return this.Children._MenuItems.Any();
		}


		/// <summary>
		/// Resets the object back to a known state.
		/// </summary>
		protected void Reset() {
			this.Title = "";
			this.Icon = "";
			this.TargetURL = "";
			this.Html = "";
		}


		/// <summary>
		/// Builds up the Html for a menu-item
		/// </summary>
		/// <param name="sb"></param>
		protected internal void BuildTagHtml(jStringBuilder sb) {
			bool prettyRender = this.Menu.Rendering.PrettyRender;
			bool renderCss = this.Menu.Rendering.RenderCSS;
			int tabDepth = this.Menu.Rendering.TabDepth;
			_IsRoot = (this.Menu.Root == this);
			
			if (_IsRoot)
				RenderRootOpenItem(sb);
			else 
				RenderOpenItem(sb);

			if (this.HasChildren()) {
				RenderChildren(sb);
			}

			if (_IsRoot)
				RenderRootCloseItem(sb);
			else
				RenderCloseItem(sb);
			
		} // BuildTagHtml


		private void RenderRootOpenItem(jStringBuilder sb) {
			sb.AppendTabsFormat("<{0}", this.Menu.Options.Menus);
			this.Menu.RenderAttributes(sb);
			sb.AppendLineIf(">");
		}

		private void RenderRootCloseItem(jStringBuilder sb) {
			sb.AppendTabsFormat("</{0}>", this.Menu.Options.Menus);
		}

		private void RenderOpenItem(jStringBuilder sb) {
			bool renderCss = this.Menu.Rendering.RenderCSS;

			sb.AppendTabsFormat("<{0}", this.Tag);

			if (this.IsDivider) {
				if (renderCss)
					this.AddCssClass("ui-widget-content ui-menu-divider");
				this.RenderAttributes(sb);
				sb.Append(">");
				return;
			}

			if (renderCss) 
				this.AddCssClass("ui-menu-item");
			
			if (this.IsDisabled)
				this.AddCssClass("ui-state-disabled");
			
			this.RenderAttributes(sb);

			sb.Append(">");
			if (!string.IsNullOrEmpty(this.Html)) 
				sb.Append(this.Html);
			else {
				if (!string.IsNullOrEmpty(this.TargetURL))
					sb.AppendFormat("<a href=\"{0}\"", this.TargetURL);
				else 
					sb.AppendFormat("<a href=\"#\"");
				
				if (renderCss)
					sb.Append(" class=\"ui-corner-all\"");

				sb.Append(">");
			
				if (!string.IsNullOrEmpty(this.Icon)) {
					sb.AppendFormat("<span class=\"ui-icon {0}\"></span>", this.Icon);
				}
				// Title is mandatory when not using the HTML version
				sb.Append(this.Title);
				sb.Append("</a>");
			}			
		}

		private void RenderCloseItem(jStringBuilder sb) {
			sb.AppendFormat("</{0}>", this.Tag);
		}

		/// <summary>
		/// Renders the list of MenuItems to the string builder.  
		/// </summary>
		/// <param name="sb">StringBuilder</param>
		protected internal void RenderChildren(jStringBuilder sb) {
			// Open list/item
			if (!_IsRoot)
				sb.AppendTabsFormat("<{0}>", this.Menu.Options.Menus);

			foreach (MenuItem mi in this.Children._MenuItems) {
				mi.BuildTagHtml(sb);
			}

			// Close list/item
			if (!_IsRoot)
				sb.AppendTabsFormatLineIf("</{0}>", this.Menu.Options.Menus);
		}

	}

}
