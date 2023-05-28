using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework.Interfaces;

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
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string screeenshotname = baseDirectory + TestContext.CurrentContext.Test.Name + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + "_error.png";
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile(screeenshotname, ScreenshotImageFormat.Png);
                driver.Quit();
            }
            else
            {
                driver.Quit();
            }
        }
    }
}
