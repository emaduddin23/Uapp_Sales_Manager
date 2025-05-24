using OpenQA.Selenium;

public class LoginPage
{
    private readonly IWebDriver driver;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    // Locators
    private IWebElement EmailField => driver.FindElement(By.XPath("//input[@placeholder='Email Address']"));
    private IWebElement Passwordfield => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
    private IWebElement LoginButton => driver.FindElement(By.XPath("//button[@type='submit']"));

    // Actions
    public void Enteremail(string username) =>EmailField.SendKeys(username);
    public void password(string pass) => Passwordfield.SendKeys(pass);
    public void ClickLogin() => LoginButton.Click();
}
