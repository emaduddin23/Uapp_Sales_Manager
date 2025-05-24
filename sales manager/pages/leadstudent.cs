using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace sales_manager.pages
{
    public class Leadstudent
    {
        private readonly IWebDriver driver;

        public Leadstudent(IWebDriver driver)
        {
            this.driver = driver;
        }

        //tap the leadstudent menu
        private IWebElement leadstudents => driver.FindElement(By.XPath("//span[normalize-space()='Lead Students']"));
        private IWebElement leadconst => driver.FindElement(By.XPath("//div[@id='consultantId']"));

        private IWebElement selectconst => driver.FindElement(By.XPath("//div[contains(text(),'Foysal ahmed')]"));

        public void clickdo()
        {
            leadstudents.Click();
            Thread.Sleep(3000);
            leadconst.Click();
            Thread.Sleep(2000);
            selectconst.Click();
        }

    }
}
