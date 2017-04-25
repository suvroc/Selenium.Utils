using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Selenium.Utils.Extensions
{
    public static class FlowExtensions
    {
        public static void TakeScreenshot(this IWebDriver driver, string testName)
        {
            var screenshotProvider = driver as ITakesScreenshot;
            if (screenshotProvider != null)
            {
                Screenshot ss = screenshotProvider.GetScreenshot();
                ss.SaveAsFile($"{testName}_{DateTime.Now:yyyy-MM-dd-hh-mm-ss}.acceptance-exception.png",
                    ScreenshotImageFormat.Png); //use any of the built in image formating
            }
        }
    }
}
