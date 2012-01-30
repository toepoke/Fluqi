using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;
using Microsoft.VisualBasic;

namespace Fluqi.jAjax
{

	/// <summary>
	/// A set of events to apply to a set of jQuery UI Ajax.
	/// </summary>
	public partial class Events: Core.Options
	{
		public Events(Ajax dp)
		 : base()
		{
			this.Ajax = dp;
			this.Reset();
		}

		/// <summary>
		/// A pre-request callback function that can be used to modify the jqXHR 
		/// (in jQuery 1.4.x, XMLHTTPRequest) object before it is sent. 
		/// Use this to set custom headers, etc. 
		/// The jqXHR and settings maps are passed as arguments. This is an Ajax Event. 
		/// Returning false in the beforeSend function will cancel the request. 
		/// As of jQuery 1.5, the beforeSend option will be called regardless of the type of 
		/// request.
		/// </summary>
		/// <remarks>See http://api.jquery.com/jQuery.ajax/#jQuery-ajax-settings for details</remarks>
		protected internal string BeforeSend { get; set; }

		/// <summary>
		/// A function to be called when the request finishes (after success and error callbacks 
		/// are executed). The function gets passed two arguments: 
		/// The jqXHR (in jQuery 1.4.x, XMLHTTPRequest) object and a string categorizing the status of the 
		/// request ("success", "notmodified", "error", "timeout", "abort", or "parsererror"). 
		/// As of jQuery 1.5, the complete setting can accept an array of functions. 
		/// Each function will be called in turn. This is an Ajax Event.
		/// </summary>
		protected internal string Complete { get; set; }

		/// <summary>
		/// A function to be called if the request fails. The function receives three arguments: 
		/// - The jqXHR (in jQuery 1.4.x, XMLHttpRequest) object, 
		/// - a string describing the type of error that occurred and an optional exception object, if one occurred. 
		///   Possible values for the second argument (besides null) are "timeout", "error", "abort", and "parsererror". 
		///   When an HTTP error occurs, errorThrown receives the textual portion of the HTTP status, such as "Not Found" or 
		///   "Internal Server Error." As of jQuery 1.5, the error setting can accept an array of functions. 
		///   Each function will be called in turn. Note: This handler is not called for cross-domain script and JSONP requests. 
		///   This is an Ajax Event.
		/// </summary>
		protected internal string Error { get; set; }

	} // Events

} // ns Fluqi.jAutoComplete
