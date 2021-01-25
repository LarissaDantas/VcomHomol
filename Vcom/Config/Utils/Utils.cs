using OpenQA.Selenium;
using System;
using System.IO;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Tracing;

namespace Vcom.Utils
{
    public class ScreenShot
    {
        private IWebDriver Driver { get; set; }
        public void ToTakeScreenShot()
        {
            if (ScenarioContext.Current.TestError != null)
            {
                Driver = (IWebDriver)ScenarioContext.Current["driver"];
                ToTakeScreenshot(Driver,"error");
            }
        }

        public void ToTakeScreenshot(IWebDriver Driver,string state="sucess")
        {
            try
            {
                string fileNameBase = string.Format("{2}-{0}_{1}",
                //FeatureContext.Current.FeatureInfo.Title.ToIdentifier(),
                DateTime.Now.ToString("dd.MM.yyyy"),
                ScenarioContext.Current.ScenarioInfo.Title.ToIdentifier(),state);
                //var x = Directory.GetDirectories("C:");
                var artifactDirectory = Path.Combine("C:/Evidency", "imagens_"+state);
                if (!Directory.Exists(artifactDirectory))
                    Directory.CreateDirectory(artifactDirectory);
                string pageSource = Driver.PageSource;
                string sourceFilePath = Path.Combine(artifactDirectory, fileNameBase + "_source.html");
                File.WriteAllText(sourceFilePath, pageSource, Encoding.UTF8);
                Console.WriteLine("Page source: {0}", new Uri(sourceFilePath));
                ITakesScreenshot toTakeScreenShot = Driver as ITakesScreenshot;
                if (toTakeScreenShot != null)
                {
                    var screenshot = toTakeScreenShot.GetScreenshot();
                    string screenshotCaminhoArquivo = Path.Combine(artifactDirectory, fileNameBase + "_screenshot.png");
                    screenshot.SaveAsFile(screenshotCaminhoArquivo, ScreenshotImageFormat.Png);
                    Console.WriteLine("ScreenShot: {0}", new Uri(screenshotCaminhoArquivo));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error taking screenshot: {0}", ex);
            }
        }
    }
}
