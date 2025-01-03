using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace SeleniumFrameworkCsharp.DriverConfig
{
    public class DriverFactory
    {
        private DriverFactory() { }

        public static IWebDriver GetDriver(string browserName)
        {
            IWebDriver driver = null;
            if (browserName.Equals("Edge"))
            {
                driver = new EdgeDriver();
            }
            else if (browserName.Equals("Chrome"))
            {
                driver = new ChromeDriver();
            }
            return driver;

        }
    }
}
