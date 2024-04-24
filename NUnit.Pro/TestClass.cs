// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
//using OpernQA.Selenium;

namespace NUnit.Pro
{
    [TestFixture]
    public class TestClass
    {
        [SetUp]
        public void OpenBrowser()
        {
            TestContext.Progress.WriteLine("This is SetUp method");
            

        }

        [Test]
        public void DragAndDrop()
        {
            TestContext.Progress.WriteLine("This is Drag and Drop method");

        }

        [TearDown]
        public void CloseBrowser()
        {
            TestContext.Progress.WriteLine("This is TearDown method");
        }
    }

   
}

