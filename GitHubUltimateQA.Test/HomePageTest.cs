
namespace UltimateQA.Test
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Support.UI;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Threading;

    public class HomePageTest
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private HomePage homePage;
        private Actions action;

        [SetUp]
        public void SetUp()
        {
            
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.ultimateqa.com");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            homePage = new HomePage(driver);
            action = new Actions(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
        
        [Test]
        public void CourseLink()
        {
            homePage.CoursesLink.Click();
        }

        [Test]
        public void SeleniumResourcesLink()
        {
            homePage.SeleniumResourcesLink.Click(); 
        }

        [Test]
        public void AutomationExercesesLink()
        {
            homePage.AutomationExercesesLink.Click();
        }

        [Test]
        public void BlogLink()
        {
            homePage.BlogLink.Click();
        }
        
        [Test]
        public void ViewAllCoursesFirstLink()
        {
            homePage.FirstViewAllCoursesLink.Click();
        }

        [Test]
        public void ViewAllCoursesSecondLink()
        {
            homePage.SecondViewAllCoursesLink.Click();
        }

        [Test]
        public void VerifyBothViewAllCoursesLinkLoadOnePage()
        {
            homePage.VerifyBothViewAllCoursesLinkLoadSamePage();
        }

        [Test]
        public void CompleteSeleniumWebDriverWithCSharpLink()
        {
            action.MoveToElement(homePage.CompleteSeleniumWebDriverLink);
            action.Perform();
            homePage.CompleteSeleniumWebDriverLink.Click();
        }

        [Test]
        public void SauceLabsAdvancedTopicsLink()
        {
            action.MoveToElement(homePage.CompleteSeleniumWebDriverLink);
            action.Perform();
            homePage.SauceLabsLink.Click();
        }
        
        [Test]
        public void VerifyTweeterLink()
        {
            homePage.VerifyTweeterLink();
        }

        [Test]
        public void VerifyLinkedInLink()
        {
            homePage.VerifyLinkedInLink();
        }

        [Test]
        public void VerifyTumblrLink()
        {
            homePage.VerifyTumblrLinks();
        }

        [Test]
        public void VerifyFacebookLink()
        {
            homePage.VerifyFacebookLink();
        }
    }

}



