using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ResendMail
{
    class NewMailChecker
    {
        public string GetNewMails(WebDriverWait wait)
        {
            IWebElement search = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/div[1]/table/tbody/tr/td[1]/a[2]/i")));
            var newMails = search.Text;

            return newMails;
        }
    }
}
