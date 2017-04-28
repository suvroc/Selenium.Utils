using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Utils.Html
{
    public class Table : BaseElement
    {
        public Table(IWebDriver driver, By selector) : base(driver, selector)
        {

        }

        public Table(IWebDriver driver, IWebElement element) : base(driver, element)
        {

        }

        public IWebElement Header
        {
            get {
                return Element.FindElement(By.CssSelector("thead"));
            }
        }
        public IWebElement Footer
        {
            get
            {
                return Element.FindElement(By.CssSelector("tfoot"));
            }
        }
        public IWebElement Body
        {
            get
            {
                return Element.FindElement(By.TagName("tbody"));
            }
        }

        public string[] Columns { get
            {
                return Element.FindElements(By.CssSelector("th")).Select(x => x.Text).ToArray();
            }
        }

        public IWebElement GetData(int row, int column)
        {
            return Element.FindElement(By.CssSelector($"tr:nth-child({row}) td:nth-child({column})"));
        }
    }
}
