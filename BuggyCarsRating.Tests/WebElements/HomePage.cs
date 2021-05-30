using BuggyCarsRating.Tests.Contexts;
using BuggyCarsRating.Tests.Providers;
using OpenQA.Selenium;

namespace BuggyCarsRating.Tests.WebElements
{
    public class HomePage : BasePage
    {
        private readonly WebDriverContext _webDriverContext;
        private readonly ConfigurationContext _configurationContext;

        public HomePage(WebDriverContext webDriverContext,
            ConfigurationContext configurationContext) : base(webDriverContext)
        {
            _webDriverContext = webDriverContext;
            _configurationContext = configurationContext;
        }

        public IWebElement HomeSection => _webDriverContext.ChromeDriver.FindElement(By.XPath("//my-home"));

        public void GoTo() => _webDriverContext.ChromeDriver.Navigate().GoToUrl(_configurationContext.Configuration.ApplicationBaseUrl);
        public bool IsHomeSectionDisplayed() => HomeSection.Displayed;
    }
}
