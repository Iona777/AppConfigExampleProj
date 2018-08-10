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

    class CreateSkillsLicenceSmoke
    {         
 
        [SetUp]
        public void Initialize()
        {
           //Managed from App.config          
        }

        [Test]
        //This test creates a self-approved licence and returns user to dashboard
        public void CreateSkillsLicenceSmokeTest()
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
                DashboardPage.createSkillsLicenceButton(driver).Click();
                string actualValue1 = GetMyCustomersPage.getTextForHeader(driver);
                Assert.IsTrue(actualValue1.Contains("SELECT COMPANY"), actualValue1 + " doesn't contain 'SELECT COMPANY'");
                GetMyCustomersPage.customerSearchBox(driver).SendKeys("TEST QC CUSTOMER");
                GetMyCustomersPage.customerSelect(driver).Click();
                string actualValue2 = GetMyCustomerContactsPage.getTextForHeader(driver);
                Assert.IsTrue(actualValue2.Contains("SELECT CONTACT"), actualValue2 + " doesn't contain 'SELECT CONTACT'");
                GetMyCustomerContactsPage.delegateButton(driver).Click();
                GetMyCustomerContactsPage.contactSelect(driver).Click();
                string actualValue3 = GetMylicencesPage.getTextForHeader(driver);
                Assert.IsTrue(actualValue3.Contains("SELECT TEMPLATE"), actualValue3 + " doesn't contain 'SELECT TEMPLATE'");
                GetMylicencesPage.blankTemplate(driver).Click();
                string actualValue4 = AlterSkillsLicencePage.getTextForHeader(driver);
                Assert.IsTrue(actualValue4.Contains("IN DRAFT"), actualValue4 + " doesn't contain 'IN DRAFT'");
                string actualValue5 = AlterSkillsLicencePage.getTextForNewCustomerCheckboxUnticked(driver);
                Assert.IsTrue(actualValue5.Contains("Additional discounts for being a new customer not applied"), actualValue5 + " doesn't contain 'Additional discounts for being a new customer not applied'");
                AlterSkillsLicencePage.getNewCustomerCheckbox(driver).Click();
                string actualValue6 = AlterSkillsLicencePage.getTextForNewCustomerCheckboxTicked(driver);
                Assert.IsTrue(actualValue6.Contains("Additional discounts for being a new customer applied"), actualValue6 + " doesn't contain 'Additional discounts for being a new customer applied'");
                AlterSkillsLicencePage.quoteATextBox(driver).SendKeys("5000");                        
                AlterSkillsLicencePage.itPracticeSelect(driver).Click();
                AlterSkillsLicencePage.itAllVendors(driver).Click();
                AlterSkillsLicencePage.agileAndScrumPremium(driver).Click();
                AlterSkillsLicencePage.clickOnSaveAndSendButton(driver);
                string actualvalue7 = CustomerApprovalPage.getTextForHeader(driver);
                Assert.IsTrue(actualvalue7.Contains("SEND SKILLS LICENCE TO CUSTOMER"), actualvalue7 + " doesn't contain 'Skills Licence To Customer'");
                HeaderPage.quotationsMenuOption(driver).Click();
                HeaderPage.salesPortalMenuOption(driver).Click();                
                string actualvalue8 = DashboardPage.getTextForHeader(driver);
                Assert.IsTrue(actualvalue8.Contains("SKILLS LICENCES"), actualvalue8 + " doesn't contain 'SKILLS LICENCES'");                
            }
        }


        [TearDown]
        public void EndTest()
        {
            
        }

    }
}
