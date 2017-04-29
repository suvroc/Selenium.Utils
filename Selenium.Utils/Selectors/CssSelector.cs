using OpenQA.Selenium;
using System.Linq;

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

        public CssSelector()
        {

        }

        public CssSelector(string selector)
        {
            this.selector = selector;
        }

        public By ToSelector()
        {
            return By.CssSelector(this.Selector);
        }

        public CssSelector All()
        {
            return AppendSelector("*");
        }

        private CssSelector AppendSelector(string fragment)
        {
            return new CssSelector(selector + fragment);
        }

        public CssSelector WithId(string id)
        {
            return AppendSelector($"#{id}");
        }

        public CssSelector WithClass(string className)
        {
            return AppendSelector($".{className}");
        }

        public CssSelector WithClasses(string[] classNames)
        {
            return AppendSelector($".{string.Join(".", classNames)}");
        }

        public CssSelector Element(string element)
        {
            return AppendSelector($"{element}");
        }

        public CssSelector WithNext(string selector)
        {
            return AppendSelector($" + {selector}");
        }

        public CssSelector WithNext(CssSelector selector)
        {
            return AppendSelector($" + {selector.Selector}");
        }

        public CssSelector WithSuccessor(string selector)
        {
            return AppendSelector($" ~ {selector}");
        }

        public CssSelector WithSuccessor(CssSelector selector)
        {
            return AppendSelector($" ~ {selector.Selector}");
        }

        public CssSelector WithDirectChild(string selector)
        {
            return AppendSelector($" > {selector}");
        }

        public CssSelector WithDirectChild(CssSelector selector)
        {
            return AppendSelector($" > {selector.Selector}");
        }

        public CssSelector WithChild(string selector)
        {
            return AppendSelector($" {selector}");
        }

        public CssSelector WithChild(CssSelector selector)
        {
            return AppendSelector($" {selector.Selector}");
        }

        #region Attributes
        public CssSelector WithAttribute(string attributeName)
        {
            return AppendSelector($"[{attributeName}]");
        }

        public CssSelector WithAttribute(string attributeName, string value)
        {
            return AppendSelector($"[{attributeName}=\"{value}\"]");
        }

        public CssSelector WithAttribute(string attributeName, string value, AttributeCompareType compareType, bool caseInsensitively = false)
        {
            string oper = "";
            switch (compareType)
            {
                case AttributeCompareType.Equal:
                    oper = "";
                    break;
                case AttributeCompareType.OneOfWords:
                    oper = "~";
                    break;
                case AttributeCompareType.BeginWith:
                    oper = "|";
                    break;
                case AttributeCompareType.FirstValue:
                    oper = "^";
                    break;
                case AttributeCompareType.LastValue:
                    oper = "$";
                    break;
                case AttributeCompareType.Contains:
                    oper = "*";
                    break;
                default:
                    break;
            }

            string command = "";

            if (caseInsensitively)
            {
                command = $"[{attributeName}{oper}=\"{value}\" i]";
            } else
            {
                command = $"[{attributeName}{oper}=\"{value}\"]";
            }

            return AppendSelector(command);
        }
        #endregion

        #region Pseudo classes
        public CssSelector ForActive()
        {
            return AppendSelector($":active");
        }

        public CssSelector ForAny(string[] tags)
        {
            return AppendSelector($":any({string.Join(",",tags)})");
        }

        public CssSelector ForAny(CssSelector[] tags)
        {
            return AppendSelector($":any({string.Join(",", tags.Select(x => x.Selector).ToList())})");
        }

        public CssSelector ForChecked()
        {
            return AppendSelector($":checked");
        }

        public CssSelector ForDefault()
        {
            return AppendSelector($":default");
        }

        public CssSelector ForDir(DirType type)
        {

            if (type == DirType.Ltr)
                return AppendSelector($":dir(ltr)");
            else
                return AppendSelector($":dir(rtl)");
        }

        public CssSelector ForDisabled()
        {
            return AppendSelector($":disabled");
        }

        public CssSelector ForEmpty()
        {
            return AppendSelector($":empty");
        }

        public CssSelector ForEnabled()
        {
            return AppendSelector($":enabled");
        }

        public CssSelector ForFirst()
        {
            return AppendSelector($":first");
        }

        public CssSelector ForFirstChild()
        {
            return AppendSelector($":first-child");
        }

        public CssSelector ForFirstOfType()
        {
            return AppendSelector($":first-of-type");
        }

        public CssSelector ForFullscreen()
        {
            return AppendSelector($":fullscreen");
        }

        public CssSelector ForFocus()
        {
            return AppendSelector($":focus");
        }

        public CssSelector ForHover()
        {
            return AppendSelector($":hover");
        }

        public CssSelector ForIndeterminate()
        {
            return AppendSelector($":indeterminate");
        }

        public CssSelector ForInRange()
        {
            return AppendSelector($":in-range");
        }

        public CssSelector ForInvalid()
        {
            return AppendSelector($":invalid");
        }

        public CssSelector ForLang(string languageCode)
        {
            return AppendSelector($":lang({languageCode})");
        }

        public CssSelector ForLastChild()
        {
            return AppendSelector($":last-child");
        }

        public CssSelector ForLastOfType()
        {
            return AppendSelector($":last-of-type");
        }

        public CssSelector ForLeftPage()
        {
            return AppendSelector($":left");
        }

        public CssSelector ForLink()
        {
            return AppendSelector($":link");
        }

        public CssSelector NotFor(string selector)
        {
            return AppendSelector($":not({selector})");
        }

        public CssSelector NotFor(CssSelector selector)
        {
            return AppendSelector($":not({selector.Selector})");
        }

        public CssSelector ForNthChild(int a, int b)
        {
            string param = GenerateNthParam(a, b);
            return AppendSelector($":nth-child({param})");
        }

        public CssSelector ForNthChild(NthParity parity)
        {
            if (parity == NthParity.Even)
                return AppendSelector($":nth-child(even)");
            else
                return AppendSelector($":nth-child(odd)");
        }

        public CssSelector ForNthLastChild(int a, int b)
        {
            string param = GenerateNthParam(a, b);
            return AppendSelector($":nth-last-child({param})");
        }

        public CssSelector ForNthLastChild(NthParity parity)
        {
            if (parity == NthParity.Even)
                return AppendSelector($":nth-last-child(even)");
            else
                return AppendSelector($":nth-last-child(odd)");
        }

        public CssSelector ForNthLastOfType(int a, int b)
        {
            string param = GenerateNthParam(a, b);
            return AppendSelector($":nth-last-of-type({param})");
        }

        public CssSelector ForNthLastOfType(NthParity parity)
        {
            if (parity == NthParity.Even)
                return AppendSelector($":nth-last-of-type(even)");
            else
                return AppendSelector($":nth-last-of-type(odd)");
        }

        public CssSelector ForNthOfType(int a, int b)
        {
            string param = GenerateNthParam(a, b);
            return AppendSelector($":nth-of-type({param})");
        }

        public CssSelector ForNthOfType(NthParity parity)
        {
            if (parity == NthParity.Even)
                return AppendSelector($":nth-of-type(even)");
            else
                return AppendSelector($":nth-of-type(odd)");
        }

        public CssSelector ForOnlyChild()
        {
            return AppendSelector($":only-child");
        }

        public CssSelector ForOnlyOfType()
        {
            return AppendSelector($":only-of-type");
        }

        public CssSelector ForOptional()
        {
            return AppendSelector($":optional");
        }

        public CssSelector ForOutOfRange()
        {
            return AppendSelector($":out-of-range");
        }

        public CssSelector ForReadOnly()
        {
            return AppendSelector($":read-only");
        }

        public CssSelector ForReadWrite()
        {
            return AppendSelector($":read-write");
        }

        public CssSelector ForRequired()
        {
            return AppendSelector($":required");
        }

        public CssSelector ForRightPage()
        {
            return AppendSelector($":right");
        }

        public CssSelector ForRootElement()
        {
            return AppendSelector($":root");
        }

        public CssSelector ForScope()
        {
            return AppendSelector($":scope");
        }

        public CssSelector ForTarget()
        {
            return AppendSelector($":target");
        }

        public CssSelector ForValid()
        {
            return AppendSelector($":valid");
        }

        public CssSelector ForVisited()
        {
            return new CssSelector(selector += $":visited");
        }

        private static string GenerateNthParam(int a, int b)
        {
            string param = "";
            if (a != 0)
            {
                param += $"{a}n";
                if (b != 0)
                {
                    param += "+";
                }
            }
            if (b != 0)
            {
                param += $"{b}";
            }

            return param;
        }
        #endregion

    }

    public enum DirType
    {
        Ltr,
        Rtl
    }

    public enum NthParity
    {
        Even,
        Odd
    }
    public enum AttributeCompareType
    {
        Equal,
        OneOfWords,
        BeginWith,
        FirstValue,
        LastValue,
        Contains
    }
}
