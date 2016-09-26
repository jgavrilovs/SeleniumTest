using System;
using System.Configuration;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SeleniumTest.Bindings
{
    [Binding]
    class CoreBindings
    {
        [Given(@"I have opened page with URL '(.*)'")]
        public void GivenIHaveOpenedPageWithURL(string url)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();

            driver.Navigate().GoToUrl(new Uri(url));
        }

        /// <summary>
        /// Takes URL from app.config based on key
        /// </summary>
        /// <param name="pageKey"></param>
        [Given(@"I have opened '(.*)' page")]
        public void GivenIHaveOpenedPage(string pageKey)
        {
            var pageUrl = ConfigurationManager.AppSettings[pageKey];

            if (string.IsNullOrWhiteSpace(pageUrl))
                throw new Exception($"{pageKey} page was not found in settings");

            var driver = ScenarioContext.Current.Get<IWebDriver>();

            driver.Navigate().GoToUrl(new Uri(pageUrl));
        }

    }
}
