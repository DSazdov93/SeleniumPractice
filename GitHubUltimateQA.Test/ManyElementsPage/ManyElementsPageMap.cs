namespace UltimateQA.Test
{
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public partial class ManyElementsPage : BasePage
    {

        public ManyElementsPage(IWebDriver driver) : base(driver)
        { }
        
        // Green Button
        public IList<IWebElement> GreenButtons => Wait.Until(d => { return d.FindElements(By.XPath("//div/a[contains(text(),'Button')]")); });


        // Tweeter Links
        public IList<IWebElement> TweeterFollowLinks => Wait.Until(d => { return d.FindElements(By.XPath(@"//ul/li/a[@title='Follow on Twitter']")); });
        
        // Facebook Links
        public IList<IWebElement> FacebookFollowLinks => Wait.Until(d => { return d.FindElements(By.XPath(@"//li/a[@title='Follow on Facebook']")); });

        // Fill Form
        public IWebElement Name => Driver.FindElement(By.Id("et_pb_contact_name_0"));

        public IWebElement EmailAddress => Driver.FindElement(By.Id("et_pb_contact_email_0"));

        public IWebElement Message => Driver.FindElement(By.Id("et_pb_contact_message_0"));

        // Find Number Of Task
        
        public IWebElement FirstTask => Driver.FindElement(By.XPath("(//span[@class='et_pb_contact_captcha_question'])[1]"));

        public IWebElement SecondTask => Driver.FindElement(By.XPath("(//span[@class='et_pb_contact_captcha_question'])[2]"));

        public IWebElement ThirdTask => Driver.FindElement(By.XPath("(//span[@class='et_pb_contact_captcha_question'])[3]"));

        // Captcha
        public IWebElement FirstCaptcha => Driver.FindElement(By.XPath("(//input[@class='input et_pb_contact_captcha'])[1]"));

        public IWebElement SecondCaptcha => Driver.FindElement(By.XPath("(//input[@class='input et_pb_contact_captcha'])[2]"));

        public IWebElement ThirdCaprcha => Driver.FindElement(By.XPath("(//input[@class='input et_pb_contact_captcha'])[3]"));

        // Submit Buttons
        public IWebElement FirstSubmitButton => Wait.Until(d => { return d.FindElement(By.XPath("(//*[@class='et_pb_contact_submit et_pb_button'])[1]")); });

        public IWebElement SecondSubmitButton => Wait.Until(d => { return d.FindElement(By.XPath("(//*[@class='et_pb_contact_submit et_pb_button'])[2]")); });

        public IWebElement ThirdSubmitButton => Wait.Until(d => { return d.FindElement(By.XPath("(//*[@class='et_pb_contact_submit et_pb_button'])[3]")); });

        // Text after click submit button
        public IWebElement TextAfterSubmitData => Wait.Until(d => { return d.FindElement(By.XPath(@"//div[@id='et_pb_contact_form_0']/div/p"));});
    }
}
