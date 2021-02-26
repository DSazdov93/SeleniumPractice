
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UltimateQA.Test
{
    public partial class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        { }

      public IWebElement EmailField => Wait.Until(d => { return d.FindElement(By.Id("user_email")); });
      
      public IWebElement PasswordField => Wait.Until(d => { return d.FindElement(By.Id("user_password")); });
      
      public IWebElement SignInButton => Wait.Until(d => { return d.FindElement(By.Id("btn-signin")); });
      
      public IWebElement RemmemberMeCheckBox => Wait.Until(d => {return d.FindElement(By.Id("user_remember_me")); });
      
      public IWebElement ErrorMessage => Wait.Until(d => { return d.FindElement(By.XPath("//div/ul/li[@class='notifications-error__list-item']")); });
      
      public IWebElement HomeLink => Wait.Until(d => { return d.FindElement(By.XPath("//li/a[contains(text(), 'Home')]")); });
    }
}
