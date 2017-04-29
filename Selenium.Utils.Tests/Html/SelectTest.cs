using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Utils.Html;
using System.Linq;

namespace Selenium.Utils.Tests.Html
{
    [TestFixture]
    public class SelectTest : BaseSeleniumTest
    {
        public SelectTest() : base("select.html")
        {

        }

        [Test]
        public void should_check_multiple()
        {
            var select = new Select(_driver, By.Name("cars"));

            Assert.True(select.Multiple);
        }

        [Test]
        public void should_check_multiple_for_single()
        {
            var select = new Select(_driver, By.Name("carsSingle"));

            Assert.IsFalse(select.Multiple);
        }

        [Test]
        public void should_check_options()
        {
            var select = new Select(_driver, By.Name("cars"));

            Assert.AreEqual(4, select.Options.Count());
        }

        [Test]
        public void should_select_by_index()
        {
            var select = new Select(_driver, By.Name("cars"));

            select.SelectByIndex(1);

            Assert.AreEqual(4, select.Options.Count());
            Assert.AreEqual(1, select.SelectedOptions.Count());
            Assert.AreEqual("Saab", select.SelectedOptions.Single().Text);
        }

        [Test]
        public void should_select_by_text()
        {
            var select = new Select(_driver, By.Name("cars"));

            select.SelectByText("Saab");

            Assert.AreEqual(4, select.Options.Count());
            Assert.AreEqual(1, select.SelectedOptions.Count());
            Assert.AreEqual("Saab", select.SelectedOptions.Single().Text);
        }

        [Test]
        public void should_select_by_value()
        {
            var select = new Select(_driver, By.Name("cars"));

            select.SelectByValue("saab");

            Assert.AreEqual(4, select.Options.Count());
            Assert.AreEqual(1, select.SelectedOptions.Count());
            Assert.AreEqual("Saab", select.SelectedOptions.Single().Text);
        }

        [Test]
        public void should_select_all()
        {
            var select = new Select(_driver, By.Name("cars"));

            select.SelectAll();

            Assert.AreEqual(4, select.Options.Count());
            Assert.AreEqual(4, select.SelectedOptions.Count());
        }

        [Test]
        public void should_deselect_all()
        {
            var select = new Select(_driver, By.Name("cars"));

            select.DeselectAll();

            Assert.AreEqual(4, select.Options.Count());
            Assert.AreEqual(0, select.SelectedOptions.Count());
        }
    }
}
