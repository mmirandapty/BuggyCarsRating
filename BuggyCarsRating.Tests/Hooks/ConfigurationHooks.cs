using BuggyCarsRating.Tests.Contexts;
using BuggyCarsRating.Tests.Models;
using Microsoft.Extensions.Configuration;
using TechTalk.SpecFlow;

namespace BuggyCarsRating.Tests.Hooks
{
    [Binding]
    public sealed class ConfigurationHooks
    {
        private readonly ConfigurationContext _testConfigurationContext;

        public ConfigurationHooks(ConfigurationContext testConfigurationContext)
        {
            _testConfigurationContext = testConfigurationContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var config = new ConfigurationBuilder()
            .AddJsonFile("testsettings.json", optional: false)
            .Build();

            _testConfigurationContext.Configuration = config.Get<ConfigurationModel>();
        }
    }
}
