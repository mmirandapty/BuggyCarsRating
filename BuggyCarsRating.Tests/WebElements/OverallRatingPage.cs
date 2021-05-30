using BuggyCarsRating.Tests.Contexts;
using BuggyCarsRating.Tests.Providers;
using OpenQA.Selenium;

namespace BuggyCarsRating.Tests.WebElements
{
    public class OverallRatingPage : BasePage
    {
        private readonly ConfigurationContext _configurationContext;
        private readonly WebDriverContext _webDriverContext;

        public OverallRatingPage(WebDriverContext webDriverContext,
            ConfigurationContext configurationContext) : base(webDriverContext)
        { 
            _webDriverContext = webDriverContext;
            _configurationContext = configurationContext;
        }

        public IWebElement CarsTable => _webDriverContext.ChromeDriver.FindElement(By.ClassName("cars"));

        public IWebElement RankSortLink => _webDriverContext.ChromeDriver.FindElement(By.LinkText("Rank"));

        public IWebElement PageNumberInput => _webDriverContext.ChromeDriver.FindElement(By.XPath("//my-pager//input[@type='text']"));
        public IWebElement PaginationNextButton => _webDriverContext.ChromeDriver.FindElement(By.LinkText("»"));
        public IWebElement PaginationPreviousButton => _webDriverContext.ChromeDriver.FindElement(By.LinkText("«"));

        public void GoTo() => _webDriverContext.ChromeDriver.Navigate().GoToUrl($"{_configurationContext.Configuration.ApplicationBaseUrl}overall");
    }
}
