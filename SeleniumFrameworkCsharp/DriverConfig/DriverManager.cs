using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumFrameworkCsharp.DriverConfig
{
    public class DriverManager
    {
        private DriverManager() { }

        private static ThreadLocal<IWebDriver> threadLocal = new ThreadLocal<IWebDriver>();
        public static IWebDriver GetDriver()
        {
            return threadLocal.Value;
        }
        public static void SetDriver(IWebDriver driver)
        {
            threadLocal.Value = driver;
        }
    }
}
