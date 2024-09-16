using ExampleProject.Framework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ExampleProject.Framework.StepDefinitions
{
    [Binding]
    internal class HerokuappSteps
    {
        HerokuappPage herokuapp = new();

        [Given("The main page is open")]
        public void MainPageDisplayed()
        {
            Assert.That(herokuapp.State.IsDisplayed, "Main page not displayed");
        }

        [When("Click on Entry Ad")]
        public void ClickEntryAd()
        {
            herokuapp.ButtonClick();
        }

        [Then("Entry Ad page is open")]
        public void EntryAdOpen()
        {
            Assert.That(herokuapp.IsLabelDisplayed, "Entry Ad page not opened");
        }

        [Then("the popup is displayed")]
        public void PopupIsDisplayed()
        {
            
            Assert.That(herokuapp.IsPopupDisplayed, "Popup is not displayed");
        }

        [When("Close the popup")]
        public void ClosePopup()
        {
            herokuapp.PopupClose();
        }

        [Then("The popup is closed")]
        public void PopupIsClosed()
        {
            Assert.That(herokuapp.IsPopupDisplayed(), Is.EqualTo(false), "Popup is closed");
        }

    }
}
