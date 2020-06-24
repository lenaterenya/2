using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace ConfigureSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
           // TimeSpan ts = new TimeSpan(0, 0, 50);
            IWebDriver driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(130));

            

            driver.Navigate().GoToUrl("https://www.mail.ru/");

            IWebElement username = driver.FindElement(By.Name("login"));
            username.SendKeys("test_auto2020");
            username.SendKeys(Keys.Return);

            IWebElement password = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("password")));
            password.SendKeys("Training1919");
            password.SendKeys(Keys.Return);

            IWebElement inbox = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/div[1]/table/tbody/tr/td[1]/a[2]/i")));
            Console.WriteLine(inbox.Text);
        }
    }
}
