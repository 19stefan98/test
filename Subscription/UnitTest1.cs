using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Subscription
{
    [TestFixture]
    public class UnitTest1
    {
        IWebDriver driver;
        [SetUp] // вызывается перед каждым тестом
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [TearDown] // вызывается после каждого теста
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void Sub()
        {
            var actualSum = "sumtel@sumtel.ru";


            sub avto1 = new sub(driver);
            avto1.ActionNum();

            Assert.AreEqual(avto1.ResultSub, actualSum);
        }

    }
}
