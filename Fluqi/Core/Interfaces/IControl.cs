using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;

namespace Fluqi.Core.Interfaces {

	/// <summary>
	/// Interface that controls should implement.
	/// </summary>
	public interface IControl {
		
		/// <summary>
		/// ID of the jQuery UI Tabs object.  Must be unique on the page.
		/// </summary>
		string ID { get; }

		/// <summary>
		/// Response object to write the control to.
		/// </summary>
		TextWriter Writer { get; }

		/// <summary>
		/// Name of the control being rendered.  This string is used when calling into the jQuery 
		/// control itself, and so must match the control name in the jQuery UI JavaScript files
		/// </summary>
		string PlugInName { get; }

	} // IControl

} // Fluqi.Interfaces

