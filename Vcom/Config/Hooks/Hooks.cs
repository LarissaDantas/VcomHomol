using Vcom.Pages;
using Vcom.Utils;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using System.IO;
using OpenQA.Selenium;

namespace Vcom.Hooks
{
    [Binding]

    public sealed class Hooks
    {
        Browser browser;
        [BeforeScenario]
        public void BeforeScenario()
        {
          browser = new Browser();

            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("Chrome") ||
                (FeatureContext.Current.FeatureInfo.Tags.Contains("Chrome")))
                browser.ChooseBrowser("Chrome");

            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("Firefox") ||
                (FeatureContext.Current.FeatureInfo.Tags.Contains("Firefox")))
                browser.ChooseBrowser("Firefox");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var screen = new ScreenShot();
            screen.ToTakeScreenshot((IWebDriver)ScenarioContext.Current["driver"],"finish");
            browser.ToFinishBrowser();
        }
    }

}
