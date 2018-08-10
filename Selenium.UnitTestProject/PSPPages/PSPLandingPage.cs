using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;



namespace Selenium.UnitTestProject.PSPPages
{
    class PSPLandingPage
    {
        public static IWebElement element = null;

        /**
  * Returns the search box element
  * @param driver
  * @return
  * 
  * 
  */
        public static string getTextForHeader(IWebDriver driver)
        {
            string actualValue1 = driver.FindElement(By.XPath("//*[@id='dash']/div/div/h2")).Text;
            return actualValue1;
        }
        public static void clickOnPrivateEventsButton(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='MainMenu_mnuMainMenu']/ul/li[5]/a"));
            element.Click();
        }


        public static IWebElement skillsLicenceHeader(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='dash']/div/div/h2"));
            return element;
        }
        public static IWebElement approvedCount(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(".//*[@id='dash']/div/table/tbody/tr[3]/td[2]"));
            return element;
        }
        public static IWebElement approved(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(".//*[@id='dash']/div/table/tbody/tr[3]/td[1]/a/span"));
            return element;
        }

        public static IWebElement approvedButSuspended(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(".//*[@id='dash']/div[1]/table/tbody[1]/tr[4]/td[1]/a/span"));
            return element;
        }

        /**
	 * Returns the create skills licence button
	 * @param driver
	 * @return
	 */
        public static IWebElement createSkillsLicenceButton(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='dash']/div/ul/li/a/span[1]"));
            return element;
        }

        public static IWebElement userCircle(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='base']/ul/li[2]/span[1]/i"));
            return element;
        }

        public static IWebElement changeUserFreeTextBox(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='userCode']"));
            return element;
        }

        public static IWebElement changeTheUserButton(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='menu']/div/ul/li[3]/form/div/ul/li/label/span[1]"));
            return element;
        }

        
    }
}
    
