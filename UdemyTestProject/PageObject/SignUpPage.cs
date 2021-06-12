using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using UdemyTestProject.Utilities;

namespace UdemyTestProject.PageObject
{
    class SignUpPage
    {
        public SignUpPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement username => driver.FindElement(By.XPath("//input[@placeholder='Username']"));

        IWebElement email => driver.FindElement(By.XPath("//input[@placeholder='Email']"));

        IWebElement password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));

        IWebElement signUp => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > button"));

        public void EnterUserName()
        {
            Thread.Sleep(5000);
            username.SendKeys("UdemtTest");
        }

        public void EnterEmail()
        {
            email.SendKeys("udemy@demo.com");

        }

        public void EnterPassword()
        {
            password.SendKeys("PasswordSecure");

        }

        public void ClickSignUpButton()
        {
            signUp.Click();
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("http://angularjs.realworld.io/#/register");
        }
    }
}
