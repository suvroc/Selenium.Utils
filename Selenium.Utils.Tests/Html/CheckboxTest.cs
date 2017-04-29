using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Utils.Html;

namespace Selenium.Utils.Tests.Html
{
    [TestFixture]
    public class CheckboxTest : BaseSeleniumTest
    {
        public CheckboxTest() : base("checkbox.html")
        {

        }

        [Test]
        public void should_check_element()
        {
            var checkbox = new Checkbox(_driver, By.Name("carCheckbox"));

            checkbox.Check();

            Assert.AreEqual("Car", checkbox.Text);
            Assert.IsTrue(checkbox.Checked);
        }

        [Test]
        public void should_uncheck_element()
        {
            var checkbox = new Checkbox(_driver, By.Name("bikeCheckbox"));

            checkbox.Uncheck();

            Assert.AreEqual("Bike", checkbox.Text);
            Assert.IsFalse(checkbox.Checked);
        }
    }
}
