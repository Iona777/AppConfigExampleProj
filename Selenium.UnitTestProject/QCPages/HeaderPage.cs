using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;



namespace Selenium.UnitTestProject.QCPages
{
    class HeaderPage
    {
        public static IWebElement element = null;
          
        public static IWebElement quotationsMenuOption(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='head']/div[1]/ul/li[3]/span"));
            return element;
        }

        public static IWebElement salesPortalMenuOption(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='head']/div[1]/ul/li[3]/ul/li[1]/a"));
            return element;
        }

    }
}
    
