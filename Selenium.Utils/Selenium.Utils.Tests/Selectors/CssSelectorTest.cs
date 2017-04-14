using NUnit.Framework;
using Selenium.Utils.Selectors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                //yield return new TestCaseData(new CssSelector()).Returns("#container *");
                yield return new TestCaseData(new CssSelector().WithId("container")).Returns("#container");
                yield return new TestCaseData(new CssSelector().WithClass("error")).Returns(".error");
                //yield return new TestCaseData(new CssSelector()).Returns("li a");
                yield return new TestCaseData(new CssSelector().Element("li")).Returns("li");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:visited");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:any");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:checked");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:default");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:dir()");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:disabled");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:empty");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:first");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:first-child");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:first-of-type");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:fullscreen");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:focus");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:hover");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:indeterminate");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:in-range");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:invalid");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:lang()");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:last-child");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:last-of-type");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:left");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:link");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:not()");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:nth-child()");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:nth-last-child()");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:nth-last-of-type()");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:nth-of-type()");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:only-child");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:only-of-type");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:optional");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:out-of-range");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:read-only");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:read-write");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:required");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:right");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:root");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:scope");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:target");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:valid");
                //yield return new TestCaseData(new CssSelector().Element("a").ForVisited()).Returns("a:visited");
                //yield return new TestCaseData(new CssSelector()).Returns("ul + p");
                //yield return new TestCaseData(new CssSelector()).Returns("#container > ul");
                //yield return new TestCaseData(new CssSelector()).Returns("div#container > ul");
                //yield return new TestCaseData(new CssSelector()).Returns("ul ~ p");
                //yield return new TestCaseData(new CssSelector()).Returns("div.btn");
                //yield return new TestCaseData(new CssSelector()).Returns("a[title]");
                //yield return new TestCaseData(new CssSelector()).Returns("a[href=\"http://net.tutsplus.com\"]");
                //yield return new TestCaseData(new CssSelector()).Returns("a[href*=\"tuts\"]");
                //yield return new TestCaseData(new CssSelector()).Returns("a[href^=\"http\"]");
                //yield return new TestCaseData(new CssSelector()).Returns("a[href^=\"http\" i]");
                //yield return new TestCaseData(new CssSelector()).Returns("a[href$=\".jpg\"]");
                //yield return new TestCaseData(new CssSelector()).Returns("a[data-filetype=\"image\"]");
                //yield return new TestCaseData(new CssSelector()).Returns("a[data-info~=\"external\"]");
                //yield return new TestCaseData(new CssSelector()).Returns("input[type=radio]:checked");
                //yield return new TestCaseData(new CssSelector()).Returns(".clearfix:after");
                //yield return new TestCaseData(new CssSelector()).Returns("div:not(#container)");
                //yield return new TestCaseData(new CssSelector()).Returns("p::first-line");
                //yield return new TestCaseData(new CssSelector()).Returns("li:nth-child(3)");
                //yield return new TestCaseData(new CssSelector()).Returns("li:nth-last-child(2)");
                //yield return new TestCaseData(new CssSelector()).Returns("ul:nth-of-type(3)");
                //yield return new TestCaseData(new CssSelector()).Returns("ul:nth-last-of-type(3)");
                //yield return new TestCaseData(new CssSelector()).Returns("ul li:first-child");
                //yield return new TestCaseData(new CssSelector()).Returns("ul > li:last-child");
                //yield return new TestCaseData(new CssSelector()).Returns("div p:only-child");
                //yield return new TestCaseData(new CssSelector()).Returns("li:only-of-type");
                //yield return new TestCaseData(new CssSelector()).Returns("ul:nth-last-of-type(3)");
                //yield return new TestCaseData(new CssSelector()).Returns("ul:nth-last-of-type(3)");
            }
        }
    }
}
