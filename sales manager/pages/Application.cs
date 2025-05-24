using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace sales_manager.pages
{
    public class Application
    {
        private readonly IWebDriver driver;
        public Application(IWebDriver driver) {
            this.driver = driver;
        }
        // tap the application 
        private IWebElement application => driver.FindElement(By.XPath("//span[normalize-space()='Applications']"));
        private IWebElement uappid => driver.FindElement(By.CssSelector(".gy-3.row > .p-2.col-6.col-sm-6.col-md-3.col-lg-2:nth-child(1) > div:only-child"));
        public void tapdo()
        {
            application.Click();
            Thread.Sleep(3000);
            uappid.Click();


        }
    }
}
