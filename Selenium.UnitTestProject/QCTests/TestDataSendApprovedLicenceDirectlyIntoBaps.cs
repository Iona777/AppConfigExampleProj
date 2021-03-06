﻿using System;
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

    class CreateApprovedLicenceDirectlyIntoBaps
    {

        //IWebDriver driver;
        

        [SetUp]
        public void Initialize()
        {
           //Managed from App.config
           
        }

        [Test]
        //This test clicks dashboard approved then hit save into baps area, select quote A and save into BAPS.  Checks user returned to dashboard.
        public void SendApprovedQuotesViaBAPS()
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
                Assert.IsTrue(actualValue1.Contains("SKILLS LICENCES"), actualValue + " doesn't contain 'SKILLS LICENCES'");
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
                AlterSkillsLicencePage.quoteATextBox(driver).SendKeys("2222.22");
                AlterSkillsLicencePage.itPracticeSelect(driver).Click();
                AlterSkillsLicencePage.itAllVendors(driver).Click();
                AlterSkillsLicencePage.agileAndScrumPremium(driver).Click();
                AlterSkillsLicencePage.clickOnSaveAndSendButton(driver);
                string actualvalue7 = CustomerApprovalPage.getTextForHeader(driver);
                Assert.IsTrue(actualvalue7.Contains("SEND SKILLS LICENCE TO CUSTOMER"), actualvalue7 + " doesn't contain 'Skills Licence To Customer'");               
                CustomerApprovalPage.getBAPSSection(driver).Click();
                string subHeadingText = CustomerApprovalPage.getTextForBAPSSubHeading(driver);
                Assert.IsTrue(subHeadingText.Contains("BAPS"), subHeadingText + "doesn't contain 'BAPS'");              
                CustomerApprovalPage.selectQuoteA(driver).Click();
                CustomerApprovalPage.selectCreateButton(driver).Click();
                string dashboardHeader = DashboardPage.getTextForHeader(driver);
                Assert.IsTrue(dashboardHeader.Contains("SKILLS LICENCES"), dashboardHeader + " doesn't contain 'SKILLS LICENCES'");
            }
        }


        [TearDown]
        public void EndTest()
        {
            
        }

    }
}
