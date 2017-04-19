using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Utils.Html
{
    public abstract class Element
    {
        protected readonly IWebDriver _driver;
        protected readonly By _selector;

        public Element(IWebDriver driver, By selector)
        {
            this._driver = driver;
            this._selector = selector;
        }
    }
}
