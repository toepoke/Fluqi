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
using System.IO;
using Fluqi.Widget.jSelectMenu;

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
	public class SelectMenuModel: BaseModel {

		public SelectMenuModel() : base(SUPPORTS_POSITION) {
				
			this.Disabled = false;
			this.Icons = Core.Icons.IconToString( Core.Icons.eIconClass.carat_1_e );
			this.My1 = "left";
			this.My2 = "top";
			this.At1 = "left";
			this.At2 = "bottom";
			this.Collision1 = Core.Collision.CollisionToString( Core.Collision.eCollision.None );
			this.Collision2 = Core.Collision.CollisionToString( Core.Collision.eCollision.None );
		}

		public bool Disabled { get; set; }
		public string Icons { get; set; }
		public int Width { get; set; }

		public void ConfigureSelectMenu(SelectMenu mnu) {
			mnu	
				.Items()
					.Add("Slower", "slower")
					.Add("Slow", "slow")
					.Add("Medium", "medium")
					.Add("Fast", "fast")
					.Add("Faster", "faster")
				.Finish()
				.Rendering
					.SetPrettyRender(true)
				.Finish()
				.Options
					.SetDisabled(this.Disabled)
					.SetWidth(this.Width)
					.SetIcons(this.Icons)
				.Finish()
			;

			if (this.showEvents) {
				mnu
					.Events
						.SetChangeEvent("return changeEvent(event, ui);")
						.SetCloseEvent("return closeEvent(event, ui);")
						.SetCreateEvent("return createEvent(event, ui);")
						.SetFocusEvent("return focusEvent(event, ui);")
						.SetSelectEvent("return selectEvent(event, ui);")
						.SetOpenEvent("return openEvent(event, ui);")
					.Finish();
			}
			if (!this.prettyRender)
				mnu.Rendering.Compress();
			if (this.renderCSS)
				mnu.Rendering.ShowCSS();
		}

		public string JavaScriptCode(SelectMenu mnu) {
			mnu.Rendering.SetPrettyRender(true);
			return mnu.GetStartUpScript();
		}

		public string CSharpCode(SelectMenu mnu) {
			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 0);

			sb.AppendTabsLineIf("<%");
			sb.AppendTabsLineIf("Html.CreateSelectMenu(\"mnu\")");

			string optionsCode = OptionsCSharpCode();
			string positionOptionsCode = PositionsCSharpCode();
			string showEventsCode = ShowEventsCSharpCode();
			string renderCode = base.RenderCSharpCode();
			bool showOptions = (optionsCode.Length > 0 || positionOptionsCode.Length > 0 || showEventsCode.Length > 0 || renderCode.Length > 0);
			
			if (showOptions) {
				sb.IncIndent();

				if (optionsCode.Length > 0 || positionOptionsCode.Length > 0) {
					sb.AppendTabsLineIf(".Options");
					sb.IncIndent();
					sb.Append(optionsCode);
					sb.DecIndent();
					sb.AppendTabsLineIf(".Finish()");
				}	
				if (positionOptionsCode.Length > 0) {
					sb.IncIndent();
					if (positionOptionsCode.Length > 0) {
						sb.AppendTabsLineIf(".Position");
						sb.Append(positionOptionsCode);
						sb.AppendTabsLineIf(".Finish()");
					}
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
			if (this.Width > 0) sb.AppendTabsFormatLineIf(".SetWidth({0})", this.Width);
			if (Core.Icons.StringToIcon(this.Icons) != Core.Icons.eIconClass.carat_1_e) {
				sb.AppendTabsFormatLineIf(".SetIcons(\"{0}\")", this.Icons);
			}

			return sb.ToString();
		}
		
		protected string ShowEventsCSharpCode() {
			if (!this.showEvents)
				// nothing to see here
				return "";

			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 2);

			sb.AppendTabsLineIf(".SetChangeEvent(\"return changeEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetCloseEvent(\"return closeEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetCreateEvent(\"return createEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetFocusEvent(\"return focusEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetSelectEvent(\"return selectEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetOpenEvent(\"return openEvent(event, ui);\")");

			return sb.ToString();
		}

	}

}

