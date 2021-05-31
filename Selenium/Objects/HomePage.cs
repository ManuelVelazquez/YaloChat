using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
 

namespace Selenium.Objects
{
    class HomePage
    {
        private IWebDriver _driver;

        public HomePage (IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Name, Using = "uid")]
        public IWebElement TxtUserID { get; set; }


        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement TxtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "btnLogin")]
        public IWebElement BtnLogin { get; set; }




    }
}
