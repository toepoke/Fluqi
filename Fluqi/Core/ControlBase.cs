using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;
using Fluqi.Core.Interfaces;
using System.Web;

namespace Fluqi.Core {
	
	/// <summary>
	/// Base class for jQuery UI controls, abstracting out common functionality.
	/// </summary>
	public class ControlBase {
		
		/// <summary>
		/// Holds the CSS classes to be added when rendering the control.
		/// </summary>
		protected List<string> _CssClasses = null;

		/// <summary>
		/// Holds a set of additional attributes to be rendered by the control.
		/// </summary>
		protected Dictionary<string, string> _HtmlAttr = null;

		/// <summary>
		/// Holds a set of Style attributes to be rendered by the control.
		/// </summary>
		protected Dictionary<string, string> _Styles = null;

		/// <summary>
		/// Constructor
		/// </summary>
		public ControlBase() {
			this._CssClasses = new List<string>();
			this._HtmlAttr = new Dictionary<string,string>();
			this._Styles = new Dictionary<string,string>();
		}


		/// <summary>
		/// Registers a set of CSS class names to be added to the control when it is rendered.
		/// This is in addition to jQuery UI styles that may appear (see RenderCss property).
		/// </summary>
		/// <param name="cssClasses">Set of space separated CSS class names to add</param>
		/// <returns>Returns this for chainability</returns>
		protected internal void WithCss(string cssClasses) {
		  this.AddCssClass(cssClasses);
		}


		/// <summary>
		/// Registers a set of CSS class names to be added to the control when it is rendered.
		/// This is in addition to jQuery UI styles that may appear (see RenderCss property).
		/// This override supports adding dynamic parameters (i.e. {0} {1}, etc).
		/// </summary>
		/// <param name="cssClassesWithFormat">Set of space separated CSS class names to add (which has formatting arguments ({0}{1], etc))</param>
		/// <param name="args"></param>
		/// <returns>Returns this for chainability</returns>
		protected internal void WithCss(string cssClassesWithFormat, params object[] args) {
		  this.WithCss( string.Format(cssClassesWithFormat, args) );
		}


		/// <summary>
		/// Registers an HTML attribute to be added to the control when it is rendered.
		/// </summary>
		/// <param name="attrName">Name of the HTML attribute, e.g. "autocomplete" or "id" for example</param>
		/// <param name="attrValue">Value to be applied when the attribute is rendered</param>
		/// <returns>Returns this for chainability</returns>
		protected internal void WithAttribute(string attrName, string attrValue) {
		  this.AddAttribute(attrName, attrValue);
		}


		/// <summary>
		/// Registers an HTML attribute to be added to the control when it is rendered.
		/// This override supports adding dynamic parameters (i.e. {0} {1}, etc).
		/// </summary>
		/// <param name="attrName">Name of the HTML attribute, e.g. "autocomplete" or "id" for example</param>
		/// <param name="attrValueWithFormat">Value to be applied when the attribute is rendered (which has formatting arguments ({0}{1], etc))</param>
		/// <param name="args">Set of arguments to pass to String.Format</param>
		/// <returns>Returns this for chainability</returns>
		protected internal void WithAttribute(string attrName, string attrValueWithFormat, params object[] args) {
		  this.WithAttribute(attrName, string.Format(attrValueWithFormat, args) );
		}


		/// <summary>
		/// Registers an embedded style setting to be added to the control when it is rendered.
		/// These are written out as part of the "style" attribute, so we might add 'WithStyle("border", "solid 1px blue")' for example.
		/// </summary>
		/// <param name="styleName">Name of the style attribute to be added</param>
		/// <param name="styleValue">Value of the style to be added</param>
		/// <returns>Returns this for chainability</returns>
		protected internal void WithStyle(string styleName, string styleValue) {
		  this.AddStyle(styleName, styleValue);
		}


		/// <summary>
		/// Registers an embedded style setting to be added to the control when it is rendered.
		/// These are written out as part of the "style" attribute, so we might add 'WithStyle("border", "solid 1px blue")' for example.
		/// </summary>
		/// <param name="styleName">Name of the style attribute to be added</param>
		/// <param name="styleValueWithFormat">Value of the style to be added (which has formatting arguments ({0}{1], etc))</param>
		/// <param name="args">Set of arguments to pass to String.Format</param>
		/// <returns>Returns this for chainability</returns>
		protected internal void WithStyle(string styleName, string styleValueWithFormat, params object[] args) {
		  this.WithStyle(styleName, string.Format(styleValueWithFormat, args) );
		}


		/// <summary>
		/// Registers an ID attribute to be added to the control when it is rendered.
		/// </summary>
		/// <param name="idValue">Value for the ID</param>
		/// <returns>Returns this for chainability</returns>
		protected internal void WithID(string idValue) {
		  this.WithAttribute("id", idValue);
		}


		/// <summary>
		/// Adds a set of class names to render with the control
		/// </summary>
		/// <param name="cssClasses">Set of class names to add (note you can add multiple class names separated by spaces)</param>
		/// <returns>Returns this for chainability</returns>
		protected internal void AddCssClass(string cssClasses) {
			if (string.IsNullOrEmpty(cssClasses))
				// nothing to see here
				return;

			string[] classes = cssClasses.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
			
			// avoid adding duplicates
			foreach (string cls in classes) {
				if (!_CssClasses.Exists(c => c.IgnorantEquals(cls) ))
					_CssClasses.Add(cls);
			}
		}


		/// <summary>
		/// Adds an additional attribute to be rendered by the control
		/// </summary>
		/// <param name="attrName">Name of the attribute</param>
		/// <param name="attrValue">Value to be associated with the attribute</param>
		/// <returns>Returns this for chainability</returns>
		protected internal void AddAttribute(string attrName, string attrValue) {
			if (string.IsNullOrEmpty(attrName) || string.IsNullOrEmpty(attrValue))
				// nothing to see here
				return;

			if (_HtmlAttr.ContainsKey(attrName))
				// overwrite existing value
				_HtmlAttr[attrName] = attrValue;
			else 
				_HtmlAttr.Add(attrName, attrValue);
		}


		/// <summary>
		/// Adds an additional embedded style to be rendered by the controll
		/// </summary>
		/// <param name="styleName">Name of the style to add, e.g. "width" or "border"</param>
		/// <param name="styleValue">Value of the style to add</param>
		/// <returns>Returns this for chainability</returns>
		protected internal void AddStyle(string styleName, string styleValue) {
			if (string.IsNullOrEmpty(styleName) || string.IsNullOrEmpty(styleValue)) 
				// nothing to see here
				return;

			// remove any semi-colon separators
			styleValue = styleValue.Trim(";".ToCharArray());

			if (_Styles.ContainsKey(styleName)) 
				// merge with existing values
				_Styles[styleName] += styleValue;
			else 
				_Styles.Add(styleName, styleValue);
		}


		/// <summary>
		/// Renders the registered attributes to the provided jStringBuilder object.  The registered
		/// CSS classes and Style rules are also added at this point (as they're attributes as well really).
		/// </summary>
		protected internal void RenderAttributes(jStringBuilder sb) {
			bool hasID = _HtmlAttr.Keys.Any(x => x == "id");
			// force the ID to come out first (as this is what you're interested in 90% of the time)
			if (hasID) {
				sb.AppendFormat(" id=\"{0}\"", HttpUtility.HtmlAttributeEncode(_HtmlAttr["id"].ToString()) );
			}

			// add in any defined CSS classes
			if (_CssClasses.Any()) {
				sb.Append(" class=\"");
				sb.Append(this._CssClasses.ToSeparated(" ") );
				sb.Append("\"");
			}

			// add in the full style rules
			if (_Styles.Any()) {
				sb.Append(" style=\"");
				foreach (string key in this._Styles.Keys) {
					sb.AppendFormat("{0}:{1};", HttpUtility.HtmlAttributeEncode(key), HttpUtility.HtmlAttributeEncode(_Styles[key].ToString()) );
				}
				sb.TrimEnd(";");
				sb.Append("\"");
			}

			if (_HtmlAttr.Any()) {
				// avoid ID as this will already have been added
				foreach (string key in _HtmlAttr.Keys.Where(x => x != "id")) {
					sb.AppendFormat(" {0}=\"{1}\"", key, HttpUtility.HtmlAttributeEncode(_HtmlAttr[key].ToString()) );
				}
			}
		}

	} // ControlBase

} // Fluqi.Core
