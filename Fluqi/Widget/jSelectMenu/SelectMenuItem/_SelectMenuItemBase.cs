using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jSelectMenuItem
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Tab.
	/// </summary>
	public partial class SelectMenuItemBase: Core.ControlBase
	{
		/// <summary>
		/// Set of sub MenuItems for this item of the menu.
		/// </summary>
		protected internal SelectMenuItems Children { get; set; }

		/// <summary>
		/// Convenience function for eastablishing if there are any child/sub-menu items off this menu item.
		/// </summary>
		/// <returns></returns>
		protected internal bool HasChildren() {
			return this.Children._SelectMenuItems.Any();
		}

		/// <summary>
		/// Holds a reference to the select menu the option is on
		/// </summary>
		protected internal jSelectMenu.SelectMenu SelectMenu { get; set; }

		/// <summary>
		/// Navigates to the MenuItem this MenuItem is contained within.
		/// </summary>
		protected internal SelectMenuItemBase Parent { get; set; }

		/// <summary>
		/// Ends configuration of the option just added and brings the fluent API back a level to 
		/// allow further select menu items to be added.
		/// </summary>
		/// <returns>Parent MenuItems object to maintain fluent API reference point</returns>
		public SelectMenuItems Finish() {
			return this.Parent.Children;
		}

		
		/// <summary>
		/// Registers a set of CSS class names to be added to the control when it is rendered.
		/// This is in addition to jQuery UI styles that may appear (see RenderCss property).
		/// </summary>
		/// <param name="cssClasses">Set of space separated CSS class names to add</param>
		/// <returns>Returns this for chainability</returns>
		new public SelectMenuItemBase WithCss(string cssClasses) {
			base.WithCss(cssClasses);
			return this;
		}


		/// <summary>
		/// Registers a set of CSS class names to be added to the control when it is rendered.
		/// This is in addition to jQuery UI styles that may appear (see RenderCss property).
		/// This override supports adding dynamic parameters (i.e. {0} {1}, etc).
		/// </summary>
		/// <param name="cssClassesWithFormat">Set of space separated CSS class names to add (which has formatting arguments ({0}{1], etc))</param>
		/// <param name="args"></param>
		/// <returns>Returns this for chainability</returns>
		new public SelectMenuItemBase WithCss(string cssClassesWithFormat, params object[] args) {
			this.WithCss(cssClassesWithFormat, args);
			return this;
		}


		/// <summary>
		/// Registers an HTML attribute to be added to the control when it is rendered.
		/// </summary>
		/// <param name="attrName">Name of the HTML attribute, e.g. "Tab" or "id" for example</param>
		/// <param name="attrValue">Value to be applied when the attribute is rendered</param>
		/// <returns>Returns this for chainability</returns>
		new public SelectMenuItemBase WithAttribute(string attrName, string attrValue) {
			base.WithAttribute(attrName, attrValue);
			return this;
		}


		/// <summary>
		/// Registers an HTML attribute to be added to the control when it is rendered.
		/// This override supports adding dynamic parameters (i.e. {0} {1}, etc).
		/// </summary>
		/// <param name="attrName">Name of the HTML attribute, e.g. "Tab" or "id" for example</param>
		/// <param name="attrValueWithFormat">Value to be applied when the attribute is rendered (which has formatting arguments ({0}{1], etc))</param>
		/// <param name="args">Set of arguments to pass to String.Format</param>
		/// <returns>Returns this for chainability</returns>
		new public SelectMenuItemBase WithAttribute(string attrName, string attrValueWithFormat, params object[] args) {
			base.WithAttribute(attrName, attrValueWithFormat, args);
			return this;
		}


		/// <summary>
		/// Registers an embedded style setting to be added to the control when it is rendered.
		/// These are written out as part of the "style" attribute, so we might add 'WithStyle("border", "solid 1px blue")' for example.
		/// </summary>
		/// <param name="styleName">Name of the style attribute to be added</param>
		/// <param name="styleValue">Value of the style to be added</param>
		/// <returns>Returns this for chainability</returns>
		new public SelectMenuItemBase WithStyle(string styleName, string styleValue) {
			base.WithStyle(styleName, styleValue);
			return this;
		}


		/// <summary>
		/// Registers an embedded style setting to be added to the control when it is rendered.
		/// These are written out as part of the "style" attribute, so we might add 'WithStyle("border", "solid 1px blue")' for example.
		/// </summary>
		/// <param name="styleName">Name of the style attribute to be added</param>
		/// <param name="styleValueWithFormat">Value of the style to be added (which has formatting arguments ({0}{1], etc))</param>
		/// <param name="args">Set of arguments to pass to String.Format</param>
		/// <returns>Returns this for chainability</returns>
		new public SelectMenuItemBase WithStyle(string styleName, string styleValueWithFormat, params object[] args) {
			base.WithStyle(styleName, styleValueWithFormat, args);
			return this;
		}


		/// <summary>
		/// Registers an ID attribute to be added to the control when it is rendered.
		/// </summary>
		/// <param name="idValue">Value for the ID</param>
		/// <returns></returns>
		new public SelectMenuItemBase WithID(string idValue) {
			base.WithID(idValue);
			return this;
		}
		
		/// <summary>
		/// Override entry-point for the SelectMenuItem and SelectOptGroups classes to render how they should be
		/// </summary>
		/// <param name="sb"></param>
		virtual protected internal void BuildTagHtml(jStringBuilder sb) {

		}

	}
		
} // ns
