using OpenQA.Selenium;

namespace SeleniumTest.Pages
{
    public class BicycleClaimPage
    {
        private static IWebDriver _driver;

        private By header = By.CssSelector("h2.ecmt-grid-gutter-m-t");

        
        private By sectionBicycleCost = By.CssSelector("#bicycleCosts_section");
        private By sectionNotifier = By.CssSelector("#bicycleNotifier_section");

        public BicycleClaimPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement Header => _driver.FindElement(header);

        public IWebElement SectionEvent => _driver.FindElement(sectionEvent);
        public IWebElement SectionBicycleCost => _driver.FindElement(sectionBicycleCost);
        public IWebElement SectionNotifier => _driver.FindElement(sectionNotifier);

    }
}