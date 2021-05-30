using BuggyCarsRating.Tests.Contexts;
using BuggyCarsRating.Tests.Models;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BuggyCarsRating.Tests.Steps
{
    [Binding]
    public sealed class RegistrationAndLoginSteps : TechTalk.SpecFlow.Steps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly WebElementContext _webElementContext;

        public RegistrationAndLoginSteps(ScenarioContext scenarioContext,
            WebElementContext pageContext)
        {
            _scenarioContext = scenarioContext;
            _webElementContext = pageContext;
        } 

        #region Registration
        [Given(@"I am in registration page")]
        public void GivenIAmInRegistrationPage()
        {
            _webElementContext.RegistrationPage.GoTo();
        }

        [Given(@"I enter my user detail")]
        public void IEnterMyUserDetail(Table table)
        {
            var registrationData = table.CreateInstance<RegistrationDataModel>();
            _webElementContext.RegistrationPage.EnterRegistrationData(registrationData);

            _scenarioContext.Add("registeredLoginData", new LoginDataModel
            {
                Login = registrationData.Username,
                Password = registrationData.Password
            });
        }
        
        [When(@"I click register button")]
        public void WhenIClickRegisterButton()
        {
            _webElementContext.RegistrationPage.ClickRegisterButton();
        }
        
        [Then(@"I will be registered")]
        public void IWillBeRegistered()
        {
            Assert.AreEqual("Registration is successful", _webElementContext.RegistrationPage.RegistrationResult.Text);
        }

        [Then(@"I will be able to login using the registered login credentials")]
        public void ThenIWillBeAbleToLoginUsingTheRegisteredLoginCredentials()
        {
            var registeredLoginData = _scenarioContext.Get<LoginDataModel>("registeredLoginData");
            Given($"I enter username {registeredLoginData.Login} and password {registeredLoginData.Password}");
            When(@"I click login button");
            Then(@"I should be logged in");
        }

        [Then(@"I will see user already exist error")]
        public void ThenIWillSeeUserAlreadyExistError()
        {
            Assert.AreEqual("UsernameExistsException: User already exists", _webElementContext.RegistrationPage.RegistrationResult.Text);
        }

        #endregion

        #region Login
        [Given(@"I enter username (.*) and password (.*)")]
        public void GivenIEnterUsernameJohnAndPasswordPassword(string username, string password)
        {
            _webElementContext.LoginForm.EnterLoginCredentials(username, password);
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            _webElementContext.LoginForm.ClickLoginButton();
        }

        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            Assert.That(_webElementContext.UserNavigation.IsUserLoggedIn(), Is.True);
        }

        [Then(@"I should not be logged in")]
        public void ThenIShouldNotBeLoggedIn()
        {
            Assert.That(_webElementContext.LoginForm.InvalidCredentialError.Displayed, Is.True);
        }

        #endregion

        #region Logout
        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {
            Given($"I enter username john and password Password123!");
            When(@"I click login button");
        }

        [When(@"I click logout button")]
        public void WhenIClickLogoutButton()
        {
            _webElementContext.UserNavigation.ClickLogoutLink();
        }

        [Then(@"I should be logged out")]
        public void ThenIShouldBeLoggedOut()
        {
            Assert.That(_webElementContext.LoginForm.Form.Displayed, Is.True);
        }

        #endregion
    }
}
