using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using Selenium.Objects;
using NUnit.Framework;
using Selenium.CommonSeleniumMethodsA;

namespace Selenium
{
    public class TestCaseYaloChat
    {
        public static  void Main(string[] args)
        {
            
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://demo.guru99.com/V4/index.php");
            driver.Manage().Window.Maximize();
            TC_Guru99Validation(driver);
           
              
            
        }
        public TestCaseYaloChat (IWebDriver driver)
        {

        }

        [SetUp]

        public void SetUp()
        {

        }


        [Test]
        public  static void TC_Guru99Validation (IWebDriver driver)
        {
            HomePage home = new HomePage(driver);
            ManagerPage manager = new ManagerPage(driver);
            CommonSeleniumMethods commonMethods = new CommonSeleniumMethods(driver);
            Menu menu = new Menu(driver);
            string UserID = "mngr326413", Password = "mybEvYb", TextHeader = "Guru99 Bank";
            
            commonMethods.Wait(driver, home.TxtUserID);
            home.TxtUserID.SendKeys(UserID);
            home.TxtPassword.SendKeys(Password);
            commonMethods.Wait(driver, home.BtnLogin);
            home.BtnLogin.Click();
            commonMethods.Wait(driver, manager.LblHeader);
            commonMethods.AreEqual(TextHeader, manager.LblHeader.Text);
            menu.clickOption(1);

            driver.Quit();

        }

        [TearDown]
        public static void TearDown ()
        {

        }




    }
}
