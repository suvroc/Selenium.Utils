using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Utils.Html;
using System.Linq;
using System.Threading;

namespace Selenium.Utils.Tests.Html
{
    [TestFixture]
    public class ListTest : BaseSeleniumTest
    {
        public ListTest() : base("list.html")
        {

        }

        [Test]
        public void should_get_all_ul_list_items()
        {
            var table = new ListElement(_driver, By.Id("unorderedList"));

            Assert.AreEqual(4, table.Items.Count());
            Assert.That(table.Items.Select(x => x.Text), Is.EquivalentTo(new string[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        }

        [Test]
        public void should_get_all_ol_list_items()
        {
            var table = new ListElement(_driver, By.Id("orderedList"));

            Assert.AreEqual(3, table.Items.Count());
            Assert.That(table.Items.Select(x => x.Text), Is.EquivalentTo(new string[] { "Item 1", "Item 2", "Item 3" }));
        }

        [Test]
        public void should_get_all_complex_list_items()
        {
            var table = new ListElement(_driver, By.Id("complexList"), By.CssSelector("a b"));

            Assert.AreEqual(3, table.Items.Count());
            Assert.That(table.Items.Select(x => x.Text), Is.EquivalentTo(new string[] { "Item 1", "Item 2", "Item 3" }));
        }
    }
}
