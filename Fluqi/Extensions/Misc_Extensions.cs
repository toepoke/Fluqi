using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Widget.jAccordion;
using System.Web;
using System.Web.Mvc;

namespace Fluqi.Extension {

	/// <summary>
	/// Set of extensions that help in the function of the library.
	/// </summary>
	public static partial class Misc_Extensions
	{

		/// <summary>
		/// Simple convenience function to convert a bool to a string value JavaScript will
		/// be happy with (i.e. in lowercase).
		/// </summary>
		/// <returns><paramref name="value"/> in lowercase</returns>
		public static string JsBool(this bool value) {
			return value.ToString().ToLower();
		}


		/// <summary>
		/// Simple convenience function to convert a bool to a string value JavaScript will
		/// be happy with (i.e. in lowercase).
		/// </summary>
		/// <returns><paramref name="value"/> in lowercase</returns>
		public static string JsBool(this bool? value) {
			if (!value.HasValue)
				return "false";

			return value.Value.JsBool();
		}

		
		/// <summary>
		/// Simple convenience function to convert a DateTime object to a string value JavaScript will
		/// be happy with.
		/// </summary>
		/// <param name="dt">Date to be converted</param>
		/// <returns>Date as JavaScript</returns>
		public static string JsDate(this DateTime dt) {
			return dt.JsDate(true);
		}


		/// <summary>
		/// Simple convenience function to convert a DateTime object to a string value JavaScript will
		/// be happy with.
		/// </summary>
		/// <param name="dt">Date to be converted</param>
		/// <param name="inDoubleQuotes">
		/// true - Surrounds the JavaScript date object in double quotes
		/// false - Surrounds the JavaScript date object in single quotes
		/// </param>
		/// <returns>Date as JavaScript</returns>
		public static string JsDate(this DateTime dt, bool inDoubleQuotes) {
			return string.Format(
				"$.datepicker.parseDate( \"yy-mm-dd\", {0} )", dt.ToString("yyyy-MM-dd").InQuotes(inDoubleQuotes) 
			);
		}
		

		/// <summary>
		/// Convenience function to render an array of strings as a JavaScript (JSON notation) array
		/// (used for initialises jQuery UI array control properties).
		/// No quote marks are added to the values.
		/// </summary>
		/// <param name="values">Set of strings to be rendered.</param>
		/// <returns>JavaScript array as a string</returns>
		public static string JsArray(this string[] values) {
			if (values == null || !values.Any())
				return "[]";

			return string.Format("[ {0} ]", string.Join(", ", values));
		}


		/// <summary>
		/// Convenience function to render an array of strings as a JavaScript (JSON notation) array
		/// (used for initialises jQuery UI array control properties).  Each item in the JSON array
		/// is quoted as instructed by the <paramref name="doubleQuotes"/> parameter.
		/// </summary>
		/// <param name="values">Set of strings to be rendered.</param>
		/// <param name="doubleQuotes">
		/// true  - double quotes (") are added to the strings
		/// false - single quotes (') are added to the strings
		/// </param>
		/// <returns>JavaScript array as a string</returns>
		public static string JsArray(this string[] values, bool doubleQuotes) {
			if (values == null || values.Count() == 0)
				return "[]";
			
			string arrayJs = "";
			for (int n=0; n < values.Count(); n++) {
				values[n] = values[n].InQuotes(doubleQuotes);
			}

			arrayJs = string.Format("[ {0} ]", string.Join(", ", values) );
			return arrayJs;
		}


		/// <summary>
		/// Convenience function to render an array of numbers as a JavaScript (JSON notation) array
		/// (used for initialises jQuery UI array control properties).
		/// Naturally for a numeric list the resulting array does _not_ have quotes.
		/// </summary>
		/// <param name="values">Set of numbers to be rendered.</param>
		public static string JsArray(this int[] values) {
			return (from v in values select v.ToString()).ToList<string>().JsArray();
		}

		
		/// <summary>
		/// Convenience function to render an array of strings as a JavaScript (JSON notation) array
		/// (used for initialises jQuery UI array control properties).
		/// Items in the JSON list are _not_ quoted.
		/// </summary>
		/// <param name="values">List of strings to be rendered.</param>
		public static string JsArray(this List<string> values) {
			return values.ToArray().JsArray();
		}


		/// <summary>
		/// Convenience function to render an array of strings as a JavaScript (JSON notation) array
		/// (used for initialises jQuery UI array control properties).
		/// </summary>
		/// <param name="values">List of strings to be rendered.</param>
		/// <param name="doubleQuotes">
		/// true  - double quotes (") are added to the strings
		/// false - single quotes (') are added to the strings
		/// </param>
		public static string JsArray(this List<string> values, bool doubleQuotes) {
			return values.ToArray().JsArray(doubleQuotes);
		}


		/// <summary>
		/// Convenience function to render a list of numbers as a JavaScript (JSON notation) array
		/// (used for initialises jQuery UI array control properties).
		/// Naturally items in the JSON list are _not_ quoted.
		/// </summary>
		/// <param name="values">List of numbers to be rendered.</param>
		public static string JsArray(this List<int> values) {
			List<string> conversion = (from i in values select i.ToString()).ToList();

			// no quotes as we know we're dealing with integers
			return conversion.ToArray().JsArray();
		}


		/// <summary>
		/// Converts a list of strings into CSV values (where separator is used as the delimiter).
		/// </summary>
		/// <param name="values">List of values to join together</param>
		/// <param name="separator">Separator to delimit values with</param>
		/// <returns>String of values delimited by specified separator</returns>
		public static string ToSeparated(this List<string> values, string separator) {
			string[] arr = (from v in values select v.ToString()).ToArray();

			return string.Join(separator, arr);
		}


		/// <summary>
		/// Converts a list of numbers into CSV values (where separator is used as the delimiter).
		/// </summary>
		/// <param name="values">List of numbers to join together</param>
		/// <param name="separator">Separator to delimit values with</param>
		/// <returns>String of values delimited by specified separator</returns>
		public static string ToSeparated(this List<int> values, string separator) {
			string[] arr = (from v in values select v.ToString()).ToArray();

			return string.Join(separator, arr);
		}


		/// <summary>
		/// Performs a string case-insensitive comparison.
		/// </summary>
		/// <param name="lhs"></param>
		/// <param name="rhs"></param>
		/// <returns>
		/// Returns true if the two strings are (case-sensitive) equal
		/// Returns false otherwise
		/// </returns>
		public static bool IgnorantEquals(this string lhs, string rhs) {
			if (string.IsNullOrEmpty(lhs) && string.IsNullOrEmpty(rhs))
				return false;
			if (string.IsNullOrEmpty(rhs) && string.IsNullOrEmpty(lhs))
				return false;

			return string.Compare(lhs, rhs, false/*ignoreCase*/) == 0;
		}

		/// <summary>
		/// Surrounds the value in single quote marks (').
		/// </summary>
		/// <param name="value">String to be quoted</param>
		/// <returns>Returns provided value in quotes.</returns>
		public static string InSingleQuotes(this string value) {
			return Fluqi.Helpers.Utils.InSingleQuotes(value);
		}

		/// <summary>
		/// Surrounds the value in double quote marks (").
		/// </summary>
		/// <param name="value">String to be quoted</param>
		/// <returns>Returns provided value in quotes.</returns>
		public static string InDoubleQuotes(this string value) {
			return Fluqi.Helpers.Utils.InDoubleQuotes(value);
		}

		/// <summary>
		/// Surrounds the value in quote marks.  The <paramref name="doubleQuotes"/> parameter
		/// determines whether to use double quotes (true) or single quotes (false).
		/// </summary>
		/// <param name="value">String to be quoted.</param>
		/// <param name="doubleQuotes">true - double quotes("), false - single quotes (')</param>
		/// <returns></returns>
		public static string InQuotes(this string value, bool doubleQuotes) {
			if (doubleQuotes)
				return InDoubleQuotes(value);
			else 
				return InSingleQuotes(value);
		}

	}

}