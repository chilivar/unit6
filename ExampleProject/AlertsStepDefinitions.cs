using System;
using TechTalk.SpecFlow;

namespace ExampleProject
{
    [Binding]
    public class AlertsStepDefinitions
    {
        [When(@"I generate JS alert on the JavaScript Alert Page")]
        public void WhenIGenerateJSAlertOnTheJavaScriptAlertPage()
        {
            throw new PendingStepException();
        }
    }
}
