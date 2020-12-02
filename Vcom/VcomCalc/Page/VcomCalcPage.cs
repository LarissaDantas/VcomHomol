using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace Vcom.Pages
{
    public class VcomCalcPage : BasePage
    {
        private readonly IWebDriver driver;

        public By inpDataPagamento = By.CssSelector("#DataDoCalculo");
        public By btnAtualizar = By.CssSelector("#btn-atualizar");
        public By btnFinalizarNegociacao = By.CssSelector("#btn-finalizar");
        public By btnVisualizarBoleto = By.CssSelector("div:nth-child(1) > p > a");

        public VcomCalcPage()
        {
            driver = (IWebDriver)ScenarioContext.Current["driver"];
        }

        public void ValidarVersao(string Versao)
        {
            Thread.Sleep(3000);
            Assert.AreEqual(Versao, GetText(By.XPath("//div/div[@class='col-md-4 col-md-offset-4 text-center']/h5/span[text()='" + Versao + "']")));
        }

        public void Negociacao(string data)
        {
            Thread.Sleep(3000);
            BarradeRolagem();
            Thread.Sleep(4000);
            WaitElementVisible(inpDataPagamento);
            ToClick(inpDataPagamento);
            ToWrite(inpDataPagamento, data);
            Thread.Sleep(3000);
            BarradeRolagem();
            ToClick(btnAtualizar);
            Thread.Sleep(2000);
            WaitElementVisible(btnFinalizarNegociacao);
            ToClick(btnFinalizarNegociacao);
        }

        public void VisualizarBoleto()
        {
            Thread.Sleep(5000);
            ToClick(btnVisualizarBoleto);
            Thread.Sleep(5000);
        }


        //public void ValidarPDF()
        //{
        //    Thread.Sleep(2000);
        //    var BtnPDF = Element.Css("a[ng-click='BaixarPDF()']");
        //    MouseActions.ClickATM(Browser, BtnPDF);

        //    Thread.Sleep(60000);

        //    AutoItHelper.CancelarImpressao();

        //    Browser.SwitchToLastWindow();
        //    CamposPDF();

        //}
    }
}
