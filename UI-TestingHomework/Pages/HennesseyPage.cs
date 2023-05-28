using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_TestingHomework.Widgets;

namespace UI_TestingHomework.Pages
{
    public class HennesseyPage : BasePage
    {
        public HennesseyPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public static HennesseyPage Navigate(IWebDriver webDriver)
        {
            webDriver.Url = "https://www.hennesseyperformance.com/";
            return new HennesseyPage(webDriver);
        }

        public StartWidget GetStartWidget()
        {
            return new StartWidget(Driver);
        }

        public EndWidget GetEndWidget() 
        { 
            return new EndWidget(Driver);
        }
    }
}
