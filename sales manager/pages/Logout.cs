using OpenQA.Selenium;

namespace sales_manager.pages
{
    public class Logoutpage
    {
        private readonly IWebDriver driver;
        private readonly ElementHelper helper;

        public Logoutpage(IWebDriver driver)
        {

            this.driver = driver;
            helper = new ElementHelper(driver);
        }
        // Locators
        private By logoutButton => By.XPath("//span[@data-tour='user']");
        private By logoutLink => By.XPath("//span[normalize-space()='Log Out']");

        public void clicklogout()
        {         // Click the logout button using the helper
            helper.Click(logoutButton);
            // Click the logout link using the helper
            helper.Click(logoutLink);
        }
    }

}
