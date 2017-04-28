using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Utils.Extensions;
using Selenium.Utils.Html;
using Selenium.Utils.Tests.Html;
using System;

namespace Selenium.Utils.Tests.Extensions
{
    [TestFixture]
    public class ValueTest : BaseSeleniumTest
    {
        public ValueTest() : base("value.html")
        {

        }

        [Test]
        public void should_check_simple_value()
        {
            var element = _driver.FindElement(By.Id("testInput"));
            var value = element.GetValue(_driver);

            Assert.AreEqual("male", value);
        }

        [Test]
        public void should_check_js_value()
        {
            var element = _driver.FindElement(By.Id("test2Input"));
            var value = element.GetValue(_driver);

            Assert.AreEqual("changed", value);
        }


    }
}
