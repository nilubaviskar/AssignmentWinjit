using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NUnit.Pro.PageObjects
{
    public class HomePage
    {

        private IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //Pageobject factory   >>using SeleniumExtras.PageObjects;

         String dragAndDrop = "//span[@class='link_span'][contains(text(),'Drag And Drop')]";
        //IWebElement dragAndDropElement = driver.FindElement(By.Xpath(dragAndDrop));
        [FindsBy(How = How.XPath, Using = "dragAndDrop")]
        private IWebElement dragAndDropElement;

        public IWebElement getDragAndDropElement()
        {
            return dragAndDropElement;
        }

        String dropDown = "//span[@class='link_span'][contains(text(),'DropDown Menu')]";
        //IWebElement dropDownMenu = driver.FindElement(By.Xpath(dropDown));
        [FindsBy(How = How.Xpath, Using = "dropDown")]
        public IWebElement dropDownMenu;

        public IWebElement getdropDownMenu()
        {
            return dropDownMenu;
        }


        String dropD = "//Select";
        //IWebElement dropdownElement = driver.FindElement(By.Xpath(dropD));
        [FindsBy(How = How.Xpath, Using = "dropD")]
        public IWebElement dropdownElement;

        public IWebElement getdropdownElement()
        {
            return dropdownElement;
        }
    }
}
