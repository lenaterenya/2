using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ResendMail
{
    class Login
    {
        public void LogIn(IWebDriver driver, WebDriverWait wait, string name, string pass, string url)
        {
            driver.Url = url;

            IWebElement username = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("login")));
            username.Clear();
            username.SendKeys(name);
            username.SendKeys(Keys.Return);

            IWebElement password = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("password")));
            password.SendKeys(pass);
            password.SendKeys(Keys.Return);
        }
    }
}
