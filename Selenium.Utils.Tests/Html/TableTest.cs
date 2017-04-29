using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Utils.Html;

namespace Selenium.Utils.Tests.Html
{
    [TestFixture]
    public class TableTest : BaseSeleniumTest
    {
        public TableTest() : base("table.html")
        {

        }

        [Test]
        public void should_get_table_data()
        {
            var table = _driver.Html().Table(By.Id("tableId"));

            Assert.AreEqual("2.1", table.GetData(2, 1).Text);
        }

        [Test]
        public void should_get_table_columns()
        {
            var table = _driver.Html().Table(By.Id("tableId"));

            Assert.That(table.Columns, Is.EquivalentTo(new string[] { "Col 1", "Col 2", "Col 3" }));
        }
    }
}
