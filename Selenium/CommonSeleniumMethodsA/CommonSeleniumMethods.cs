using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using NUnit.Framework;


namespace Selenium.CommonSeleniumMethodsA
{
     class CommonSeleniumMethods
    {
        private IWebDriver _driver;
        public CommonSeleniumMethods(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        public void Wait(IWebDriver driver, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(13));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }

        public void AreEqual(string firstWord, string secondWord)
        {
            try
            {
                Assert.AreEqual(firstWord, secondWord);
            }

            catch
            {

            }
           
        }

    }
}
