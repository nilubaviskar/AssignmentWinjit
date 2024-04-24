using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;



namespace NUnit.Pro.Utility
{
    class Base
    {
        public IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            //COnfiguration >> Add package Sysyem.Configuration.ConfigurationManager
            String browserName = ConfigurationManager.AppSetting["browser"];
            InitBrowser("browserName");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            // Maximize the browser window (optional)
            driver.Manage().Window.Maximize();
            // TestContext.Progress.WriteLine("This is SetUp method");
            driver.Url = "http://www.globalsqa.com/demo-site/draganddrop/";
            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Url);
        }

        public IWebDriver getDriver()
        {
            return driver;
        }
        public void InitBrowser(string browserName)
        {
            switch(browserName)
                {
                    case "Firefox":
                        new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());    //using WebDriverManager.DriverConfigs.Impl;
                        driver = new FirefoxDriver();                                             //using OpenQA.Selenium.Firefox;
                    break;

                    case "Chrome":
                      new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());    //using WebDriverManager.DriverConfigs.Impl;
                      driver = new ChromeDriver();                                              //using OpenQA.Selenium.Chrome;
                    break;

                    case "Edge":
                      new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());    //using WebDriverManager.DriverConfigs.Impl;
                      driver = new EdgeDriver();                                              //using OpenQA.Selenium.Edge;
                    break;


                }




        }

        [TearDown]
        public void AfterTest()
        {
            driver.Quit();
        }
    }
}
