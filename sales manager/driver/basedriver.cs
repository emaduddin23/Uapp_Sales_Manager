using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

public static class DriverFactory
{
    public static IWebDriver CreateDriver()
    {
        return new FirefoxDriver(); // or ChromeDriver
    }
}
