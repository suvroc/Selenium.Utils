using NUnit.Framework;
using Selenium.Utils.Extensions;
using Selenium.Utils.Tests.Html;
using System;

namespace Selenium.Utils.Tests.Extensions
{
    [TestFixture]
    public class RetryTest : BaseSeleniumTest
    {
        public RetryTest() : base("")
        {

        }

        [Test]
        public void should_check_retry_success()
        {
            var result = _driver.Retry(RetryTest.TestFunction, 5, TimeSpan.FromMilliseconds(50));
        }

        [Test]
        public void should_check_retry_fail()
        {
            Assert.Throws<Exception>(() => _driver.Retry(RetryTest.TestFunctionFailed, 5, TimeSpan.FromMilliseconds(50)));
        }

        private static int index = 0;

        private static int TestFunction()
        {
            if (index++ >= 3)
            {
                return 12;
            }
            throw new Exception();
        }

        private static int TestFunctionFailed()
        {
            throw new Exception();
        }
    }
}
