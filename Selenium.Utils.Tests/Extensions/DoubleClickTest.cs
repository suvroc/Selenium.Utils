using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Utils.Extensions;
using Selenium.Utils.Tests.Html;

namespace Selenium.Utils.Tests.Extensions
{
    [TestFixture]
    public class DoubleClickTest : BaseSeleniumTest
    {
        public DoubleClickTest() : base("doubleClick.html")
        {

        }

        [Test]
        public void should_check_double_click()
        {
            var element = _driver.FindElement(By.Id("testButton"));
            _driver.DoubleClick(element);

            var panel = _driver.FindElement(By.Id("successPanel"));

            Assert.IsTrue(panel.Displayed);
        }
    }
}
