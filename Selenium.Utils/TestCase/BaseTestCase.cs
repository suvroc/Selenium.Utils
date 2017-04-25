using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Html5;

namespace Selenium.Utils.TestCase
{
    public class BaseTestCase
    {
        protected IWebDriver _driver;

        protected virtual IWebDriver CreateDriver()
        {
            return new ChromeDriver();
        }

        public virtual void Initalize()
        {
            _driver = CreateDriver();

            _driver.Manage().Cookies.DeleteAllCookies();

            var webStorage = _driver as IHasWebStorage;
            if (webStorage != null)
            {
                webStorage.WebStorage.LocalStorage.Clear();
                webStorage.WebStorage.SessionStorage.Clear();
            }
        }
    }
}
