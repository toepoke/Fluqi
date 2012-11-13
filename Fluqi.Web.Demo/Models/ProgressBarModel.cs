using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Fluqi.Extension.Helpers;
using Fluqi.Extension;
using Fluqi.Helpers;
using Fluqi.Widget.jProgressBar;
using Fluqi.Web.Demo.Helpers;
using System.IO;

namespace Fluqi.Models
{
	/// <summary>
	/// Takes all the Initial Settings defined on the view and configures the control accordingly.
	/// Also displays the JavaScript and C# required to make the jQuery UI control do what we want
	/// For instance on the DatePicker screen we can change the "ShowAnim" setting to "Explode"
	/// this class takes what the model tells us and would then configure the DatePicker (or whatever
	/// control we're looking at).
	/// </summary>
	/// <remarks>
	/// Note all the files in this project are for demo purposes and certainly aren't "best practice" by
	/// any stretch of the imagination.
	/// </remarks>
	public class ProgressBarModel: BaseModel {

		public ProgressBarModel() : base() {
			this.disabled = false;
		}

		public bool disabled { get; set; }
		public int value { get; set; }

		public void ConfigureProgressBar(ProgressBar pb) {
			pb
				.Rendering
					.SetPrettyRender(true)
				.Finish()
				.Options
					.SetDisabled(this.disabled)
					.SetValue(this.value)
				.Finish()
			;

			if (this.showEvents) {
				pb.Events
					.SetCreateEvent("createEvent(event, ui);")
					.SetChangeEvent("changeEvent(event, ui);")
					.SetCompleteEvent("completeEvent(event, ui);")
				.Finish();
			}
			if (!this.prettyRender)
				pb.Rendering.Compress();
			if (this.renderCSS)
				pb.Rendering.ShowCSS();
		}

		public string JavaScriptCode(ProgressBar pb) {
			pb.Rendering.SetPrettyRender(true);
			return pb.GetStartUpScript();
		}

		public string CSharpCode(ProgressBar pb) {
			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 0);

			sb.AppendTabsLineIf("<%");
			sb.AppendTabsFormatLineIf("Html.CreateProgressBar(\"{0}\")", pb.ID );

			string optionsCode = OptionsCSharpCode();
			string showEventsCode = ShowEventsCSharpCode();
			string renderCode = base.RenderCSharpCode();
			bool showOptions = (optionsCode.Length > 0 || showEventsCode.Length > 0 || renderCode.Length > 0);
			
			if (showOptions) {
				sb.IncIndent();

				if (optionsCode.Length > 0) {
					sb.AppendTabsLineIf(".Options");
					sb.IncIndent();
					sb.Append(optionsCode);
					sb.DecIndent();
					sb.AppendTabsLineIf(".Finish()");
				}
				if (showEventsCode.Length > 0) {
					sb.AppendTabsLineIf(".Events");
					sb.IncIndent();
					sb.Append(showEventsCode);
					sb.DecIndent();
					sb.AppendTabsLineIf(".Finish()");
				}

				if (renderCode.Length > 0)
					sb.Append(renderCode);
				sb.DecIndent();
			}
			sb.AppendTabsLineIf(".Render();");
			sb.AppendTabsLineIf("%>");
						
			return sb.ToString();	
		}

		protected string OptionsCSharpCode() {
			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 2);

			if (this.disabled)
				sb.AppendTabsLineIf(".SetDisabled(true)");
			if (this.value != Options.DEFAULT_VALUE)
				sb.AppendTabsFormatLineIf(".SetValue({0})", this.value);

			return sb.ToString();			
		}

		protected string ShowEventsCSharpCode() {
			if (!this.showEvents)
				// nothing to see here
				return "";

			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 2);

			sb.AppendTabsLineIf(".SetCreateEvent(\"createEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetChangeEvent(\"changeEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetCompleteEvent(\"completeEvent(event, ui);\")");

			return sb.ToString();
		}
		
	}

}
