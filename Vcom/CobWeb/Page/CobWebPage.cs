using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace Vcom.Pages
{
    public class CobWebPage : BasePage
    {
        private readonly IWebDriver driver;

        public By inpLogin = By.XPath("//*[@id='txtUsuario']");
        public By inpSenha = By.XPath("//*[@id='txtSenha']");
        public By inpEntrar = By.XPath("//*[@id='btnConfirmar']");
        public By impMenu = By.XPath("//*[@id='divPrincipal']");

        public CobWebPage()
        {
            driver = (IWebDriver)ScenarioContext.Current["driver"];
        }

        public void Logar()
        {
          //Thread.Sleep(5000);
            ToClick(inpLogin);
            ToWrite(inpLogin, "cobsystems");
            WaitElementVisible(inpSenha);
          //Thread.Sleep(3000);
            ToClick(inpSenha);
          //Thread.Sleep(1000);
            ToWrite(inpSenha, "cob3vc");
          //Thread.Sleep(3000);
            ToClick(inpEntrar);
          //Thread.Sleep(1000);
            WaitElementVisible(impMenu);
        }

        public void Usuario()
        {
          //Thread.Sleep(5000);
            ToClick(inpLogin);
            ToWrite(inpLogin, "cobsystems");
        }

        public void Senha()
        {
            WaitElementVisible(inpSenha);
          //Thread.Sleep(3000);
            ToClick(inpSenha);
          //Thread.Sleep(1000);
            ToWrite(inpSenha, "cob3vc");
        }

        public void PaginaInicial()
        {
          //Thread.Sleep(3000);
            ToClick(inpEntrar);
          //Thread.Sleep(2000);
        }

        public void Telecobrança()
        {
          //Thread.Sleep(3000);
            JavaScript("document.querySelector('#M3001').click();");
        }
    }
}
