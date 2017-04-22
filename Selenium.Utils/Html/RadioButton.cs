using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace Selenium.Utils.Html
{
    public class RadioButton : BaseElement
    {
        public RadioButton(IWebDriver driver, By selector) : base(driver, selector)
        {
        }

        public RadioButton(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }

        public string Text
        {
            get
            {
                return ((IJavaScriptExecutor)_driver).ExecuteScript("return arguments[0].nextSibling.nodeValue", this.Element).ToString();  
            }
        }
    }
}
