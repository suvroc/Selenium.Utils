using System;
using System.Collections.Generic;
using System.Drawing;
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

        public TimeSpan MaximumTimeout { get; set; }

        public TimeSpan ImplicitWaitTimeout { get; set; }
        public TimeSpan JavaScriptTimeout { get; set; }
        public TimeSpan PageLoadTimeout { get; set; }

        public TestDeviceType DeviceType { get; set; }


        protected virtual IWebDriver CreateDriver()
        {
            return new ChromeDriver();
        }

        public virtual void Initalize()
        {
            _driver = CreateDriver();

            SetupTimeouts();
            SetupResponsiveness();

            _driver.Manage().Cookies.DeleteAllCookies();

            var webStorage = _driver as IHasWebStorage;
            if (webStorage != null)
            {
                webStorage.WebStorage.LocalStorage.Clear();
                webStorage.WebStorage.SessionStorage.Clear();
            }
        }

        private void SetupResponsiveness()
        {
            Size screenSize;
            switch (DeviceType)
            {
                    case TestDeviceType.Mobile:
                    screenSize = new Size(480, 860);
                    break;
                    case TestDeviceType.Tablet:
                    screenSize = new Size(768, 1024);
                    break;
                    case TestDeviceType.Laptop:
                    screenSize = new Size(992, 1024);
                    break;
                    case TestDeviceType.Desktop:
                    screenSize = new Size(1200, 1000);
                    break;
                default:
                    screenSize = new Size(800, 600);
                    break;
            }
            _driver.Manage().Window.Size = screenSize;
        }

        private void SetupTimeouts()
        {
            _driver.Manage().Timeouts().ImplicitWait = 
                MaximumTimeout > ImplicitWaitTimeout ? ImplicitWaitTimeout : MaximumTimeout;
            _driver.Manage().Timeouts().AsynchronousJavaScript =
                MaximumTimeout > JavaScriptTimeout ? JavaScriptTimeout : MaximumTimeout; ;
            _driver.Manage().Timeouts().PageLoad =
                MaximumTimeout > PageLoadTimeout ? PageLoadTimeout : MaximumTimeout; ;
        }
    }

    public enum TestDeviceType
    {
        None,
        Mobile,
        Tablet,
        Laptop,
        Desktop
    }
}
