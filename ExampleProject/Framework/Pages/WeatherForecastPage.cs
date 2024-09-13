using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;


namespace ExampleProject.Framework.Pages
{
    internal class WeatherForecastPage : Form
    {
        private ITextBox locationName = ElementFactory.GetTextBox(By.XPath("//*[@Class='header-loc']"), "Location name");
        private ILabel header = ElementFactory.GetLabel(By.XPath("//*[@class='header-logo']"), "Button go back");

        public WeatherForecastPage() : base(By.XPath("//div[contains(@Class, 'today-forecast-card')]"), "WeatherForecast")
        {
        }

        public string GetLocationName()
        {
            return locationName.Text;
        }

        public void ClickOnHeader()
        {
            header.Click();
        }

       



    }
}
