using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Utils.Html;
using System.Threading;
using System.Linq;

namespace Selenium.Utils.Tests.Html
{
    [TestFixture]
    public class ImageTest : BaseSeleniumTest
    {
        public ImageTest() : base("image.html")
        {

        }

        [Test]
        public void should_check_image()
        {
            var select = new Image(_driver, By.Id("image"));

            Assert.IsTrue(select.Source.EndsWith("somefile.png"));
        }
    }
}
