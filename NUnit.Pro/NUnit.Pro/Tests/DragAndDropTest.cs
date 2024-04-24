using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Pro.Utility;

namespace NUnit.Pro.Tests
{
    class DragAndDropTest : Base
    {
        [Test]
        public void DranAndDropImage()
        {
            //String dragAndDrop = "//span[@class='link_span'][contains(text(),'Drag And Drop')]";
            // IWebElement dragAndDropElement = driver.FindElement(By.Xpath(dragAndDrop));
            //To click element
            HomePage.homePage = new HomePage(getDriver());
            homePage.getDragAndDropElement().Click();
            //dragAndDropElement.Click();
            try
            {
                // Find the image element by its XPath
                /* String draggable = "//li[@id= 'menu-item-2804']";
                 IWebElement draggableElement = driver.FindElement(By.Xpath(draggable));
                 String droppable = "//*[@id= 'trash']";
                 IWebElement droppableElement = driver.FindElement(droppable);*/

                DragAndDropPage DragAndDrop = new DragAndDropPage(getDriver());
                DragAndDropPage.getdraggableElement();
                DragAndDropPage.getdroppableElement();
                // Create an instance of Actions class

                Actions actions = new Actions(driver);

                // Scroll to the image element using JavaScript
                actions.dragAndDrop(DragAndDropPage.getdraggableElement(), DragAndDropTestPage.getgetdroppableElement().Perform();

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
    }
}
