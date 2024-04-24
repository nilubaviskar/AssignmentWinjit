using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Pro.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace NUnit.Pro.Tests
{
    class SelectFromDropDownTest : Base
    {
        [Test]
        public void DropDown()
        {


            /*String dropDown = "//span[@class='link_span'][contains(text(),'DropDown Menu')]";
            IWebElement dropDownMenu = driver.FindElement(By.Xpath(dropDown));
            String dropD = "//Select";
            IWebElement dropdownElement = driver.FindElement(By.Xpath(dropD));*/
            //To click element
            DropDownPage.dropDownPage = new DropDownPage(getDriver());
            dropDownPage.getDropDownMenu().Click();
            // Create a SelectElement object
            SelectElement select = new SelectElement(dropDownPage.getDropdownElement());

            // Select by text
            select.SelectByText("Albania");
            // Optional: Wait for a few seconds to see the selection
            System.Threading.Thread.Sleep(3000);

            /* // Select by index
             select.SelectByIndex(2);

             // Optional: Wait for a few seconds to see the selection
             System.Threading.Thread.Sleep(3000);

             // Select by value
             select.SelectByValue("ALB");

             // Optional: Wait for a few seconds to see the selection
             System.Threading.Thread.Sleep(3000);*/
        }

    }
}
