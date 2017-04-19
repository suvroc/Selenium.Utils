using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Utils.Html
{
    public static class HtmlExtensions
    {
        public static Table FindTable(this IWebDriver driver, By selector)
        {
            return new Table(driver, selector);
        }
    }
}
