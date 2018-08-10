using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.UnitTestProject
{
    class DashboardWithMeDeclinedPage
    {
        public static IWebElement element = null;

        /**
         * Returns the Header element
         * @param driver
         * @return
         */
        
        public static String getTextForHeader(IWebDriver driver)
        {
            string getTextForHeader = driver.FindElement(By.XPath("//*[@id='dash']/div/div/h2/text()")).Text;
            return getTextForHeader;
        }
        
    }
}
