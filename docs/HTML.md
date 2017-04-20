# HTML elements helpers

Library contains a set of wrapper class to provide better experience with common HTML elements and actions.

## Table

	Table table = _driver.FindTable(By.Id("tableId"));
	table.GetData(2, 1);
	table.Columns
	table.Body
	table.Footer