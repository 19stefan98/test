using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Subscription
{
    public class sub
    {
        public IWebDriver driver { get; set; }
        public string ResultSub { get; set; }
        public sub(IWebDriver driver)
        
        {
            this.driver = driver;
        }
        Random rand = new Random();

        public void ActionNum()
        {
            TimeSpan timeout = new TimeSpan(00, 00, 10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://itech:itech@saint-petersburg.sumtel.itech-test.ru/");

            var clickBlock = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class=\"subscribe-form\"]/form/div/label/input")));

            var s = "";
            for (int v = 0; v < 7; v++)
            {
                s += Convert.ToChar(rand.Next(97, 122));
            }

            clickBlock.SendKeys(s + "@send22u.info");
            clickBlock.Submit();
            ResultSub = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.ClassName("price__whole-amount"))).Text;
        }
    }
}
