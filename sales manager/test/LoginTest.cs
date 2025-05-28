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
    private Dashboard dashboard; // Added Dashboard instance for completeness
    private WebDriverWait wait; // Removed readonly modifier  
    private Myprofile myprofile; // Added Myprofile instance for completeness
    private Logoutpage Logoutpage; // Added Logout instance for completeness
    [SetUp]
    public void SetUp()
    {
        driver = DriverFactory.CreateDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("http://test.uapp.uk/");
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        //Thread.Sleep(3000); // Consider using WebDriverWait instead of Thread.Sleep for better synchronization
        //Thread.Sleep(3000); // Consider using WebDriverWait instead of Thread.Sleep for better synchronization
        loginPage = new LoginPage(driver);
        navigationPage = new NavigationPage(driver);
        leadstudent = new Leadstudent(driver);
        application = new Application(driver);
        dashboard = new Dashboard(driver); // Initialize Dashboard instance 
        myprofile = new Myprofile(driver);
        Logoutpage = new Logoutpage(driver); // Initialize Logout instance if needed
        //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30)); // Now allowed since 'wait' is no longer readonly  
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
        
        loginPage.login("rijetab665@daxiake.com", "a123456");

        //Thread.Sleep(3000); // Consider using WebDriverWait instead of Thread.Sleep for better synchronization

        dashboard.ClickDashboard();// Navigate to the dashboard after clicking the example
        myprofile.ClickMyProfile();
        navigationPage.ClickExample();
        Logoutpage.clicklogout();

        // navigationPage.clickdrop();
        //leadstudent.clickdo();
        //Thread.Sleep(3000);
        //application.tapdo();
        //Thread.Sleep(3000);
    }
}
