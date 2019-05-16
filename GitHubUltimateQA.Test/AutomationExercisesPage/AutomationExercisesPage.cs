namespace UltimateQA.Test
{
    using OpenQA.Selenium;
    using System.Collections.Generic;
    using System.Linq;

    public class AutomationExercisesPage : BasePage
    {
        public AutomationExercisesPage(IWebDriver driver) : base(driver)
        { }
        
        public IWebElement BigPageWithManyElementsLink => Driver.FindElement(By.XPath(@"//li/a[contains(text(),'Big page with many elements')]"));

        public IWebElement FakeLandingPageLink => Driver.FindElement(By.XPath(@"//li/a[contains(text(),'Fake Landing Page')]"));

        public IWebElement FakePricingPageLink => Driver.FindElement(By.XPath(@"//li/a[contains(text(),'Fake Pricing Page')]"));

        public IWebElement FillOutFormsLink => Driver.FindElement(By.XPath(@"//li/a[contains(text(),'Fill out forms')]"));

        public IWebElement LearnHowToAutomateLink => Driver.FindElement(By.XPath(@"//li/a[contains(text(),'Learn how to automate an application that evolves over time')]"));

        public IWebElement LoginAutomationLink => Driver.FindElement(By.XPath(@"//li/a[contains(text(),'Login automation')]"));

        public IWebElement InteractionsWithSimpleElements => Driver.FindElement(By.XPath(@"//li/a[contains(text(),'Interactions with simple elements')]"));
    }
}
