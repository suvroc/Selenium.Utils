using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Selenium.Utils.PageObjects
{
    public abstract class BasePageObject
    {
        protected readonly IWebDriver _driver;
        protected readonly IWebElement _element;

        public BasePageObject(IWebDriver driver)
        {
            this._driver = driver;
        }

        public BasePageObject(IWebDriver driver, IWebElement element)
        {
            this._driver = driver;
            this._element = element;
        }

        public string Url
        {
            get
            {
                return _driver.Url;
            }
        }

        public static TPageObject CreatePageObject<TPageObject>(IWebDriver driver)
            where TPageObject : BasePageObject
        {
            var type = typeof(TPageObject);
            IList<Type> constructorSignature = new List<Type> { typeof(IWebDriver) };
            IList<object> constructorArgs = new List<object> { driver };

            var constructor = type.GetConstructor(constructorSignature.ToArray());

            if (constructor == null)
            {
                throw new ArgumentException(
                    $"The result type specified ({type}) is not a valid block. It must have a constructor that takes only a session.");
            }

            return (TPageObject)constructor.Invoke(constructorArgs.ToArray());
        }

        public TPageObject NavigateTo<TPageObject>()
            where TPageObject : BasePageObject
        {
            return CreatePageObject<TPageObject>(_driver);
        }
    }
}
