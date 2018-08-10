using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace Selenium.UnitTestProject.QCPages
{
    class ManagerDashboardPage
    {
        
            public static IWebElement element = null;

        public static string getTextForHeader(IWebDriver driver)
        {
            string managerDashboardHeader = driver.FindElement(By.XPath(".//*[@id='dash']/div[1]/div/h2")).Text;
            return managerDashboardHeader;
        }

        public static string getSkillsLicencePendingApproval(IWebDriver driver)
        {
            string managerDashboardHeader = driver.FindElement(By.XPath("//*[@id='dash']/div[1]/table/tbody/tr[1]/td[1]/a/span[1]")).Text;
            return managerDashboardHeader;
        }

        public static IWebElement selectSkillsLicenceForReview(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//*[@id='dash']/div[1]/table/tbody/tr[1]/td[1]/a/span[1]"));
            return element;
        }


    }

}
    
