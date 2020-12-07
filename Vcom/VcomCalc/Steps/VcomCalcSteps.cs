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
            VcomCalcPage.NegociacaoAVista(Data);
        }

        [Then(@"e apresentado com sucesso o boleto para impressao")]
        public void EntaoEApresentadoComSucessoOBoletoParaImpressao()
        {
            VcomCalcPage.VisualizarBoleto();
        }

        [Given(@"realizo uma negociação parcelado ""(.*)""")]
        public void DadoRealizoUmaNegociacaoParcelado(string Data)
        {
            VcomCalcPage.NegociacaoAParcelado(Data);
        }

        [Then(@"e apresentado com sucesso o boleto para email")]
        public void EntaoEApresentadoComSucessoOBoletoParaEmail()
        {
            VcomCalcPage.VisualizarEmail();
        }

        [Then(@"e apresentado com sucesso o boleto para o sms")]
        public void EntaoEApresentadoComSucessoOBoletoParaOSms()
        {
            VcomCalcPage.EnviarPorSms();
        }

        [Given(@"clico em detalhes")]
        public void DadoClicoEmDetalhes()
        {
            VcomCalcPage.UltimasAtualizações();
        }

        [Then(@"visualiso as ultimas negociaçoes")]
        public void EntaoVisualisoAsAultimasNegociacoes()
        {
            VcomCalcPage.VisualizarUltimasAtualizações();
        }

        [Given(@"seleciono a opção de reimprimir")]
        public void DadoSelecionoAOpcaoDeReimprimir()
        {
            VcomCalcPage.UltimasAtualizações();
            VcomCalcPage.VisualizarUltimasAtualizações();
            VcomCalcPage.SelecionarReimpressao();
        }

        [Then(@"visualizo a reimpressão com sucesso")]
        public void EntaoVisualizoAReimpressaoComSucesso()
        {
            VcomCalcPage.VisualizarReimpressao();
        }

        [Given(@"seleciono a opção de cancelar boletos")]
        public void DadoSelecionoAOpcaoDeCancelarBoletos()
        {
            VcomCalcPage.CancelarBoleto();
        }

        [Then(@"o boleto é cancelado com sucesso")]
        public void EntaoOBoletoECanceladoComSucesso()
        {
            VcomCalcPage.VisualizarReimpressao();
        }

        [Given(@"seleciono a opção de gravar negociação")]
        public void DadoSelecionoAOpcaoDeGravarNegociacao()
        {
            VcomCalcPage.SalvarNegociacao();
        }

        [Then(@"é gravado com sucesso")]
        public void EntaoEGravadoComSucesso()
        {
            VcomCalcPage.VisualizarReimpressao();
        }

        [Given(@"seleciono a opção de emitir boleto")]
        public void DadoSelecionoAOpcaoDeEmitirBoleto()
        {
            VcomCalcPage.EmitirBoleto();
        }

        [Given(@"seleciono abrir calculo gravado")]
        public void DadoSelecionoAbrirCalculoGravado()
        {
            VcomCalcPage.Abrir();
        }

        [Then(@"visualizo a negociação em aberto")]
        public void EntaoVisualizoANegociacaoEmAberto()
        {
            VcomCalcPage.VisualizarReimpressao();
        }

        [Given(@"seleciono cancelamento de cálculo gravado")]
        public void DadoSelecionoCancelamentoDeCalculoGravado()
        {
            VcomCalcPage.Cancelar();
        }

        [Then(@"visualizo o cancelamento com sucesso")]
        public void EntaoVisualizoOCancelamentoComSucesso()
        {
            VcomCalcPage.VisualizarReimpressao();
        }

        [Given(@"seleciono a opção de recebimento")]
        public void DadoSelecionoAOpcaoDeRecebimento()
        {
            VcomCalcPage.RecebimentoNegociacao();
        }

        [Then(@"e confirmado o recebimento")]
        public void EntaoEConfirmadoORecebimento()
        {
            VcomCalcPage.VisualizarReimpressao();
        }

    }
}
