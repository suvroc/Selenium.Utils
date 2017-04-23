using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace Selenium.Utils.Html
{
    public class Select : BaseElement
    {
        public Select(IWebDriver driver, By selector) : base(driver, selector)
        {
        }

        public Select(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }

        public bool Multiple {
            get
            {
                return Element.GetAttribute("multiple") == "true";
            }
        }

        public IEnumerable<IWebElement> Options {
            get
            {
                return Element.FindElements(By.TagName("option"));
            }
        }

        public IEnumerable<IWebElement> SelectedOptions
        {
            get
            {
                return Options.Where(x => x.Selected);
            }
        }

        public void SelectByIndex(int index)
        {
            Options.ElementAt(index).Click();
        }

        public void SelectByText(string text)
        {
            var option = Options.SingleOrDefault(x => x.Text == text);
            if (option == null)
            {
                throw new ArgumentException($"There is no option with text '{text}'");
            }
            option.Click();
        }

        public void SelectByValue(string value)
        {
            var option = Options.SingleOrDefault(x => x.GetAttribute("value") == value);
            if (option == null)
            {
                throw new ArgumentException($"There is no option with text '{value}'");
            }
            option.Click();
        }

        public void SelectAll()
        {
            foreach (var option in Options)
            {
                if (!option.Selected)
                    option.Click();
            }
        }

        public void DeselectAll()
        {
            foreach (var option in Options)
            {
                if (option.Selected)
                    option.Click();
            }
        }
    }
}
