using Vcom.Pages;
using TechTalk.SpecFlow;
using System.Configuration;

namespace Vcom.VcomCob.Steps
{
    [Binding]
    public class VcomCalcSteps : BasePage
    {
        

        public HomePage HomePage { get; private set; }
        public VcomCalcPage VcomCalcPage { get; private set; }

        public VcomCalcSteps()
        {
            HomePage = new HomePage();
            VcomCalcPage = new VcomCalcPage();
        }


        [Given(@"que eu acesso o VComCalc Sistemas")]
        public void DadoQueEuAcessoOVComCalcSistemas()
        {
            HomePage.GoTo(ConfigurationManager.AppSettings["VcomCalcSistemasURL"]);
        }

        [Then(@"é apresentada as versões dos sistemas ""(.*)""")]
        public void EntaoEApresentadaAsVersoesDosSistemas(string Versao)
        {
            VcomCalcPage.ValidarVersao(Versao);
        }

        [Given(@"que eu acesso o VcomCalc com cliente negociavel")]
        public void DadoQueEuAcessoOVcomCalcComClienteNegociavel()
        {
            HomePage.GoTo(ConfigurationManager.AppSettings["VcomCalcURL"]);
        }

        [Given(@"realizo uma negociação a vista ""(.*)""")]
        public void DadoRealizoUmaNegociacaoAVista(string Data)
        {
            VcomCalcPage.Negociacao(Data);
        }

        [Then(@"e apresentado com sucesso o boleto para impressao")]
        public void EntaoEApresentadoComSucessoOBoletoParaImpressao()
        {
            VcomCalcPage.VisualizarBoleto();
        }

    }
}
