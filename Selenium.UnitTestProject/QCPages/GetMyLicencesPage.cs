using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace Selenium.UnitTestProject.QCPages
{
    class GetMylicencesPage
    {
        public static IWebElement element = null;

        /**
	 * Returns the search box element
	 * @param driver
	 * @return
	 */
        public static string getTextForHeader(IWebDriver driver)
        {
            string actualValue4 = driver.FindElement(By.XPath(".//*[@id='main']/div[1]/h2")).Text;
            return actualValue4;
        }

        public static IWebElement blankTemplate(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='main']/div[2]/ul/li[1]/a"));
            return element;
        }


        /**
         * Returns the customer element
         * @param driver
         * @return
         */
        public static IWebElement customerSelect(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='reducing']/ul/li/a"));
            return element;
        }
    }
}
    
