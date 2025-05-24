using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using sales_manager.pages;



[TestFixture]
public class LoginTest
{
    private IWebDriver driver;
    private LoginPage loginPage;
    private NavigationPage navigationPage;
   // private StudentPage StudentPage;
    private Leadstudent leadstudent;
    private Application application;
    //private readonly WebDriverWait wait;


    [SetUp]
    public void SetUp()
    {
        driver = DriverFactory.CreateDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("http://test.uapp.uk/");
        Thread.Sleep(5000);
        loginPage = new LoginPage(driver);
        navigationPage = new NavigationPage(driver);
        leadstudent = new Leadstudent(driver);
        application = new Application(driver);
       // StudentPage = new StudentPage(driver);
    }

    [TearDown]
    public void TearDown()
    {
        //driver.Quit();
        driver.Dispose();
    }

    [Test]
    public void TestLoginAndMenuNavigation()
    {

        loginPage.Enteremail("vifotad264@deusa7.com");
        loginPage.password("emad123");
        loginPage.ClickLogin();
        Thread.Sleep(3000);
        navigationPage.clickdrop();
        Thread.Sleep(3000);
        leadstudent.clickdo();
        Thread.Sleep(3000);
        application.tapdo();
        Thread.Sleep(3000);
    }
}
