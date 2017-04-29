using System.Collections.Generic;
using OpenQA.Selenium;

namespace Selenium.Utils.Html
{
    public class ListElement : BaseElement
    {
        private By _elementSelector;

        public ListElement(IWebDriver driver, By selector) : base(driver, selector)
        {
        }

        public ListElement(IWebDriver driver, By selector, By elementSelector) : base(driver, selector)
        {
            _elementSelector = elementSelector;
        }

        public ListElement(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }

        public ListElement(IWebDriver driver, IWebElement element, By elementSelector) : base(driver, element)
        {
            _elementSelector = elementSelector;
        }

        public IEnumerable<IWebElement> Items
        {
            get
            {
                if (_elementSelector != null)
                {
                    return Element.FindElements(_elementSelector);
                }
                return Element.FindElements(By.TagName("li"));
            }
        }
    }
}
