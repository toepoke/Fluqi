using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Fluqi;
using Fluqi.Widget.jTab;
using Fluqi.Extension;

namespace Fluqi.Web.Demo.WebForms {

	public partial class QuickDemo : System.Web.UI.Page {

		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected Widget.jAccordion.Accordion BuildAccordion() {
			var ac = base.Page.CreateAccordion("ac", ""); 
			ac
				.Panels
					.Add("Tabs Demo")
					.Add("AutoComplete Demo")
					.Add("DatePicker Demo")
					.Add("Slider Demo")
					.Add("ProgressBar Demo")
					.Add("Dialog Demo")
					.Add("Button Demo")
				.Finish()
				.Options
					.SetAnimated("bounceslide")
				.Finish();
			return ac;
		}

		protected Tabs BuildTabs() {
			var tabs = base.Page.CreateTabs("tabs")
				.Panes
					.Add("tab-1", "Tab #1")
					.Add("tab-2", "Tab #2")
					.Add("tab-3", "Tab #3")
				.Finish()
			;

			return tabs;
		}

	}
}