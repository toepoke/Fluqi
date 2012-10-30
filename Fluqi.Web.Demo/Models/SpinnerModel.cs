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
using Fluqi.Widget.jSpinner;
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
	public class SpinnerModel: BaseModel {

		public SpinnerModel() : base() {
			this.disabled = false;
			this.downIconClass = Options.DEFAULT_DOWN_ICON_CLASS;
			this.upIconClass = Options.DEFAULT_UP_ICON_CLASS;
			this.min = Options.DEFAULT_MIN_VALUE;
			this.max = Options.DEFAULT_MAX_VALUE;
			this.step = Options.DEFAULT_STEP;
			this.page = Options.DEFAULT_PAGE;
		}

		// culture isn't in the UI (doesn't make sense to)
		public bool disabled { get; set; }
		public string downIconClass { get; set; }
		public string upIconClass { get; set; }
		// incremental isn't in the UI (doesn't make sense to)
		public string min { get; set; }
		public string max { get; set; }
		// numberFormat isn't in the UI 
		public int page { get; set; }
		public string step { get; set; }



		public void ConfigureSpinner(Spinner spin) {
			spin
				.Rendering
					.SetPrettyRender(true)
				.Finish()
				.Options
					.SetDisabled(this.disabled)
					.SetIcons(this.downIconClass, this.upIconClass)
					.SetMin(this.min)
					.SetMax(this.max)
					.SetPage(this.page)
					.SetStep(this.step)
				.Finish();

			if (this.showEvents) {
				spin
					.Events
						.SetChangeEvent("return changeEvent(event, ui);")
						.SetCreateEvent("return createEvent(event, ui);")
						.SetSpinEvent("return spinEvent(event, ui);")
						.SetStartEvent("return startEvent(event, ui);")
						.SetStopEvent("return stopEvent(event, ui);")
					.Finish();
			}
			if (!this.prettyRender)
				spin.Rendering.Compress();
			if (this.renderCSS)
				spin.Rendering.ShowCSS();
		}

		public string JavaScriptCode(Spinner spin) {
			return spin.GetStartUpScript();
		}

		public string CSharpCode(Spinner spin) {
			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 0);

			sb.AppendTabsLineIf("<%");
			sb.AppendTabsLineIf("Html.CreateSpinner(\"spin\")");

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
			if (!string.IsNullOrEmpty(this.downIconClass) && !string.IsNullOrEmpty(this.upIconClass)) 
				sb.AppendTabsFormatLineIf(".SetIcons(\"{0}\", \"{1}\")", this.downIconClass, this.upIconClass);
			if (!string.IsNullOrEmpty(this.min))
				sb.AppendTabsFormatLineIf(".SetMin({0})", this.min);
			if (!string.IsNullOrEmpty(this.max))
				sb.AppendTabsFormatLineIf(".SetMax({0})", this.max);
			if (!string.IsNullOrEmpty(this.step))
				sb.AppendTabsFormatLineIf(".SetStep({0})", this.step);
			if (this.page != Options.DEFAULT_PAGE)
				sb.AppendTabsFormatLineIf(".SetPage({0})", this.page);
			
			return sb.ToString();
		}

		protected string ShowEventsCSharpCode() {
			if (!this.showEvents)
				// nothing to see here
				return "";

			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 2);

			sb.AppendTabsLineIf(".SetChangeEvent(\"return changeEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetCreateEvent(\"return createEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetSlideEvent(\"return spinEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetStartEvent(\"return startEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetStopEvent(\"return stopEvent(event, ui);\")");

			return sb.ToString();
		}



	}

}

