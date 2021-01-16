using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Vcom.Pages
{
    public sealed class Browser
    {
        private IWebDriver Driver { get; set; }


        public void ChooseBrowser(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    var options = new ChromeOptions();
                    options.AddUserProfilePreference("credentials_enable_service", false);
                    options.AddUserProfilePreference("password_manager_enabled", false);
                    //options.AddArguments("headless");
                    options.PageLoadStrategy = PageLoadStrategy.Normal;
                    Driver = new ChromeDriver(options);
                    ConfigBrowser();
                    ScenarioContext.Current["driver"] = Driver;
                    break;

                case "Firefox":
                    Driver = new FirefoxDriver();
                    break;

                default:
                    Driver = new ChromeDriver();
                    ConfigBrowser();
                    ScenarioContext.Current["driver"] = Driver;
                    break;
            }
        }

        private void ConfigBrowser()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            Driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromMilliseconds(20);
            Driver.Manage().Window.Maximize();
            
        }

        public void ToFinishBrowser()
        {
            Driver = (IWebDriver)ScenarioContext.Current["driver"];
            Driver.Quit();
            Driver.Dispose();
        }

    }
}
