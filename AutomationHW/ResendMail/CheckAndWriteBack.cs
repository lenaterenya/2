using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResendMail
{
    class CheckAndWriteBack
    {
        public void LogIn2(IWebDriver driver, WebDriverWait wait, string name2, string pass2, string url2)
        {
            driver.Url = url2;

            IWebElement username = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("login")));
            username.Clear();
            username.SendKeys(name2);
            username.SendKeys(Keys.Return);

            IWebElement password = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("password")));
            password.SendKeys(pass2);
            password.SendKeys(Keys.Return);

            IWebElement inboxEmail = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("ll-sj__normal")));
            


        }
    }
}
