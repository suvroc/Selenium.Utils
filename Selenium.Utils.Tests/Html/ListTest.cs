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
        }

        [Test]
        public void should_get_all_ol_list_items()
        {
            var table = new ListElement(_driver, By.Id("orderedList"));

            Assert.AreEqual(3, table.Items.Count());
        }
    }
}
