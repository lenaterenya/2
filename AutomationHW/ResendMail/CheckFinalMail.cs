using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;


namespace ResendMail
{
    class CheckFinalMail
    {
        public void LastMailCheck (IWebDriver driver, WebDriverWait wait)

        {
            IWebElement inboxEmail = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("ll-sj__normal")));
            ReadOnlyCollection<IWebElement> webElements = driver.FindElements(By.ClassName("ll-sj__normal"));

            foreach (var webElement in webElements)
            {
                if (webElement.Text == "Test Email")
                {
                    Console.WriteLine("Letter is received");
                }

            }


        }
    }
}

