
namespace Fluqi.Widget.jSelectMenuItem {
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Fluqi.Extension.Helpers;
	using System.Web;

	/// <summary>
	/// Defines the logic and rendering of a single option.
	/// </summary>
	public partial class SelectMenuOptGroup: SelectMenuItemBase {

		protected const string PARENT_TAG = "optgroup";
		protected const string CHILD_TAG = "OPTION";
		protected const string LABEL_TAG = "label";

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="owner">SelectMenu object _this_ item belongs to</param>
		public SelectMenuOptGroup(jSelectMenu.SelectMenu owner)	{
		  this.SelectMenu = owner;
		  this.Children = new SelectMenuItems(this);
		  this.Parent = null;
			this.Reset();
		}

		/// <summary>
		/// Constructor for a child menu option
		/// </summary>
		/// <param name="parent">SelectMenuItem object _this_ item belongs to</param>
		public SelectMenuOptGroup(SelectMenuItemBase parent) {
			this.Parent = parent;
			this.SelectMenu = parent.SelectMenu;
			this.Children = new SelectMenuItems(this);
			this.Reset();
		}

		/// <summary>
		/// Specifies that the rendered menu item should be disabled.
		/// </summary>
		protected internal bool IsDisabled { get; set; }

		/// <summary>
		/// Group label
		/// </summary>
		protected internal string Label { get; set; }

		/// <summary>
		/// Flags whether this MenuItem is the root of the menu.
		/// </summary>
		protected bool _IsRoot { get; set; }

		/// <summary>
		/// Changes the label
		/// </summary>
		/// <returns>this for chainability</returns>
		public SelectMenuOptGroup SetLabel(string label) {
			this.Label = label;
			return this;
		}

		/// <summary>
		/// Sets this menu item as disabled
		/// </summary>
		/// <returns>this for chainability</returns>
		public SelectMenuOptGroup SetDisabled() {
			this.IsDisabled = true;
			return this;
		}

		/// <summary>
		/// Resets the object back to a known state.
		/// </summary>
		protected void Reset() {
			this.IsDisabled = false;
		}


		/// <summary>
		/// Builds up the Html for a select menuitem
		/// </summary>
		/// <param name="sb"></param>
		override protected internal void BuildTagHtml(jStringBuilder sb) {
			bool prettyRender = this.SelectMenu.Rendering.PrettyRender;
			bool renderCss = this.SelectMenu.Rendering.RenderCSS;
			int tabDepth = this.SelectMenu.Rendering.TabDepth;
			_IsRoot = (this.SelectMenu.Root == this);
			
			//if (_IsRoot)
			//  RenderRootOpenItem(sb);
			// else
			//	... not needed - open is part of the child in this instance

			if (this.HasChildren()) {
				RenderChildren(sb);
			}

			//if (_IsRoot)
			//  RenderRootCloseItem(sb);
			// else
			//	... not needed - open is part of the child in this instance
			
		} // BuildTagHtml


		/// <summary>
		/// Renders the list of SelectMenuItems to the string builder.  
		/// Note: For the SelectMenu this only happens for the root (i.e. this isn't recursive like the Menu control)
		/// </summary>
		/// <param name="sb">StringBuilder</param>
		protected internal void RenderChildren(jStringBuilder sb) {
			// Open list/item
			if (!_IsRoot) {
				RenderRootOpenItem(sb);
			}

			foreach (SelectMenuItem mi in this.Children._SelectMenuItems) {
				mi.BuildTagHtml(sb);
			}

			// Close list/item
			if (!_IsRoot) {
				RenderRootCloseItem(sb);
			}
		}

		private void RenderRootOpenItem(jStringBuilder sb) {
			sb.AppendTabsFormat("<{0}", PARENT_TAG);
			if (!string.IsNullOrEmpty(this.Label)) {
				sb.AppendFormat(" {0}=\"{1}\"", 
					LABEL_TAG, 
					HttpUtility.HtmlAttributeEncode(this.Label)
				);
			}
			if (this.IsDisabled) {
				sb.Append(" disabled=\"disabled\"");
			}
			this.RenderAttributes(sb);
			sb.Append(">");
		}

		private void RenderRootCloseItem(jStringBuilder sb) {
			sb.AppendTabsFormatLineIf("</{0}>", PARENT_TAG);
		}

	}

}
