namespace UltimateQA.Test
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System.IO;
    using System.Reflection;

    [TestFixture]
    public class LoginPageTest
    {
        private IWebDriver driver;
        private LoginPage loginPage;
     
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://courses.ultimateqa.com/users/sign_in");
            loginPage = new LoginPage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void VerifyErrorMessageWithInvalidEmailAndPassword()
        {
            loginPage.VerifyLoginErrorMessageWithInvalidEmailAndPassword();
        }

        [Test]
        public void VerifyErrorMessageWithInvalidEmailAndEmptyPasswordField()
        {
            loginPage.VerifyLoginErrorMessageWithInvalidEmailAndEmptyPasswordField();
        }

        [Test]
        public void VerifyErrorMessageWithEmptyEmailFieldAndPasswordField()
        {
            loginPage.VerifyErrorMessageWithEmptyEmailFieldAndPasswordField();
        }

        [Test]
        public void LoginWithValidEmailAndPassword()
        {
            loginPage.LoginWithValidEmailAndPassword();
        }

        [Test]
        public void VerifyErrorMessageWithValidEmailAndInvalidPassword()
        {
            loginPage.VerifyErrorMessageWithValidEmailAndInvalidPassword();
        }

        [Test]
        public void VerifyErrorMessageWithInvalidEmailAndValidPassword()
        {
            loginPage.VerifyErrorMessageWithInvalidEmailAndValidPassword();
        }

        [Test]
        public void VerifyHomeLinkIfLoadHomePage()
        {
            loginPage.VerifyHomeLinkLoadHomePage();
        }
    }
}
