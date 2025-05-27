using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using sales_manager.pages;
using SeleniumExtras.WaitHelpers;

public class LoginPage
{
    private readonly IWebDriver driver;
    //private readonly WebDriverWait wait;
    private readonly ElementHelper helper;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
        helper = new ElementHelper(driver);
       // wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
    }

    // Locators
    //private IWebElement EmailField => driver.FindElement(By.XPath("//input[@placeholder='Email Address']"));
    //private IWebElement Passwordfield => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
    //private IWebElement LoginButton => driver.FindElement(By.XPath("//button[@type='submit']"));
    private By EmailField => By.XPath("//input[@placeholder='Email Address']");
    private By Passwordfield => By.XPath("//input[@placeholder='Password']");
    private By LoginButton =>By.XPath("//button[@type='submit']");

    // Actions

    //public void login(string username, string pass)
    ////{
    ////    //EmailField.SendKeys(username);
    ////    wait.Until(ExpectedConditions.ElementToBeClickable(EmailField)).SendKeys(username);
    ////    wait.Until(ExpectedConditions.ElementToBeClickable(Passwordfield)).SendKeys(pass);
    ////    wait.Until(ExpectedConditions.ElementToBeClickable(LoginButton)).Click();
    ////    //Passwordfield.SendKeys(pass);
    ////    //LoginButton.Click();

    ////}

    public void clickpage()
    {
        helper.Click(EmailField); // 🔁 Reusing the helper
        helper.Click(Passwordfield);

    }
    public void Enteremail(string username)
    {
        //wait.Until(ExpectedConditions.ElementIsVisible(EmailField)).SendKeys(username);
        helper.Type(EmailField, username); // Using the helper to type in the email field
    }
    public void EnterPassword(string pass)
    {
        helper.Type(Passwordfield, pass);
    }
    public void ClickLogin()
    {
        //wait.Until(ExpectedConditions.ElementToBeClickable(LoginButton)).Click();
        helper.Click(LoginButton); // Using the helper to click the login button
    }
    public void login(string username, string password)
    {
        Enteremail(username);
        EnterPassword(password);
        ClickLogin();
    }

    //    public void Enteremail(string username) =>EmailField.SendKeys(username);
    //    public void password(string pass) => Passwordfield.SendKeys(pass);
    //    public void ClickLogin() => LoginButton.Click();
}
