using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.UnitTestProject
{
    class GetMyCustomersPage
    {
        public static IWebElement element = null;

        /**
         * Returns the search box element
         * @param driver
         * @return
         */
        public static IWebElement customerSearchBox(IWebDriver driver)
        {
            element = driver.FindElement(By.Id("selected"));
            return element;
        }

        public static string getTextForHeader(IWebDriver driver)
        {
            string actualValue2 = driver.FindElement(By.XPath(".//*[@id='main']/div[2]/h2")).Text;
            return actualValue2;
        }
        /**
         * TO DO - ADD IN A CHECK YOU ARE ON THE RIGHT PAGE LIKE WITH THE END ASSERT IN SMOKE TEST
         */
        public static IWebElement customerSelect(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//a[@href='/Home/GetMyCustomerContacts?CustomerId=3402211&CustomerName=TEST QC CUSTOMER&customerAddress=Test building, Town, DY12 3AY']"));
            return element;
        }


    }
}
