using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jMenu
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Menu.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Menu
	{
		/// <summary>
		/// Registers a set of CSS class names to be added to the control when it is rendered.
		/// This is in addition to jQuery UI styles that may appear (see RenderCss property).
		/// </summary>
		/// <param name="cssClasses">Set of space separated CSS class names to add</param>
		/// <returns>Returns this for chainability</returns>
		new public Menu WithCss(string cssClasses) {
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
		new public Menu WithCss(string cssClassesWithFormat, params object[] args) {
			base.WithCss(cssClassesWithFormat, args);
			return this;
		}


		/// <summary>
		/// Registers an HTML attribute to be added to the control when it is rendered.
		/// </summary>
		/// <param name="attrName">Name of the HTML attribute, e.g. "Menu" or "id" for example</param>
		/// <param name="attrValue">Value to be applied when the attribute is rendered</param>
		/// <returns>Returns this for chainability</returns>
		new public Menu WithAttribute(string attrName, string attrValue) {
			base.AddAttribute(attrName, attrValue);
			return this;
		}


		/// <summary>
		/// Registers an HTML attribute to be added to the control when it is rendered.
		/// This override supports adding dynamic parameters (i.e. {0} {1}, etc).
		/// </summary>
		/// <param name="attrName">Name of the HTML attribute, e.g. "Menu" or "id" for example</param>
		/// <param name="attrValueWithFormat">Value to be applied when the attribute is rendered (which has formatting arguments ({0}{1], etc))</param>
		/// <param name="args">Set of arguments to pass to String.Format</param>
		/// <returns>Returns this for chainability</returns>
		new public Menu WithAttribute(string attrName, string attrValueWithFormat, params object[] args) {
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
		new public Menu WithStyle(string styleName, string styleValue) {
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
		public Menu WithStyle(string styleName, string styleValueWithFormat, params Menu[] args) {
			base.WithStyle(styleName, styleValueWithFormat, args);
			return this;
		}


		/// <summary>
		/// Registers an ID attribute to be added to the control when it is rendered.
		/// </summary>
		/// <param name="idValue">Value for the ID</param>
		/// <returns></returns>
		new protected internal Menu WithID(string idValue) {
			base.WithID(idValue);
			return this;
		}


	} // IControlBase

} // ns
