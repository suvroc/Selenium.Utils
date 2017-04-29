using NUnit.Framework;
using Selenium.Utils.Helpers;

namespace Selenium.Utils.Tests.Helpers
{
    [TestFixture]
    public class HelperTest
    {
        [Test]
        [TestCase("http://www.google.com", true)]
        [TestCase("http://w2w2w.g2o2o2g22l2e.c", false)]
        public void should_test_file_download(string url, bool result)
        {
            var res = GeneralHelper.TestFileDownload(url);

            Assert.AreEqual(result, res);
        }


    }
}
