using OpenQA.Selenium;

namespace Selenium.Utils.Html
{
    public class Image : BaseElement
    {
        public Image(IWebDriver driver, By selector) : base(driver, selector)
        {
        }

        public Image(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }

        public string Source
        {
            get
            {
                return Element.GetAttribute("src");
            }
        }

        public string Alt
        {
            get
            {
                return Element.GetAttribute("alt");
            }
        }
    }
}
