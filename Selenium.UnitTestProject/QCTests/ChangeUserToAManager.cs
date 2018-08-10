using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Selenium.UnitTestProject.QCPages;
using Selenium.UnitTestProject.EnvironmentConfig;

namespace Selenium.UnitTestProject
{
    //add these bits in to make all tests run at same time
    [TestFixture]
    [Parallelizable]

    class ChangeUserToAManager
    {
        
        //IWebDriver driver;
        

        [SetUp]
        public void Initialize()
        {
        //Managed from WebDriverManager.App.config
           
        }

        [Test]
        //This tests uses the app.config value to pick a manager and change SP to use that salesperson to login.  It then checks user has landed on a manager version of the dashboard page.
        public void ChageUserToAManagerTest()
        {
            using (IWebDriver driver = WebDriverManager.WebDriverManager.GetWebDriverForConfig())
            {
                string page = EnvironmentConfig.ConfigurationWrapper.GetURLFromEnvironmentKey();
                string actualValue = DashboardPage.getTextForHeader(driver);
                while (actualValue == null)
                {
                    driver.Url = page;
                }
                Assert.IsTrue(actualValue.Contains("SKILLS LICENCES"), actualValue + " doesn't contain 'SKILLS LICENCES'");
                DashboardPage.userCircle(driver).Click();
                DashboardPage.changeUserFreeTextBox(driver).SendKeys(ConfigurationWrapper.ManagerUserName());
                DashboardPage.changeTheUserButton(driver).Click();
                string ManagerDashboardHeader = DashboardPage.getTextForHeader(driver);
                Assert.IsTrue(ManagerDashboardHeader.Contains("APPROVALS PENDING"), ManagerDashboardHeader + " doesn't contain 'APPROVALS PENDING'");
             }
        }


        [TearDown]
        public void EndTest()
        {
            
        }

    }
}
