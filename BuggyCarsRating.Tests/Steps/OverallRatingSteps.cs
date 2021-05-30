using BuggyCarsRating.Tests.Contexts;
using BuggyCarsRating.Tests.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BuggyCarsRating.Tests.Steps
{
    [Binding]
    public sealed class OverallRatingSteps
    {
        private readonly WebElementContext _webElementContext;

        public OverallRatingSteps(WebElementContext webElementContext)
        {
            _webElementContext = webElementContext;
        }

        [Given(@"I am in overall rating page")]
        public void GivenIAmInOverallRatingPage()
        {
            _webElementContext.OverallRatingPage.GoTo();
        }

        [Then(@"I will see a list of registered models")]
        public void ThenIWillSeeAListOfRegisteredModels()
        {
            var rows = _webElementContext.OverallRatingPage.CarsTable.FindElements(By.CssSelector("tbody tr"));
            Console.WriteLine($"There are {rows.Count} cars in the list.");
            Assert.GreaterOrEqual(rows.Count, 1);
        }

        [Given(@"I manually enter page (.*)")]
        public void IManuallyEnterPage(int pageNumber)
        {
            _webElementContext.OverallRatingPage.PageNumberInput.Clear();
            _webElementContext.OverallRatingPage.PageNumberInput.SendKeys(pageNumber.ToString());
        }

        [When(@"I press enter key")]
        public void WhenIPressEnterKey()
        {
            _webElementContext.OverallRatingPage.PageNumberInput.SendKeys(Keys.Enter);
        }


        [When(@"I click (.*) page button")]
        public void WhenIClickNextButton(string button)
        {
            if (button == "next")
            {
                _webElementContext.OverallRatingPage.PaginationNextButton.Click();
            }
            else if (button == "previous")
            {
                _webElementContext.OverallRatingPage.PaginationPreviousButton.Click();
            }
        }

        [Then(@"current page should be (.*)")]
        public void ThenCurrentPageShouldBe(int pageNumber)
        {
            Assert.AreEqual(pageNumber.ToString(), _webElementContext.OverallRatingPage.PageNumberInput.GetAttribute("value"),
                $"Expected is page {pageNumber.ToString()} but displayed page {_webElementContext.OverallRatingPage.PageNumberInput.GetAttribute("value")} instead.");
        }

        [Then(@"all model image thumbnail should display")]
        public void ThenAllModelImageThumbnailShouldDisplay()
        {
            Thread.Sleep(1000);
            var rows = _webElementContext.OverallRatingPage.CarsTable.FindElements(By.CssSelector("tbody tr"));

            foreach(var row in rows)
            {
                var image = row.FindElement(By.ClassName("img-thumbnail"));
                int imageWidth = Convert.ToInt32(image.GetAttribute("naturalWidth"));
                Assert.Greater(imageWidth, 0, $"Image thumbnail for {image.GetAttribute("title")} is broken.");
            }
        }

        [When(@"I click column header Rank")]
        public void WhenIClickColumnHeaderRank()
        {
            _webElementContext.OverallRatingPage.RankSortLink.Click();
        }

        [Then(@"list will be sorted as below")]
        public void ThenListWillBeSortedAsBelow(Table table)
        {
            Thread.Sleep(1000);
            var rows = _webElementContext.OverallRatingPage.CarsTable.FindElements(By.CssSelector("tbody tr"));
            var ranksList = new List<int>();

            foreach (var row in rows)
            {
                int rank = Convert.ToInt32(row.FindElement(By.CssSelector("td:nth-child(4)")).Text);
                ranksList.Add(rank);
            }

            var sortedRanksList = table.CreateSet<RankListModel>().Select(r => r.Rank);

            Assert.That(ranksList.SequenceEqual(sortedRanksList), Is.True,
                $"Expected sorting is {String.Join(",", sortedRanksList)} but actual result is {String.Join(", ", ranksList)}");
        }

    }
}
