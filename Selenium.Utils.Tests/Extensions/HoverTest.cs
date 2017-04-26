using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Utils.Extensions;
using Selenium.Utils.Html;
using Selenium.Utils.Tests.Html;

namespace Selenium.Utils.Tests.Extensions
{
    [TestFixture]
    public class HoverTest : BaseSeleniumTest
    {
        public HoverTest() : base("hover.html")
        {

        }

        [Test]
        public void should_check_hover()
        {
            var element = _driver.FindElement(By.Id("testButton"));
            _driver.Hover(element);

            var panel = _driver.FindElement(By.Id("successPanel"));

            Assert.IsTrue(panel.Displayed);
        }
    }
}
