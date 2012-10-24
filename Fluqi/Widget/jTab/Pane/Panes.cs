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
		/// Flags the currently active pane.
		/// </summary>
		protected internal Dictionary<string, Pane>.Enumerator _CurrentPaneValue;

		/// <summary>
		/// Holds the set of panes added to the Tabs object.
		/// </summary>
		protected internal Dictionary<string, Pane> _Panes = null;

		/// <summary>
		/// Holds a reference to the Pane which has just been added, in case further configuration
		/// of the Pane is required.
		/// </summary>
		protected internal Pane _CurrentPane = null;

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
		/// <param name="active">Flags whether this tab should be the active tab on page load</param>
		/// <returns>Returns Tabs object to maintain chainability</returns>
		public Panes Add(string idOrLocation, string title, bool active) {
			Pane newTab = new Pane(this.Tabs.Writer, this, idOrLocation, title, active);

			if (this._Panes.ContainsKey(newTab.IDOrLocation))
				throw new ArgumentException(string.Format("A tab with ID or Location \"{0}\" has already been added.", newTab.IDOrLocation));

			newTab.Index = this._Panes.Count();
			this._Panes.Add(newTab.IDOrLocation, newTab);

			// hold a quick reference to the Pane in case further configuration is required
			_CurrentPane = newTab;

			return this;
		}


		/// <summary>
		/// Allows further configuration of a tab pane that has just been added.
		/// </summary>
		/// <returns>Added tab Pane.</returns>
		public Pane Configure() {
			return _CurrentPane;
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
		/// Gets the Pane at a given index.
		/// </summary>
		/// <param name="index">Index to find</param>
		/// <remarks>
		/// The index is based on the <see cref="Pane.Index"/> property
		/// </remarks>
		public Pane this[int index] {
			get {
				Pane foundPane = null;

				foreach (Pane currPane in _Panes.Values) {
					if (currPane.Index == index) { 
						foundPane = currPane;
						continue;
					}
				}

				return foundPane;
			}
			// no set implementation
		}


		/// <summary>
		/// Gets a Pane with a given key (the key allocated when the Tabs was first built.
		/// </summary>
		/// <param name="key">Key index to the pane</param>
		public Pane this[string key] {
			get {
				if (!_Panes.ContainsKey(key))
					// nothing to see here
					return null;

				return _Panes[key];
			}
			// no set implementation			
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
		/// Internal helper method to get the Tab marked as active (if there is one)
		/// </summary>
		/// <returns>
		/// Returns the active Tab if there is one
		/// Returns null otherwise
		/// </returns>
		protected internal Pane GetActiveTab() {
			foreach (Pane tb in this._Panes.Values) {
				if (tb.IsActive)
					return tb;
			}

			return null;		
		}


		/// <summary>
		/// Internal helper method to establish if any of the tabs are marked as active
		/// </summary>
		/// <returns>
		/// Returns true if a active Tab is defined
		/// Returns false otherwise
		/// </returns>
		protected internal bool HasActiveTab() {
			return (this.GetActiveTab() != null);
		}


		/// <summary>
		/// Resets all tabs to unselected.
		/// </summary>
		protected internal void ResetSelectedTabs() {
			foreach (Pane t in this._Panes.Values) 
				// go directly to the underlying value rather than the property
				// ... otherwise we'll end up calling our self back and have a stackoverflow
				t._IsActive = false;
		}


		/// <summary>
		/// Works out which (if any) of the tab panes are marked as active.
		/// If none are active, the first tab is marked as selected.
		/// </summary>
		/// <remarks>
		/// This is necessary to ensure the correct mark-up is produced when the
		/// ShowCSS option is enabled (i.e. full markup is rendered).
		/// </remarks>
		protected internal void ResolveActiveTab() {
			if (!this.HasActiveTab() && this._Panes.Any())
				this._Panes.Values.FirstOrDefault().IsActive = true;
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
