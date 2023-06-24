using DataDrivenWithParameter.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenWithParameter.PageObject
{
    class DataDrivenWithParameterPage
    {
        public DataDrivenWithParameterPage()
        {
            driver = Hooks1.driver;

        }

        IWebDriver driver;
        internal static bool IsNewArticle;

        IWebElement SignUp => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(2) > li:nth-child(3) > a"));
        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
        IWebElement Email => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input"));
        IWebElement Password => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/input"));
        IWebElement SignUpButton => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/button"));
        IWebElement NewArticle => driver.FindElement(By.XPath("(//a[@class = 'nav-link']) [3] "));
        public void ClickOnSignUp()
        {
            SignUp.Click();
        }

        public void EnterUsername(string username)
        {
            Username.SendKeys(username);
        }

        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }

        public void ClickOnSignUpButton()
        {
            SignUpButton.Click();
        }

        public void NavigateToWebSite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public bool IsNewArticleDisplayed()
        {

            return NewArticle.Displayed;
        }




    }
}
