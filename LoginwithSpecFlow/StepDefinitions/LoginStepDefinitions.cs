using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LoginwithSpecFlow.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        public IWebDriver driver;
        [Given(@"User is at the Login Page")]
        public void GivenUserIsAtTheLoginPage()
        {
            driver = new ChromeDriver();
            driver.Url = "http://localhost:51434/";
        }
        [When(@"User enter '([^']*)' and '([^']*)'")]
        public void WhenUserEnterAnd(string p0, string p1)
        {
            driver.FindElement(By.Id("username")).SendKeys("bhavya");
            driver.FindElement(By.Id("password")).SendKeys("indra");
        }

        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            driver.FindElement(By.CssSelector("body > div.container.body-content > div > div > div > div:nth-child(2) > form > div > center > div > div:nth-child(9) > div > input")).Click();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {

        }
    }
}