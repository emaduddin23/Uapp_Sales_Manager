using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

public class StudentPage
{
    private IWebDriver driver;

    public StudentPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    private IWebElement GraduationIcon => driver.FindElement(By.CssSelector(".fa-graduation-cap"));

    public void ClickGraduationIcon()
    {
        GraduationIcon.Click();
    }

    public void SelectDropdownOption(string dropdownId, int optionIndex)
    {
        driver.FindElement(By.CssSelector(".css-t3ipsp-control .css-19bb58m")).Click();
        driver.FindElement(By.Id($"{dropdownId}-option-{optionIndex}")).Click();
    }

    public void ClearTag()
    {
        driver.FindElement(By.CssSelector(".tag-clear")).Click();
    }

    public void ClickMenuItem()
    {
        driver.FindElement(By.CssSelector(".hover .menu-item")).Click();
    }
}
