using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jAutoComplete {
	
	/// <summary>
	/// The "Methods" are called after the control has been initialised.  If for instance you want to change
	/// the value of a property, or invoke "some" action on the control (e.g. "open" or "close") you 
	/// call the "Method" rather than through the "Options" (as Options is about the initialisation of the control).
	/// </summary>
	public partial class Methods {

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="ac">Autocomplete object to be called</param>
		public Methods(AutoComplete ac) 
			: base(ac)
		{
		}		

		/// <summary>
		/// Close the Autocomplete menu. Useful in combination with the search method, to 
		/// close the open menu.
		/// </summary>
		public void Close() {
			base.RenderMethodCall("close");
		}	


		/// <summary>
		/// Remove the AutoComplete functionality completely. This will return the element back to its pre-init state.
		/// </summary>
		public void Destroy() {
			base.RenderMethodCall("destroy");
		}	


		/// <summary>
		/// Disable the AutoComplete.
		/// </summary>
		public void Disable() {
			base.RenderMethodCall("disable");
		}	


		/// <summary>
		/// Enable the AutoComplete.
		/// </summary>
		public void Enable() {
			base.RenderMethodCall("enable");
		}	


		/// <summary>
		/// Triggers a search event, which, when data is available, then will display the suggestions; 
		/// can be used by a selectbox-like button to open the suggestions when clicked. 
		/// If no value argument is specified, the current input's value is used. Can be called with an 
		/// empty string and minLength: 0 to display all items.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="searchParam">Search string to use</param>
		public void SearchJS(string searchParam) {
			base.RenderMethodCall("search", searchParam);
		}

		/// <summary>
		/// Triggers a search event, which, when data is available, then will display the suggestions; 
		/// can be used by a selectbox-like button to open the suggestions when clicked. 
		/// If no value argument is specified, the current input's value is used. Can be called with an 
		/// empty string and minLength: 0 to display all items.
		/// </summary>
		/// <param name="searchParam">Search string to use</param>
		public void Search(string searchParam) {
			this.Search(searchParam, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Triggers a search event, which, when data is available, then will display the suggestions; 
		/// can be used by a selectbox-like button to open the suggestions when clicked. 
		/// If no value argument is specified, the current input's value is used. Can be called with an 
		/// empty string and minLength: 0 to display all items.
		/// </summary>
		/// <param name="searchParam">Search string to use</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void Search(string searchParam, bool inDoubleQuotes) {
			searchParam = searchParam.InQuotes(inDoubleQuotes);
			base.RenderMethodCall("search", searchParam);
		}
		

		/// <summary>
		/// Returns the .ui-autocomplete element.
		/// </summary>
		/// <remarks>See https://jqueryui.com/demos/autocomplete/#method-widget for details.</remarks>
		public void Widget() {
			base.RenderMethodCall("widget");
		}	

	}

}
