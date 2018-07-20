using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumSessionPageObjects.Utilities;
using System.Threading;

namespace SeleniumSessionPageObjects.Pages
{
    public static class DemoSiteStudentDetailsPage
    {
        private static string DemoSiteStudentDetailsPageTitle { get => Driver.UIDriver.Title.ToString(); }
        private static IWebElement StudentDetailsTable { get => Driver.UIDriver.FindElement(By.Id("studentsTable")); }
        private static IList<IWebElement> StudentTableElements { get => StudentDetailsTable.FindElements(By.TagName("td")); }  
        private static IList<IWebElement> StudentTableRows { get => StudentDetailsTable.FindElements(By.TagName("tr")); }

        public static string GetDemoSiteStudentDetailsPageTitle()
        {
            return DemoSiteStudentDetailsPageTitle;
        }
        public static List<string> GetStudentDetails()
        {
            return StudentTableElements.Select(sd => sd.Text).ToList();
        }

        public static List<string> GetStudentNames()
        {
            List<string> stuNames = new List<string> { };
            stuNames = StudentTableRows.Select(sr => sr.FindElements(By.TagName("td"))[0].Text).ToList();
            stuNames.RemoveAt(0);
            return stuNames;
        }
    }
}
