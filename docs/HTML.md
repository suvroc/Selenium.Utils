# HTML elements helpers

Library contains a set of wrapper class to provide better experience with common HTML elements and actions.

## Table

	Table table = _driver.FindTable(By.Id("tableId"));
	table.GetData(2, 1);
	table.Columns
	table.Body
	table.Footer
	
## RadioElement
	
	<form>
        <input type="radio" name="gender" value="male" checked> Male<br>
        <input type="radio" name="gender" value="female"> Female<br>
        <input type="radio" name="gender" value="other"> Other
    </form>
	
	var radio = new RadioButton(driver, element);
	radio.Text
	
## RadioElements
	
	<form>
        <input type="radio" name="gender" value="male" checked> Male<br>
        <input type="radio" name="gender" value="female"> Female<br>
        <input type="radio" name="gender" value="other"> Other
    </form>
	
	var radio = new RadioButtons(driver, element);
	radio.Options
	radio.SelectedOption
	radio.SelectByIndex(1)
	radio.SelectByText("Female")
	radio.SelectByValue("female")