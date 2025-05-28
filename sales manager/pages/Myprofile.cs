using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V134.Network;
using OpenQA.Selenium.Support.UI;

namespace sales_manager.pages
{
    public class Myprofile
    {
        private readonly IWebDriver driver;
        private readonly ElementHelper helper;
        
        public Myprofile(IWebDriver driver)
        {
            this.driver = driver;
            helper = new ElementHelper(driver);
           

        }
        // Locators
        private By myprofileLink => By.XPath("//span[normalize-space()='My Profile']");
        public void ClickMyProfile()
        {
            // Click the My Profile link using the helper
            helper.Click(myprofileLink);
            // Optionally, scroll down to ensure the My Profile link is visible
            // scrollHelper.ScrollBy(0, 500); 
        }
    }
}
