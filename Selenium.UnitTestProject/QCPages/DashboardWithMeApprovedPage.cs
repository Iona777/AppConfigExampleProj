using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.UnitTestProject
{
    class DashboardWithMeApprovedPage
    {
        public static IWebElement element = null;

        /**
         * Returns the search box element
         * @param driver
         * @return
         */
        
        public static String getTextForApprovedBody(IWebDriver driver)
        {
            string getTextForApprovedBody = driver.FindElement(By.XPath(".//*[@id='dash']/div/table/tbody/tr/td")).Text;
            return getTextForApprovedBody;
        }
        public static IWebElement getApprovedLicence(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(".//*[@id='dash']/div/table/tbody/tr/td[1]/a/span[1]"));
            return element;
        }
        public static String getTextForApprovedLicenceLine(IWebDriver driver)
        {
            string getTextForApprovedLicenceLine = driver.FindElement(By.XPath(".//*[@id='dash']/div/table/tbody/tr/td[1]/a/span[1]")).Text;
            return getTextForApprovedLicenceLine;
        }

        public static IWebElement clickSuspendApprovedLicence(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(".//*[@id='dash']/div/table/tbody/tr[1]/td[7]/a/span"));
            return element;
        }



    }
}
