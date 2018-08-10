using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace Selenium.UnitTestProject.QCPages
{
    class ShowManagerSkillsLicencePage
    {
        
            public static IWebElement element = null;

        public static string getTextForHeader(IWebDriver driver)
        {
            string showManagerSkillsLicenceHeader = driver.FindElement(By.XPath("//*[@id='dash']/div/dl/dt[1]")).Text;
            return showManagerSkillsLicenceHeader;
        }


        public static IWebElement selectDeclineSkillsLicenceButton(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='dash']/div/dl/dd[8]/ul/li[2]/a/span[1]"));
            return element;
        }

        public static IWebElement selectApproveSkillsLicenceButton(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='dash']/div/dl/dd[8]/ul/li[1]/a/span[1]"));
            return element;
        }


    }

}
    
