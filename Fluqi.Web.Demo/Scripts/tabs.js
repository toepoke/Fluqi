
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

function showEvent(event, ui) {
	addToLog(
		"SHOW EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.tab.text", ui.tab.innerText, 20)
		+ "<br/>- " + buildKeyValue("ui.panel.text", ui.panel.innerText, 20)
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

function enableEvent(event, ui) {
	addToLog("ENABLE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.panel.id", ui.panel.id, 20)
		+ "<br/>- " + buildKeyValue("ui.tab.text", ui.tab.innerText, 20)
	);
}

function disableEvent(event, ui) {
	addToLog("DISABLE EVENT"
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


