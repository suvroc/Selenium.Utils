using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace Selenium.Utils.Html
{
    public class RadioButtons : BaseElements
    {
        public RadioButtons(IWebDriver driver, By selector) : base(driver, selector)
        {
        }

        public IEnumerable<RadioButton> Options
        {
            get
            {
                return this.Elements.Select(x => new RadioButton(_driver, x));
            }
        }

        public RadioButton SelectedOption
        {
            get
            {
                return this.Options.Single(x => x.Element.Selected);
            }
        }

        public void SelectByIndex(int index)
        {
            var elements = this.Elements;
            if (elements.Count() < index)
            {
                throw new IndexOutOfRangeException($"There is no radio option for index {index}");
            }
            elements.ElementAt(index).Click();
        }

        public void SelectByText(string text)
        {
            var element = this.Options.SingleOrDefault(x => x.Text.Trim() == text.Trim());
            if (element == null)
            {
                throw new ArgumentException($"There is not option with the text '{text}'");
            }
            element.Element.Click();
        }

        public void SelectByValue(string value)
        {
            var element = this.Elements.SingleOrDefault(x => x.GetAttribute("value") == value);
            if (element == null)
            {
                throw new ArgumentException($"There is no option with value '{value}'");
            }
            element.Click();

        }
    }
}
