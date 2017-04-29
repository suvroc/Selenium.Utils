using System.Net;

namespace Selenium.Utils.Helpers
{
    public class GeneralHelper
    {
        public static bool TestFileDownload(string url)
        {
            WebRequest webRequest = WebRequest.Create(url);
            WebResponse webResponse;
            try
            {
                webResponse = webRequest.GetResponse();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
