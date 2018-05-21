using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;


namespace WikiTest1
{
    [TestClass]
    public class WikiPage
    {
        [TestMethod]
        public void ValidateWiki()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.wikipedia.org");

            // To choose English language
            IWebElement english = driver.FindElement(By.XPath("//strong[text() = 'English']"));
            english.Click();

            // To send input as 'Test Automation'
            IWebElement search = driver.FindElement(By.Name("search"));
            search.SendKeys("Test Automation");

            // To submit the input
            IWebElement search_go = driver.FindElement(By.Name("go"));
            search_go.Click();

            // To validate 'Unit testing' text
            IWebElement element = driver.FindElement(By.Id("Unit_testing"));
            if (element.Displayed)
            {
                Console.WriteLine("UnitTesting text is PRESENT");
            }

            // To validate 'Test Automation Interface Model' image
            IWebElement img = driver.FindElement(By.XPath("//img[@class = 'thumbimage']"));
            if (img.Displayed)
            {
                Console.WriteLine("Test Automation Interface Model image is PRESENT");
            }


            // To validate and navigate to 'Behavior driven development' page
            IWebElement text_link = driver.FindElement(By.XPath("//a[text()= 'Behavior driven development']"));
            if(text_link.Displayed)
            {
                Console.WriteLine("Behavior driven development text link is PRESENT");
                text_link.Click();
            }
            

        }
    }
}
