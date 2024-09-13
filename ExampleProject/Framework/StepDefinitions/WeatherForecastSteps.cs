using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using ExampleProject.Framework.Hooks;
using ExampleProject.Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;


namespace ExampleProject.Framework.StepDefinitions
{
    [Binding]
    internal class WeatherForecastSteps
    {
        WeatherForecastPage weatherForecastPage = new();
        protected static readonly JsonSettingsFile testdata = new("testdata.json");
        private string locationNewYork = testdata.GetValue<string>("AccuWeather.locationNewYork");
        private string locationLondon = testdata.GetValue<string>("AccuWeather.locationLondon");
        


        [Then(@"The city weather page header contains the city name New York from the search")]
        public void ComparisonOfNewYork()
        {
            Assert.That(weatherForecastPage.GetLocationName(), Does.Contain(locationNewYork), "Incorrect text");
        }

        [Then(@"The city weather page header contains the city name London from the search")]
        public void ComparisonOfLondon()
        {
            Assert.That(weatherForecastPage.GetLocationName(), Does.Contain(locationLondon), "Incorrect text");
        }

        

        [When(@"I go back to the main page")]
        public void GoBack()
        {
            Thread.Sleep(5000);
            weatherForecastPage.ClickOnHeader();

        }




    }
}
