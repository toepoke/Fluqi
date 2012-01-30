using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;

namespace Fluqi.Extension.Helpers
{
	/// <summary>
	/// Set of extensions for the <see cref="TextWriter"/> object.
	/// </summary>
	public static class WriterExt {
		
		/// <summary>
		/// Adds a method of adding a String.Format type call to the response stream.
		/// </summary>
		/// <param name="writer">Response object to be extended</param>
		/// <param name="fmt">String of format arguments</param>
		/// <param name="values">Values to be added to the format string</param>
		public static void Write(this TextWriter writer, string fmt, params object[] values) {
			writer.Write(string.Format(fmt, values));
		}


		/// <summary>
		/// Adds a method of adding a string value to the response stream followed by newline.
		/// </summary>
		/// <param name="resp">Response object to be extended</param>
		/// <param name="value"></param>
		public static void WriteLine(this HttpResponseBase resp, string value) {
			resp.Write(value + Environment.NewLine);
		}


		/// <summary>
		/// Adds a newline to the response stream.
		/// </summary>
		/// <param name="writer">Response object to be extended</param>
		public static void WriteLine(this TextWriter writer) {
			writer.Write(Environment.NewLine);
		}


		/// <summary>
		/// Adds a method of adding a String.Format type call to the response stream, immediately followed by a newline.
		/// </summary>
		/// <param name="writer">Response object to be extended</param>
		/// <param name="fmt">String of format arguments</param>
		/// <param name="values">Values to be added to the format string</param>
		public static void WriteLine(this TextWriter writer, string fmt, params object[] values) {
			writer.Write(string.Format(fmt, values) + Environment.NewLine);
		}


		/// <summary>
		/// Writes a value to the response stream, but only if <paramref name="condition"/> is true.
		/// </summary>
		/// <param name="writer">Response object to be extended</param>
		/// <param name="condition">Condition to be evaluated</param>
		/// <param name="value">Value to be writte if condition is true</param>
		public static void WriteIf(this TextWriter writer, bool condition, object value) {
			if (!condition)
				return;

			writer.Write(value);
		}


		/// <summary>
		/// Writes a String.Format string to the response stream, but only if <paramref name="condition"/>
		/// is true.
		/// </summary>
		/// <param name="writer">Response object to be extended</param>
		/// <param name="condition">Condition to be evaluated</param>
		/// <param name="fmt">String of format arguments</param>
		/// <param name="values">Values to be added to the format string</param>
		public static void WriteIf(this TextWriter writer, bool condition, string fmt, params object[] values) {
			writer.WriteLineIf(condition, string.Format(fmt, values));
		}


		/// <summary>
		/// Writes a newline to the response stream, but only if <paramref name="condition"/> is true.
		/// </summary>
		/// <param name="writer">Response object to be extended</param>
		/// <param name="condition">Condition to be evaluated</param>
		public static void WriteLineIf(this TextWriter writer, bool condition) {
			writer.WriteIf(condition, Environment.NewLine);
		}


		/// <summary>
		/// Writes a value (followed by a newline) to the response stream, but only if <paramref name="condition"/>
		/// is true.
		/// </summary>
		/// <param name="writer">Response object to be extended</param>
		/// <param name="condition">Condition to be evaluated</param>
		/// <param name="value">Value to be written</param>
		public static void WriteLineIf(this TextWriter writer, bool condition, object value) {
			writer.WriteIf(condition, value + Environment.NewLine);
		}


		/// <summary>
		/// Writes a String.Format string (followed by a newline), but only if the condition is true.
		/// </summary>
		/// <param name="writer">Response object to be extended</param>
		/// <param name="condition">Condition to be evaluated</param>
		/// <param name="fmt">String of format arguments</param>
		/// <param name="values">Values to be added to the format string</param>
		public static void WriteLineIf(this TextWriter writer, bool condition, string fmt, params object[] values) {
			writer.Write(fmt, values);
			if (condition)
				writer.WriteLine("");
		}


		/// <summary>
		/// Writes X Tab(s) to the response stream, but only if the <paramref name="condition"/> is true
		/// (useful for formatting JavaScript to the response stream nicely).
		/// </summary>
		/// <param name="writer">Response object to be extended.</param>
		/// <param name="condition">Condition to be evaluated.</param>
		/// <param name="numTabs">Number of tabs to write to the response stream</param>
		public static void WriteTabsIf(this TextWriter writer, bool condition, int numTabs )  {
			writer.WriteIf(condition, new string('\t', numTabs) );
		}


		/// <summary>
		/// Writes a single Tab to the response stream, but only if the <paramref name="condition"/> is true
		/// (useful for formatting JavaScript to the response stream nicely).
		/// </summary>
		/// <param name="writer">Response object to be extended.</param>
		/// <param name="condition">Condition to be evaluated.</param>
		public static void WriteTabsIf(this TextWriter writer, bool condition)  {
			writer.WriteTabsIf(condition, 1 );
		}

	}
}
