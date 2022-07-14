using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium;

namespace Phase4Section1._4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var driver = new ChromeDriver();


            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:51434/");
            By username = By.Id("username");
            IWebElement EMAIL = driver.FindElement(username);
            EMAIL.SendKeys("bhavya");
            By password = By.Id("password");
            IWebElement PASS = driver.FindElement(password);
            PASS.SendKeys("indra");
            By LOGIN = By.CssSelector("body > div.container.body-content > div > div > div > div:nth-child(2) > form > div > center > div > div:nth-child(9) > div > input");
            IWebElement LOG = driver.FindElement(LOGIN);
            LOG.Click();
            By ORDER = By.Name("compare");
            driver.FindElement(ORDER).Click();
           

        }
    }
}
