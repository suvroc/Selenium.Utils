using System;
using OpenQA.Selenium;

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

        public static object GetJsProperty(this IWebElement element, IWebDriver driver, string jsCode)
        {
            if (driver is IJavaScriptExecutor jsExecutor)
            {
                return jsExecutor.ExecuteScript(string.Concat("return arguments[0].", jsCode), element);
            }
            return null;
        }

        public static T GetJsProperty<T>(this IWebElement element, IWebDriver driver, string jsCode)
        {
            if (driver is IJavaScriptExecutor jsExecutor)
            {
                return (T)jsExecutor.ExecuteScript(string.Concat("return arguments[0].", jsCode), element);
            }
            return default(T);
        }

        public static string GetValue(this IWebElement element, IWebDriver driver)
        {
            var val =  element.GetAttribute("value");
            if (!string.IsNullOrEmpty(val))
            {
                return val;
            }
            if (driver is IJavaScriptExecutor jsExecutor)
            {
                return (string)jsExecutor.ExecuteScript("return arguments[0].nodeValue", element);
            }
            return "";
        }

        public static void SendKeys(this IWebElement element, string value, bool clearFirst)
        {
            if (clearFirst)
                element.Clear();
            element.SendKeys(value);
        }
    }
}
