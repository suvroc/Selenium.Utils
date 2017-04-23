using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace Selenium.Utils.Html
{
    public class ListElement : BaseElement
    {
        public ListElement(IWebDriver driver, By selector) : base(driver, selector)
        {
        }

        public ListElement(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }

        public IEnumerable<IWebElement> Items
        {
            get
            {
                return Element.FindElements(By.TagName("li"));
            }
        }
    }
}
