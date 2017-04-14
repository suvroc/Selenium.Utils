using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Utils.Selectors
{
    public class CssSelector
    {
        private string selector = "";

        public string Selector
        {
            get {
                return selector;
            }
        }

        public CssSelector All()
        {
            selector += "*";
            return this;
        }

        public CssSelector WithId(string id)
        {
            selector += $"#{id}";
            return this;
        }

        public CssSelector WithClass(string className)
        {
            selector += $".{className}";
            return this;
        }

        public CssSelector Element(string element)
        {
            selector += $"{element}";
            return this;
        }

        #region Pseudo classes
        public CssSelector ForActive()
        {
            selector += $":active";
            return this;
        }



        public CssSelector ForVisited()
        {
            selector += $":visited";
            return this;
        }
        #endregion
    }
}
