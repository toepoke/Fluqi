
function createEvent(event, ui) {
	addToLog("CREATE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
	);
}

function searchEvent(event, ui) {
	addToLog("SEARCH EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
	);
}

function responseEvent(event, ui) {
	ui.content.push({ label: "fluqi", value: "response event added this!" });
	addToLog("RESPONSE EVENT"
		+"<br/>- " + buildKeyValue("event.type", event.type, 28)
	);
}

function openEvent(event, ui) {
	addToLog("OPEN EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
	);
}

function focusEvent(event, ui) {
	addToLog("FOCUS EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.item.label", ui.item.label, 20)
		+ "<br/>- " + buildKeyValue("ui.item.value", ui.item.value, 20)
	);
}

function selectEvent(event, ui) {
	addToLog("SELECT EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.item.label", ui.item.label, 20)
		+ "<br/>- " + buildKeyValue("ui.item.value", ui.item.value, 20)
	);
}

function closeEvent(event, ui) {
	addToLog("CLOSE EVENT"		
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
	);
}

function changeEvent(event, ui) {
	var report = "CHANGE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28);

	if (ui.item != null) {
		report += "<br/>- " + buildKeyValue("ui.item.label", ui.item.label, 20)
		report += "<br/>- " + buildKeyValue("ui.item.value", ui.item.value, 20)
	} else {
		report += "<br/>- no selection.";
	}

	addToLog(report);
}






