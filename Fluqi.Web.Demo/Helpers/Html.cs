using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Linq.Expressions;

namespace Fluqi.Web.Demo.Helpers {
	
	public static class Html {

		public static MvcHtmlString TextBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string classes, string tooltip) 
		{
			var atts = BuildAttributes(classes, tooltip);
			return htmlHelper.TextBoxFor<TModel, TProperty>(expression, atts);
		}

		public static MvcHtmlString TextBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string tooltip) 
		{
			return htmlHelper.TextBoxFor(expression, "", tooltip);
		}

		public static MvcHtmlString CheckBoxFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, bool>> expression, string classes, string tooltip) {
			var atts = BuildAttributes(classes, tooltip);
			return htmlHelper.CheckBoxFor<TModel>(expression, atts);
		}

		public static MvcHtmlString CheckBoxFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, bool>> expression, string tooltip) {
			return htmlHelper.CheckBoxFor(expression, "", tooltip);
		}

		public static MvcHtmlString DropDownTipListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, string classes, string tooltip) {
			var atts = BuildAttributes(classes, tooltip);
			return htmlHelper.DropDownListFor(expression, selectList, atts);
		}

		public static MvcHtmlString DropDownTipListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, string tooltip) {
			return htmlHelper.DropDownTipListFor(expression, selectList, "", tooltip);
		}

		private static Dictionary<string, object> BuildAttributes(string classes, string tooltip) {
			var htmlAttributes = new Dictionary<string, object>();
			if (!string.IsNullOrEmpty(tooltip))
				htmlAttributes.Add("title", tooltip);
			if (!string.IsNullOrEmpty(classes))
				htmlAttributes.Add("class", classes);
			return htmlAttributes;						
		}
	}

}