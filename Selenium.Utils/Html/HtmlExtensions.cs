using OpenQA.Selenium;
using Selenium.Utils.PageObjects;

namespace Selenium.Utils.Html
{
    public static class HtmlExtensions
    {
        public static HtmlToolbox Html(this IWebDriver driver)
        {
            return new HtmlToolbox(driver);
        }
    }

    public class HtmlToolbox
    {
        private IWebDriver _driver;

        public HtmlToolbox(IWebDriver driver)
        {
            _driver = driver;
        }

        public Checkbox Checkbox(By selector)
        {
            return new Checkbox(_driver, selector);
        }

        public Checkbox Checkbox(IWebElement element)
        {
            return new Checkbox(_driver, element);
        }

        public Image Image(By selector)
        {
            return new Image(_driver, selector);
        }

        public Image Image(IWebElement element)
        {
            return new Image(_driver, element);
        }

        public ListElement ListElement(By selector)
        {
            return new ListElement(_driver, selector);
        }

        public ListElement ListElement(By selector, By elementSelector)
        {
            return new ListElement(_driver, selector, elementSelector);
        }

        public ListElement ListElement(IWebElement element)
        {
            return new ListElement(_driver, element);
        }

        public ListElement ListElement(IWebElement element, By elementSelector)
        {
            return new ListElement(_driver, element, elementSelector);
        }

        public Navigable<TPageObjectType> Navigable<TPageObjectType>(By selector)
            where TPageObjectType : BasePageObject
        {
            return new Navigable<TPageObjectType>(_driver, selector);
        }

        public Navigable<TPageObjectType> Navigable<TPageObjectType>(IWebElement element)
            where TPageObjectType : BasePageObject
        {
            return new Navigable<TPageObjectType>(_driver, element);
        }

        public RadioButton RadioButton(By selector)
        {
            return new RadioButton(_driver, selector);
        }

        public RadioButton RadioButton(IWebElement element)
        {
            return new RadioButton(_driver, element);
        }

        public RadioButtons RadioButtons(By selector)
        {
            return new RadioButtons(_driver, selector);
        }

        public Select Select(By selector)
        {
            return new Select(_driver, selector);
        }

        public Select Select(IWebElement element)
        {
            return new Select(_driver, element);
        }

        public Table Table(By selector)
        {
            return new Table(_driver, selector);
        }
         
        public Table Table(IWebElement element)
        {
            return new Table(_driver, element);
        }
    }
}
