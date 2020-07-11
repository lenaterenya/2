using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ResendMail
{
    class MailLoginAutomation
    {
       static void Main(string[] args)
        {
            var login = new Login();
            //var newMailChecker = new NewMailChecker();
            IWebDriver driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(130));
            var writeNewMail = new WriteNewMail();
            var checkincomeletter = new CheckIncomeLetter();
            var responseEmail = new ResponseEmail();
            var checkFinalMail = new CheckFinalMail();

            login.LogIn(driver, wait, "test_auto2020", "Training1919", "https://mail.ru/");
            writeNewMail.WriteEmail(wait);

            checkincomeletter.LogIn2(driver, wait, "secondmail20", "Training2020", "https://mail.ru/");
            responseEmail.ResponseLetter(wait);
            login.LogIn(driver, wait, "test_auto2020", "Training1919", "https://mail.ru/");
            checkFinalMail.LastMailCheck(driver, wait);
        }
    }
}