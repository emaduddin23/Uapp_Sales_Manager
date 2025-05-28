using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace sales_manager.pages
{
    public class Dashboard
    {
        private readonly IWebDriver driver;
        private readonly ElementHelper helper;
        //private readonly WebDriverWait wait;
        public ScrollHelper scrollHelper;
        public Dashboard(IWebDriver driver)
        {
            this.driver = driver;
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            helper = new ElementHelper(driver);
            scrollHelper = new ScrollHelper(driver);
        }
        // Locators
        private By dashboardLink => By.CssSelector(".nav-item.uapp-nav-item.active");
        public void ClickDashboard()
        {
            // Click the dashboard link using the helper
            helper.Click(dashboardLink);
            scrollHelper.ScrollBy(0, 500); // Scroll down to ensure the dashboard link is visible
           // scrollHelper.ScrollBy(); // Scroll to the dashboard link if needed
        }
    }
}
