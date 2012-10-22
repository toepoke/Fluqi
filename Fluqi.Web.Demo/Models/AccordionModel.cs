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
using Fluqi.Widget.jAccordion;
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
	public class AccordionModel: BaseModel {

		public AccordionModel() : base() {
			this.collapsible = false;
			this.disabled = false;
			this.animate = "";
			this.evt = Core.BrowserEvent.BrowserEventToString(Core.BrowserEvent.eBrowserEvent.Click);
			this.heightStyle = Core.HeightStyle.HeightStyleToString(Core.HeightStyle.eHeightStyle.Auto);
			this.headerIconClass = Core.Icons.IconToString( Core.Icons.eIconClass.triangle_1_e );
			this.activeHeaderIconClass = Core.Icons.IconToString( Core.Icons.eIconClass.triangle_1_s );
			this.activePanel = 0;
		}

		public bool collapsible { get; set; }
		public bool disabled { get; set; }
		public string animate { get; set; }
		public string evt { get; set; }
		public string heightStyle { get; set; }
		public string headerIconClass { get; set; }
		public string activeHeaderIconClass { get; set; }
		public int activePanel { get; set; }


		public void ConfigureAccordion(Accordion ac) {
			ac
				.Rendering
					.SetPrettyRender(true)
				.Finish()
				.Options
					.SetCollapsible(this.collapsible)
					.SetDisabled(this.disabled)
					.SetAnimate(this.animate)
					.SetEvent(this.evt)
					.SetHeightStyle(this.heightStyle)
					.SetIcons(this.headerIconClass, this.activeHeaderIconClass)
				.Finish()
				.Panels
					.Add("My Panel 1", (this.activePanel == 0) )
					.Add("My Panel 2", (this.activePanel == 1) )
					.Add("My Panel 3", (this.activePanel == 2) )
				;
			
			if (this.showEvents) {
				ac.Events
					.SetCreateEvent("return createEvent(event, ui);")
					.SetActivateEvent("return activateEvent(event, ui);")
					.SetBeforeActivateEvent("return beforeActivateEvent(event, ui);")
				;
			}
			if (!this.prettyRender)
				ac.Rendering.Compress();
			if (this.renderCSS)
				ac.Rendering.ShowCSS();
		}

		public string JavaScriptCode(Accordion ac) {
			return ac.GetStartUpScript();
		}


		public string CSharpCode(Accordion ac) {
			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 0);

			sb.AppendTabsLineIf("<%");
			sb.AppendTabsFormatLineIf("var ac = Html.CreateAccordion(\"{0}\")", ac.ID);

			string optionsCode = OptionsCSharpCode();
			string showEventsCode = ShowEventsCSharpCode();
			string renderCode = base.RenderCSharpCode();

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

			sb.IncIndent();
			sb.AppendTabsLineIf(".Panels");
			sb.IncIndent();
			sb.AppendTabsFormatLineIf(".Add(\"My Panel 1\"{0})", (this.activePanel == 0 ? ", true" : "") );
			sb.AppendTabsFormatLineIf(".Add(\"My Panel 2\"{0})", (this.activePanel == 1 ? ", true" : "") );
			sb.AppendTabsFormatLineIf(".Add(\"My Panel 3\"{0})", (this.activePanel == 2 ? ", true" : "") );
			sb.DecIndent();
			sb.AppendTabsLineIf(".Finish()");
			sb.DecIndent();
			sb.AppendTabsLineIf(";");
			sb.AppendTabsLineIf("%>");

			sb.AppendLineIf();
			sb.AppendTabsLineIf("<%using (ac.RenderContainer()) {%>");
			sb.IncIndent();
			sb.AppendTabsLineIf("<%using (ac.Panels.RenderNextPane()) {%>");
			sb.AppendTabsLineIf("\t<p>Proin ...</p>");
			sb.AppendTabsLineIf("<%}%>");
			sb.AppendTabsLineIf("<%using (ac.Panels.RenderNextPane()) {%>");
			sb.AppendTabsLineIf("\t<p>Morbi ...</p>");
			sb.AppendTabsLineIf("<%}%>");
			sb.AppendTabsLineIf("<%using (ac.Panels.RenderNextPane()) {%>");
			sb.AppendTabsLineIf("\t<p>Mauris ...</p>");
			sb.AppendTabsLineIf("<%}%>");
						
			sb.DecIndent();
			sb.AppendTabsLineIf("<%}%>");
			
			return sb.ToString();
		}

		protected string OptionsCSharpCode() {
			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 2);

			if (this.disabled)
				sb.AppendTabsLineIf(".SetDisabled(true)");
			if (!string.IsNullOrEmpty(this.animate)) {
				if (Helpers.Utils.IsBool(this.animate))
					sb.AppendTabsFormatLineIf(".SetAnimate({0})", bool.Parse(this.animate).JsBool());
				else if (!Helpers.Utils.IsNullEmptyOrDefault(this.animate, Widget.jAccordion.Options.DEFAULT_ANIMATE))
					sb.AppendTabsFormatLineIf(".SetAnimate(\"{0}\")", this.animate);
			}
			if (this.collapsible)
				sb.AppendTabsLineIf(".SetCollapsible(true)");
			if (!Helpers.Utils.IsNullEmptyOrDefault(this.evt, Widget.jAccordion.Options.DEFAULT_EVENT))
				sb.AppendTabsFormatLineIf(".SetEvent(\"{0}\")", this.evt);
			if (!string.IsNullOrEmpty(this.heightStyle)) {
				sb.AppendTabsFormatLineIf(".SetHeightStyle(\"{0}\")", this.heightStyle);
			}


			// icons have to be set as a pair
			bool addNormalIcon = !string.IsNullOrEmpty(this.headerIconClass) && this.headerIconClass != Widget.jAccordion.Options.DEFAULT_HEADER_ICON_CLASS;
			bool addSelectedIcon = !string.IsNullOrEmpty(this.activeHeaderIconClass) && this.activeHeaderIconClass != Widget.jAccordion.Options.DEFAULT_ACTIVE_HEADER_ICON_CLASS;
			if (addNormalIcon || addSelectedIcon) {
				 sb.AppendTabsFormatLineIf(".SetIcons(\"{0}\", \"{1}\")", this.headerIconClass, this.activeHeaderIconClass);
			}

			return sb.ToString();
		}

		protected string ShowEventsCSharpCode() {
			if (!this.showEvents)
				// nothing to see here
				return "";

			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 2);
			sb.AppendTabsLineIf(".SetCreateEvent(\"return createEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetactivateEvent(\"return activateEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetBeforeActivateEvent(\"return beforeActivateEvent(event, ui);\")");

			return sb.ToString();
		}

	}

}

