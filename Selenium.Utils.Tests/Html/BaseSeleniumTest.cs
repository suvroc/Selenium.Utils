using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Selenium.Utils.Tests.Html
{
    public class BaseSeleniumTest
    {
        protected IWebDriver _driver;
        private string _page;

        public BaseSeleniumTest(string page)
        {
            _page = page;
        }

        [SetUp]
        public void Setup()
        {
            CreateDriver();
        }

        private void CreateDriver()
        {
            _driver = new ChromeDriver();
            
            _driver.Navigate().GoToUrl($"{AppDomain.CurrentDomain.BaseDirectory}\\TestFiles\\{_page}");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
