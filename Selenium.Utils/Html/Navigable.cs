using OpenQA.Selenium;
using Selenium.Utils.PageObjects;

namespace Selenium.Utils.Html
{
    public class Navigable<TPageObjectType> : BaseElement where TPageObjectType : BasePageObject
    {
        public Navigable(IWebDriver driver, By selector) : base(driver, selector)
        {
        }

        public Navigable(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }

        public TPageObjectType Navigate()
        {
            this.Element.Click();
            return BasePageObject.CreatePageObject<TPageObjectType>(_driver);
        }
    }
}
