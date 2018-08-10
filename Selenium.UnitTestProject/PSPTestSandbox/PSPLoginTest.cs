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
using Selenium.UnitTestProject.PSPPages;

namespace Selenium.UnitTestProject
{
    class Login
    {         
 
        [SetUp]
        public void Initialize()
        {
           //Managed from App.config          
        }

        [Test]
        
        public void PSPLoginTest()
        {
            using (IWebDriver driver = WebDriverManager.WebDriverManager.GetWebDriverForConfig())
           {
               PSPPages.PSPLandingPage.clickOnPrivateEventsButton(driver);
                
            }
        }


        [TearDown]
        public void EndTest()
        {
            
        }

    }
}
