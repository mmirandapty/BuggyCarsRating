using BuggyCarsRating.Tests.Providers;
using OpenQA.Selenium;

namespace BuggyCarsRating.Tests.WebElements
{
    public class UserNavigation
    {
        private WebDriverContext _webDriverContext;

        public UserNavigation(WebDriverContext webDriverContext) => _webDriverContext = webDriverContext;

        public IWebElement UserGreeting => _webDriverContext.ChromeDriver.FindElement(By.XPath("//span[contains(text(),'Hi')]"));
        public IWebElement ProfileLink => _webDriverContext.ChromeDriver.FindElement(By.LinkText("Profile"));
        public IWebElement LogoutLink => _webDriverContext.ChromeDriver.FindElement(By.LinkText("Logout"));

        public bool IsUserLoggedIn() => UserGreeting.Displayed && ProfileLink.Displayed && LogoutLink.Displayed;
        public void ClickLogoutLink() => LogoutLink.Click();
    }
}
