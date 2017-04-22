using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Utils.Html
{
    public abstract class BaseElements
    {
        protected readonly IWebDriver _driver;
        protected readonly By _selector;

        public IEnumerable<IWebElement> Elements
        {
            get
            {
                return _driver.FindElements(_selector);
            }
        }

        public BaseElements(IWebDriver driver, By selector)
        {
            this._driver = driver;
            this._selector = selector;
        }
    }
}
