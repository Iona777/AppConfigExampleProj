using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace Selenium.UnitTestProject.QCPages
{
    class GetMyCustomerContactsPage
    {
        public static IWebElement element = null;

        /**
         * Returns the search box element
         * @param driver
         * @return
         */

        public static string getTextForHeader(IWebDriver driver)
        {
            string actualValue3 = driver.FindElement(By.XPath(".//*[@id='main']/div[1]/h2")).Text;
            return actualValue3;
        }

        public static IWebElement contactsSearchBox(IWebDriver driver)
        {
            element = driver.FindElement(By.Id("selected"));
            return element;
        }

        /**
         * Returns the delegate button
         * @param driver
         * @return
         */
        public static IWebElement delegateButton(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='main']/div[1]/div/label[2]"));
            return element;
        }

        
        /**
         * Returns the customer element
         * @param driver
         * @return
         */
        public static IWebElement contactSelect(IWebDriver driver)
        {        
             element = driver.FindElement(By.XPath("//a[@href='/Home/GetMyLicences?ContactId=5241159&ContactName=Beth%20Marshall&ContactEmail=bethmarshall2013%40hotmail.co.uk']"));
             return element;
        }

    }
}
    
