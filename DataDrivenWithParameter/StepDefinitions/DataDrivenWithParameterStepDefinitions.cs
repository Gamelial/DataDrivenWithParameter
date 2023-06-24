using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using DataDrivenWithParameter.PageObject;

namespace DataDrivenWithParameter.StepDefinitions
{
    [Binding]
    public class DataDrivenWithParameterStepDefinitions
    {
        DataDrivenWithParameterPage dataDrivenWithParameterPage;

        public DataDrivenWithParameterStepDefinitions()
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();
        }



        [Given(@"I navigate to ""([^""]*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterPage.NavigateToWebSite(url);
        }

        [Given(@"I click on Sign up")]
        public void GivenIClickOnSignUp()
        {
            dataDrivenWithParameterPage.ClickOnSignUp();
        }

        [Given(@"I enter my Username text ""([^""]*)""")]
        public void GivenIEnterMyUsernameText(string username)
        {
            dataDrivenWithParameterPage.EnterUsername(username);
        }

        [Given(@"I enter my email text ""([^""]*)""")]
        public void GivenIEnterMyEmailText(string email)
        {
            dataDrivenWithParameterPage.EnterEmail(email);
        }

        [Given(@"I enter my password text ""([^""]*)""")]
        public void GivenIEnterMyPasswordText(string password)
        {
            dataDrivenWithParameterPage.EnterPassword(password);
        }


        [When(@"I click on the Sign up button")]
        public void WhenIClickOnTheSignUpButton()
        {
            dataDrivenWithParameterPage.ClickOnSignUpButton();
        }


        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(dataDrivenWithParameterPage.IsNewArticleDisplayed);
        }

    }
}

