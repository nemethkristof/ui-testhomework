using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_TestingHomework.Pages;

namespace UI_TestingHomework.Widgets
{
    public class EndWidget : BasePage
    {
        public EndWidget(IWebDriver webDriver) : base(webDriver)
        {
        }

        public IWebElement GetWebElement(String linktext_to_find)
        {
            return Driver.FindElement(By.LinkText(linktext_to_find));
        }
    }
}
