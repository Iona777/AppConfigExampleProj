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
    [TestFixture]
    [Parallelizable]

    class CreateAwaitingApprovalSkillsLicence
    {         
 
        [SetUp]
        public void Initialize()
        {
           //Managed from App.config          
        }

        [Test]
        //This test creates a self-approved licence and returns user to dashboard
        public void CreateAwaitingApprovalSkillsLicenceTest()
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
                DashboardPage.changeUserFreeTextBox(driver).SendKeys(ConfigurationWrapper.SalspersonUserName());
                DashboardPage.changeTheUserButton(driver).Click();
                string actualValue1 = DashboardPage.getTextForHeader(driver);
                Assert.IsTrue(actualValue1.Contains("SKILLS LICENCES"), actualValue1 + " doesn't contain 'SKILLS LICENCES'");
                string actualValue2 = DashboardPage.getTextForHeader(driver);
                Assert.IsTrue(actualValue2.Contains("SKILLS LICENCES"), actualValue2 + " doesn't contain 'SKILLS LICENCES'");
                DashboardPage.createSkillsLicenceButton(driver).Click();
                string actualValue3 = GetMyCustomersPage.getTextForHeader(driver);
                Assert.IsTrue(actualValue3.Contains("SELECT COMPANY"), actualValue3 + " doesn't contain 'SELECT COMPANY'");
                GetMyCustomersPage.customerSearchBox(driver).SendKeys("TEST QC CUSTOMER");
                GetMyCustomersPage.customerSelect(driver).Click();
                string actualValue4 = GetMyCustomerContactsPage.getTextForHeader(driver);
                Assert.IsTrue(actualValue4.Contains("SELECT CONTACT"), actualValue4 + " doesn't contain 'SELECT CONTACT'");
                GetMyCustomerContactsPage.delegateButton(driver).Click();
                GetMyCustomerContactsPage.contactSelect(driver).Click();
                string actualValue5 = GetMylicencesPage.getTextForHeader(driver);
                Assert.IsTrue(actualValue5.Contains("SELECT TEMPLATE"), actualValue5 + " doesn't contain 'SELECT TEMPLATE'");
                GetMylicencesPage.blankTemplate(driver).Click();
                string actualValue6 = AlterSkillsLicencePage.getTextForHeader(driver);
                Assert.IsTrue(actualValue6.Contains("IN DRAFT"), actualValue6 + " doesn't contain 'IN DRAFT'");
                AlterSkillsLicencePage.quoteATextBox(driver).SendKeys("5555.55");
                AlterSkillsLicencePage.itPracticeSelect(driver).Click();
                AlterSkillsLicencePage.itAllVendors(driver).Click();
                AlterSkillsLicencePage.agileAndScrumPremium(driver).Click();
                AlterSkillsLicencePage.QuoteADiscountBox(driver).Click();
                AlterSkillsLicencePage.QuoteADiscountBox(driver).SendKeys("99");
                AlterSkillsLicencePage.QuoteADiscountBox(driver).SendKeys(Keys.Tab);
                string actualValue7 = AlterSkillsLicencePage.getHierarchyWarning(driver);
                Assert.IsTrue(actualValue7.Contains("Over Sales Director"), actualValue7 + " doesn't contain 'Over Sales Director'");
                AlterSkillsLicencePage.clickOnSaveAndSendButton(driver);
                string actualvalue8 = ManagerApprovalPage.getTextForHeader(driver);
                Assert.IsTrue(actualvalue8.Contains("MANAGER APPROVAL"), actualvalue8 + " doesn't contain 'MANAGER APPROVAL'");
                ManagerApprovalPage.clickOnManagerNameTickbox(driver);
                ManagerApprovalPage.clickOnSendToManagerButton(driver);
                string actualvalue9 = DashboardPage.getTextForHeader(driver);
                Assert.IsTrue(actualvalue9.Contains("SKILLS LICENCES"), actualvalue9 + " doesn't contain 'SKILLS LICENCES'");

            }
        }


        [TearDown]
        public void EndTest()
        {
            
        }

    }
}
