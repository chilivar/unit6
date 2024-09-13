using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
namespace ExampleProject.Framework.Pages
{
    internal class MainPage : Form
    {
        private IButton privacyBtn = ElementFactory.GetButton(By.XPath("//div[contains(@Class,'banner-button')]"), "Policy accept");
        private ITextBox searchField = ElementFactory.GetTextBox(By.XPath("//input[@Class='search-input']"), "Search field");
        private ILabel searchResult = ElementFactory.GetLabel(By.XPath("//div[@Class='search-results']"), "Container with the result");
        private ILabel firstResultItem = ElementFactory.GetLabel(By.XPath("//div[@Class='results-container']//div[1]"), "First item in the list");
        private IButton recentLocationItem = ElementFactory.GetButton(By.XPath("//a[contains(@Class, 'recent-location-item')][1]"), "First recent location item");
        private ILabel currentLocation = ElementFactory.GetLabel(By.XPath("//div[contains(@Class,'current-location-result')]"), "Current location option");

        public MainPage() : base(By.XPath("//*[@class='header-logo']"), "AccuWeather")
        {
        }

        public void ClickPrivacyBtn() => privacyBtn.Click();

        public void ClickFirstItem() => firstResultItem.Click();

        public void ClickRecentLocationItem() => recentLocationItem.Click();

        public void ClickSearchInput() => searchField.Click();

        public bool CurrentLocationIsDisplayed()
        {
            return currentLocation.State.IsDisplayed;
        }

        public void EnterSearchText(string text)
        {
            searchField.ClearAndType(text);
        }

        public bool IsResultsContainerDisplayed()
        {
            return searchResult.State.IsDisplayed;
        }



    }
}