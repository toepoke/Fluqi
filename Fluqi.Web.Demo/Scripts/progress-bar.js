
function createEvent(event, ui) {
	addToLog("CREATE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
	);
	
	TimeoutMethod();
}

function changeEvent(event, ui) {
	addToLog("CHANGE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
	);
}

function completeEvent(event, ui) {
	addToLog("COMPLETE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
	);
}

function IncrementProgressBar(newValue) {
	$("#pb").progressbar( "option", "value", newValue );	
}

function GetProgressBarValue() {
	var currValue = $("#pb").progressbar( "option", "value" );

	return parseInt(currValue);
}

function TimeoutMethod() {
	var currValue = GetProgressBarValue();

	if (currValue < 100) {
		IncrementProgressBar( currValue + 2 );
		setTimeout("TimeoutMethod()", 50);
	}
}