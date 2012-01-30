using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fluqi.Extension.Helpers
{
	/// <summary>
	/// The jStringBuilder class is used for building up code it an indented manner, however the 
	/// indentation can be switched off to compress the output if required.
	/// </summary>
	public class jStringBuilder {
	
		/// <summary>
		/// Can't inherit from StringBuilder so have to provide our own interface to it :(
		/// </summary>
		private StringBuilder _sb = null;

		/// <summary>
		/// Records how many tabs we should use when pretty things up
		/// </summary>
		private int _IndentLevel = 0;

		/// <summary>
		/// Flags that Whitespace should be respected and output (in reality this means that
		/// linefeeds and tabs are respected when using the "If" methods)
		/// </summary>
		private bool _RespectWS = true;

		/// <summary>
		/// Constructor
		/// </summary>
		public jStringBuilder() {
			_sb = new StringBuilder();
		}


		/// <summary>
		/// Detailed constructor
		/// </summary>
		/// <param name="includeWhitespace">Flags that tabs and newline should be added to the underlying StringBuilder</param>
		public jStringBuilder(bool includeWhitespace)
			: this()
		{
			_RespectWS = includeWhitespace;
		}


		/// <summary>
		/// Detailed constructor
		/// </summary>
		/// <param name="includeWhitespace">Flags that tabs and newline should be added to the underlying StringBuilder</param>
		/// <param name="initialTabDepth">Initial number of tabs that be inserted at the start of a new line of code</param>
		public jStringBuilder(bool includeWhitespace, int initialTabDepth)
			: this()
		{
			_RespectWS = includeWhitespace;
			_IndentLevel = initialTabDepth;
		}


		/// <summary>
		/// Establishes how many tabs are currently being inserted at the start of a new line of code.
		/// </summary>
		public int IndentLevel {
			get {
				return _IndentLevel;
			}
		}


		/// <summary>
		/// Establishes whether whitespace (tabs and newlines) should be added to the underlying StringBuilder.
		/// </summary>
		public bool RespectWs {
			get {
				return _RespectWS;
			}
		}

#region "Set of methods for mirroring (some of) the interface of StringBuilder"
#pragma warning disable 1591
		public override string ToString()
		{
			return _sb.ToString();
		}

		public string ToString(int startIndex, int length)
		{
			return _sb.ToString(startIndex, length);
		}

		public void Append(object value)
		{
			_sb.Append(value);
		}

		public void AppendFormat(string fmt, params object[] args)
		{
			_sb.AppendFormat(fmt, args);
		}

		public void AppendLine(string value)
		{
			_sb.AppendLine(value);			
		}

		public void AppendLine()
		{
			_sb.AppendLine();
		}

		public void Insert(int index, string value, int count)
		{
			_sb.Insert(index, value, count);
		}

		public void Insert(int index, string value)
		{
			_sb.Insert(index, value);
		}

		public void Remove(int startIndex, int length)
		{
			_sb.Remove(startIndex, length);
		}

		public void Replace(string oldValue, string newValue)
		{
			_sb.Replace(oldValue, newValue);
		}

		public void Replace(char oldValue, char newValue)
		{
			_sb.Replace(oldValue, newValue);
		}

		public int Length
		{
			get { return _sb.Length; }
		}
#pragma warning restore 1591
#endregion
		
		/// <summary>
		/// Inserts tabs followed by a String.Format argument set.
		/// </summary>
		/// <param name="format">String of format arguments</param>
		/// <param name="args">Values to be added to the format string</param>
		public void AppendTabsFormat(string format, params object[] args) {
			this.AppendTabs();
			this.AppendFormat(format, args);
		}


		/// <summary>
		/// Inserts tabs (if <see cref="RespectWs"/> is true) followed by a String.Format argument set.
		/// </summary>
		/// <param name="format">String of format arguments</param>
		/// <param name="args">Values to be added to the format string</param>
		public void AppendTabsFormatIf(string format, params object[] args) {
			this.AppendTabsIf();
			this.AppendFormat(format, args);
		}


		/// <summary>
		/// Adds a String.Format followed by a newline.
		/// </summary>
		/// <param name="format">String of format arguments</param>
		/// <param name="args">Values to be added to the format string</param>
		public void AppendFormatLine(string format, params object[] args) {
			this.AppendFormat(format, args);
			this.AppendLine();
		}


		/// <summary>
		/// Adds tabs (at the current indent level) followed by a String.Format string and a newline
		/// </summary>
		/// <param name="format">String of format arguments</param>
		/// <param name="args">Values to be added to the format string</param>
		public void AppendTabsFormatLine(string format, params object[] args) {
			this.AppendTabs();
			this.AppendFormatLine(format, args);
		}


		/// <summary>
		/// Adds a String.Format string.  A newline is then added, but only if the RespectWs
		/// is true.
		/// </summary>
		/// <param name="format">String of format arguments</param>
		/// <param name="args">Values to be added to the format string</param>
		public void AppendFormatLineIf(string format, params object[] args) {
			this.AppendFormat(format, args);
			if (_RespectWS)
				this.AppendLine();
		}


		/// <summary>
		/// Adds tabs (at the current indent level) followed by a String.Format string and a newline.
		/// Note the tabs and newline part are only added if the RespectWs flag is true.
		/// </summary>
		/// <param name="format">String of format arguments</param>
		/// <param name="args">Values to be added to the format string</param>
		public void AppendTabsFormatLineIf(string format, params object[] args) {
			if (_RespectWS)
				this.AppendTabs();
			this.AppendFormatLineIf(format, args);
		}


		/// <summary>
		/// Adds a newline, but only if the RespectWs is true.
		/// </summary>
		public void AppendLineIf() {
			if (_RespectWS)
				this.AppendLine();
		}


		/// <summary>
		/// Adds a string to the StringBuilder, followed by a newline.  Note the newline is only
		/// added if the RespectWs is true.
		/// </summary>
		/// <param name="value"></param>
		public void AppendLineIf(string value) {
			this.Append(value);
			this.AppendLineIf();
		}


		/// <summary>
		/// Adds tabs to the current indent level, then the provided string and finally a newline.
		/// Note tabs and newline are only added if the RespectWs is true.
		/// </summary>
		/// <param name="value">String to add to the StringBuilder</param>
		public void AppendTabsLineIf(string value) {
			if (_RespectWS)
				this.AppendTabs();
			this.AppendLineIf(value);
		}


		/// <summary>
		/// Adds tabs (at the current IndentLevel), then the provided string and finally a newline to the
		/// StringBuilder.
		/// </summary>
		/// <param name="value">String to be added.</param>
		public void AppendTabsLine(string value) {
			this.AppendTabs();
			this.AppendLine(value);
		}


		/// <summary>
		/// Sets the IndentLevel to <paramref name="numTabs"/> (the indent level being the number of tabs
		/// to insert at the start of a newline).
		/// </summary>
		/// <param name="numTabs"></param>
		public void SetIndent(int numTabs) {
			_IndentLevel = numTabs;
		}


		/// <summary>
		/// Increments the IndentLevel by one (the indent level being the number of tabs
		/// to insert at the start of a newline).
		/// </summary>
		public void IncIndent() {
			_IndentLevel++;
		}


		/// <summary>
		/// Increments the IndentLevel by one (the indent level being the number of tabs
		/// to insert at the start of a newline).
		/// </summary>
		/// <param name="by">Number of tabs to increment the indent by</param>
		public void IncIndent(int by) {
			_IndentLevel+=by;
		}


		/// <summary>
		/// Decrements the IndentLevel by one (the indent level being the number of tabs to 
		/// insert at the start of a newline).
		/// </summary>
		public void DecIndent() {
			_IndentLevel--;
		}


		/// <summary>
		/// Decrements the IndentLevel by one (the indent level being the number of tabs to 
		/// insert at the start of a newline).
		/// </summary>
		/// <param name="by">Number of tabs to decrement the indent by</param>
		public void DecIndent(int by) {
			_IndentLevel-=by;
		}


		/// <summary>
		/// Adds the provided number of tabs to the StringBuilder.
		/// </summary>
		/// <param name="numTabs">Number of tabs to add to the StringBuilder</param>
		public void AppendTabs(int numTabs) {
			this.Append(new string('\t', numTabs));
		}


		/// <summary>
		/// Adds the provided number of tabs to the StringBuilder (but only if the RespectWs is true.
		/// </summary>
		/// <param name="numTabs">Number of tabs to add to the StringBuilder</param>
		public void AppendTabsIf(int numTabs) {
			if (_RespectWS)
				this.AppendTabs(numTabs);
		}


		/// <summary>
		/// Adds a number of tabs to the StringBuilder (the number of tabs being driven by 
		/// the IndentLevel).
		/// </summary>
		public void AppendTabs() {
			this.AppendTabs(_IndentLevel);
		}


		/// <summary>
		/// Adds a number of tabs to the StringBuilder (the number of tabs being driven by 
		/// the IndentLevel) - but only if the RespectWs is true.
		/// </summary>
		public void AppendTabsIf() {
			if (_RespectWS)
				this.AppendTabs(_IndentLevel);
		}


		/// <summary>
		/// Adds the defined number of tabs to the StringBuilder, followed by the given String.
		/// The tabs only added if the RespectWs is true.
		/// </summary>
		/// <param name="value">String to be added to the StringBuilder.</param>
		public void AppendTabsIf(string value) {
			this.AppendTabsIf();
			this.Append(value);
		}


		/// <summary>
		/// Adds the defined number of tabs, then a String.Format string.  Tabs are only added if the RespectWs is true.
		/// </summary>
		/// <param name="fmt">String of format arguments</param>
		/// <param name="args">Values to be added to the format string</param>
		public void AppendTabsFormatIf(string fmt, params string[] args) {
			this.AppendTabsIf();
			this.AppendFormat(fmt, args);
		}


		/// <summary>
		/// Adds the defined number of tabs to the StringBuilder.
		/// </summary>
		public void AppendIndent() {
			this.AppendTabs(this._IndentLevel);
		}


		/// <summary>
		/// Adds the defined number of tabs to the StringBuilder, but only if the RespectWs flag is true.
		/// </summary>
		public void AppendIndentIf() {
			if (_RespectWS)
				this.AppendIndent();
		}


		/// <summary>
		/// Adds the given JavaScript into a script/document.ready block to the StringBuilder.
		/// This is used to initialise a control (<see cref="Core.RenderBase.AutoScript"/> flag).
		/// </summary>
		/// <param name="script">JavaScript to be initialised</param>
		public void AppendUIStartUp(string script) {
			this.AppendLineIf();
				
			this.AppendTabsLineIf("<script type=\"text/javascript\">");
			this.AppendTabsLineIf("$(document).ready( function() {");
			this.AppendLineIf(script);
			this.AppendTabsLineIf("});");
			this.AppendTabsLineIf("</script>");
		}


		/// <summary>
		/// Removes any occurence of the given String from the end of the StringBuilder.
		/// </summary>
		/// <param name="value">String to be trimmed</param>
		public void TrimEnd(string value) {
			if (_sb.Length < value.Length)
				// can't possibly be the same at the end as they're different lengths
				return;

			int endIndex = (_sb.Length - value.Length);

			if (_sb.ToString(endIndex, value.Length) == value)
				_sb.Remove(endIndex, value.Length);
		}


		/// <summary>
		/// Removes any occurence of the given String from the start of the StringBuilder.
		/// </summary>
		/// <param name="value">String to be trimmed</param>
		public void TrimStart(string value) {
			if (_sb.Length < value.Length)
				// can't possibly be the same at the start as they're different lengths
				return;

			if (_sb.ToString(0, value.Length) == value)
				_sb.Remove(0, value.Length);
		}


		/// <summary>
		/// Removes any occurence of the given String from the start and end of the StringBuilder.
		/// </summary>
		/// <param name="value">String to be trimmed</param>
		public void Trim(string value) {
			this.TrimEnd(value);
			this.TrimStart(value);
		}

		/// <summary>
		/// Kind of like a normal trip, but we ignore whitespace until we find
		/// "something" which may or may not be what we're after.  If it 
		/// is what we're after we'll remove it
		/// </summary>
		/// <param name="valueToTrim">The "something" we want removing</param>
		public void TrimExcessContent(string valueToTrim) {
			if (string.IsNullOrEmpty(valueToTrim))
				// nothing to see here, move along
				return;
			if (valueToTrim.Length > this.Length)
				// you ain't going to see that then are you
				return;

			// whisk past any whitespace (there might not be any, but this cool .. we're all over it)
			int pos = _sb.Length-1;
			string whitespace = " \t\r\n";
			while (whitespace.IndexOf(_sb[pos]) >= 0) {
				// hit whitespace, so move back a bit
				pos--;
			}
			
			if (pos > valueToTrim.Length) {
				// we didn't hit the start of the string, so we must have moved past the whitespace
				// so now check the string
				string substr = SubString(pos-valueToTrim.Length,pos);
				if (substr == valueToTrim)
					_sb.Remove(pos, _sb.Length-pos);
			}

		}


		/// <summary>
		/// Establishes the string of characters located between <paramref name="start"/> and <paramref name="stop"/>
		/// in the StringBuilder.
		/// </summary>
		/// <param name="start">Where to start extracting</param>
		/// <param name="stop">Where to stop extracting</param>
		/// <returns>
		/// Returns the string located between start/stop of the StringBuilder.
		/// </returns>
		/// <remarks>
		/// If the start/stop is invalid an exception is thrown.
		/// </remarks>
		public string SubString(int start, int stop) {
			if (start > this.Length) 
				throw new IndexOutOfRangeException(string.Format("{0} is greater than the length of the string.", start));
			if (stop > this.Length)
				throw new IndexOutOfRangeException(string.Format("{0} is greater than the length of the string.", stop));
			if (start >= stop)
				throw new NotSupportedException("Start position must be earlier than the Stop position.");

			StringBuilder substr = new StringBuilder(stop - start);
			for (int ndx=stop; ndx > start; ndx--) {
				substr.Append(_sb[ndx]);
			}

			return substr.ToString();
		}


		/// <summary>
		/// Establishes a number characters in the StringBuilder starting at postion <paramref name="start"/> 
		/// (for <paramref name="countChars"/>).
		/// </summary>
		/// <param name="start">Where to start copying from</param>
		/// <param name="countChars">Number of characters to copy</param>
		/// <returns></returns>
		public string SubStringByLength(int start, int countChars) {
			return SubString(start, start+countChars);
		}

	}

}
