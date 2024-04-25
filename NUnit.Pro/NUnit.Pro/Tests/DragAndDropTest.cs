using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Pro.PageObjects;
using NUnit.Pro.Utility;

namespace NUnit.Pro.Tests
{
    class DragAndDropTest : Base
    {
        [Test]
        public void DranAndDropImage()
        {
            HomePage.homePage = new HomePage(getDriver());
            homePage.getDragAndDropElement().Click();
            DragAndDropPage DragAndDrop = new DragAndDropPage(getDriver());
            DragAndDrop.getdraggableElement();
            DragAndDrop.getdroppableElement();
            // Create an instance of Actions class
            Actions actions = new Actions(driver);

            // Scroll to the image element using JavaScript
            actions.dragAndDrop(DragAndDrop.getdraggableElement(), DragAndDrop.getgetdroppableElement()).Perform();

            // Optional: You can also use JavaScript to scroll to a specific position if needed
            // For example, scrolling to a specific pixel offset
            // ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 500);");
            // Optional: Wait for a few seconds to see the scrolled image
               
            
              }
    }
}
