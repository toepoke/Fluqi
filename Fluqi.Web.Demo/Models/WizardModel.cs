using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Fluqi.Extension.Helpers;
using Fluqi.Extension;
using Fluqi.Helpers;
using Fluqi.Widget.jPushButton;
using Fluqi.Widget.jTab;
using Fluqi.Widget.jDatePicker;
using System.IO;

namespace Fluqi.Models
{
	public class WizardModel {

		// Step 1 - About you
		[DisplayName("Name?")]
		public string Name { get; set; }
		[DisplayName("Date of birth?")]
		public DateTime DateOfBirth { get; set; }
		[DisplayName("Age?")]
		public int Age { get; set; }

		// Step 2 - Your game
		[DisplayName("How often do you play? (every monday, every tuesday, etc)")]
		public string HowOften { get; set; }
		[DisplayName("How long do you play for?")]
		public string Duration { get; set; }

		public WizardModel() {
			this.DateOfBirth = DateTime.Now;
		}

		public SelectList PlayingTimes() {
			Dictionary<string, string> dictPlayingTimes = new Dictionary<string,string>();
			dictPlayingTimes.Add("30", "30 mins");
			dictPlayingTimes.Add("60", "60 mins");
			dictPlayingTimes.Add("90", "90 mins");
			return new SelectList(dictPlayingTimes, "Key", "Value");
		}

		public void ConfigureSideBar(Widget.jAccordion.Accordion ac) {
			ac
				.Panels
					.Add("About you")
					.Add("Your game")
					.Add("Finish")
				.Finish()
				.Options
					.SetCollapsible(true)
					.SetAutoHeight(false)
				.Finish()
				.Rendering
					.SetAutoScript(false)
					.SetTabDepth(1)
				.Finish();
		}
		
		public void ConfigureTabs(Tabs tabs) {
			tabs
				.Panes
					.Add("step1", "About you")
					.Add("step2", "Your game")
					.Add("finish", "Finish")
				.Finish()
				.Rendering
					.SetAutoScript(false)
					.SetTabDepth(1)
				.Finish();
		}

		public void ConfigureButtons(PushButton back, PushButton next, PushButton finish) {
			back.Rendering.SetAutoScript(false).SetTabDepth(1).Finish().Events.SetClickEvent("stepBack();");
			next.Rendering.SetAutoScript(false).SetTabDepth(1).Finish().Events.SetClickEvent("stepNext();");
			finish.Rendering.SetAutoScript(false).SetTabDepth(1).Finish().Events.SetClickEvent("stepFinish();");
		}

		public void ConfigureDatePicker(DatePicker dt) {
			dt
				.Rendering
					.SetAutoScript(false)
					.SetTabDepth(1)
				.Finish()
				.Options
					.SetShowOn("both")
					.SetChangeYear(true)
					.SetChangeMonth(true)
					.SetYearRange("-100")
			;
		}

	} // WizardModel

} // ns
