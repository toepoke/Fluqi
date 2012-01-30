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
using Fluqi.Widget.jSlider;
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
	public class SliderModel: BaseModel {

		public SliderModel() : base() {
			this.Disabled = false;
			this.Animated = "false";
			this.Min = Options.DEFAULT_MIN;
			this.Max = Options.DEFAULT_MAX;
			this.Orientation = Core.Orientation.OrientationToString( Core.Orientation.eOrientation.Horizontal );	
			this.Range = "false";
			this.Step = Options.DEFAULT_STEP;
			this.Value = Options.DEFAULT_VALUE;
			this.Values = "";
			this.Size = "200px";
		}

		public bool Disabled { get; set; }
		public string Animated { get; set; }
		public int Min { get; set; }
		public int Max { get; set; }
		public string Orientation { get; set; }
		public string Range { get; set; }
		public int Step { get; set; }
		public int Value { get; set; }
		public string Values { get; set; }
		public string Size { get; set; }

		public void ConfigureSlider(Slider sldr) {
			sldr.Options
				.SetAnimate(this.Animated)
				.SetDisabled(this.Disabled)
				.SetMin(this.Min)
				.SetMax(this.Max)
				.SetOrientation(this.Orientation)
				.SetRange(this.Range)
				.SetStep(this.Step)
				.SetValue(this.Value)
				.SetValues(this.Values)
				.SetSize(this.Size)
			.Finish();

			if (this.showEvents) {
				sldr
					.Events
						.SetCreateEvent("return createEvent(event, ui);")
						.SetStartEvent("return startEvent(event, ui);")
						.SetSlideEvent("return slideEvent(event, ui);")
						.SetChangeEvent("return changeEvent(event, ui);")
						.SetStopEvent("return stopEvent(event, ui);")
					.Finish();
			}
			if (!this.prettyRender)
				sldr.Rendering.Compress();
			if (this.renderCSS)
				sldr.Rendering.ShowCSS();
		}

		public string JavaScriptCode(Slider sldr) {
			return sldr.GetStartUpScript();
		}

		public string CSharpCode(Slider sldr) {
			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 0);

			sb.AppendTabsLineIf("<%");
			sb.AppendTabsLineIf("Html.CreateSlider(\"sldr\")");

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

			if (this.Disabled) sb.AppendTabsLineIf(".SetDisabled(true)");
			
			if (Helpers.Utils.IsBool(this.Animated)) {
				if (bool.Parse(this.Animated))
					sb.AppendTabsLineIf(".SetAnimate(true)");
			} else if (Helpers.Utils.IsNumeric(this.Animated)) {
				sb.AppendTabsFormatLineIf(".SetAnimate({0})", this.Animated);
			}

			if (this.Min != Options.DEFAULT_MIN)
				sb.AppendTabsFormatLineIf(".SetMin({0})", this.Min);
			if (this.Max != Options.DEFAULT_MAX)
				sb.AppendTabsFormatLineIf(".SetMax({0})", this.Max);

			if (Core.Orientation.StringToOrientation(this.Orientation) != Options.DEFAULT_ORIENTATION)
				sb.AppendTabsFormatLineIf(".SetOrientation(\"{0}\")", this.Orientation);

			if (Helpers.Utils.IsBool(this.Range)) {
				if (bool.Parse(this.Range))
					sb.AppendTabsLineIf(".SetRange(true)");
			} else {
				sb.AppendTabsFormatLineIf(".SetRange(\"{0}\")", this.Range);
			}

			if (this.Step != Options.DEFAULT_STEP)
				sb.AppendTabsFormatLineIf(".SetStep({0})", this.Step);
			
			if (this.Value != Options.DEFAULT_VALUE)
				sb.AppendTabsFormatLineIf(".SetValue({0})", this.Value);

			if (!string.IsNullOrEmpty(this.Values))
				sb.AppendTabsFormatLineIf(".SetValues({0})", this.Values);

			sb.AppendTabsFormatLineIf(".SetSize(\"{0}\")", this.Size);

			return sb.ToString();
		}

		protected string ShowEventsCSharpCode() {
			if (!this.showEvents)
				// nothing to see here
				return "";

			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 2);

			sb.AppendTabsLineIf(".SetCreateEvent(\"return createEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetStartEvent(\"return startEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetSlideEvent(\"return slideEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetChangeEvent(\"return changeEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetStopEvent(\"return stopEvent(event, ui);\")");

			return sb.ToString();
		}



	}

}

