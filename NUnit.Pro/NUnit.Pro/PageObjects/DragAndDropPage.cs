using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;
using CSharpSelfFramework.utilities;


namespace NUnit.Pro.PageObjects
{
    public class DragAndDropPage
    {
        private IWebDriver driver;
        public DragAndDropPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        //Pageobject factory   >>using SeleniumExtras.PageObjects;



        String draggable = "//li[@id= 'menu-item-2804']";
        //IWebElement draggableElement = driver.FindElement(By.Xpath(draggable));
        [FindsBy(How = How.XPath, Using = "draggable")]
        private IWebElement draggableElement;

        public IWebElement getdraggableElement()
        {
            return draggableElement;
        }
        
        
        String droppable = "//*[@id= 'trash']";
        //IWebElement droppableElement = driver.FindElement(droppable);
        [FindsBy(How = How.XPath, Using = "droppable")]
        private IWebElement droppableElement;

        public IWebElement getdroppableElement()
        {
            return droppableElement;
        }
    }

}