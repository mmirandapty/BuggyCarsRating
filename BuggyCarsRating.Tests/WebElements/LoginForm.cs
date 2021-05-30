using BuggyCarsRating.Tests.Models;
using BuggyCarsRating.Tests.Providers;
using OpenQA.Selenium;

namespace BuggyCarsRating.Tests.WebElements
{
    public class LoginForm
    {
        private WebDriverContext _webDriverContext;

        public LoginForm(WebDriverContext webDriverContext) => _webDriverContext = webDriverContext;

        public IWebElement Form => _webDriverContext.ChromeDriver.FindElement(By.ClassName("form-inline"));
        public IWebElement LoginInput => _webDriverContext.ChromeDriver.FindElement(By.Name("login"));
        public IWebElement PasswordInput => _webDriverContext.ChromeDriver.FindElement(By.Name("password"));
        public IWebElement LoginButton => _webDriverContext.ChromeDriver.FindElement(By.XPath("//button[@type='submit'][text()='Login']"));

        public IWebElement InvalidCredentialError => _webDriverContext.ChromeDriver.FindElement(By.XPath("//span[contains(text(), 'Invalid username/password')]"));

        public void EnterLoginCredentials(LoginDataModel data)
        {
            LoginInput.SendKeys(data.Login);
            PasswordInput.SendKeys(data.Password);
        }

        public void EnterLoginCredentials(string username, string password)
        {
            LoginInput.SendKeys(username);
            PasswordInput.SendKeys(password);
        }

        public void ClickLoginButton() => LoginButton.Click();
    }
}
