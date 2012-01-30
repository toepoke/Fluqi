using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Fluqi.Widget.jTab
{
	/// <summary>
	/// Models the set of Panes that are in the Tabs control.
	/// </summary>
	public class Panes
	{
		/// <summary>
		/// Flags the currently selected pane.
		/// </summary>
		protected internal Dictionary<string, Pane>.Enumerator _CurrentPaneValue;

		/// <summary>
		/// Holds the set of panes added to the Tabs object.
		/// </summary>
		protected internal Dictionary<string, Pane> _Panes = null;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="tabs">Tabs object the panels belong to</param>
		public Panes(Tabs tabs)
		 : base()
		{
			this.Tabs = tabs;
			this._Panes = new Dictionary<string,Pane>();
		}

		/// <summary>
		/// Holds a reference to the <see cref="Tabs"/> object these events are for
		/// </summary>
		public Tabs Tabs { get; set; }

		/// <summary>
		/// Used to flag that configuration of <see cref="Options"/> has finished, and 
		/// returns the <see cref="Tabs"/> object so we can continue defining Tabs attributes.
		/// </summary>
		/// <returns>Returns <see cref="Tabs"/> object to return chaining to the Tabs collection</returns>
		public Tabs Finish() {
			return this.Tabs;
		}


		/// <summary>
		/// Adds a tab into the collection of tabs.  Due to the dependencies between the 
		/// tab headings and content panes the tabs must be defined up-front
		/// </summary>
		/// <param name="idOrLocation">
		/// For static tabs this is the ID of the tab content pane (must be unique on the page).
		/// For dynamic tabs this is the URL where the content is loaded from.
		/// </param>
		/// <param name="title">Title of the tab (to appear in the tab headings)</param>
		/// <returns>Returns Tabs object to maintain chainability</returns>
		public Panes Add(string idOrLocation, string title) {
			return this.Add(idOrLocation, title, false);
		}


		/// <summary>
		/// Adds a tab into the collection of tabs.  Due to the dependencies between the 
		/// tab headings and content panes the tabs must be defined up-front
		/// </summary>
		/// <param name="idOrLocation">
		/// For static tabs this is the ID of the tab content pane (must be unique on the page).
		/// For dynamic tabs this is the URL where the content is loaded from.
		/// </param>
		/// <param name="title">Title of the tab (to appear in the tab headings)</param>
		/// <param name="selected">Flags whether this tab should be the selected tab on page load</param>
		/// <returns>Returns Tabs object to maintain chainability</returns>
		public Panes Add(string idOrLocation, string title, bool selected) {
			Pane newTab = new Pane(this.Tabs.Writer, this, idOrLocation, title, selected);

			if (this._Panes.ContainsKey(newTab.IDOrLocation))
				throw new ArgumentException(string.Format("A tab with ID or Location \"{0}\" has already been added.", newTab.IDOrLocation));

			newTab.Index = this._Panes.Count();
			this._Panes.Add(newTab.IDOrLocation, newTab);

			return this;
		}

		/// <summary>
		/// Renders the tab content pane to the Response.
		/// </summary>
		public Pane RenderNextPane() {
			if (this.Tabs._AsDynamic)
				throw new NotSupportedException("Tabs.Panes.RenderNextPane is not supported in \"Dynamic\" loading is on.");
			if (!this.Tabs._HeaderRendered)
				throw new Exception("Tabs.RenderHeader must be called before Tabs.Panes.RenderNextPane().");

			Pane t = this.GetNextTab();

			if (t == null)
				throw new InvalidOperationException("No tab found.");

			Pane tb = this._Panes[t.IDOrLocation];
			if (tb != null) {
				tb.Render();
			}
		
			return tb;
		}


		/// <summary>
		/// Gets the underlying list of Panes on the Accordion control.
		/// </summary>
		/// <returns>List of panes on the tab.</returns>
		/// <remarks>
		/// Note that the Panes are intentionally hidden from the caller so that the API reads more clearly.
		/// </remarks>
		public Dictionary<string, Pane> ToDictionary() {
			return this._Panes;
		}


		/// <summary>
		/// Internal helper method to get the Tab marked as Selected (if there is one)
		/// </summary>
		/// <returns>
		/// Returns the selected Tab if there is one
		/// Returns null otherwise
		/// </returns>
		protected internal Pane GetSelectedTab() {
			foreach (Pane tb in this._Panes.Values) {
				if (tb.IsSelected)
					return tb;
			}

			return null;		
		}


		/// <summary>
		/// Internal helper method to establish if any of the tabs are marked as selected
		/// </summary>
		/// <returns>
		/// Returns true if a selected Tab is defined
		/// Returns false otherwise
		/// </returns>
		protected internal bool HasSelectedTab() {
			return (this.GetSelectedTab() != null);
		}


		/// <summary>
		/// Resets all tabs to unselected.
		/// </summary>
		protected internal void ResetSelectedTabs() {
			foreach (Pane t in this._Panes.Values) 
				// go directly to the underlying value rather than the property
				// ... otherwise we'll end up calling our self back and have a stackoverflow
				t._IsSelected = false;
		}


		/// <summary>
		/// Works out which (if any) of the tab panes are marked as selected.
		/// If none are selected, the first tab is marked as selected.
		/// </summary>
		/// <remarks>
		/// This is necessary to ensure the correct mark-up is produced when the
		/// ShowCSS option is enabled (i.e. full markup is rendered).
		/// </remarks>
		protected internal void ResolveActiveTab() {
			if (!this.HasSelectedTab() && this._Panes.Any())
				this._Panes.Values.FirstOrDefault().IsSelected = true;
		}


		/// <summary>
		/// Returns the next tab to be rendered through <see cref="RenderNextPane"/>.
		/// </summary>
		/// <returns>
		/// Returns next tab to be rendered if list has not been exhausted.
		/// Returns null if all tab panes have already been rendered.
		/// </returns>
		protected internal Pane GetNextTab() {
			if (_CurrentPaneValue.MoveNext()) {
				Pane t = _CurrentPaneValue.Current.Value;
				return t;
			}

			return null;
		}


		/// <summary>
		/// Resets where the enumerator is (used for tracking which tab is due to 
		/// be rendered on the next call to <see cref="RenderNextPane"/>).
		/// </summary>
		protected internal void ResetEnumerator() {
			_CurrentPaneValue = this._Panes.GetEnumerator();
		}

	}
}
