using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace Selenium.Utils.Extensions
{
    public static class DriverExtensions
    {
        public static void TakeScreenshot(this IWebDriver driver, string testName)
        {
            if (driver is ITakesScreenshot screenshotProvider)
            {
                Screenshot ss = screenshotProvider.GetScreenshot();
                ss.SaveAsFile($"{testName}_{DateTime.Now:yyyy-MM-dd-hh-mm-ss}.acceptance-exception.png",
                    ScreenshotImageFormat.Png);
            }
        }

        public static void DoubleClick(this IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).DoubleClick().Build().Perform();
        }

        public static void Hover(this IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Build().Perform();
        }

        public static void Retry(this IWebDriver driver, Action operation, int retryCount, TimeSpan delay)
        {
            int i = 0;
            while (retryCount > i)
            { 
                try
                {
                    operation();
                }
                catch (Exception)
                {
                    if(retryCount <= i)
                    {
                        throw;
                    }
                }
                Thread.Sleep(delay.Milliseconds);
                i++;
            }
        }

        public static T Retry<T>(this IWebDriver driver, Func<T> operation, int retryCount, TimeSpan delay)
        {
            int i = 0;
            while (true)
            {
                try
                {
                    return operation();
                }
                catch (Exception)
                {
                    if (retryCount <= i)
                    {
                        throw;
                    }
                }
                Thread.Sleep(delay.Milliseconds);
                i++;
            }
        }

        public static void DragAndDrop(this IWebDriver driver, IWebElement from, IWebElement to)
        {
            (new Actions(driver)).DragAndDrop(from, to).Perform();
        }

        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }

        public static TResult WaitUntil<TResult>(this IWebDriver driver, Func<IWebDriver, TResult> function, int timeoutInSeconds)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(function);
        }

        public static bool IsElementPresent(this IWebDriver driver, By by, out IWebElement element)
        {
            try
            {
                element = driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                element = null;
                return false;
            }
        }

        public static bool IsElementPresent(this IWebDriver driver, By by)
        {
            return driver.IsElementPresent(by, out IWebElement element);
        }

        public static void WaitForPageToLoad(this IWebDriver driver)
        {
            TimeSpan timeout = new TimeSpan(0, 0, 30);
            WebDriverWait wait = new WebDriverWait(driver, timeout);

            IJavaScriptExecutor javascript = driver as IJavaScriptExecutor;
            if (javascript == null)
                throw new ArgumentException("driver", "Driver must support javascript execution");

            wait.Until((d) =>
            {
                try
                {
                    string readyState = javascript.ExecuteScript(
                    "if (document.readyState) return document.readyState;").ToString();
                    return readyState.ToLower() == "complete";
                }
                catch (Exception)
                {
                    return false;
                }
            });
        }
    }
}
