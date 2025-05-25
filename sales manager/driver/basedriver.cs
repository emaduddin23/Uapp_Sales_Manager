using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

public static class DriverFactory
{
    public static IWebDriver driver;
    public static WebDriverWait Wait;
    //public DriverFactory(IWebDriver driver)
    //{
    //    this.driver = driver;
    //    Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
    //}
    public static void DriverContext()
    {
        driver = new FirefoxDriver(); // or ChromeDriver
        Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
    }
    //public static IWebDriver CreateDriver()
    //{
    //    return new FirefoxDriver(); // or ChromeDriver
    //}

    public static void Quit()

    {
        driver.Dispose();
        driver.Quit();
    }
}
