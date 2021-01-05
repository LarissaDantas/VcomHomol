using Vcom.Pages;
using Vcom.Utils;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using System.IO;


namespace Vcom.Hooks
{
    [Binding]

        public sealed class Hooks
        {
            [BeforeScenario]
            public void BeforeScenario()
            {
                var toStart = new Browser();

                if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("Chrome") ||
                    (FeatureContext.Current.FeatureInfo.Tags.Contains("Chrome")))
                    toStart.ChooseBrowser("Chrome");

                if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("Firefox") ||
                    (FeatureContext.Current.FeatureInfo.Tags.Contains("Firefox")))
                    toStart.ChooseBrowser("Firefox");
            }

        

            [AfterScenario]
            public void AfterScenario()
            {

            if (ScenarioContext.Current.TestError != null)
            {
                var screen = new ScreenShot();
                screen.ToTakeScreenShot();
            }


            var end = new Browser();
                end.ToFinishBrowser();
            }
        }

}
