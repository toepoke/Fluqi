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
using Fluqi.Widget.jPushButton;
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
	public class PushButtonModel: BaseModel {

		public PushButtonModel() : base() {
			this.disabled = false;
			this.text = true;
			this.primaryIcon = "";
			this.secondaryIcon = "";
			this.label = "Fluqi!";
			this.renderAs = Core.ButtonType.ButtonTypeToString(Core.ButtonType.eButtonType.Button);
		}

		public bool disabled { get; set; }
		public bool text { get; set; }
		public string primaryIcon { get; set; }
		public string secondaryIcon { get; set; }
		public string label { get; set; }
		public string renderAs { get; set; }
		
		public void ConfigureButton(PushButton btn) {
			btn
				.Rendering
					.SetPrettyRender(true)
				.Finish()
				.Options
					.SetDisabled(this.disabled)
					.SetText(this.text)
					.SetIcons(this.primaryIcon, this.secondaryIcon)
				.Finish()
			;

			if (!string.IsNullOrEmpty(this.renderAs)) {
				Core.ButtonType.eButtonType inputType = Core.ButtonType.StringToButtonType(this.renderAs);
				btn.RenderAs(inputType);
				if (inputType == Core.ButtonType.eButtonType.Hyperlink)
					// just to make things look right
					btn.Href = "#";
			}

			if (this.showEvents) {
				btn.Events
					.SetCreateEvent("createEvent(event, ui);")
					.SetClickEvent("clickEvent();")
				.Finish();
			}
			if (!this.prettyRender)
				btn.Rendering.Compress();
			if (this.renderCSS)
				btn.Rendering.ShowCSS();
		}

		public string JavaScriptCode(PushButton btn) {
			return btn.GetStartUpScript();
		}

		public string CSharpCode(PushButton btn) {
			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 0);

			sb.AppendTabsLineIf("<%");
			sb.AppendTabsFormatLineIf("Html.CreateButton(\"{0}\", \"{1}\")", btn.ID, this.label);

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
			if (!this.text)
				sb.AppendTabsLineIf(".SetText(false)");
			// icons must be set as a pair
			if (!string.IsNullOrEmpty(this.primaryIcon) || !string.IsNullOrEmpty(this.secondaryIcon)) {
				sb.AppendTabsFormatLineIf(".SetIcons(\"{0}\", \"{1}\")", this.primaryIcon, this.secondaryIcon);
			}

			return sb.ToString();
		}

		protected string ShowEventsCSharpCode() {
			if (!this.showEvents)
				// nothing to see here
				return "";

			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 2);

			sb.AppendTabsLineIf(".SetCreateEvent(\"createEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetClickEvent(\"clickEvent(event, ui);\")");

			return sb.ToString();
		}

	}

}
