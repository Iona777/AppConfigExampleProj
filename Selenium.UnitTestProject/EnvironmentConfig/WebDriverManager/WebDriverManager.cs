using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
namespace Selenium.UnitTestProject.WebDriverManager
{
    public static class WebDriverManager
    {
        public static IWebDriver GetWebDriverForConfig()
        {
            IWebDriver driver;
            switch(EnvironmentConfig.ConfigurationWrapper.Browser())
            {
                case "FireFox":
                    driver = GetWebDriverFireFox();
                    break;
                case "IE":
                    driver = GetWebDriverFireIE();
                    break;
                case "Chrome":
                    driver = GetWebDriverForChrome();
                    break;
                case "Headless":
                    driver = GetHeadlessWebDriverForChrome();
                    break;
                 default:
                    throw new Exception("Unknown browser:" + EnvironmentConfig.ConfigurationWrapper.Browser());

            }

            
            driver.Manage().Timeouts().ImplicitWait = 
                    TimeSpan.FromSeconds(
                        EnvironmentConfig.ConfigurationWrapper.WebDriverTimeout()
                        );
            driver.Manage().Window.Maximize();
            driver.Url = EnvironmentConfig.ConfigurationWrapper.GetURLFromEnvironmentKey();
            if ( )
            { }
            else
            { driver.Url = EnvironmentConfig.ConfigurationWrapper.GetURLFromEnvironmentKey(); }
            return driver;
        }

        private static IWebDriver GetWebDriverForChrome()
        {
            IWebDriver driver;
            driver = new ChromeDriver();
            return driver;
        }
        private static IWebDriver GetHeadlessWebDriverForChrome()
        {
            IWebDriver driver;
            driver = new ChromeDriver();
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            return driver;
        }
        private static IWebDriver GetWebDriverFireFox()
        {
            IWebDriver driver;
            driver = new FirefoxDriver();
            return driver;
        }

        private static IWebDriver GetWebDriverFireIE()
        {
            IWebDriver driver;
            driver = new InternetExplorerDriver();
            return driver;
        }

    }
}
