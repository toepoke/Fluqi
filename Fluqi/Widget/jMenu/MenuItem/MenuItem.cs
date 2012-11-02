
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
	public class MenuItem: Core.ControlBase {

		public const string DEFAULT_SINGLE_TAG = "li";

		public MenuItem(jMenu.Menu owner, string id)
		{
			this.Menu = owner;
			this.Tag = jMenu.Options.DEFAULT_MENUS;
			this.Children = new MenuItems(this, id);
			this.Parent = null;
		}

		public MenuItem(MenuItem parent) {
			this.Parent = parent;
			this.Menu = parent.Menu;
			this.Tag = jMenu.Options.DEFAULT_MENUS;
			this.Children = new MenuItems(this);
		}

		/// <summary>
		/// Holds a reference to the menu the item is on
		/// </summary>
		protected internal jMenu.Menu Menu { get; set; }

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
		private bool _IsRoot { get; set; }

		public MenuItem SetTitle(string value) {
			this.Title = value;
			return this;
		}

		public MenuItem SetIcon(string value) {
			this.Icon = value;
			return this;
		}

		public MenuItem SetIcon(Core.Icons.eIconClass value) {
			return this.SetIcon( Core.Icons.ByEnum(value) );
		}

		public MenuItem SetTargetURL(string value) {
			this.TargetURL = value;
			return this;
		}
				
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
			sb.AppendTabsFormat("<{0}", this.Tag);
			this.Menu.RenderAttributes(sb);
			sb.AppendLineIf(">");
		}

		private void RenderRootCloseItem(jStringBuilder sb) {
			sb.AppendTabsFormat("</{0}>", this.Tag);
		}

		private void RenderOpenItem(jStringBuilder sb) {
			sb.AppendTabsFormat("<{0}>", DEFAULT_SINGLE_TAG);

			if (!string.IsNullOrEmpty(this.Html)) 
				sb.Append(this.Html);
			else {
				if (!string.IsNullOrEmpty(this.TargetURL))
					sb.AppendFormat("<a href=\"{0}\">", this.TargetURL);
				else 
					sb.AppendFormat("<a href=\"#\">");
			
				if (!string.IsNullOrEmpty(this.Icon)) {
					sb.AppendFormat("<span class=\"ui-icon {0}\"></span>", this.Icon);
				}
				// Title is mandatory when not using the HTML version
				sb.Append(this.Title);
				sb.Append("</a>");
			}			
		}

		private void RenderCloseItem(jStringBuilder sb) {
			sb.AppendFormat("</{0}>", DEFAULT_SINGLE_TAG);
		}

		protected internal void RenderChildren(jStringBuilder sb) {
			// Open list/item
			if (!_IsRoot)
				sb.AppendTabsFormat("<{0}>", this.Tag);			

			foreach (MenuItem mi in this.Children._MenuItems) {
				mi.BuildTagHtml(sb);
			}

			// Close list/item
			if (!_IsRoot)
				sb.AppendTabsFormatLineIf("</{0}>", this.Tag);
		}

	}

}
