using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace ExampleProject.Framework.Pages
{
    internal class HerokuappPage : Form
    {
        private IButton link = ElementFactory.GetButton(By.XPath("//a[text()='Entry Ad']"), "Button on main page");

        private ILabel label = ElementFactory.GetLabel(By.XPath("//div[@id='content']"), "Get content");
        private ILabel labelPopup = ElementFactory.GetLabel(By.XPath("//div[@class='modal']"), "Get content modal");
        private IButton clocePopup = ElementFactory.GetButton(By.XPath("//div[@class='modal-footer']"), "Click button");


        public HerokuappPage() : base(By.XPath("//*[@class='heading']"), "Welcome to the-internet")
        {
        }



        public void ButtonClick()
        {
            link.Click();
        }

        public bool IsLabelDisplayed()
        {
            return label.State.IsDisplayed;
        }

        public bool IsPopupDisplayed()
        {
            return labelPopup.State.WaitForDisplayed();
        }

        public void PopupClose()
        {
            clocePopup.Click();
        }

        
    }
}
