using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MercuryReg
{
    class TempMail
    {
        public IWebDriver driver { set; get; }
        public string s { set; get; }
        public string pruf { set; get; }
        TimeSpan timeout = new TimeSpan(00, 00, 45);

        public TempMail(IWebDriver driver, string s)
        {
            this.driver = driver;
            this.s = s;
        }

        public void Action()
        {
            driver.Navigate().GoToUrl("https://temp-mail.org/ru/option/change");
            var mail = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.Name("mail")));
            mail.SendKeys(s);
            var submit = driver.FindElement(By.Id("postbut"));
            submit.Click();

            driver.Navigate().GoToUrl("https://temp-mail.org/");
            var cont = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"mails\"]/tbody/tr/td[1]")));
            pruf = driver.FindElement(By.XPath("//*[@id=\"mails\"]/tbody/tr/td[1]")).Text;
        }
    }
}
