
function createEvent(event, ui) {
	addToLog("CREATE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.panel.text", ui.panel.text(), 20)
	);

	// Note that there should also be "ui.header" too (according to the upgrade log)
	// however at time of writing this isn't present.
}

function selectEvent(event, ui) {
	addToLog(
		"SELECT EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.tab.text", ui.tab.innerText, 20)
		+ "<br/>- " + buildKeyValue("ui.panel.text", ui.panel.innerText, 20)
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



