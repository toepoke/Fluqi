using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension.Helpers;
using System.Diagnostics.CodeAnalysis;
using System.Runtime;
using Fluqi.Core.Interfaces;

namespace Fluqi.Widget.jAutoComplete
{
	
	public partial class AutoComplete
	{

		/// <summary>
		/// Writes out the initialisation JavaScript to configure the tabs object client-side.
		/// </summary>
		/// <remarks>
		/// Useful if you want to declare your own document.ready and add in the initialisation
		/// yourself (if you have additional initialisation you want to perform for instance).
		/// </remarks>
		protected internal string GetControlScript() {
			return this.GetControlScript(this.Rendering.TabDepth);
		}


		/// <summary>
		/// Writes out the document.ready, text/JavaScript and tabs initialisation script
		/// to the Response.
		/// </summary>
		/// <param name="incDocReady">
		/// If true wraps the initialisation script with a jQuery document.ready section
		/// If false only the control initialisation script is written.
		/// </param>
		/// <remarks>
		/// Useful if you want more control over where the initialisation takes place.
		/// </remarks>
		public string GetStartUpScript(bool incDocReady) {
			bool prettyRender = this.Rendering.PrettyRender;
			int tabDepth = this.Rendering.TabDepth;
			jStringBuilder sb = new jStringBuilder(prettyRender, tabDepth);

			if (incDocReady)
				sb.AppendUIStartUp(this.GetControlScript(tabDepth));
			else
				sb.AppendLineIf(this.GetControlScript(tabDepth));

			return sb.ToString();
		}

		
		/// <summary>
		/// Renders (and returns) the JavaScript required to initialise the accordion control
		/// with the required options.
		/// A jQuery document.ready section is wrapped around the script.
		/// </summary>
		/// <returns>Returns initialisation JavaScript</returns>
		public string GetStartUpScript() {
			return this.GetStartUpScript(true/*include document.ready*/);
		}


		/// <summary>
		/// Writes out the document.ready, text/JavaScript and control initialisation script
		/// to the Response.
		/// </summary>
		/// <remarks>
		/// Useful if you want more control over where the initialisation takes place.
		/// </remarks>
		public void RenderStartUpScript() {
			this.RenderStartUpScript(true/*include document.ready*/);
		}


		/// <summary>
		/// Writes out the document.ready, text/JavaScript and control initialisation script
		/// to the Response.
		/// </summary>
		/// <param name="incDocReady">
		/// If true the control initialisation is wrapped in a jQuery document.ready and script
		/// declaration.
		/// If false no wrapping takes place.
		/// </param>
		/// <remarks>
		/// Useful if you want more control over where the initialisation takes place.
		/// </remarks>
		public void RenderStartUpScript(bool incDocReady) {
			string startUpScript = this.GetStartUpScript(incDocReady);

			this.Writer.Write(startUpScript);
		}

	}
}
