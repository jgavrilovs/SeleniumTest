using OpenQA.Selenium;

namespace SeleniumTest.PageObjects.Sections
{
    public class WhatHasHappenedSection
    {
        private static IWebDriver _driver;

        private static IWebElement _section;

        public WhatHasHappenedSection(IWebDriver driver)
        {
            _driver = driver;

            _section = _driver.FindElement(SectionLocator);
        }

        private static readonly By SectionLocator = By.CssSelector("#eventForm_section");


    }
}
