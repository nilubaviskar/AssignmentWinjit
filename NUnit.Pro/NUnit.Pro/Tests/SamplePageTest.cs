using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Pro.Utility;

namespace NUnit.Pro.Tests
{
    class SamplePageTest : Base
    {
        [Test]
        [TestCase("name1","abc@gmail.com")]
        [TestCaseSource("name2","xyZ@gmail.com")]
        public void SamplePageTest()
        {
            
            SamplePageTestPage.samplePageTestPage = new SamplePageTestPage(getDriver());
            //parameterization
            samplePageTestPage.FillForm(String Name, String Email); ;

        }

       
    }
}
