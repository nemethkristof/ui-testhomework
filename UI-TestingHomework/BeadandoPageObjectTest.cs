using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections;
using System.Xml.Linq;
using UI_TestingHomework.Pages;

namespace UI_TestingHomework
{
    public class BeadandoPageObjectTest : TestBase
    {
        [Test, TestCaseSource("TestData")]
        public void HennesseyNavTest(String linktext_to_go, String linktext_to_find)
        {
            IWebElement webelement = HennesseyPage.Navigate(Driver)
                .GetStartWidget()
                .NavigateTo(linktext_to_go)
                .GetEndWidget()
                .GetWebElement(linktext_to_find);

            Assert.IsNotNull(webelement);
        }


        static IEnumerable TestData()
        {
            var doc = XElement.Load(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory) + "\\data.xml");
            return
                from vars in doc.Descendants("testData")
                let linktext_to_go = vars.Attribute("linktext_to_go").Value
                let linktext_to_find = vars.Attribute("linktext_to_find").Value
                select new object[] { linktext_to_go, linktext_to_find };
        }
    }
}