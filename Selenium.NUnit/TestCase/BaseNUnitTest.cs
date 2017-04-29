using NUnit.Framework;
using NUnit.Framework.Interfaces;
using Selenium.Utils.Extensions;
using Selenium.Utils.TestCase;

namespace Selenium.NUnit.TestCase
{
    public class BaseNUnitTest : BaseTestCase
    {
        [TearDown]
        public void TearDown()
        {
            var state = TestContext.CurrentContext.Result.Outcome;
            if (state.Status == TestStatus.Failed || state.Status == TestStatus.Warning)
            {
                _driver.TakeScreenshot(TestContext.CurrentContext.Test.FullName);
            }

            _driver.Quit();
        }

        [SetUp]
        public override void Initalize()
        {
            base.Initalize();
            
        }
    }
}
