using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace Selenium.Objects
{
    class ManagerPage
    {
        private IWebDriver _driver;

        public ManagerPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Name, Using = "uid")]
        public IWebElement TxtUserID { get; set; }

        

        [FindsBy(How = How.ClassName, Using = "barone")]
        public IWebElement LblHeader { get; set; }




    }
}
