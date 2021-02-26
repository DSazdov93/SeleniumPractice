namespace UltimateQA.Test
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public partial class ManyElementsPage
    {
        private Actions action;

        public void VerifyGreenButtonsIfLoadOnePage()
        {
            
            for (int i = 0; i < GreenButtons.Count(); i++)
            {
                string expectedTitle = "Complicated Page - Ultimate QA";
                GreenButtons[i].Click();
                string actualTitle = Driver.Title;
                Assert.AreEqual(expectedTitle, actualTitle);
            }
        }

        public void VerifyTweeterLinksIfLoadOnePage()
        {
            for (int i = 0; i < TweeterFollowLinks.Count(); i++)
            {
                string expectedTitle = "Nikolay Advolodkin (@Nikolay_A00) | Twitter";
                TweeterFollowLinks[i].Click();
                string actualTitle = Driver.Title;
                Driver.Navigate().Back();

                Assert.AreEqual(expectedTitle, actualTitle);
            }
        }

        public void VerifyFacebookLinksIfLoadOnePage()
        {
            for (int i = 0; i < FacebookFollowLinks.Count(); i++)
            {
                string expectedTitle = "Ultimate QA - Home | Facebook";
                IWebElement link = FacebookFollowLinks[i];
                link.Click();
                string actualTitle = Driver.Title;
                Driver.Navigate().Back();

                Assert.AreEqual(expectedTitle, actualTitle);
            }
        }

        public string SolveFirstTask()
        {
            string[] getNumber = FirstTask.Text.Split(" + ");
            int addNumber = int.Parse(getNumber[0]) + int.Parse(getNumber[1]);
            string solvedTask = addNumber.ToString();
            return solvedTask;
        }

        public string GetHintsAfterClickSubmitButton()
        {
            string text = TextAfterSubmitData.Text;
            return text;
        }

        public bool GetHintsForEmptyFields()
        {
            bool isEqual = false;
            
            IList<IWebElement> getFieldsThatShouldBeFill = Driver.FindElements(By.XPath(@"//div[@id=""et_pb_contact_form_0""]/div/ul/li"));

            string nameField = Name.GetAttribute("value");
            string emailField = EmailAddress.GetAttribute("value");
            string messageField = Message.GetAttribute("value");
            string captchaField = FirstCaptcha.GetAttribute("value");

            List<string> expectedHints = new List<string>();
            List<string> actualHints = new List<string>(); 

            if (nameField == string.Empty)
            {
                expectedHints.Add("Name");
            }

            if (emailField == string.Empty)
            {
                expectedHints.Add("Email Address");
            }

            if (messageField == string.Empty)
            {
                expectedHints.Add("Message");
            }

            if (captchaField == string.Empty)
            {
                expectedHints.Add("Captcha");
            }

            for (int i = 0; i < getFieldsThatShouldBeFill.Count; i++)
            {
                actualHints.Add(getFieldsThatShouldBeFill[i].Text);
            }

            if (expectedHints.SequenceEqual(actualHints))
            {
                isEqual = true;
            }

            return isEqual;
        }

        public void MoveToElement()
        {
            string expectedResult = "Submit";
            
            action = new Actions(Driver);
            action.MoveToElement(FirstSubmitButton);
            string actualResult = FirstSubmitButton.Text;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}