using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Utils.Html
{
    public class Table : Element
    {
        public Table(IWebDriver driver, By selector) : base(driver, selector)
        {

        }

        //public IWebElement Caption { get { _driver.find } }
        public IWebElement Header { get; set; }
        public IWebElement Footer { get; set; }
        public IWebElement Body
        {
            get
            {
                return _driver.FindElement(_selector).FindElement(By.TagName("tbody"));
            }
        }

        public string[] Columns { get;  }

        public IWebElement GetData(int column, int row)
        {
            return null;
        }
    }
}
