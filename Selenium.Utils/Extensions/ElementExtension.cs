using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Selenium.Utils.Extensions
{
    public static class ElementExtensions
    {
        public static void UploadFile(this IWebElement element, string filepath)
        {
            if (element.GetAttribute("type") != "file")
            {
                throw new ArgumentException("You can't upload file for the input with different type than 'file'");
            }
            element.SendKeys(filepath);
        }
        // execute js

        public static object GetJsProperty(this IWebElement element, IWebDriver driver, string jsCode)
        {
            var jsExecutor = driver as IJavaScriptExecutor;
            if (jsExecutor != null)
            {
                return jsExecutor.ExecuteScript(string.Concat("return arguments[0].", jsCode), element);
            }
            return null;
        }
    }
}
