using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_TestingHomework.Pages;

namespace UI_TestingHomework.Widgets
{
    public class StartWidget : BasePage
    {
        public StartWidget(IWebDriver webDriver) : base(webDriver)
        {
        }

        public HennesseyPage NavigateTo(String linktext_to_go)
        {
            Driver.FindElement(By.LinkText(linktext_to_go)).Click();
            return new HennesseyPage(Driver);
        }
    }
}
