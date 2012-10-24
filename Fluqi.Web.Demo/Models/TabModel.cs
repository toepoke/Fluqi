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
using Fluqi.Widget.jTab;
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
	public class TabModel: BaseModel {

		/// <summary>
		/// Constructor - initialise model as per jQuery UI defaults
		/// </summary>
		public TabModel() : base() {
			this.collapsible = false;
			this.disabled = false;
			this.showEffect = "";
			this.showDuration = "";
			this.hideEffect = "";
			this.hideDuration = "";
			this.evt = Core.BrowserEvent.BrowserEventToString(Core.BrowserEvent.eBrowserEvent.Click);
			this.selectedTab = 0;
		}

		public bool collapsible { get; set; }
		public bool disabled { get; set; }
		public string evt { get; set; }
		public string showEffect { get; set; }
		public string showDuration { get; set; }
		public string hideEffect { get; set; }
		public string hideDuration { get; set; }
		public int selectedTab { get; set; }

		public void ConfigureTabs(Tabs tabs) {
			tabs
				.Rendering
					.SetPrettyRender(true)
				.Finish()
				.Options
					.SetCollapsible(this.collapsible)
					.SetDisabled(this.disabled)
					.ShowAnimation
						.SetEffect(this.showEffect)
						.SetDuration(this.showDuration)
					.Finish()
					.HideAnimation
						.SetEffect(this.hideEffect)
						.SetDuration(this.hideDuration)
					.Finish()
				.Finish()
				.Panes
					.Add("tab1", "Tab #1", (this.selectedTab == 0) )
					.Add("tab2", "Tab #2", (this.selectedTab == 1) )
					.Add("tab3", "Tab #3", (this.selectedTab == 2) )
				.Finish()
			;

			if (this.showEvents) {
				tabs.Events
					.SetCreateEvent("return createEvent(event, ui);")
					.SetSelectEvent("return selectEvent(event, ui);")
					.SetLoadEvent("return loadEvent(event, ui);")
					.SetShowEvent("return showEvent(event, ui);")
					.SetAddEvent("return addEvent(event, ui);")
					.SetRemoveEvent("return removeEvent(event, ui);")
					.SetEnableEvent("return enableEvent(event, ui);")
					.SetDisableEvent("return disableEvent(event, ui);")
				;
			}
			if (!this.prettyRender)
				tabs.Rendering.Compress();
			if (this.renderCSS)
				tabs.Rendering.ShowCSS();
		}

		public string JavaScriptCode(Tabs tabs) {
			return tabs.GetStartUpScript();
		}
		
		public string CSharpCode(Tabs tabs) {
			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 0);

			sb.AppendTabsLineIf("<%");
			sb.AppendTabsFormatLineIf("var tabs = Html.CreateTabs(\"{0}\")", tabs.ID);

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

			sb.IncIndent();
			sb.AppendTabsLineIf(".Panes");
			sb.IncIndent();
			sb.AppendTabsFormatLineIf(".Add(\"tab1\", \"Tab #1\"{0})", (this.selectedTab == 0 ? ", true" : "") );
			sb.AppendTabsFormatLineIf(".Add(\"tab2\", \"Tab #2\"{0})", (this.selectedTab == 1 ? ", true" : "") );
			sb.AppendTabsFormatLineIf(".Add(\"tab3\", \"Tab #3\"{0})", (this.selectedTab == 2 ? ", true" : "") );
			sb.DecIndent();
			sb.AppendTabsLineIf(".Finish();");
			sb.DecIndent();
			sb.AppendTabsLineIf("%>");

			sb.AppendLineIf();
			sb.AppendTabsLineIf("<%using (tabs.RenderHeader()) {%>");
			sb.IncIndent();
			sb.AppendTabsLineIf("<%using (tabs.Panes.RenderNextPane()) {%>");
			sb.AppendTabsLineIf("\t<p>Proin ...</p>");
			sb.AppendTabsLineIf("<%}%>");
			sb.AppendTabsLineIf("<%using (tabs.Panes.RenderNextPane()) {%>");
			sb.AppendTabsLineIf("\t<p>Morbi ...</p>");
			sb.AppendTabsLineIf("<%}%>");
			sb.AppendTabsLineIf("<%using (tabs.Panes.RenderNextPane()) {%>");
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
			if (this.collapsible)
				sb.AppendTabsLineIf(".SetCollapsible(true)");
			sb.AppendTabsLineIf(".ShowAnimation");
			sb.IncIndent();
			sb.AppendTabsFormatLineIf(".SetEffect(\"{0}\")", this.showEffect);
			sb.AppendTabsFormatLineIf(".SetDuration(\"{0}\")", this.showDuration);
			sb.AppendTabsLineIf(".Finish()");
			sb.DecIndent();
			sb.AppendTabsLineIf(".HideAnimation");
			sb.IncIndent();
			sb.AppendTabsFormatLineIf(".SetEffect(\"{0}\")", this.hideEffect);
			sb.AppendTabsFormatLineIf(".SetDuration(\"{0}\")", this.hideDuration);
			sb.AppendTabsLineIf(".Finish()");
			sb.DecIndent();
			if (!Utils.IsNullEmptyOrDefault(this.evt, Options.DEFAULT_EVENT))
				sb.AppendTabsFormatLineIf(".SetEvent(\"{0}\")", this.evt);

			return sb.ToString();
		}

		protected string ShowEventsCSharpCode() {
			if (!this.showEvents)
				// Nothing to see here
				return "";

			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 2);
	
			sb.AppendTabsLineIf(".SetCreateEvent(\"return createEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetSelectEvent(\"return selectEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetLoadEvent(\"return loadEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetShowEvent(\"return showEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetAddEvent(\"return addEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetRemoveEvent(\"return removeEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetEnableEvent(\"return enableEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetDisableEvent(\"return disableEvent(event, ui);\")");

			return sb.ToString();
		}

	}

}
