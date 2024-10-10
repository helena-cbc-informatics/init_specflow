using TechTalk.SpecFlow;
using init_specflow.Drivers;
using OpenQA.Selenium;


namespace init_specflow.Steps
{
    [Binding]
    public sealed class StepDefinitions
    {
       
       private readonly ScenarioContext _scenarioContext;

       public StepDefinitions(ScenarioContext scenarioContext)
       {
           _scenarioContext = scenarioContext;
       }

       [Given("I am at website \"(.*)\"")]
       public void GivenIAmAtWebsite(string website)
       {
           Driver.OpenChromeBrowser(website);
       }

       [When("I search for \"(.*)\"")]
       public void WhenISearchFor(string search)
       {
            Driver.GetWebElementByXpath(GoogleElements.BtnAcceptCookies).Click();
            Driver.GetWebElementByXpath(GoogleElements.InpSearch).SendKeys(search + Keys.Enter);
       }

       [Then("I validate Helenas LinkedIn is displayed")]
        public void ThenIValidateHelenasLinkedInIsDisplayed()
        {
            Driver.GetWebElementByXpath(GoogleElements.LblHelenaCaronaLinkedIn);
        }
    }
}
