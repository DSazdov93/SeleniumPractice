
namespace UltimateQA.Test
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;
    using System;
    using System.IO;
    using System.Reflection;
    using System.Threading;

    public class AutomationExercisesPageTest
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private AutomationExercisesPage automationExercisesPage;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.ultimateqa.com/automation/");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            automationExercisesPage = new AutomationExercisesPage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void PageWithManyElementsLink()
        {
            automationExercisesPage.BigPageWithManyElementsLink.Click();
        }

        [Test]
        public void FakeLandingPageLink()
        {
            automationExercisesPage.FakeLandingPageLink.Click();
        }

        [Test]
        public void PricingPageLink()
        {
            automationExercisesPage.FakePricingPageLink.Click();
        }

        [Test]
        public void FillFormsLink()
        {
            automationExercisesPage.FillOutFormsLink.Click();
        }

        [Test]
        public void LearnHowToAutomateLink()
        {
            automationExercisesPage.LearnHowToAutomateLink.Click();
        }

        [Test]
        public void LoginAutomationLink()
        {
            automationExercisesPage.LoginAutomationLink.Click();
        }

        [Test]
        public void InteractionsWithSimpleElements()
        {
            automationExercisesPage.InteractionsWithSimpleElements.Click();
        }
    }
}
