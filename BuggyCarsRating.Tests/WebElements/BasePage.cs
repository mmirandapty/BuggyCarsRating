using BuggyCarsRating.Tests.Providers;
using OpenQA.Selenium;

namespace BuggyCarsRating.Tests.WebElements
{
    public class BasePage
    {
        private WebDriverContext _webDriverContext;

        public BasePage(WebDriverContext webDriverContext) => _webDriverContext = webDriverContext;

        public IWebElement LogoLink => _webDriverContext.ChromeDriver.FindElement(By.LinkText("Buggy Rating"));

        public void ClickLogoLink() => LogoLink.Click();
    }
}
