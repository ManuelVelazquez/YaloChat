using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace Selenium.Objects
{
    class Menu
    {
        private IWebDriver _driver;

        public Menu(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public IList<IWebElement> LeftMenu => _driver.FindElements(By.CssSelector("ul[class='menusubnav'] > li"));

        public void clickOption(string name)
        {

            IList<IWebElement> listMenu = LeftMenu;

            foreach (IWebElement elemnt in listMenu)
            {
                if (elemnt.Text == name)
                {
                    elemnt.Click();
                }
            }

        }
        public void clickOption(int index)
        {

            IList<IWebElement> listMenu = LeftMenu;
            listMenu[index].Click();
        }
    }
}
