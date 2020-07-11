using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ResendMail
{
    class ResponseEmail
    {
        public void ResponseLetter(WebDriverWait wait)
        {
            IWebElement respond = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"app-canvas\"]/div/div[1]/div[1]/div/div[1]/div[2]/div[2]/table/tbody/tr/td/div[6]/span")));
            respond.Click();

            IWebElement body = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[15]/div[2]/div/div[1]/div[2]/div[3]/div[5]/div/div/div[2]/div[1]/div[1]")));
            body.SendKeys("Got Your Mail");
            body.SendKeys(Keys.Return);

            IWebElement send = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[15]/div[2]/div/div[2]/div[1]/span[1]")));
            send.Click();

            IWebElement close = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("button2__wrapper")));
            close.Click();

            IWebElement logout = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("PH_logoutLink")));
            logout.Click();

        }
    }
}
