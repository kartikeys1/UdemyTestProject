using System;
using TechTalk.SpecFlow;
using UdemyTestProject.PageObject;

namespace UdemyTestProject.StepDefinition
{
    [Binding]
    public class SignUpSteps
    {
        SignUpPage signUpPage;

        public SignUpSteps()
        {
            signUpPage = new SignUpPage();
        }


        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            signUpPage.NavigateToWebsite();
        }
        
        [Given(@"I enter the username")]
        public void GivenIEnterTheUsername()
        {
            signUpPage.EnterUserName();
        }
        
        [Given(@"I enter the email")]
        public void GivenIEnterTheEmail()
        {
            signUpPage.EnterEmail();
        }
        
        [Given(@"I enter the password")]
        public void GivenIEnterThePassword()
        {
            signUpPage.EnterPassword();
        }
        
        [When(@"I click on Sign up")]
        public void WhenIClickOnSignUp()
        {
            signUpPage.ClickSignUpButton();
        }
        
        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
           // ScenarioContext.Current.Pending();
        }
    }
}
