using ATFbones.ui.drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace ATFbones.ui.pageobjects
{
    abstract class AbstractPageObject
    {
        protected static IWebDriver _driver;

        public AbstractPageObject(IWebDriver driver)
        {
            _driver = driver;
             }
    }
}
