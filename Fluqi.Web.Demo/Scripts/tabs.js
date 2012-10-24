
function createEvent(event, ui) {
	addToLog("CREATE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.tab", ui.tab[0].innerText, 20)
		+ "<br/>- " + buildKeyValue("ui.panel", ui.panel.text(), 20)
	);
}

function beforeActivateEvent(event, ui) {
	addToLog(
		"BEFORE_ACTIVATE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.oldTab.text", ui.oldTab.innerText, 20)
		+ "<br/>- " + buildKeyValue("ui.oldPanel.text", ui.oldPanel.innerText, 20)
		+ "<br/>- " + buildKeyValue("ui.newTab.text", ui.newTab.innerText, 20)
		+ "<br/>- " + buildKeyValue("ui.newPanel.text", ui.newPanel.innerText, 20)
		+ "<br/>- " + buildKeyValue("ui.index", ui.index, 20)
	);
}

function loadEvent(event, ui) {
	addToLog("LOAD EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.tab.text", ui.tab.innerText, 20)
		+ "<br/>- " + buildKeyValue("ui.panel.text", ui.panel.innerText, 20)
	);	
}

function activateEvent(event, ui) {
	addToLog(
		"ACTIVATE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.oldTab.text()", ui.oldTab.text(), 20)
		+ "<br/>- " + buildKeyValue("ui.oldPanel.text()", ui.oldPanel.text(), 20)
		+ "<br/>- " + buildKeyValue("ui.newTab.text()", ui.newTab.text(), 20)
		+ "<br/>- " + buildKeyValue("ui.newPanel.text()", ui.newPanel.text(), 20)
	);
}

function addEvent(event, ui) {
	addToLog("ADD EVENT"	
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.panel.id", ui.panel.id, 20)
		+ "<br/>- " + buildKeyValue("ui.tab.text", ui.tab.innerText, 20)
	);		
}

function removeEvent(event, ui) {
	addToLog("REMOVE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.panel.id", ui.panel.id, 20)
		+ "<br/>- " + buildKeyValue("ui.tab.text", ui.tab.innerText, 20)
	);
}

function beforeLoadEvent(event, ui) {
	addToLog("BEFORE_LOAD EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.ajaxSettings.username", ui.ajaxSettings.username, 20)
	);
}

/// <summary>
/// Taken from upgrade guide 1.9:
/// http://jqueryui.com/upgrade-guide/1.9/#deprecated-add-and-remove-methods-and-events-use-refresh-method
/// </summary
var _newTabID = 1;
function addTab(title, fromUrl) {
	$("<li><a href='" + fromUrl + "'>" + title + _newTabID + "</a></li>")
		.appendTo("#tabs .ui-tabs-nav");
	$("#tabs").tabs("refresh");
	_newTabID++;
}

/// <summary>
/// Taken from upgrade guide 1.9:
/// http://jqueryui.com/upgrade-guide/1.9/#deprecated-add-and-remove-methods-and-events-use-refresh-method
/// </summary
function removeTab(index) {	
	// Remove the tab
	var tab = $("#tabs").find(".ui-tabs-nav li:eq(" + index + ")").remove();
	// Find the id of the associated panel
	var panelId = tab.attr("aria-controls");
	// Remove the panel
	$("#" + panelId).remove();
	// Refresh the tabs widget
	$("tabs").tabs("refresh");
}


/// <summary>
/// Taken from upgrade guide 1.9:
/// http://jqueryui.com/upgrade-guide/1.9/#removed-rotate-method 
/// Which advises the following plug-in
/// https://github.com/cmcculloh/jQuery-UI-Tabs-Rotate
/// </summary
function startRotation() {
	$("#tabs").tabs().tabs("rotate", 1500, true);
}

/// <summary>
/// Taken from upgrade guide 1.9:
/// http://jqueryui.com/upgrade-guide/1.9/#removed-rotate-method 
/// Which advises the following plug-in
/// https://github.com/cmcculloh/jQuery-UI-Tabs-Rotate
/// </summary
function stopRotation() {
	$("#tabs").tabs().tabs("rotate", 0, true);
}


