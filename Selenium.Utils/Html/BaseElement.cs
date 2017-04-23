using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Utils.Html
{
    public abstract class BaseElement
    {
        protected readonly IWebDriver _driver;
        protected readonly By _selector;
        private readonly IWebElement _element;

        public IWebElement Element
        {
            get
            {
                if (_element != null)
                {
                    return _element;
                }
                return _driver.FindElement(_selector);
            }
        }

        public BaseElement(IWebDriver driver, By selector)
        {
            this._driver = driver;
            this._selector = selector;
        }

        public BaseElement(IWebDriver driver, IWebElement element)
        {
            this._driver = driver;
            this._element = element;
        }

        protected bool IsElementPresent(By by, out IWebElement element)
        {
            try
            {
                element = _driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                element = null;
                return false;
            }
        }

        protected bool IsElementPresent(By by)
        {
            IWebElement element;
            return this.IsElementPresent(by, out element);
        }
    }
}
