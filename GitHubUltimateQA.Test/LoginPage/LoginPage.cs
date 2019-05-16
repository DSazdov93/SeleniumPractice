namespace UltimateQA.Test
{
    using NUnit.Framework;
    using OpenQA.Selenium;

    public partial class LoginPage
    {
        public void VerifyLoginErrorMessageWithInvalidEmailAndPassword()
        {
            string expectedResult = "Invalid Email or password.";
            EmailField.SendKeys("qualityAssurance@quality.qa");
            PasswordField.SendKeys("123456789");
            RemmemberMeCheckBox.Click();
            SignInButton.Click();
            string actualResult = ErrorMessage.Text;

            Assert.AreEqual(expectedResult, actualResult);
        }

        public void VerifyLoginErrorMessageWithInvalidEmailAndEmptyPasswordField()
        {
            string expectedResult = "Invalid Email or password.";
            EmailField.SendKeys("qualityAssurance@quality.qa");
            RemmemberMeCheckBox.Click();
            SignInButton.Click();
            string actualResult = ErrorMessage.Text;

            Assert.AreEqual(expectedResult, actualResult);
        } 

        public void VerifyErrorMessageWithEmptyEmailFieldAndPasswordField()
        {
            string expectedResult = "Invalid Email or password.";
            RemmemberMeCheckBox.Click();
            SignInButton.Click();
            string actualResult = ErrorMessage.Text;

            Assert.AreEqual(expectedResult, actualResult);
        }

        public void LoginWithValidEmailAndPassword()
        {
            string expectedResult = "Ultimate QA";
            EmailField.SendKeys("practiceqa@abv.bg");
            PasswordField.SendKeys("123456789");
            RemmemberMeCheckBox.Click();
            SignInButton.Click();
            string actualResult = Driver.Title;

            Assert.AreEqual(expectedResult, actualResult);
        }

        public void VerifyErrorMessageWithValidEmailAndInvalidPassword()
        {
            string expectedResult = "Invalid Email or password.";
            EmailField.SendKeys("practiceqa@abv.bg");
            PasswordField.SendKeys("wrongPassword");
            RemmemberMeCheckBox.Click();
            SignInButton.Click();
            string actualResult = ErrorMessage.Text;

            Assert.AreEqual(expectedResult, actualResult);
        }

        public void VerifyErrorMessageWithInvalidEmailAndValidPassword()
        {
            string expectedResult = "Invalid Email or password.";
            EmailField.SendKeys("qualityassurance@abv.bg");
            PasswordField.SendKeys("123456789");
            RemmemberMeCheckBox.Click();
            SignInButton.Click();
            string actualResult = ErrorMessage.Text;

            Assert.AreEqual(expectedResult, actualResult);
        }

        public void VerifyHomeLinkLoadHomePage()
        {
            string expectedResult = "Home - Ultimate QA";
            HomeLink.Click();
            string actualResult = Driver.Title;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
