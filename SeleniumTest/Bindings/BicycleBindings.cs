using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumTest.Pages;
using TechTalk.SpecFlow;

namespace SeleniumTest.Bindings
{
    [Binding]
    class BicycleBindings
    {

        [Then(@"Bicycle start page should be displayed")]
        public void ThenBicycleStartPageShouldBeDisplayed()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            Assert.IsNotNull(page.Header);
        }

        [Then(@"Bicycle start page`s header should be '(.*)'")]
        public void ThenBicycleStartPageSHeaderShouldBe(string headerText)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);

            Assert.IsNotNull(page.Header);
            Assert.AreEqual(page.Header.Text, headerText);
        }

    }
}
