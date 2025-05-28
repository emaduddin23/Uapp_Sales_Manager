using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace sales_manager.pages
{
    public class ScrollHelper
    {
        private readonly IWebDriver driver;
        public ScrollHelper(IWebDriver driver) {
         this.driver = driver;  
        }
        public void ScrollBy(int x, int y)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript($"window.scrollBy({x}, {y});");
        }

        public void ScrollToBottom()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        }

        public void ScrollToElement(By locator)
        {
            IWebElement element = driver.FindElement(locator);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
    }
}
