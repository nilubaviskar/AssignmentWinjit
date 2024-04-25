/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;
using CSharpSelfFramework.utilities;

namespace NUnit.Pro
{
    class SeleniumTest : Base    //Using CSharpSelfFramework.utilities
    {
        /*IWebDriver driver;
        [SetUp]
        public void OpenBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            // driver = new FirefoxDriver();

            // Maximize the browser window (optional)
            driver.Manage().Window.Maximize();
            TestContext.Progress.WriteLine("This is SetUp method");
        }*/

        /*[Test]
        public void OpenUrl()
        {
            driver.Url = "http://www.globalsqa.com/demo-site/draganddrop/";
            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Url);
            //driver.Close();

        }*/

        /*[Test]
        public void DranAndDropImage()
        {
            String dragAndDrop = "//span[@class='link_span'][contains(text(),'Drag And Drop')]";
            IWebElement dragAndDropElement = driver.FindElement(By.Xpath(dragAndDrop));
            //To click element
            dragAndDropElement.Click();
            try
            {
                // Find the image element by its XPath
                String draggable = "//li[@id= 'menu-item-2804']";
                IWebElement draggableElement = driver.FindElement(By.Xpath(draggable));
                String droppable = "//*[@id= 'trash']";
                IWebElement droppableElement = driver.FindElement(droppable);
                // Create an instance of Actions class
                Actions actions = new Actions(driver);

                // Scroll to the image element using JavaScript
                actions.dragAndDrop(draggableElement, droppableElement).Perform();

                // Optional: You can also use JavaScript to scroll to a specific position if needed
                // For example, scrolling to a specific pixel offset
                // ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 500);");

                // Optional: Wait for a few seconds to see the scrolled image
                System.Threading.Thread.Sleep(3000);
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Image element not found: " + e.Message);
            }
            finally
            {
                // Quit the WebDriver
                driver.Quit();
            }
        }

        [Test]
        public void DropDown()
        {
            /*using OpenQA.Selenium;
            using OpenQA.Selenium.Chrome;
            using OpenQA.Selenium.Support.UI;
            using System;*/

            /*String dropDown = "//span[@class='link_span'][contains(text(),'DropDown Menu')]";
            IWebElement dropDownMenu = driver.FindElement(By.Xpath(dropDown));
            String dropD = "//Select";
            IWebElement dropdownElement = driver.FindElement(By.Xpath(dropD));
            //To click element
            dropDownMenu.Click();
            // Create a SelectElement object
            SelectElement select = new SelectElement(dropdownElement);

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
        

        /*[Test]
        public void SamplePageTest()
        {
            String samplePage = "//span[@class='link_span'][contains(text(),'Sample Page Test')]";
            IWebElement samplePageTest = driver.FindElement(By.Xpath(samplePage));

            String name = "//*[@id='g2599-name']";
            IWebElement nameElement = driver.FindElement(By.Xpath(name));

            String email = "//*[@id='g2599-email']";
            IWebElement emailElement = driver.FindElement(By.Xpath(email);

            String experience = "//*[@id='g2599-experienceinyears']";
            IWebElement experienceElement = driver.FindElement(By.Xpath(experience);


            String functinalTesting = "//*[@value='Functional Testing']";
            IWebElement functinalTestingCheckBox = driver.FindElement(By.Xpath(functinalTesting);

            String automationTesting = "//*[@value='Automation Testing']";
            IWebElement automationTestingCheckBox = driver.FindElement(By.Xpath(automationTesting);

            String manualTesting = "//*[@value='Manual Testing']";
            IWebElement manualTestingCheckBox = driver.FindElement(By.Xpath(manualTesting);


            String graduate = "//*[@value='Graduate']";
            IWebElement graduateOption = driver.FindElement(By.Xpath(graduate);

            String postGraduate = "//*[@value='Post Graduate']";
            IWebElement graduateOption = driver.FindElement(By.Xpath(postGraduate);

            String other = "//*[@value='Other']";
            IWebElement otherOption = driver.FindElement(By.Xpath(other);

            String alertBox = "//button[contains(text(),'Alert Box : Click Here')]";
            IWebElement alertBoxElement = driver.FindElement(By.Xpath(alertBox);

            String comment = "//*[@class='textarea']";
            IWebElement commentElement = driver.FindElement(By.Xpath(comment);

            String submit = "//*[@class='contact-submit']";
            IWebElement submitElement = driver.FindElement(By.Xpath(submit);

            }

        public void SelectExperience()
        {
            //Select the Experience from drop down
            //value=3-5;
            // Create a SelectElement object
            SelectElement select = new SelectElement(experienceElement);

            // Select by text
            select.SelectByValue("3-5");
            // Optional: Wait for a few seconds to see the entered text
            System.Threading.Thread.Sleep(3000);
        }

        public void AddEmail()
        {
            //Add Email in the form
            // Clear the existing text in the textbox (optional)
            emailElement.Clear();

            // Send keys to the textbox to input text
            emailElement.SendKeys("Test@gmail.com");

            // Optional: Wait for a few seconds to see the entered text
            System.Threading.Thread.Sleep(3000);
        }

        public void AddName()
        {
            //Add Name in the form
            // Clear the existing text in the textbox (optional)
            nameElement.Clear();

            // Send keys to the textbox to input text
            nameElement.SendKeys("Test Name");

            // Optional: Wait for a few seconds to see the entered text
            System.Threading.Thread.Sleep(3000);
        }

        public void ClickOnSamplePageTest() 
            {
            //To click on Sample page Test  
            samplePageTest.Click();
            }

        public void SelectExpertiseCheckBox()
        {
            try
            {
                // Find the checkbox element by its ID, XPath, or other locator
                //IWebElement checkbox = driver.FindElement(By.Id("your_checkbox_id"));
                String functinalTesting = "//*[@value='Functional Testing']";
                IWebElement functinalTestingCheckBox = driver.FindElement(By.Xpath(functinalTesting);
                // Check if the checkbox is not already checked
                if (!functinalTestingCheckBox.Selected)
                {
                    // Click on the checkbox to check it
                    functinalTestingCheckBox.Click();
                }

                // Optional: Wait for a few seconds to see the checkbox being checked
                System.Threading.Thread.Sleep(3000);
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Checkbox element not found: " + e.Message);
            }
            
            public void SelectEducationOption()
            {


                // Find the radio button element by its ID, XPath, or other locator
                //IWebElement radioButton = driver.FindElement(By.Id("your_radio_button_id"));
                String graduate = "//*[@value='Graduate']";
                IWebElement graduateOption = driver.FindElement(By.Xpath(graduate);

                // Check if the radio button is not already selected
                if (!graduateOption.Selected)
                    {
                    // Click on the radio button to select it
                    graduateOption.Click();
                    }

                    // Optional: Wait for a few seconds to see the radio button being selected
                    System.Threading.Thread.Sleep(3000);
                
               else
                {
                    Console.WriteLine("Radio button element not found: " + e.Message);
                }
               
            }

            public void ClickAlertBox()
            {


                // Click the button to trigger the alert
                alertBoxElement.Click();

                // Switch to the alert
                IAlert alert = driver.SwitchTo().Alert();

                // Get the text of the alert
                string alertText = alert.Text;
                Console.WriteLine("Alert Text: " + alertText);

                // Accept the alert (click OK)
                alert.Accept();

                // Optional: Wait for a few seconds to see the alert being accepted
                System.Threading.Thread.Sleep(3000);
            }

            public void ClocOnSubmitButton()
            {
                submitElement.Click();
            }
        }

    }
}*/

    


