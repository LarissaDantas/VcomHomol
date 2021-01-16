using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Vcom.Pages
{
    public class BasePage
    {
        private static readonly int WAIT_ELEMENT_SECONDS = 80;
        private readonly IWebDriver driver;

        private  WebDriverWait Wait;

        public BasePage()
        {
            driver = (IWebDriver)ScenarioContext.Current["driver"];
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(WAIT_ELEMENT_SECONDS));


        }

        public void JavaScript(string script)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            string title = (string)jse.ExecuteScript(script);
        }
        public void BarradeRolagem()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("scrollBy(0,850);");
        }

        public void BarradeRolagemSubindo()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("scroll(250, 0);");
        }


        public IWebElement WaitElement(By path)
        {
            //WaitForAjax();
            Thread.Sleep(1000);
            return  Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(path));
            
        }
        //public void WaitForAjax()
        //{
        //    while (true) // Handle timeout somewhere
        //    {
        //        var ajaxIsComplete = (bool)(driver as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0 && document.readyState =='complete'");
        //        if (ajaxIsComplete)
        //            break;
        //        Thread.Sleep(100);
        //    }
        //}
        public bool WaitElementVisible(By path)
        {
            
            var element = WaitElement(path);
            Console.WriteLine(element.Displayed);
            return element.Displayed;
        }

        public bool WaitElementIsClickabe(By path)
        {
            var element = WaitElement(path);
            return element.Displayed && element.Enabled;
        }

        public IWebElement ToLocate(By path)
        {
            return driver.FindElement(path);
        }

        public void ToClick(By path)
        {
            //WaitElementVisible(path);
            WaitElementIsClickabe(path);
            ToLocate(path).Click();
        }

        public void ToWrite(By path, string text)
        {
            WaitElementVisible(path);
            ToLocate(path).Clear();
            ToLocate(path).SendKeys(text);
            ToLocate(path).SendKeys(Keys.Tab);
        }

            public void TAB(By path)
        {
            WaitElementVisible(path);
            ToLocate(path).Click();
            ToLocate(path).SendKeys(Keys.Tab);
        }
        public string GetText(By path)
        {
            WaitElementVisible(path);
            return ToLocate(path).Text;
        }

        public void ToNavigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void ToSelectByText(By path, String text)
        {
            WaitElementVisible(path);
            new SelectElement(ToLocate(path)).SelectByText(text);

        }

    }
}
