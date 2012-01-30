using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fluqi.Web.Builder.Controllers
{
	public partial class BuilderController : Controller
	{

		public ActionResult DatePicker()
		{
			Models.DatePickerModel options = new Models.DatePickerModel();

			return View(options);
		}

		[HttpPost()]
		public ActionResult DatePicker(Models.DatePickerModel options) {
			if (options.FakeDayNamesChange) {
				// just make all the dayNames uppercase to illustrate you
				// can change them
				for (int dayNdx=0; dayNdx < options.DayNames.Count(); dayNdx++) {
					// dayNames, dayNamesShort and dayNamesMin should all be the same size
					// so we can get away with setting all three
					options.DayNames[dayNdx] = options.DayNames[dayNdx].ToUpper();
					options.DayNamesMin[dayNdx] = options.DayNamesMin[dayNdx].ToUpper();
					options.DayNamesShort[dayNdx] = options.DayNamesShort[dayNdx].ToUpper();
				}
			}

			if (options.FakeMonthNamesChange) {
				// just make all the monthNames uppercase to illustrate you 
				// can change them
				for (int monthNdx=0; monthNdx < options.MonthNames.Count(); monthNdx++) {
					// monthNames and monthNamesShort should all be the same size
					// so we can get away with setting all three
					options.MonthNames[monthNdx] = options.MonthNames[monthNdx].ToUpper();
					options.MonthNamesShort[monthNdx] = options.MonthNamesShort[monthNdx].ToUpper();
				}

			}

			return View(options);
		}

	}

}
