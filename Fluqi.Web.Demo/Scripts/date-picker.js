
function createEvent(event, ui) {
	addToLog("CREATE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
	);
}

function beforeShowEvent(input, inst) {
	addToLog("BEFORE_SHOW EVENT"
		+ "<br/>- " + buildKeyValue("input.id", input.id, 20)
		+ "<br/>- " + buildKeyValue("inst.selectedDay", inst.selectedDay, 20)
		+ "<br/>- " + buildKeyValue("inst.selectedMonth", inst.selectedMonth, 20)
		+ "<br/>- " + buildKeyValue("inst.selectedYear", inst.selectedYear, 20)
	);
}

function beforeShowDayEvent(date) {
	addToLog("BEFORE_SHOW_DAY EVENT"
		+ "<br/>- " + buildKeyValue("date.toDateString()", date.toDateString(), 15)
	);

	// beforeShowDayEvent expects an array of results to be returned
	return [true, '', 'Test tooltip for ' + date.toDateString()];
}

function onChangeMonthYear(year, month, inst) {
	addToLog("ON_CHANGE_MONTH_YEAR EVENT"
		+ "<br/>- " + buildKeyValue("year", year.toString(), 28)
		+ "<br/>- " + buildKeyValue("month", month.toString(), 28)
		+ "<br/>- " + buildKeyValue("inst.selectedDay", inst.selectedDay, 20)
		+ "<br/>- " + buildKeyValue("inst.selectedMonth", inst.selectedMonth, 20)
		+ "<br/>- " + buildKeyValue("inst.selectedYear", inst.selectedYear, 20)
	);
}

function onClose(dateText, inst) {
	addToLog("ON_CLOSE EVENT"
		+ "<br/>- " + buildKeyValue("dateText", dateText, 20)
		+ "<br/>- " + buildKeyValue("inst.selectedDay", inst.selectedDay, 20)
		+ "<br/>- " + buildKeyValue("inst.selectedMonth", inst.selectedMonth, 20)
		+ "<br/>- " + buildKeyValue("inst.selectedYear", inst.selectedYear, 20)
	);
}

function onSelect(dateText, inst) {
	addToLog("ON_SELECT EVENT"
		+ "<br/>- " + buildKeyValue("dateText", dateText, 20)
		+ "<br/>- " + buildKeyValue("inst.selectedDay", inst.selectedDay, 20)
		+ "<br/>- " + buildKeyValue("inst.selectedMonth", inst.selectedMonth, 20)
		+ "<br/>- " + buildKeyValue("inst.selectedYear", inst.selectedYear, 20)
	);
}


