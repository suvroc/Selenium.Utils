using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Utils.Html;
using System.Threading;
using System.Linq;

namespace Selenium.Utils.Tests.Html
{
    [TestFixture]
    public class RadioTest : BaseSeleniumTest
    {
        public RadioTest() : base("radioButton.html")
        {

        }

        [Test]
        public void should_get_options()
        {
            var radio = new RadioButtons(_driver, By.Name("gender"));

            Assert.AreEqual(3, radio.Options.Count());
        }

        [Test]
        public void should_select_by_index()
        {
            var radio = new RadioButtons(_driver, By.Name("gender"));

            radio.SelectByIndex(1);

            Assert.AreEqual("female", radio.SelectedOption.Element.GetAttribute("value"));
        }

        [Test]
        public void should_select_by_value()
        {
            var radio = new RadioButtons(_driver, By.Name("gender"));

            radio.SelectByValue("female");

            Assert.AreEqual("female", radio.SelectedOption.Element.GetAttribute("value"));
        }

        [Test]
        public void should_select_by_text()
        {
            var radio = new RadioButtons(_driver, By.Name("gender"));

            radio.SelectByText("Female");

            Assert.AreEqual("female", radio.SelectedOption.Element.GetAttribute("value"));
        }

        [Test]
        public void should_select_by_text_male()
        {
            var radio = new RadioButtons(_driver, By.Name("gender"));

            radio.SelectByText("Male");

            Assert.AreEqual("male", radio.SelectedOption.Element.GetAttribute("value"));
        }

        [Test]
        public void should_select_by_text_other()
        {
            var radio = new RadioButtons(_driver, By.Name("gender"));

            radio.SelectByText("Other");

            Assert.AreEqual("other", radio.SelectedOption.Element.GetAttribute("value"));
        }
    }
}
