using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace UI_TestingHomework
{
    [TestFixture]
    public class TestBase
    {
        IWebDriver driver;

        public IWebDriver Driver
        {
            get
            { return driver; }
            set
            {
                driver.Quit();
                driver = value;
            }
        }

        [SetUp]
        protected void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--lang=hu");

            driver = new ChromeDriver(options);
        }

        [TearDown]
        protected void Teardown()
        {
            driver.Quit();
        }
    }
}
