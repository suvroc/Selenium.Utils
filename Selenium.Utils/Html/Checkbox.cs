using OpenQA.Selenium;

namespace Selenium.Utils.Html
{
    public class Checkbox : BaseElement
    {
        public Checkbox(IWebDriver driver, By selector) : base(driver, selector)
        {
        }

        public Checkbox(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }

        public string Text
        {
            get
            {
                return ((IJavaScriptExecutor)_driver).ExecuteScript("var node = arguments[0].nextSibling; while(node.textContent && node.textContent.trim() === '') node = node.nextSibling; return node.textContent.trim()", this.Element).ToString();
            }
        }

        public bool Checked
        {
            get
            {
                return this.Element.Selected;
            }
        }

        public void Check()
        {
            if (!Checked)
                this.Element.Click();
        }

        public void Uncheck()
        {
            if (Checked)
                this.Element.Click();
        }

        public void Switch()
        {
            this.Element.Click();
        }
    }
}
