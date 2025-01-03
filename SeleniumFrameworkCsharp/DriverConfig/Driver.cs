using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Configuration;

namespace SeleniumFrameworkCsharp.DriverConfig
{
    public class Driver
    {
        private Driver() { }
        public static void InitDriver()
        {
            if (DriverManager.GetDriver() == null)
            {
                IWebDriver driver = DriverFactory.GetDriver("Edge");
                DriverManager.SetDriver(driver);
                DriverManager.GetDriver().Navigate().GoToUrl("http://www.google.in");
                DriverManager.GetDriver().Manage().Window.Maximize();
            }
        }
        public static void QuitDriver()
        {
            if (DriverManager.GetDriver() != null)
            {
                DriverManager.GetDriver().Quit();
                DriverManager.SetDriver(null);
            }
        }
    }
}
