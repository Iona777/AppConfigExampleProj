using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.UnitTestProject
{
    class ManagerApprovalPage
    {
        public static IWebElement element = null;

        public static string getTextForHeader(IWebDriver driver)
        {
            string actualvalue = driver.FindElement(By.XPath("//*[@id='main']/div[1]/h2")).Text;
            return actualvalue;
        }

        /**
        * 
        * selects the first manager name tickbox
        * 
        */
        public static void clickOnManagerNameTickbox(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='approval']/div[2]/div[1]/div[2]/ul/li[2]/span[1]/span[1]/i"));
            element.Click();
        }

        /**
        * 
        * selects the send to manager button
        * 
        */
        public static void clickOnSendToManagerButton(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='Save_Submit_To_Manager_link']/span[1]"));
            element.Click();
        }

        


        /*   public static IWebElement getBAPSSection(IWebDriver driver)
           {
               element = driver.FindElement(By.XPath(".//*[@id='how_to_send']/label[3]"));
               return element;
           }
           public static IWebElement getBAPSButton(IWebDriver driver)
           {
               element = driver.FindElement(By.XPath(".//*[@id='how_to_send']/label[3]/div[2]/span"));
               return element;
           }
           public static string getTextForSubHeading(IWebDriver driver)
           {
               string actualvalue = driver.FindElement(By.XPath(".//*[@id='main']/div[5]/div[1]/h2")).Text;
               return actualvalue;
           }
           public static IWebElement selectQuoteA(IWebDriver driver)
           {
               element = driver.FindElement(By.XPath(".//*[@id='main']/div[5]/div[2]/div/div/label"));
               return element;
           }
           public static IWebElement selectCreateButton(IWebDriver driver)
           {
               element = driver.FindElement(By.XPath(".//*[@id='btn_CustomerApproval_SendBAPS']/span[1]"));
               return element;
           }
           */
    }
}
