using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumSessionPageObjects.Utilities;

namespace SeleniumSessionPageObjects.Pages
{
    public static class DemoSiteLoginPage
    {
        private static string DemoSiteLoginPageTitle { get => Driver.UIDriver.Title.ToString(); }
        private static IWebElement UserName { get => Driver.UIDriver.FindElement(By.Id("userName")); }
        private static IWebElement Password { get => Driver.UIDriver.FindElement(By.Id("password")); }
        private static IWebElement LoginButton { get => Driver.UIDriver.FindElement(By.CssSelector(".btn.btn-info")); }

        public static string GetDemoSiteLoginPageTitle()
        {
            return DemoSiteLoginPageTitle;
        }
        public static void EnterUserName(string username)
        {
            UserName.SendKeys(username);
        }

        public static void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }
        
        public static void Submit()
        {
            LoginButton.Submit();
        }
    }
}
