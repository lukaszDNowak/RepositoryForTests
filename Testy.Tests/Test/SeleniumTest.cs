using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace Testy.Tests
{
    class SeleniumTest
    {
        IWebDriver _driver;
        [SetUp]
        public void StartBrowser()
        {
            _driver = new FirefoxDriver();
        }
        [Test]
        public void SumTestSelenium()
        { 
            var firstDigit = "1";
            var secondDigit = 2;

            _driver.Navigate().GoToUrl("http://lukasznowak.azurewebsites.net/");
            var firstDigitLabel = _driver.FindElement(By.Name("a"));
            firstDigitLabel.SendKeys(firstDigit+"");
            var secondDigitLabel = _driver.FindElement(By.Name("b"));
            secondDigitLabel.SendKeys(secondDigit + Keys.Enter);

            new WebDriverWait(_driver, TimeSpan.FromSeconds(10))
            .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlMatches("http://lukasznowak.azurewebsites.net/Home/Sum"));

            var score = _driver.FindElement(By.Id("score"));
            new WebDriverWait(_driver, TimeSpan.FromSeconds(10))
            .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElement(score,"3"));

        }
        [TearDown]
        public void CloseBrowser()
        {
            _driver.Close();
        }

        [Test]
        public void LoginTestSelenium()
        {
            var userEmail = "Lukasz@Nowak.pl";
            var pass = "ZaliczeniePrzedmiotuNa5:)";

            _driver.Navigate().GoToUrl("http://lukasznowak.azurewebsites.net/Account/Login");
            _driver.FindElement(By.Id("loginLink")).Click();

            var email = _driver.FindElement(By.Id("Email"));
            email.SendKeys(userEmail);

            var password = _driver.FindElement(By.Id("Password"));
            password.SendKeys(pass);

            _driver.FindElement(By.Id("saveBtn")).Click();

            new WebDriverWait(_driver, TimeSpan.FromSeconds(10))
            .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlMatches("http://lukasznowak.azurewebsites.net/"));

        }
    }
}

