using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace init_specflow.Drivers
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void OpenChromeBrowser(string website)
        {
            ChromeOptions options = new();
            options.AddArgument("--start-maximized");

            try
            {
                driver = new ChromeDriver(options);
                driver.Navigate().GoToUrl(Websites.GetWebsiteUrl(website));
            }
            catch (Exception e)
            {
                throw new NotPossibleToOpenBrowser("chrome", website, e);
            }
        }

        public static void CloseChromeBrowser()
        {
            if(driver != null)
            {
                driver.Close();
                driver.Quit();
            }
        }

        public static IWebElement GetWebElementByXpath(string xpath)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Setup.Timeout))
                {
                    PollingInterval = TimeSpan.FromSeconds(Setup.Polling),
                };
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
                return driver.FindElement(By.XPath(xpath));
            }
            catch (Exception e)
            {
                throw new ElementNotFoundException("XPath", xpath, e);
            }
        }

    }

    public class Websites
    {
        public static string GetWebsiteUrl(string websiteName)
        {
            switch(websiteName)
            {
                case "google":
                    return "https://www.google.com";
                default:
                    throw new WebsiteNameNotFoundException(websiteName);
            }
        }
    }
}
