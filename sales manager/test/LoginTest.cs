using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using sales_manager.pages;
using SeleniumExtras.WaitHelpers;



[TestFixture]
public class LoginTest
{
    private IWebDriver driver;
    private LoginPage loginPage;
    private NavigationPage navigationPage;
    private Leadstudent leadstudent;
    private Application application;
    private WebDriverWait wait; // Removed readonly modifier  

    [SetUp]
    public void SetUp()
    {
        driver = DriverFactory.CreateDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("http://test.uapp.uk/");
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        Thread.Sleep(3000); // Consider using WebDriverWait instead of Thread.Sleep for better synchronization
        //Thread.Sleep(3000); // Consider using WebDriverWait instead of Thread.Sleep for better synchronization
        loginPage = new LoginPage(driver);
        navigationPage = new NavigationPage(driver);
        leadstudent = new Leadstudent(driver);
        application = new Application(driver);

        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30)); // Now allowed since 'wait' is no longer readonly  
    }

    [TearDown]
    public void TearDown()
    {
        driver.Dispose();
    }

    [Test]
    public void TestLoginAndMenuNavigation()
    {
        //loginPage.Enteremail("vifotad264@deusa7.com");
        //loginPage.password("emad123");
        //loginPage.ClickLogin();
        loginPage.login("vifotad264@deusa7.com", "emad123");
        Thread.Sleep(3000); // Consider using WebDriverWait instead of Thread.Sleep for better synchronization
        navigationPage.clickdrop();
        leadstudent.clickdo();
        Thread.Sleep(3000);
        application.tapdo();
        Thread.Sleep(3000);
    }
}
