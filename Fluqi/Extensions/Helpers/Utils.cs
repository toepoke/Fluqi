using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Helpers {

	/// <summary>
	/// Set of helper methods for accomplishing various things.
	/// </summary>
	public class Utils {

		/// <summary>
		/// Establishes if the given value is merely a set of empty quotes (either "" or '').
		/// </summary>
		/// <param name="value">String to check</param>
		/// <returns>
		/// Returns true if string is "" or ''
		/// Returns false otherwise
		/// Returns _false_ if string is null or empty!
		/// </returns>
		public static bool IsEmptyQuotes(string value) {
			if (string.IsNullOrEmpty(value))
				return false;

			if (string.Equals(value, "\"\"", StringComparison.InvariantCultureIgnoreCase))
				return true;
			else if (string.Equals(value, "''", StringComparison.InvariantCultureIgnoreCase))
				return true;

			return false;
		}

		/// <summary>
		/// Establishes if the given value is null, empty or the same as the default.  We look
		/// at the default value because if we're rendering the default we don't need to output
		/// the setting (as it's the default for the jQuery UI control) and thus we can reduce the
		/// JavaScript needed to initialise the control (which can be fairly big if you've got 20+ 
		/// options (never mind readability!))
		/// </summary>
		/// <param name="value">Options being set</param>
		/// <param name="defaultValue">Default for the option</param>
		/// <returns>
		/// Returns true if the value is null, empty or the same as the default
		/// Returns false otherwise
		/// </returns>
		public static bool IsNullEmptyOrDefault(string value, string defaultValue) {
			if (string.IsNullOrEmpty(value))
				return true;
			
			return value.IgnorantEquals(defaultValue);
		}


		/// <summary>
		/// Establishes if the given value is null, empty or the same as the default.  We look
		/// at the default value because if we're rendering the default we don't need to output
		/// the setting (as it's the default for the jQuery UI control) and thus we can reduce the
		/// JavaScript needed to initialise the control (which can be fairly big if you've got 20+ 
		/// options (never mind readability!))
		/// </summary>
		/// <param name="values">Options being set</param>
		/// <param name="defaultValues">Defaults for the option</param>
		/// <returns>
		/// Returns true if the value is null, empty or the same as the default
		/// Returns false otherwise
		/// </returns>
		public static bool IsNullEmptyOrDefault(List<string> values, List<string> defaultValues) {
			if (values == null || defaultValues == null)
				// can't be the same, remember "x != null", "null != x" and "null != null" !
				return false;

			if (values.Count() != defaultValues.Count()) 
				// not the same number of items => can't be the same
				return false;

			if (values == defaultValues)
				// same underlying object, so must be the same!
				return true;

			// otherwise look at each item in isolation
			for (int v=0; v < values.Count(); v++) {
				for (int d=0; d < defaultValues.Count(); d++) {
					if (values[v] != defaultValues[d]) {
						return false;
					}
				}
			}

			// all items in the list are the same, so the lists are the same
			return true;
		}


		/// <summary>
		/// Works out what type of date value or object is being passed in (i.e. is a string date like "01/01/2000",
		/// a numerical date value like "3" for 3 days, or a relative date specification like "+1w -1d" where some
		/// of them need quotes, but other don't.
		/// </summary>
		/// <param name="dateValue">Value to be queried</param>
		/// <returns></returns>
		public static bool AddQuotesToJQueryDate(string dateValue) {
			bool addQuotes = false;

			DateTime actualDate = DateTime.MaxValue;
			if (DateTime.TryParse(dateValue, out actualDate)) {
				// supplying a date in a string, e.g. "01/01/2000", so we'll just add in quotes
				addQuotes = true;
			} else if (IsNumeric(dateValue)) {
				addQuotes = false;
			} else {
				if (IsRelativeDateSpec(dateValue))
					// relative date/time, so again add quotes
					addQuotes = true;
			}
			// else it must be a javascript object, so not quotes

			return addQuotes;
		}

		/// <summary>
		/// Surrounds the value in double quote marks.
		/// </summary>
		/// <param name="value">String to be quoted</param>
		/// <param name="doubleQuote">
		/// If true double quotes (") are used
		/// If false single quotes (') are used
		/// </param>
		/// <returns>Returns provided value in quotes.</returns>
		private static string Quote(string value, bool doubleQuote) {
			string quoteMark = "\"";

			if (!doubleQuote)
				quoteMark = "'";

			value = value ?? "";
			// make sure we won't be adding quotes twice!
			value = value.Trim( "\"'".ToCharArray() );
			value = quoteMark + value + quoteMark;

			return value;
		}

		/// <summary>
		/// Surrounds the value in single quote marks.
		/// </summary>
		/// <param name="value">String to be quoted</param>
		/// <returns>Returns provided value in quotes.</returns>
		public static string InSingleQuotes(string value) {
			return Quote(value, false/*singleQuotes*/);
		}

		/// <summary>
		/// Surrounds the value in double quote marks.
		/// </summary>
		/// <param name="value">String to be quoted</param>
		/// <returns>Returns provided value in double quotes.</returns>
		public static string InDoubleQuotes(string value) {
			return Quote(value, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Establishes if the given value is a numeric value or not (note +10 and -10 are considered numeric 
		/// too).
		/// </summary>
		/// <param name="value">Value to query</param>
		/// <returns>
		/// Returns true if the value is considered numeric
		/// Returns false otherwise
		/// </returns>
		public static bool IsNumeric(string value) {
			int number = 0;
			
			return int.TryParse(value, out number);
		}


		/// <summary>
		/// Establishes if the given value is a numeric value or not (note +10 and -10 are considered numeric 
		/// too).
		/// </summary>
		/// <param name="value">Value to query</param>
		/// <returns>
		/// Returns true if the value is considered numeric
		/// Returns false otherwise
		/// </returns>
		public static bool IsBool(string value) {
			bool output = false;

			return bool.TryParse(value, out output);
		}


		/// <summary>
		/// Establishes whether the given value is considered to be a string representing
		/// a relative date.  Some jQuery UI controls (mainly DatePicker) allow you to 
		/// specify a relate date, "+10d" is "10 days in the future" and "-1m" is "one month in the past"
		/// </summary>
		/// <param name="value">Value to be queried</param>
		/// <returns>
		/// Returns true if the value is considered to be a relative date specification
		/// Returns false otherwise
		/// </returns>
		public static bool IsRelativeDateSpec(string value) {
			if (string.IsNullOrEmpty(value))
				return false;

			char[] relativeDateSpecChars = "+- \tdDwWmMyY".ToCharArray();
			if (value.IndexOfAny(relativeDateSpecChars) >= 0)
				return true;

			return !IsNumeric(value);
		}


		/// <summary>
		/// Establishes whether the given value is considered to be a [jQuery] selector string
		/// </summary>
		/// <param name="value">Value to be queried</param>
		/// <returns>
		/// Returns true if value is deemed to be a selector
		/// Returns false otherwise
		/// </returns>
		public static bool IsSelector(string value) {
			if (string.IsNullOrEmpty(value)) 
				// nothing to see here
				return false;

			char[] selectorChars = "$()#.~ >".ToCharArray();
			if (value.IndexOfAny(selectorChars) >= 0)
				return true;

			return false;
		}


		/// <summary>
		/// Establishes whether the given value is considered to be a JSON string
		/// </summary>
		/// <param name="value">Value to be queried</param>
		/// <returns>
		/// Returns true if value is deemed to be a JSON object
		/// Returns false otherwise
		/// </returns>
		/// <remarks>To determine this we simply look for the presence of "{", "}", "," or ":"</remarks>
		public static bool IsJSON(string value) {
			if (string.IsNullOrEmpty(value))
				// nothing to see here
				return false;

			char[] jsonChars = "{},:".ToCharArray();
			if (value.IndexOfAny(jsonChars) >= 0)
				return true;

			return false;
		}


		/// <summary>
		/// Simply removes any quotations marks at the start/end of a given
		/// string.  This is usually so we can remove any added by the user
		/// and add our own (otherwise we could add a second set of quotes that 
		/// aren't required.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string TrimQuotes(string value) {
			if (string.IsNullOrEmpty(value)) 
				// nothing to see here
				return "";

			return value.Trim(new char[] { '\"', '\'' });
		}


		/// <summary>
		/// Simple query method to work out if a given string has 
		/// any quotation ('") marks at the start of end of the string
		/// </summary>
		/// <param name="value"></param>
		/// <returns>
		/// Returns true if there are quotes at _either_ the start of the end
		/// Returns false otherwise (so false if there are quotes in the middle)
		/// </returns>
		public static bool IsQuoted(string value) {
			if (string.IsNullOrEmpty(value))
				// nothing to see here, move along
				return false;

			if (value.StartsWith("\"") || value.StartsWith("'"))
				return true;

			if (value.EndsWith("\"") || value.EndsWith("'"))
				return true;

			return false;
		}

	}

}
