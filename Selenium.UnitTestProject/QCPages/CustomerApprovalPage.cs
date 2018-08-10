using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.UnitTestProject
{
    class CustomerApprovalPage
    {
        public static IWebElement element = null;

        public static string getTextForHeader(IWebDriver driver)
        {
            string actualvalue = driver.FindElement(By.XPath(".//*[@id='main']/div[1]/h2")).Text;
            return actualvalue;
        }
        public static IWebElement getBAPSSection(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='how_to_send']/label[3]"));
            return element;
        }
        public static IWebElement getBAPSButton(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(".//*[@id='how_to_send']/label[3]/div[2]/span"));
            return element;
        }
        public static IWebElement getPortalSection(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(".//*[@id='how_to_send']/label[1]"));
            return element;
        }

        public static IWebElement selectSendToCustomerViaPortalButton(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(".//*[@id='btn_CustomerApproval_SendPortal']/span[1]"));
            return element;
        }

        public static IWebElement getEchosignSection(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='how_to_send']/label[2]"));
            return element;
        }

        public static IWebElement selectSendToCustomerViaEchosignButton(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='btn_CustomerApproval_SendAdobeSign']/span[1]"));
            return element;
        }

        public static string getTextForEchosignSubHeading(IWebDriver driver)
        {
            string actualvalue = driver.FindElement(By.XPath("//*[@id='main']/div[4]/div[1]/h2")).Text;
            return actualvalue;
        }

        public static string getTextForPortalSubHeading(IWebDriver driver)
        {
            string actualvalue = driver.FindElement(By.XPath("//*[@id='main']/div[3]/div[1]/h2")).Text;
            return actualvalue;
        }

        public static string getTextForBAPSSubHeading(IWebDriver driver)
        {
            string actualvalue = driver.FindElement(By.XPath("//*[@id='main']/div[5]/div[1]/h2")).Text;
            return actualvalue;
        }
 
        public static IWebElement selectQuoteA(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='main']/div[5]/div[2]/div/div[1]/label"));
            return element;
        }
        public static IWebElement selectQuoteAEchosign(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='main']/div[4]/div[2]/div/div[1]/label"));
            return element;
        }

        public static IWebElement selectQuoteB(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(".//*[@id='main']/div[4]/div[2]/div[1]/div[2]/label"));
            return element;
        }

        public static IWebElement selectQuoteC(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(".//*[@id='main']/div[4]/div[2]/div[1]/div[3]/label"));
            return element;
        }

        public static IWebElement selectCreateButton(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='btn_CustomerApproval_SendBAPS']/span[1]"));
            return element;
        }
        
    }
}
