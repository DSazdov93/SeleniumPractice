namespace UltimateQA.Test
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Support.UI;
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Threading;

    [TestFixture]
    public class ManyElementsPageTest
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private ManyElementsPage manyElementsPage;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.ultimateqa.com/complicated-page/");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            manyElementsPage = new ManyElementsPage(driver);
            
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void VerifyGreenButtonsLoadSamePage()
        {
            manyElementsPage.VerifyGreenButtonsIfLoadOnePage();
        }

        [Test]
        public void VerifyAllTweeterFollowLinksLoadSamePage()
        {

            manyElementsPage.VerifyTweeterLinksIfLoadOnePage();
        }

        [Test]
        public void VerifyAllFacebookFollowLinksLoadSamePage()
        {
            manyElementsPage.VerifyFacebookLinksIfLoadOnePage();
        }

        [Test]
        public void VerifyTextWithAllFilledFields()
        {
            string expectedText = "Thanks for contacting us";
            manyElementsPage.Name.SendKeys("Daniel");
            manyElementsPage.EmailAddress.SendKeys("automationTest@test.test");
            manyElementsPage.Message.SendKeys("Automation quality assurance");
            manyElementsPage.FirstCaptcha.SendKeys(manyElementsPage.SolveFirstTask());
            manyElementsPage.FirstSubmitButton.Click();
            string actualText = manyElementsPage.GetHintsAfterClickSubmitButton();

            Assert.AreEqual(expectedText, actualText);
        }

        [Test]
        public void VerifyTextWithoutFilledFields()
        {
            string expectedText = "Please, fill in the following fields:";
            manyElementsPage.FirstSubmitButton.Click();
            string actualText = manyElementsPage.GetHintsAfterClickSubmitButton();

            Assert.AreEqual(expectedText, actualText);
        }

        [Test]
        public void VerifyTextWithoutNameFilledField()
        {
            string expectedText = "Please, fill in the following fields:";
            manyElementsPage.EmailAddress.SendKeys("automationTest@test.test");
            manyElementsPage.Message.SendKeys("Automation quality assurance");
            manyElementsPage.FirstCaptcha.SendKeys(manyElementsPage.SolveFirstTask());
            manyElementsPage.FirstSubmitButton.Click();
            string actualText = manyElementsPage.GetHintsAfterClickSubmitButton();

            Assert.AreEqual(expectedText, actualText);
        }

        [Test]
        public void VerifyTextOnHintsWithFilledNameField()
        {
            manyElementsPage.Name.SendKeys("Quality Assurance");
            manyElementsPage.FirstSubmitButton.Click();

            Assert.That(manyElementsPage.GetHintsForEmptyFields());
        }

        [Test]
        public void VerifyTextOnHintsWithFilledNameAndEmailField()
        {
            manyElementsPage.Name.SendKeys("Quality Assurance");
            manyElementsPage.EmailAddress.SendKeys("qualityAssurance@automation.com");
            manyElementsPage.FirstSubmitButton.Click();

            Assert.That(manyElementsPage.GetHintsForEmptyFields());
        }

        [Test]
        public void VerifyTextOnHintsWithFilledNameEmailAndMessageField()
        {
            manyElementsPage.Name.SendKeys("Quality Assurance");
            manyElementsPage.EmailAddress.SendKeys("qualityAssurance@automation.com");
            manyElementsPage.Message.SendKeys("QA => QualityAssurance!");
            manyElementsPage.FirstSubmitButton.Click();

            Assert.That(manyElementsPage.GetHintsForEmptyFields());
        }

        [Test]
        public void VerifyTextOnHintsWithFilledNameAndCaptchaField()
        {
            manyElementsPage.Name.SendKeys("Quality Assurance");
            manyElementsPage.FirstCaptcha.SendKeys(manyElementsPage.SolveFirstTask());
            manyElementsPage.FirstSubmitButton.Click();

            Assert.That(manyElementsPage.GetHintsForEmptyFields());
        }

        [Test]
        public void VerifyTextOnSubmitButton()
        {
            manyElementsPage.MoveToElement();
        }
    }
}
