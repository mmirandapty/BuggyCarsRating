using BuggyCarsRating.Tests.WebElements;
using BuggyCarsRating.Tests.Providers;

namespace BuggyCarsRating.Tests.Contexts
{
    public class WebElementContext
    {
        private readonly WebDriverContext _webDriverContext;
        private readonly ConfigurationContext _configurationContext;

        public HomePage Homepage;
        public RegistrationPage RegistrationPage;
        public LoginForm LoginForm;
        public UserNavigation UserNavigation;
        public OverallRatingPage OverallRatingPage;

        public WebElementContext(WebDriverContext webDriverContext,
            ConfigurationContext configurationContext)
        {
            _webDriverContext = webDriverContext;
            _configurationContext = configurationContext;

            this.Homepage = new HomePage(_webDriverContext, _configurationContext);
            this.RegistrationPage = new RegistrationPage(_webDriverContext, _configurationContext);
            this.LoginForm = new LoginForm(_webDriverContext);
            this.UserNavigation = new UserNavigation(_webDriverContext);
            this.OverallRatingPage = new OverallRatingPage(_webDriverContext, _configurationContext);
        }
    }
}
