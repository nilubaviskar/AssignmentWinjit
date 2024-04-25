using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Pro.PageObjects
{
    public class SamplePageTestPage
    {
        private IWebDriver driver;
        public SamplePageTestPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        /* 
         String dropDown = "//span[@class='link_span'][contains(text(),'DropDown Menu')]";
        //IWebElement dropDownMenu = driver.FindElement(By.Xpath(dropDown));
        [FindsBy(How = How.XPath, Using = "dropDown")]
        private IWebElement dropDownMenu;

        public IWebElement getDropDownMenu()
        {
            return dropDownMenu;
        }
         */
        String samplePage = "//span[@class='link_span'][contains(text(),'Sample Page Test')]";
        //IWebElement samplePageTest = driver.FindElement(By.Xpath(samplePage));
        [FindsBy(How = How.XPath, Using = "samplePage")]
        private IWebElement samplePageTest;

        public IWebElement getsamplePageTest()
        {
            return samplePageTest;
        }


        String name = "g2599-name";
        //IWebElement nameElement = driver.FindElement(By.Xpath(name));
        [FindsBy(How = How.Id, Using = "name")]
        private IWebElement nameElement;

        public IWebElement getnameElement()
        {
            return nameElement;
        }

        String email = "g2599-email";
        //IWebElement emailElement = driver.FindElement(By.Xpath(email);
        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailElement;

        public IWebElement getemailElement()
        {
            return emailElement;
        }


        String experience = "//*[@id='g2599-experienceinyears']";
        IWebElement experienceElement = driver.FindElement(By.Xpath(experience));


        String functinalTesting = "//*[@value='Functional Testing']";
        IWebElement functinalTestingCheckBox = driver.FindElement(By.Xpath(functinalTesting));

        String automationTesting = "//*[@value='Automation Testing']";
        IWebElement automationTestingCheckBox = driver.FindElement(By.Xpath(automationTesting));

        String manualTesting = "//*[@value='Manual Testing']";
        IWebElement manualTestingCheckBox = driver.FindElement(By.Xpath(manualTesting));


        String graduate = "//*[@value='Graduate']";
        IWebElement graduateOption = driver.FindElement(By.Xpath(graduate));

        String postGraduate = "//*[@value='Post Graduate']";
        IWebElement graduateOption = driver.FindElement(By.Xpath(postGraduate));

        String other = "//*[@value='Other']";
        IWebElement otherOption = driver.FindElement(By.Xpath(other));

        String alertBox = "//button[contains(text(),'Alert Box : Click Here')]";
        IWebElement alertBoxElement = driver.FindElement(By.Xpath(alertBox));

        String comment = "//*[@class='textarea']";
        IWebElement commentElement = driver.FindElement(By.Xpath(comment));

        String submit = "//*[@class='contact-submit']";
        IWebElement submitElement = driver.FindElement(By.Xpath(submit));


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
                IWebElement functinalTestingCheckBox = driver.FindElement(By.Xpath(functinalTesting));
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
        }

         public void SelectEducationOption()
            {


                // Find the radio button element by its ID, XPath, or other locator
                //IWebElement radioButton = driver.FindElement(By.Id("your_radio_button_id"));
                String graduate = "//*[@value='Graduate']";
                IWebElement graduateOption = driver.FindElement(By.Xpath(graduate));

                // Check if the radio button is not already selected
                if (!graduateOption.Selected)
                {
                    // Click on the radio button to select it
                    graduateOption.Click();
                }
         
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

        public void ClickOnSubmitButton()
            {
                submitElement.Click();
            }
        
        public void AddComment()
            {
                commentElement.SendKeys("test");
            }
        
        public void FillForm(String Name, String Email)
            {
                AddName();
                AddEmail();
                SelectExperience();
                SelectExpertiseCheckBox();
                SelectEducationOption();
                ClickAlertBox();
                AddComment();
                ClickOnSubmitButton();
            }
        
        }





    }


    

