using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SeleniumTest.Bindings
{
    [Binding]
    public sealed class InitialTestBindings
    {

        [Then("search page should be visible")]
        public void SearchPageIsVisible()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();

            var element = driver.FindElement(By.Id("lst-ib"));
            Assert.IsNotNull(element);
        }
    }
}
