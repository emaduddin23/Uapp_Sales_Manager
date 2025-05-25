using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

public class LoginPage
{
    private readonly IWebDriver driver;
    private readonly WebDriverWait wait;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
    }

    // Locators
    private IWebElement EmailField => driver.FindElement(By.XPath("//input[@placeholder='Email Address']"));
    private IWebElement Passwordfield => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
    private IWebElement LoginButton => driver.FindElement(By.XPath("//button[@type='submit']"));

    // Actions

    public void login(string username, string pass)
    {
        //EmailField.SendKeys(username);
        wait.Until(ExpectedConditions.ElementToBeClickable(EmailField)).SendKeys(username);
        wait.Until(ExpectedConditions.ElementToBeClickable(Passwordfield)).SendKeys(pass);
        wait.Until(ExpectedConditions.ElementToBeClickable(LoginButton)).Click();
        //Passwordfield.SendKeys(pass);
        //LoginButton.Click();

    }
//    public void Enteremail(string username) =>EmailField.SendKeys(username);
//    public void password(string pass) => Passwordfield.SendKeys(pass);
//    public void ClickLogin() => LoginButton.Click();
}
