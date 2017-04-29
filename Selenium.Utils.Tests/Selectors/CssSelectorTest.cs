using NUnit.Framework;
using Selenium.Utils.Selectors;
using System.Collections;

namespace Selenium.Utils.Tests.Selectors
{
    [TestFixture]
    public class CssSelectorTest
    {
        [Test]
        [TestCaseSource("TestCases")]
        public string should_test_selector_generator(CssSelector selector)
        {
            return selector.Selector;
        }

        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new CssSelector()).Returns("");
                yield return new TestCaseData(new CssSelector().All()).Returns("*");
                yield return new TestCaseData(new CssSelector().WithId("container").WithChild(new CssSelector().All())).Returns("#container *");
                yield return new TestCaseData(new CssSelector().WithId("container")).Returns("#container");
                yield return new TestCaseData(new CssSelector().WithClass("error")).Returns(".error");
                yield return new TestCaseData(new CssSelector().Element("li").WithChild(new CssSelector().Element("a"))).Returns("li a");
                yield return new TestCaseData(new CssSelector().Element("li")).Returns("li");
                yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:visited");
                yield return new TestCaseData(new CssSelector().Element("a").ForAny(new CssSelector[] { new CssSelector().Element("li") })).Returns("a:any(li)");
                yield return new TestCaseData(new CssSelector().Element("a").ForChecked()).Returns("a:checked");
                yield return new TestCaseData(new CssSelector().Element("a").ForDefault()).Returns("a:default");
                yield return new TestCaseData(new CssSelector().Element("a").ForDir(DirType.Ltr)).Returns("a:dir(ltr)");
                yield return new TestCaseData(new CssSelector().Element("a").ForDisabled()).Returns("a:disabled");
                yield return new TestCaseData(new CssSelector().Element("a").ForEmpty()).Returns("a:empty");
                yield return new TestCaseData(new CssSelector().Element("a").ForFirst()).Returns("a:first");
                yield return new TestCaseData(new CssSelector().Element("a").ForFirstChild()).Returns("a:first-child");
                yield return new TestCaseData(new CssSelector().Element("a").ForFirstOfType()).Returns("a:first-of-type");
                yield return new TestCaseData(new CssSelector().Element("a").ForFullscreen()).Returns("a:fullscreen");
                yield return new TestCaseData(new CssSelector().Element("a").ForFocus()).Returns("a:focus");
                yield return new TestCaseData(new CssSelector().Element("a").ForHover()).Returns("a:hover");
                yield return new TestCaseData(new CssSelector().Element("a").ForIndeterminate()).Returns("a:indeterminate");
                yield return new TestCaseData(new CssSelector().Element("a").ForInRange()).Returns("a:in-range");
                yield return new TestCaseData(new CssSelector().Element("a").ForInvalid()).Returns("a:invalid");
                yield return new TestCaseData(new CssSelector().Element("a").ForLang("en")).Returns("a:lang(en)");
                yield return new TestCaseData(new CssSelector().Element("a").ForLastChild()).Returns("a:last-child");
                yield return new TestCaseData(new CssSelector().Element("a").ForLastOfType()).Returns("a:last-of-type");
                yield return new TestCaseData(new CssSelector().Element("a").ForLeftPage()).Returns("a:left");
                yield return new TestCaseData(new CssSelector().Element("a").ForLink()).Returns("a:link");
                yield return new TestCaseData(new CssSelector().Element("a").NotFor(new CssSelector().Element("li"))).Returns("a:not(li)");
                yield return new TestCaseData(new CssSelector().Element("a").ForNthChild(NthParity.Even)).Returns("a:nth-child(even)");
                yield return new TestCaseData(new CssSelector().Element("a").ForNthChild(NthParity.Odd)).Returns("a:nth-child(odd)");
                yield return new TestCaseData(new CssSelector().Element("a").ForNthChild(1,2)).Returns("a:nth-child(1n+2)");
                yield return new TestCaseData(new CssSelector().Element("a").ForNthChild(0,2)).Returns("a:nth-child(2)");
                yield return new TestCaseData(new CssSelector().Element("a").ForNthChild(2, 0)).Returns("a:nth-child(2n)");
                yield return new TestCaseData(new CssSelector().Element("a").ForNthLastChild(1,2)).Returns("a:nth-last-child(1n+2)");
                yield return new TestCaseData(new CssSelector().Element("a").ForNthLastOfType(1,2)).Returns("a:nth-last-of-type(1n+2)");
                yield return new TestCaseData(new CssSelector().Element("a").ForNthOfType(1,2)).Returns("a:nth-of-type(1n+2)");
                yield return new TestCaseData(new CssSelector().Element("a").ForOnlyChild()).Returns("a:only-child");
                yield return new TestCaseData(new CssSelector().Element("a").ForOnlyOfType()).Returns("a:only-of-type");
                yield return new TestCaseData(new CssSelector().Element("a").ForOptional()).Returns("a:optional");
                yield return new TestCaseData(new CssSelector().Element("a").ForOutOfRange()).Returns("a:out-of-range");
                yield return new TestCaseData(new CssSelector().Element("a").ForReadOnly()).Returns("a:read-only");
                yield return new TestCaseData(new CssSelector().Element("a").ForReadWrite()).Returns("a:read-write");
                yield return new TestCaseData(new CssSelector().Element("a").ForRequired()).Returns("a:required");
                yield return new TestCaseData(new CssSelector().Element("a").ForRightPage()).Returns("a:right");
                yield return new TestCaseData(new CssSelector().Element("a").ForRootElement()).Returns("a:root");
                yield return new TestCaseData(new CssSelector().Element("a").ForScope()).Returns("a:scope");
                yield return new TestCaseData(new CssSelector().Element("a").ForTarget()).Returns("a:target");
                yield return new TestCaseData(new CssSelector().Element("a").ForValid()).Returns("a:valid");
                yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:visited");
                yield return new TestCaseData(new CssSelector().Element("ul").WithNext(new CssSelector().Element("p"))).Returns("ul + p");
                yield return new TestCaseData(new CssSelector().WithId("container").WithDirectChild(new CssSelector().Element("ul"))).Returns("#container > ul");
                yield return new TestCaseData(new CssSelector().Element("div").WithId("container").WithDirectChild(new CssSelector().Element("ul"))).Returns("div#container > ul");
                yield return new TestCaseData(new CssSelector().Element("ul").WithSuccessor(new CssSelector().Element("p"))).Returns("ul ~ p");
                yield return new TestCaseData(new CssSelector().Element("div").WithClass("btn")).Returns("div.btn");
                yield return new TestCaseData(new CssSelector().Element("div").WithClasses(new string[] { "btn", "btn-default" })).Returns("div.btn.btn-default");
                yield return new TestCaseData(new CssSelector().Element("a").WithAttribute("title")).Returns("a[title]");
                yield return new TestCaseData(new CssSelector().Element("a").WithAttribute("href", "http://net.tutsplus.com")).Returns("a[href=\"http://net.tutsplus.com\"]");
                yield return new TestCaseData(new CssSelector().Element("a").WithAttribute("href", "tuts", AttributeCompareType.Contains)).Returns("a[href*=\"tuts\"]");
                yield return new TestCaseData(new CssSelector().Element("a").WithAttribute("href", "http", AttributeCompareType.FirstValue)).Returns("a[href^=\"http\"]");
                yield return new TestCaseData(new CssSelector().Element("a").WithAttribute("href", "http", AttributeCompareType.FirstValue, true)).Returns("a[href^=\"http\" i]");
                yield return new TestCaseData(new CssSelector().Element("a").WithAttribute("href", ".jpg", AttributeCompareType.LastValue)).Returns("a[href$=\".jpg\"]");
                yield return new TestCaseData(new CssSelector().Element("a").WithAttribute("data-filetype", "image", AttributeCompareType.Equal)).Returns("a[data-filetype=\"image\"]");
                yield return new TestCaseData(new CssSelector().Element("a").WithAttribute("data-info", "external", AttributeCompareType.OneOfWords)).Returns("a[data-info~=\"external\"]");
                yield return new TestCaseData(new CssSelector().Element("input").WithAttribute("type", "radio").ForChecked()).Returns("input[type=\"radio\"]:checked");
                yield return new TestCaseData(new CssSelector().WithClass("clearfix")).Returns(".clearfix");
                yield return new TestCaseData(new CssSelector().Element("div").NotFor(new CssSelector().WithId("container"))).Returns("div:not(#container)");
                yield return new TestCaseData(new CssSelector().Element("li").ForNthChild(0, 3)).Returns("li:nth-child(3)");
                yield return new TestCaseData(new CssSelector().Element("li").ForNthLastChild(0, 2)).Returns("li:nth-last-child(2)");
                yield return new TestCaseData(new CssSelector().Element("ul").ForNthOfType(0, 3)).Returns("ul:nth-of-type(3)");
                yield return new TestCaseData(new CssSelector().Element("ul").ForNthLastOfType(0, 3)).Returns("ul:nth-last-of-type(3)");
                yield return new TestCaseData(new CssSelector().Element("ul").WithChild(new CssSelector().Element("li").ForFirstChild())).Returns("ul li:first-child");
                yield return new TestCaseData(new CssSelector().Element("ul").WithDirectChild(new CssSelector().Element("li").ForLastChild())).Returns("ul > li:last-child");
                yield return new TestCaseData(new CssSelector().Element("div").WithChild(new CssSelector().Element("p").ForOnlyChild())).Returns("div p:only-child");
                yield return new TestCaseData(new CssSelector().Element("li").ForOnlyOfType()).Returns("li:only-of-type");
                yield return new TestCaseData(new CssSelector().Element("ul").ForNthLastOfType(0, 3)).Returns("ul:nth-last-of-type(3)");
            }
        }
    }
}
