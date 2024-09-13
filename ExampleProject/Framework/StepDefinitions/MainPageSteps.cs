using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using ExampleProject.Framework.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;


namespace ExampleProject.Framework.StepDefinitions
{
    [Binding]
    internal class MainPageSteps
    {
        MainPage mainPage = new();
        protected static readonly JsonSettingsFile testdata = new("testdata.json");
        private string locationNewYork = testdata.GetValue<string>("AccuWeather.locationNewYork");
        private string locationLondon = testdata.GetValue<string>("AccuWeather.locationLondon");


        [Given(@"I have consented to data usage")]
        public void ClickConsentDataUsage()
        {
            mainPage.ClickPrivacyBtn();
        }

        [When(@"I input (.*) in the search field")]
        public void InputNewYorkInSearchField(string locationNewYork)
        {
            mainPage.EnterSearchText(locationNewYork);
        }

        [When(@"I click on the first result New York")]
        public void ClickFirstresultFirstCity()
        {
            mainPage.ClickFirstItem();
           
        }

        [When(@"I click on the first search result London")]
        public void ClickFirstresultSecondCity()
        {
            mainPage.ClickFirstItem();
            
        }

        [When(@"Search result is displayed")]
        public void SearchResultIsDisplayed()
        {
            Assert.That(mainPage.IsResultsContainerDisplayed(), "Not displayed");
        }

        [When(@"I input London in the search field")]
        public void InputLondonInSearchField()
        {
            mainPage.EnterSearchText(locationLondon);
        }

        [When(@"I choose the first city in Recent locations")]
        public void ChooseFirstInRecentLocation()
        {
            mainPage.ClickRecentLocationItem();
        }

        [When(@"Click search field")]
        [When(@"I click search field")]
        public void ClickSearchField()
        {
            mainPage.ClickSearchInput();
        }

        [Then(@"I use current location label is displayed")]
        public void CurrentlocationLabelIsDisplayed()
        {
            mainPage.CurrentLocationIsDisplayed();
        }

        [Then(@"Main page is displayed")]
        public void MainPageIsdisplayed()
        {
            Assert.That(mainPage.State.IsDisplayed, "Main page not displayed");
        }





    }
}
