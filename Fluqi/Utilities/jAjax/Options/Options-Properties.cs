using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;
using Fluqi.Core;
using Fluqi.Core.Types;

namespace Fluqi.jAjax
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Ajax.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Options: Core.Options
	{

		/// <summary>
		/// The content type sent in the request header that tells the server 
		/// what kind of response it will accept in return. 
		/// If the accepts setting needs modification, it is recommended to 
		/// do so once in the $.ajaxSetup() method
		/// </summary>
		protected internal Map Accepts { get; set; }

		/// <summary>
		/// By default, all requests are sent asynchronously (i.e. this is set to true 
		/// by default). If you need synchronous requests, set this option to false. 
		/// Cross-domain requests and dataType: "jsonp" requests do not support 
		/// synchronous operation. 
		/// Note that synchronous requests may temporarily lock the browser, 
		/// disabling any actions while the request is active.
		/// </summary>
		protected internal bool Async { get; set; }

		/// <summary>
		/// Default: true, false for dataType 'script' and 'jsonp'
		/// If set to false, it will force requested pages not to be cached by the browser. 
		/// Setting cache to false also appends a query string parameter, "_=[TIMESTAMP]", 
		/// to the URL.
		/// </summary>
		/// <remarks>
		/// Note I think this is sometimes set by jQuery on a per-request basis:
		/// - Default: true
		/// - false for dataType 'script' and 'jsonp'
		/// </remarks>
		protected internal bool Cached { get; set; }

		/// <summary>
		/// A map of string/regular-expression pairs that determine how jQuery will parse 
		/// the response, given its content type.
		/// </summary>
		protected internal Map Contents { get; set; }

		/// <summary>
		/// When sending data to the server, use this content-type. 
		/// Default is "application/x-www-form-urlencoded", which is fine for most cases. 
		/// If you explicitly pass in a content-type to $.ajax() then it'll always be sent to the server 
		/// (even if no data is sent). 
		/// Data will always be transmitted to the server using UTF-8 charset; you must decode this 
		/// appropriately on the server side.
		/// </summary>
		protected internal string ContentType { get; set; }

		/// <summary>
		/// This object will be made the context of all Ajax-related callbacks. 
		/// By default, the context is an object that represents the ajax settings used in the call 
		/// ($.ajaxSettings merged with the settings passed to $.ajax). 
		/// For example specifying a DOM element as the context will make that the context for the 
		/// complete callback of a request.
		/// </summary>
		/// <remarks>
		/// The "Context" is passed "as is" to jQuery.
		/// </remarks>
		protected internal string Context { get; set; }

		/// <summary>
		/// A map of dataType-to-dataType converters. Each converter's value is a function 
		/// that returns the transformed value of the response.
		/// </summary>
		protected internal Map Converters { get; set; } 

		/// <summary>
		/// Default: false for same-domain requests, true for cross-domain requests
		/// If you wish to force a crossDomain request (such as JSONP) on the same domain, set the value 
		/// of crossDomain to true. 
		/// This allows, for example, server-side redirection to another domain
		/// </summary>
		/// <remarks>
		/// Note I think this is set by jQuery on a per-request basis:
		/// - false for same-domain requests
		/// - true for cross-domain requests
		/// </remarks>
		protected internal bool CrossDomain { get; set; }

		/// <summary>
		/// Data to be sent to the server. It is converted to a query string, if not already a string. 
		/// It's appended to the url for GET-requests. 
		/// See processData option to prevent this automatic processing. Object must be Key/Value pairs. 
		/// If value is an Array, jQuery serializes multiple values with same key based on the value of 
		/// the traditional setting (described below).
		/// </summary>
		protected internal string Data { get; set; }

		/// <summary>
		/// A function to be used to handle the raw response data of XMLHttpRequest.  This is a pre-filtering 
		/// function to sanitize the response. You should return the sanitized data. 
		/// The function accepts two arguments: The raw data returned from the server and the 'dataType' parameter.
		/// </summary>
		/// <remarks>This setting is passed to jQuery "as is".</remarks>
		protected internal string DataFilter { get; set; }

		/// <summary>
		/// Default: Intelligent Guess (xml, json, script, or html)
		/// The type of data that you're expecting back from the server. If none is specified, jQuery will try 
		/// to infer it based on the MIME type of the response (an XML MIME type will yield XML, in 1.4 JSON 
		/// will yield a JavaScript object, in 1.4 script will execute the script, and anything else will be 
		/// returned as a string). The available types (and the result passed as the first 
		/// argument to your success callback) are:
		/// "xml": 
		///    Returns a XML document that can be processed via jQuery.
		/// "html": 
		///    Returns HTML as plain text; included script tags are evaluated when inserted in the DOM.
		/// "script": 
		///    Evaluates the response as JavaScript and returns it as plain text. Disables caching by appending 
		///    a query string parameter, "_=[TIMESTAMP]", to the URL unless the cache option is set to true. 
		///    Note: This will turn POSTs into GETs for remote-domain requests.
		/// "json": 
		///    Evaluates the response as JSON and returns a JavaScript object. In jQuery 1.4 the JSON data is 
		///    parsed in a strict manner; any malformed JSON is rejected and a parse error is thrown. 
		///    (See json.org for more information on proper JSON formatting.)
		///    "jsonp": Loads in a JSON block using JSONP. Adds an extra "?callback=?" to the end of your URL to 
		///    specify the callback. Disables caching by appending a query string parameter, "_=[TIMESTAMP]", to the 
		///    URL unless the cache option is set to true.
		/// "text": A plain text string. 
		/// multiple, space-separated values: 
		///    As of jQuery 1.5, jQuery can convert a dataType from what it received in the Content-Type header to 
		///    what you require. For example, if you want a text response to be treated as XML, 
		///    use "text xml" for the dataType. You can also make a JSONP request, have it received as text, and 
		///    interpreted by jQuery as XML: "jsonp text xml." Similarly, a shorthand string such as 
		///    "jsonp xml" will first attempt to convert from jsonp to xml, and, failing that, convert from jsonp to 
		///    text, and then from text to xml.
		/// </summary>
		protected internal string DataType { get; set; }

		

	} // Options

} // ns Fluqi.jAjax


