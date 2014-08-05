
namespace Fluqi.Widget.jSelectMenuItem {
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Fluqi.Extension.Helpers;

	/// <summary>
	/// Defines the logic and rendering of a single option.
	/// </summary>
	public partial class SelectMenuItem: Core.ControlBase {

		/// <summary>
		/// Default tag to use for a SelectMenuItem ("OPTION" by default, and frankly it should always be "OPTION"!)
		/// </summary>
		public const string DEFAULT_SINGLE_TAG = "option";

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="owner">SelectMenu object _this_ item belongs to</param>
		public SelectMenuItem(jSelectMenu.SelectMenu owner)
		{
		  this.SelectMenu = owner;
		  this.Children = new SelectMenuItems(this);
		  this.Parent = null;
			this.Reset();
		}

		/// <summary>
		/// Constructor for a child menu option
		/// </summary>
		/// <param name="parent">SelectMenuItem object _this_ item belongs to</param>
		public SelectMenuItem(SelectMenuItem parent) {
			this.Parent = parent;
			this.SelectMenu = parent.SelectMenu;
			this.Children = new SelectMenuItems(this);
			this.Reset();
		}

		/// <summary>
		/// Holds a reference to the select menu the option is on
		/// </summary>
		protected internal jSelectMenu.SelectMenu SelectMenu { get; set; }

		/// <summary>
		/// Specifies that the rendered menu item should be disabled.
		/// </summary>
		protected internal bool IsDisabled { get; set; }

		/// <summary>
		/// Text to appear in the item
		/// </summary>
		protected internal string Title { get; set; }

		/// <summary>
		/// Value of the item
		/// </summary>
		protected internal string Value { get; set; }

		/// <summary>
		/// Icon to appear alongside the menu item
		/// ToDo: Can these appear on the left hand and right hand side?
		/// </summary>
		protected internal string Icon { get; set; }

		/// <summary>
		/// Html tag to use for containing menu-items.  By default this is LI.
		/// </summary>
		protected internal string Tag { get; set; }

		/// <summary>
		/// Set of sub MenuItems for this item of the menu.
		/// </summary>
		protected internal SelectMenuItems Children { get; set; }

		/// <summary>
		/// Navigates to the MenuItem this MenuItem is contained within.
		/// </summary>
		protected internal SelectMenuItem Parent { get; set; }

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
		public SelectMenuItem SetTitle(string title) {
			this.Title = title;
			return this;
		}

		/// <summary>
		/// Changes the value of the menu item.
		/// </summary>
		/// <param name="value">value</param>
		/// <returns>this for chainability</returns>
		public SelectMenuItem SetValue(object value) {
			this.Value = value.ToString();
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
		public SelectMenuItem SetIcon(string cssClass) {
			this.Icon = cssClass;
			return this;
		}

		/// <summary>
		/// Sets the icon which appears to the left of the menu item.  This is one of the built in
		/// icons provdided by the jQuery UI framework.
		/// </summary>
		/// <returns>this for chainability</returns>
		public SelectMenuItem SetIcon(Core.Icons.eIconClass value) {
			return this.SetIcon( Core.Icons.ByEnum(value) );
		}

		/// <summary>
		/// Sets the tag to use (should only be "OPTION" really)
		/// </summary>
		/// <returns>this for chainability</returns>
		public SelectMenuItem SetTag(string value) {
			this.Tag = value;
			return this;
		}
			
		/// <summary>
		/// Sets this menu item as disabled
		/// </summary>
		/// <returns>this for chainability</returns>
		public SelectMenuItem SetDisabled() {
			this.IsDisabled = true;
			return this;
		}

		/// <summary>
		/// Ends configuration of the option just added and brings the fluent API back a level to 
		/// allow further select menu items to be added.
		/// </summary>
		/// <returns>Parent MenuItems object to maintain fluent API reference point</returns>
		public SelectMenuItems Finish() {
			return this.Parent.Children;
		}

		/// <summary>
		/// Convenience function for eastablishing if there are any child/sub-menu items off this menu item.
		/// </summary>
		/// <returns></returns>
		protected internal bool HasChildren() {
			return this.Children._SelectMenuItems.Any();
		}


		/// <summary>
		/// Resets the object back to a known state.
		/// </summary>
		protected void Reset() {
			this.Title = "";
			this.Icon = "";
			this.Tag = DEFAULT_SINGLE_TAG;
			this.IsDisabled = false;
		}


		/// <summary>
		/// Builds up the Html for a select menuitem
		/// </summary>
		/// <param name="sb"></param>
		protected internal void BuildTagHtml(jStringBuilder sb) {
			bool prettyRender = this.SelectMenu.Rendering.PrettyRender;
			bool renderCss = this.SelectMenu.Rendering.RenderCSS;
			int tabDepth = this.SelectMenu.Rendering.TabDepth;
			_IsRoot = (this.SelectMenu.Root == this);
			
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
			sb.AppendTabsFormat("<{0}", this.SelectMenu.Options.SelectTag);
			this.SelectMenu.RenderAttributes(sb);
			sb.AppendLineIf(">");
		}

		private void RenderRootCloseItem(jStringBuilder sb) {
			sb.AppendTabsFormat("</{0}>", this.SelectMenu.Options.SelectTag);
		}

		private void RenderOpenItem(jStringBuilder sb) {
			bool renderCss = this.SelectMenu.Rendering.RenderCSS;

			sb.AppendTabsFormat("<{0}", this.Tag);

			this.RenderAttributes(sb);
			
			if (!string.IsNullOrEmpty(this.Value)) {
				sb.AppendFormat(" value=\"{0}\"", this.Value);
			}

			sb.Append(">");
			sb.Append(this.Title);
		}

		private void RenderCloseItem(jStringBuilder sb) {
			sb.AppendFormat("</{0}>", this.Tag);
		}

		/// <summary>
		/// Renders the list of SelectMenuItems to the string builder.  
		/// Note: For the SelectMenu this only happens for the root (i.e. this isn't recursive like the Menu control)
		/// </summary>
		/// <param name="sb">StringBuilder</param>
		protected internal void RenderChildren(jStringBuilder sb) {
			// Open list/item
			if (!_IsRoot)
				sb.AppendTabsFormat("<{0}>", this.SelectMenu.Options.SelectTag);

			foreach (SelectMenuItem mi in this.Children._SelectMenuItems) {
				mi.BuildTagHtml(sb);
			}

			// Close list/item
			if (!_IsRoot)
				sb.AppendTabsFormatLineIf("</{0}>", this.SelectMenu.Options.SelectTag);
		}

	}

}
