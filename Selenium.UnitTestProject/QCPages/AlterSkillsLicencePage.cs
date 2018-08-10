using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace Selenium.UnitTestProject.QCPages
{
    class AlterSkillsLicencePage
    {
        public static IWebElement element = null;

        /**
         * Returns the quote A text box
         * @param driver
         * @return
         */

        public static string getTextForHeader(IWebDriver driver)
        {
            string actualValue5 = driver.FindElement(By.XPath(".//*[@id='dash']/div/dl/dt[1]")).Text;
            return actualValue5;
        }

        public static IWebElement getNewCustomerCheckbox(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='dash']/div/dl/dd[3]/ul/li[2]/span"));
            return element;
        }

        public static string getTextForNewCustomerCheckboxUnticked(IWebDriver driver)
        {
            string actualValue6 = driver.FindElement(By.XPath("//*[@id='dash']/div/dl/dd[3]/ul/li[2]/span")).Text;
            return actualValue6;
        }

        public static string getTextForNewCustomerCheckboxTicked(IWebDriver driver)
        {
            string actualValue6 = driver.FindElement(By.XPath("//*[@id='dash']/div/dl/dd[3]/ul/li[1]/span")).Text;
            return actualValue6;
        }

        public static IWebElement quoteATextBox(IWebDriver driver)
        {

            element = driver.FindElement(By.Id("the_main_input"));
            return element;
        }


        /**
        * Returns the hierarchy threshold warning
        * 
        * 
        */

        public static string getHierarchyWarning(IWebDriver driver)
        {
            string actualValue7 = driver.FindElement(By.XPath("//*[@id='main']/div/table/tbody[1]/tr[3]/td[5]/span[5]")).Text;
            return actualValue7;
        }

        /**
         * Returns the ITpractice
         * @param driver
         * @return
         */
        public static IWebElement itPracticeSelect(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='main']/div/table/tbody[1]/tr[1]/th/span[1]/span"));
            return element;
        }


        /**
         * Returns All Vendors
         * @param driver
         * @return
         */
        public static IWebElement itAllVendors(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='main']/div/table/tbody[1]/tr[1]/th/span[3]/span[2]/span"));
            return element;
        }


        /**
         * 
         * returns Agile and Scrum Vendor
         * 
         */
        public static IWebElement agileAndScrumPremium(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='main']/div/table/tbody[1]/tr[3]/td[2]/input"));
            return element;
        }

        /**
         * 
         * returns Agile and Scrum Vendor's Quote A discount box
         * 
         */
        public static IWebElement QuoteADiscountBox(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='main']/div/table/tbody[1]/tr[3]/td[2]/input"));
            return element;
        }

        //

        /**
         * 
         * selects the SaveAndSend button
         * 
         */
        public static void clickOnSaveAndSendButton(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='main']/div/table/tfoot/tr/td[1]/ul/li[1]/a/span[1]"));
            element.Click();
        }

        /**
        * 
        * selects the Draft button
        * 
        */
        public static void clickOnDraftButton(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='saveasdraft_link']"));
            element.Click();
        }

        /**
       * 
       * selects the colour of the threshold warning box
       * 
       */
        public static String checkColourOfQuoteADiscountBox(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='main']/div/table/tbody[1]/tr[3]/td[2]/input"));
            string colour = element.GetCssValue("colour");
            return colour;
        }

    }
}
    
