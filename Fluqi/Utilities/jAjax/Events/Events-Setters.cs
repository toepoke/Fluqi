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
	/// A set of properties to apply to a set of jQuery UI Ajax.
	/// </summary>
	public partial class Events: Core.Options
	{

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
		public Events SetBeforeSend(string beforeSend) {
			this.BeforeSend = beforeSend;
			return this;
		}


		/// <summary>
		/// A function to be called when the request finishes (after success and error callbacks 
		/// are executed). The function gets passed two arguments: 
		/// The jqXHR (in jQuery 1.4.x, XMLHTTPRequest) object and a string categorizing the status of the 
		/// request ("success", "notmodified", "error", "timeout", "abort", or "parsererror"). 
		/// As of jQuery 1.5, the complete setting can accept an array of functions. 
		/// Each function will be called in turn. This is an Ajax Event.
		/// </summary>
		public Events SetComplete(string complete) {
			this.Complete = complete;
			return this;
		}

	} // Events

} // ns Fluqi.jAjax
