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
    public static class DemoSiteCreateStudentPage
    {
        private static IWebElement AddStudent { get => Driver.UIDriver.FindElement(By.CssSelector(".btn.btn-primary")); }
        private static IWebElement Name { get => Driver.UIDriver.FindElement(By.Id("name")); }
        private static IList<IWebElement> Class { get => Driver.UIDriver.FindElements(By.CssSelector("#class>option")); }
        private static IWebElement RollNo { get => Driver.UIDriver.FindElement(By.Id("roll-number")); }
        private static IList<IWebElement> GenderType { get => Driver.UIDriver.FindElements(By.CssSelector(".radio-inline>input")); }
        private static IWebElement Submit { get => Driver.UIDriver.FindElements(By.CssSelector(".btn.btn-primary"))[1]; }
       
        public static void AddStudentDetails()
        {
            AddStudent.Click();
        }
        public static void EnterName(string name)
        {
            Name.SendKeys(name);
        }
        public static void SelectClass(StudentClass studClass)
        {
            switch (studClass)
            {
                case StudentClass.I:
                    Class[1].Click();
                    break;
                case StudentClass.II:
                    Class[2].Click();
                    break;
                case StudentClass.III:
                    Class[3].Click();
                    break;
                case StudentClass.V:
                    Class[4].Click();
                    break;
                case StudentClass.VI:
                    Class[5].Click();
                    break;
                case StudentClass.VII:
                    Class[6].Click();
                    break;
                case StudentClass.VIII:
                    Class[7].Click();
                    break;
                case StudentClass.IX:
                    Class[8].Click();
                    break;
                case StudentClass.X:
                    Class[9].Click();
                    break;
                default:
                    break;
            }
        }
        public static void EnterRollNo(string rollNo)
        {
            RollNo.SendKeys(rollNo);
        }
        public static void SelectGender(Gender genderType)
        {
            switch (genderType)
            {
                case Gender.Female:
                    GenderType[0].Click();
                    break;
                case Gender.Male:
                    GenderType[1].Click();
                    break;
                case Gender.Others:
                    GenderType[2].Click();
                    break;
                default:
                    break;
            }
        }
        public static void SaveStudentDetails()
        {            
            Thread.Sleep(3000);
            Submit.Click();
            Thread.Sleep(2000);
            //Helper.WaitForElementVisibleByCssSelector(".btn.btn-primary", 2);
        }
    }
}