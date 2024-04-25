using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Pro.PageObjects
{
    public class DropDownPage
    {
        private IWebDriver driver;
        public DropDownPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //Pageobject factory   >>using SeleniumExtras.PageObjects;

        String dropDown = "//span[@class='link_span'][contains(text(),'DropDown Menu')]";
        //IWebElement dropDownMenu = driver.FindElement(By.Xpath(dropDown));
        [FindsBy(How = How.XPath, Using = "dropDown")]
        private IWebElement dropDownMenu;

        public IWebElement getDropDownMenu()
        {
            return dropDownMenu;
        }

        String dropD = "//Select";
        //IWebElement dropdownElement = driver.FindElement(By.Xpath(dropD));
        [FindsBy(How = How.XPath, Using = "dropD")]
        private IWebElement dropdownElement;

        public IWebElement getDropdownElement()
        {
            return dropdownElement;
        }
    }

}