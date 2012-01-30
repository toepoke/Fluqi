using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension.Helpers;
using Fluqi.Interfaces;

namespace Fluqi.Core {
	
	public class ControlDictionaryBase<T>: Dictionary<string, T> { //, ControlBase<T> {
		
		private Core.ControlBase<T> _ControlHelper = null;

		public ControlDictionaryBase() {
			_ControlHelper = new Core.ControlBase<T>();
		}


		/// <summary>
		/// Registers a set of CSS class names to be added to the control when it is rendered.
		/// This is in addition to jQuery UI styles that may appear (see RenderCss property).
		/// </summary>
		/// <param name="cssClasses">Set of space separated CSS class names to add</param>
		/// <returns>Returns this for chainability</returns>
		public ControlBase<T> WithCss(string cssClasses) {
			return _ControlHelper.WithCss(cssClasses);
		}


		/// <summary>
		/// Registers a set of CSS class names to be added to the control when it is rendered.
		/// This is in addition to jQuery UI styles that may appear (see RenderCss property).
		/// This override supports adding dynamic parameters (i.e. {0} {1}, etc).
		/// </summary>
		/// <param name="cssClassesWithFormat">Set of space separated CSS class names to add (which has formatting arguments ({0}{1], etc))</param>
		/// <param name="args"></param>
		/// <returns>Returns this for chainability</returns>
		public ControlBase<T> WithCss(string cssClassesWithFormat, params object[] args) {
			return _ControlHelper.WithCss(cssClassesWithFormat, args);
		}


		/// <summary>
		/// Registers an HTML attribute to be added to the control when it is rendered.
		/// </summary>
		/// <param name="attrName">Name of the HTML attribute, e.g. "autocomplete" or "id" for example</param>
		/// <param name="attrValue">Value to be applied when the attribute is rendered</param>
		/// <returns>Returns this for chainability</returns>
		public ControlBase<T> WithAttribute(string attrName, string attrValue) {
			return _ControlHelper.WithAttribute(attrName, attrValue);
		}


		/// <summary>
		/// Registers an HTML attribute to be added to the control when it is rendered.
		/// This override supports adding dynamic parameters (i.e. {0} {1}, etc).
		/// </summary>
		/// <param name="attrName">Name of the HTML attribute, e.g. "autocomplete" or "id" for example</param>
		/// <param name="attrValueWithFormat">Value to be applied when the attribute is rendered (which has formatting arguments ({0}{1], etc))</param>
		/// <returns>Returns this for chainability</returns>
		public ControlBase<T> WithAttribute(string attrName, string attrValueWithFormat, params object[] args) {
			return _ControlHelper.WithAttribute(attrName, attrValueWithFormat, args);
		}


		/// <summary>
		/// Registers an embedded style setting to be added to the control when it is rendered.
		/// These are written out as part of the "style" attribute, so we might add 'WithStyle("border", "solid 1px blue")' for example.
		/// </summary>
		/// <param name="styleName">Name of the style attribute to be added</param>
		/// <param name="styleValue">Value of the style to be added</param>
		/// <returns>Returns this for chainability</returns>
		public ControlBase<T> WithStyle(string styleName, string styleValue) {
			return _ControlHelper.WithStyle(styleName, styleValue);
		}


		/// <summary>
		/// Registers an embedded style setting to be added to the control when it is rendered.
		/// These are written out as part of the "style" attribute, so we might add 'WithStyle("border", "solid 1px blue")' for example.
		/// </summary>
		/// <param name="styleName">Name of the style attribute to be added</param>
		/// <param name="styleValueWithFormat">Value of the style to be added (which has formatting arguments ({0}{1], etc))</param>
		/// <returns>Returns this for chainability</returns>
		public ControlBase<T> WithStyle(string styleName, string styleValueWithFormat, params object[] args) {
			return _ControlHelper.WithStyle(styleName, styleValueWithFormat, args);
		}


		/// <summary>
		/// Registers an ID attribute to be added to the control when it is rendered.
		/// </summary>
		/// <param name="idValue">Value for the ID</param>
		/// <returns>Returns this for chainability</returns>
		public ControlBase<T> WithID(string idValue) {
			return _ControlHelper.WithID(idValue);
		}


		/// <summary>
		/// Adds a set of class names to render with the control
		/// </summary>
		/// <param name="cssClasses">Set of class names to add (note you can add multiple class names separated by spaces)</param>
		protected internal ControlBase<T> AddCssClass(string cssClasses) {
			return _ControlHelper.AddCssClass(cssClasses);
		}


		/// <summary>
		/// Adds an additional attribute to be rendered by the control
		/// </summary>
		/// <param name="attrName">Name of the attribute</param>
		/// <param name="attrValue">Value to be associated with the attribute</param>
		protected internal ControlBase<T> AddAttribute(string attrName, string attrValue) {
			return _ControlHelper.AddAttribute(attrName, attrValue);
		}


		/// <summary>
		/// Adds an additional embedded style to be rendered by the controll
		/// </summary>
		/// <param name="styleName">Name of the style to add, e.g. "width" or "border"</param>
		/// <param name="styleValue">Value of the style to add</param>
		/// <returns>Returns this for chainability</returns>
		protected internal ControlBase<T> AddStyle(string styleName, string styleValue) {
			return _ControlHelper.AddStyle(styleName, styleValue);
		}


		/// <summary>
		/// Renders the registered attributes to the provided jStringBuilder object.  The registered
		/// CSS classes and Style rules are also added at this point (as they're attributes as well really).
		/// </summary>
		protected internal void RenderAttributes(jStringBuilder sb) {
			_ControlHelper.RenderAttributes(sb);
		}

	}

}
