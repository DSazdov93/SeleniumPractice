
namespace UltimateQA.Test
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;
    using System;
    using System.Linq;
    using System.Threading;

    public partial class HomePage
    {
        public void VerifyBothViewAllCoursesLinkLoadSamePage()
        {
            
            FirstViewAllCoursesLink.Click();
            string addressFirstLink = Driver.Title;
            Driver.Navigate().Back();

            SecondViewAllCoursesLink.Click();
            string addressSecondLink = Driver.Title;

           Assert.AreEqual(addressFirstLink, addressSecondLink);
        }

        public void VerifyTweeterLink()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            string expectedTitle = "Share a link on Twitter";
            js.ExecuteScript("arguments[0].click()", TweeterLink);
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            string actualTitle = Driver.Title;

            Assert.AreEqual(expectedTitle, actualTitle);
        }

        public void VerifyLinkedInLink()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            string expectedTitle = "LinkedIn";
            js.ExecuteScript("arguments[0].click()", LinkedInLinks[0]);
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            string actualTitle = Driver.Title;

            Assert.AreEqual(expectedTitle, actualTitle);
        }

        public void VerifyTumblrLinks()
        {
            string expectedTItle = "Tumblr";

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].click()", TumblrLinks[0]);
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            string actualTitle = Driver.Title;

            Assert.AreEqual(expectedTItle, actualTitle);
        }

        public void VerifyFacebookLink()
        {
            string expectedTitle = "Facebook";

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].click()", FacebookLinks[0]);
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            string actualTitle = Driver.Title;

            Assert.AreEqual(expectedTitle, actualTitle);
        }
    }
}
