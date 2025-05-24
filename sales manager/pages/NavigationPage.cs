using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

public class NavigationPage
{
    private readonly IWebDriver driver;
   // private readonly Actions actions;

    public NavigationPage(IWebDriver driver)
    {
        this.driver = driver;
       // this.actions = new Actions(driver);
    }

    // tap student button
    private IWebElement tappage => driver.FindElement(By.XPath("//span[normalize-space()='Student']"));
    private IWebElement parent => driver.FindElement(By.CssSelector("div#UniversityTypeId.css-b62m3t-container > div.css-13cymwt-control:nth-child(3)"));
    private IWebElement selectint => driver.FindElement(By.XPath("//div[contains(text(),'International')]"));
    private IWebElement consultant => driver.FindElement(By.CssSelector("div.mb-2.col-sm-12.col-md-3.col-lg-4 > div#consultantId.css-b62m3t-container"));
    private IWebElement selectcon => driver.FindElement(By.XPath("//div[contains(text(),'rahim')]"));
    private IWebElement status => driver.FindElement(By.CssSelector("div.mb-2.col-sm-12.col-md-3.col-lg-4 > div#status.css-b62m3t-container"));
    private IWebElement selectsta => driver.FindElement(By.XPath("//div[contains(text(),'Active')]"));

    private IWebElement typname => driver.FindElement(By.XPath("//input[@id='search']"));

    private IWebElement clear => driver.FindElement(By.XPath("//button[normalize-space()='Clear All']"));


    //action
    public void clickdrop()
    {
        tappage.Click();
        Thread.Sleep(3000);
        parent.Click();
        Thread.Sleep(3000);
        selectint.Click();
        Thread.Sleep(3000);
        consultant.Click();
        Thread.Sleep(3000);
        selectcon.Click();
        Thread.Sleep(3000);
        status.Click();
        Thread.Sleep(3000);
        selectsta.Click();
        Thread.Sleep(3000);
        typname.SendKeys("rasid khan");
        Thread.Sleep(3000);
        clear.Click();
        //leadstudnet.Click();
        //application.Click();
        //scroll1.Click();    
    }





}









//// Hover over login button
//actions.MoveToElement(driver.FindElement(By.CssSelector(".btn-register-lg"))).Perform();

//// Move to top left
//actions.MoveToElement(driver.FindElement(By.TagName("body")), 0, 0).Perform();

//// Click menu buttons
//driver.FindElement(By.CssSelector(".\\33")).Click();
//driver.FindElement(By.CssSelector(".hover .menu-text")).Click();
//driver.FindElement(By.CssSelector(".css-15lsz6c-indicatorContainer")).Click();
//driver.FindElement(By.Id("react-select-5-option-2")).Click();
//driver.FindElement(By.CssSelector(".fa-arrow-circle-left")).Click();
//driver.FindElement(By.CssSelector(".round")).Click();
//driver.FindElement(By.CssSelector(".dropdown-item:nth-child(5) > .align-middle:nth-child(2)")).Click();


