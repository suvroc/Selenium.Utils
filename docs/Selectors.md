# Css selector builder

`CssSelector` class priovides a set of useful methods to create a complete CSS selector using fluent syntax.

	new CssSelector()
		.Element("ul")
		.WithDirectChild(new CssSelector()
			.Element("li")
			.ForLastChild()).Selector

which results in

	ul > li:last-child

	

It supports 2 ways for getting the final selector:
	
- `.Selector` - returns string CSS selector
- `.ToSelector()` - returns `By` object used by Selenium WebDriver

The complete list of building methods:

General selectors

- `WithId("elementId")`
- `WithClass("className")`
- `WithClasses(new string[] { "btn" "btn-default" })`
- `Element("td")`
- `WithNext("td > a")`
- `WithNext(new CssSelector(...))`
- `WithSuccessor("td > a")`
- `WithSuccessor(new CssSelector(...))`
- `WithDirectChild("td > a")`
- `WithDirectChild(new CssSelector(...))`
- `WithChild("td > a")`
- `WithChild(new CssSelector(...))`

Attribute selectors:

- `WithAttribute("required")`
- `WithAttribute("target", "blank")`
- `WithAttribute("href", "www.google.com", AttributeCompareType.Contains , caseInsensitively: false)`

Pseudo classes:
- `ForActive()`
- `ForAny(new string[] { "td", "td > a" })`
- `ForAny(new CssSelector[] { new CssSelector(...), new CssSelector(...) })`
- `ForChecked()`
- `ForDefault()`
- `ForDir(DirType.Ltr)`
- `ForDisabled()`
- `ForEmpty()`
- `ForEnabled()`
- `ForFirst()`
- `ForFirstChild()`
- `ForFirstOfType()`
- `ForFullscreen()`
- `ForFocus()`
- `ForHover()`
- `ForIndeterminate()`
- `ForInRange()`
- `ForInvalid()`
- `ForLang("en")`
- `ForLastChild()`
- `ForLastOfType()`
- `ForLeftPage()`
- `ForLink()`
- `NotFor("td > a")`
- `NotFor(new CssSelector(...))`
- `ForNthChild(2, 1)`
- `ForNthChild(NthParity.Even)`
- `ForNthLastChild(2, 1)`
- `ForNthLastChild(NthParity.Even)`
- `ForNthLastOfType(2, 1)`
- `ForNthLastOfType(NthParity.Even)`
- `ForNthOfType(2, 1)`
- `ForNthOfType(NthParity.Even)`
- `ForOnlyChild()`
- `ForOnlyOfType()`
- `ForOptional()`
- `ForOutOfRange()`
- `ForReadOnly()`
- `ForReadWrite()`
- `ForRequired()`
- `ForRightPage()`
- `ForRootElement()`
- `ForScope()`
- `ForTarget()`
- `ForValid()`
- `ForVisited()`
