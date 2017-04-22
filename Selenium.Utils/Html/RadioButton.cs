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
                return ((IJavaScriptExecutor)_driver).ExecuteScript("var node = arguments[0].nextSibling; while(node.textContent && node.textContent.trim() === '') node = node.nextSibling; return node.textContent", this.Element).ToString();  
            }
        }
    }
}
