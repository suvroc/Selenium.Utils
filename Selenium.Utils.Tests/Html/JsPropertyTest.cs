using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Utils.Html;
using System.Threading;
using System.Linq;
using Selenium.Utils.Extensions;

namespace Selenium.Utils.Tests.Html
{
    [TestFixture]
    public class JsPropertyTest : BaseSeleniumTest
    {
        public JsPropertyTest() : base("jsProperty.html")
        {

        }

        [Test]
        public void should_check_element()
        {
            var input = _driver.FindElement(By.Id("valueInput"));

            var result = (string)input.GetJsProperty(_driver, "value");

            Assert.AreEqual("20", result);
        }
    }
}
