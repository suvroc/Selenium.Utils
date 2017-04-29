using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Utils.Html;
using Selenium.Utils.PageObjects;

namespace Selenium.Utils.Tests.Html
{
    [TestFixture]
    public class NavigableTest : BaseSeleniumTest
    {
        public NavigableTest() : base("navigate1.html")
        {

        }

        [Test]
        public void should_go_to_next_page()
        {
            var pageObject1 = new Navigate1PageObject(_driver);

            var pageObject2 = pageObject1.NextPageLink.Navigate();

            Assert.IsTrue(pageObject2 is Navigate2PageObject);
            Assert.IsTrue(pageObject2.Url.EndsWith("navigate2.html"));
        }
    }

    class Navigate1PageObject : BasePageObject
    {
        public Navigate1PageObject(IWebDriver driver) : base(driver)
        {
        }

        public Navigable<Navigate2PageObject> NextPageLink
        {
            get
            {
                return new Navigable<Navigate2PageObject>(this._driver, By.Id("nextPageLink"));
            }
        }
    }

    class Navigate2PageObject : BasePageObject
    {
        public Navigate2PageObject(IWebDriver driver) : base(driver)
        {
        }
    }
}
