using ATFbones.ui.drivers;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ATFbones
{
    [Binding]
    public class AbstractStepDefs
    {
        protected static IWebDriver _driver;

        public AbstractStepDefs()
        {
            if (_driver == null)
            {
                BrowserFactory.InitBrowser("Chrome");
                _driver = BrowserFactory.Driver;
            }
        }
    }
}
