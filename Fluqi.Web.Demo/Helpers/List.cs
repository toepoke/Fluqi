using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Linq.Expressions;

namespace Fluqi.Web.Demo.Helpers {
	
	public static class List {

		public static SelectList IconListNames() {
			List<string> items = Fluqi.Core.Icons.ToList();
			// prompt for select
			items.Insert(0, "");
			Dictionary<string, string> dict = 
				items.ToDictionary(
					v => (v == "None" ? "" : v.ToLower()),
					// strip off the ui-icon in the label, doesn't help anyone
					v => v.ToLower().Replace("ui-icon-", "")
				);
					
			return new SelectList(dict, "Key", "Value");
		}

		public static SelectList IconPositionListNames() {
			List<string> items = Fluqi.Core.IconPosition.ToList();
			// prompt for select
			items.Insert(0, "");
			Dictionary<string, string> dict = 
				items.ToDictionary(
					v => (v == "None" ? "" : v.ToLower()),
					v => v.ToLower()
				);

			return new SelectList(dict, "Key", "Value");
		}
		
		public static SelectList BrowserEventItems() {
			List<string> items = Core.BrowserEvent.ToList();

			Dictionary<string, string> dict = 
				items.ToDictionary(
					v => (v == "None" ? "" : v.ToLower()),
					v => v.ToLower()
				);
					
			return new SelectList(dict, "Key", "Value");
		}

		public static SelectList OrientationItems() {
			List<string> items = Core.Orientation.ToList();
			// no prompt as there's only two options and the default is one of them
			Dictionary<string, string> dict = 
				items.ToDictionary(
					v => (v == "None" ? "" : v.ToLower()),
					v => v.ToLower()
				);
					
			return new SelectList(dict, "Key", "Value");
		}

		public static SelectList DirectionItems() {
			List<string> items = Core.Position.ToList();
			// no need for select prompt
			Dictionary<string, string> dict = 
				items.ToDictionary(
					v => (v == "None" ? "" : v.ToLower()),
					v => v.ToLower()
				);
					
			return new SelectList(dict, "Key", "Value");
		}

		public static SelectList CollisionItems() {
			List<string> items = Core.Collision.ToList();
			// prompt for select
			Dictionary<string, string> dict = 
				items.ToDictionary(
					v => v.ToLower(),
					v => v.ToLower()
				);
					
			return new SelectList(dict, "Key", "Value");
		}

		public static SelectList ButtonOptions() {
			List<string> items = Core.ButtonType.ToList();
			// prompt for select
			items.Insert(0, "");
			Dictionary<string, string> dict = 
				items.ToDictionary(
					v => (v == "None" ? "" : v.ToLower()),
					v => v.ToLower()
				);
					
			return new SelectList(dict, "Key", "Value");
		}

		public static SelectList AnimationItems() {
			List<string> animationList = Core.Animation.ToList();
			Dictionary<string, string> animations = 
				animationList.ToDictionary(
					v => (v == "None" ? "" : v.ToLower()), 
					v => v.ToLower()
				);
			return new SelectList(animations, "Key", "Value");
		}

		public static SelectList EasingItems() {
			List<string> list = Core.Ease.ToList();
			Dictionary<string, string> easing = 
				list.ToDictionary(
					v => (v == "None" ? "" : v), 
					v => v
				);
			return new SelectList(easing, "Key", "Value");
		}

		public static SelectList HeightStyleItems() {
			List<string> list = Core.HeightStyle.ToList();
			Dictionary<string, string> styles = 
				list.ToDictionary(
					v => (v == "None" ? "" : v.ToLower()), 
					v => v.ToLower()
				);
			return new SelectList(styles, "Key", "Value");
		}

	}

}