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
using Fluqi.Widget.jMenu;
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
	public class MenuModel: BaseModel {

		public MenuModel() : base() {
			this.Disabled = false;
			this.Icons = Core.Icons.IconToString( Core.Icons.eIconClass.carat_1_e );
			this.My1 = "left";
			this.My2 = "top";
			this.At1 = "right";
			this.At2 = "top";
			this.Collision1 = Core.Collision.CollisionToString( Core.Collision.eCollision.None );
			this.Collision2 = Core.Collision.CollisionToString( Core.Collision.eCollision.None );
		}

		public bool Disabled { get; set; }
		public string Icons { get; set; }
		public string My1 { get; set; }
		public string My2 { get; set; }
		public string At1 { get; set; }
		public string At2 { get; set; }
		public string Collision1 { get; set; }
		public string Collision2 { get; set; }

		public void ConfigureMenu(Menu mnu) {
			mnu
				.Items()
					.Add("Home", "http://fluqi.apphb.com", Core.Icons.eIconClass.home)
					.Add("File", Core.Icons.eIconClass.disk)
						.SubMenu()
							.Add("Open", Core.Icons.eIconClass.folder_open)
							.Add("Search", Core.Icons.eIconClass.search)
							.Add("Close", Core.Icons.eIconClass.close)
						.Back()
					.Add("Edit", Core.Icons.eIconClass.pencil)
						.SubMenu()
							.Add("Cut", Core.Icons.eIconClass.scissors)
							.Add("Copy", Core.Icons.eIconClass.copy)
							.Add("Paste", Core.Icons.eIconClass.clipboard)
						.Back()
				.Finish()
				.Rendering
					.SetPrettyRender(true)
				.Finish()
				.Options
					.SetDisabled(this.Disabled)
					.SetIcons(this.Icons)
					.Position
						.SetAt(this.At1, this.At2)
						.SetMy(this.My1, this.My2)
						.SetCollision(this.Collision1, this.Collision2)
					.Finish()		
				.Finish();

			if (this.showEvents) {
				mnu
					.Events
						.SetCreateEvent("return createEvent(event, ui);")
						.SetBlurEvent("return blurEvent(event, ui);")
						.SetSelectEvent("return selectEvent(event, ui);")
						.SetFocusEvent("return focusEvent(event, ui);")
					.Finish();
			}
			if (!this.prettyRender)
				mnu.Rendering.Compress();
			if (this.renderCSS)
				mnu.Rendering.ShowCSS();
		}

		public string JavaScriptCode(Menu mnu) {
			return mnu.GetStartUpScript();
		}

		public string CSharpCode(Menu mnu) {
			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 0);

			sb.AppendTabsLineIf("<%");
			sb.AppendTabsLineIf("Html.CreateMenu(\"mnu\")");

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
			
			if (Core.Icons.StringToIcon(this.Icons) != Core.Icons.eIconClass.carat_1_e) {
				sb.AppendTabsFormatLineIf(".SetIcons(\"{0}\")", this.Icons);
			}

			return sb.ToString();
		}

		protected string PositionsCSharpCode() {
			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 3);

			if (!string.IsNullOrEmpty(this.At1) && !string.IsNullOrEmpty(this.At2)) {
				sb.AppendTabsFormatLineIf(".SetAt(\"{0}\", \"{1}\")", this.At1, this.At2);
			} else if (!string.IsNullOrEmpty(this.At1)) {
				sb.AppendTabsFormatLineIf(".SetAt(\"{0}\")", this.At1);
			} else if (!string.IsNullOrEmpty(this.At2)) {
				sb.AppendTabsFormatLineIf(".SetAt(\"{0}\")", this.At2);
			}

			if (!string.IsNullOrEmpty(this.My1) && !string.IsNullOrEmpty(this.My2)) {
				sb.AppendTabsFormatLineIf(".SetMy(\"{0}\", \"{1}\")", this.My1, this.My2);
			} else if (!string.IsNullOrEmpty(this.My1)) {
				sb.AppendTabsFormatLineIf(".SetMy(\"{0}\")", this.My1);
			} else if (!string.IsNullOrEmpty(this.My2)) {
				sb.AppendTabsFormatLineIf(".SetMy(\"{0}\")", this.My2);
			}

			if (!Helpers.Utils.IsNullEmptyOrDefault(this.Collision1, "none") && !Helpers.Utils.IsNullEmptyOrDefault(this.Collision2, "none")) {
				sb.AppendTabsFormatLineIf(".SetCollision(\"{0}\", \"{1}\")", this.Collision1, this.Collision2);
			} else if (!Helpers.Utils.IsNullEmptyOrDefault(this.Collision1, "none")) {
				sb.AppendTabsFormatLineIf(".SetCollision(\"{0}\")", this.Collision1);
			} else if (!Helpers.Utils.IsNullEmptyOrDefault(this.Collision2, "none")) {
				sb.AppendTabsFormatLineIf(".SetCollision(\"{0}\")", this.Collision2);
			}

			return sb.ToString();
		}

		protected string ShowEventsCSharpCode() {
			if (!this.showEvents)
				// nothing to see here
				return "";

			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 2);

			sb.AppendTabsLineIf(".SetCreateEvent(\"return createEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetBlurEvent(\"return blurEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetSelectEvent(\"return selectEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetFocusEvent(\"return focusEvent(event, ui);\")");

			return sb.ToString();
		}

	}

}

