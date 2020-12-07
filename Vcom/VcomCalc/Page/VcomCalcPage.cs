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
        public By btnBoletoEmail = By.CssSelector("div:nth-child(2) > p > a");
        public By selectEmail = By.CssSelector("div[class='col-md-6 col-sm-12'] select");
        public By opcaoEmail = By.CssSelector("div[class='col-md-6 col-sm-12'] select > option:nth-child(3)");
        public By btnEnviarEmail = By.CssSelector("#btn-envie-agora-email");
        public By btnEnviarSMS = By.CssSelector("div:nth-child(3) > p > a");
        public By selectNumero = By.XPath("//*[@class='envio-boleto-sms-form']/div/div[2]/div/div[1]/div[1]/select");
        public By selectOpcaoNumero = By.XPath("//*[@class='envio-boleto-sms-form']/div/div[2]/div/div[1]/div[1]//option[3]");
        public By selectEnvio = By.XPath("//*[@class='envio-boleto-sms-form']/div/div[2]/div/div[1]/div[3]/select");
        public By selectOpcaoEnvio = By.XPath("//*[@class='envio-boleto-sms-form']/div/div[2]/div/div[1]/div[3]//option[2]");
        public By selectSMS = By.XPath("//*[@class='envio-boleto-sms-form']/div/div[2]/div/div[2]/div/select");
        public By selectOpcaoSMS = By.XPath("//*[@class='envio-boleto-sms-form']/div/div[2]/div/div[2]/div//option[2]");
        public By btnEnviarSMSAgora = By.CssSelector("#btn-envie-agora-sms");
        public By btnNegociacoes = By.CssSelector("#btn-ultimas-negociacoes");
        public By btnMostrarOpcoes = By.XPath("//*[@id='tr-negociacao-dados-138669']/td[1]/a/i");
        public By btnOpcoes = By.XPath("//*[@id='tr-negociacao-138669']/td[2]/div/div[1]/div/button");
        public By btnReimprimir = By.XPath("//*[@id='tr-negociacao-138669']/td[2]/div/div[1]/div/ul/li[3]/a");
        public By btnCancelar = By.XPath("//*[@id='tr-negociacao-138669']/td[2]/div/div[1]/div/ul/li[5]/a");
        public By btnComandos = By.XPath("//*[@id='div-btn-comandos']/button[2]");
        public By btnGravarSimulacao = By.XPath("//*[@id='btn-gravar-simulacao']");
        public By mensagem = By.XPath("//*[@id='p-mensagem']");
        public By abrirOpcoes = By.XPath("//*[@id='tr-negociacao-dados-138675']/td[1]/a");
        public By btnOpcoesGravados = By.XPath("//*[@id='tr-negociacao-138675']/td[2]/div/div[1]/div/button");
        public By btnEmitirBoleto = By.XPath("//*[@id='tr-negociacao-138675']/td[2]/div/div[1]/div/ul/li[3]/a");
        public By btnAbrir = By.XPath("//*[@id='tr-negociacao-138675']/td[2]/div/div[1]/div/ul/li[1]/a");
        public By btnCancelarNegociacao = By.XPath("//*[@id='tr-negociacao-138675']/td[2]/div/div[1]/div/ul/li[4]/a");
        public By btnGravarPagamento = By.CssSelector("#btn-gravar-pagamento");
        public By btnConfirmarPagamento = By.CssSelector("#btn-confirmar-pagamento");



        public VcomCalcPage()
        {
            driver = (IWebDriver)ScenarioContext.Current["driver"];
        }

        public void ValidarVersao(string Versao)
        {
            Thread.Sleep(3000);
            Assert.AreEqual(Versao, GetText(By.XPath("//div/div[@class='col-md-4 col-md-offset-4 text-center']/h5/span[text()='" + Versao + "']")));
        }

        public void NegociacaoAVista(string data)
        {
            Thread.Sleep(3000);
            BarradeRolagem();
            Thread.Sleep(5000);
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

        public void NegociacaoAParcelado(string data)
        {
            Thread.Sleep(3000);
            BarradeRolagem();
            Thread.Sleep(5000);
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
        public void VisualizarEmail()
        {
            Thread.Sleep(5000);
            WaitElementVisible(btnBoletoEmail);
            ToClick(btnBoletoEmail);
            WaitElementVisible(selectEmail);
            ToClick(selectEmail);
            WaitElementVisible(opcaoEmail);
            ToClick(opcaoEmail);
            WaitElementVisible(opcaoEmail);
            ToClick(btnEnviarEmail);
            Thread.Sleep(5000);
            Assert.AreEqual("O boleto foi enviado com sucesso para: ", GetText(By.XPath("//*[@id='div - envio - resultado']/div/h3[text()='O boleto foi enviado com sucesso para: ']")));
        }

        public void EnviarPorSms()
        {
            Thread.Sleep(5000);
            WaitElementVisible(btnEnviarSMS);
            ToClick(btnEnviarSMS);
            BarradeRolagem();
            WaitElementVisible(selectNumero);
            ToClick(selectNumero);
            WaitElementVisible(selectOpcaoNumero);
            ToClick(selectOpcaoNumero);
            WaitElementVisible(selectEnvio);
            ToClick(selectEnvio);
            WaitElementVisible(selectOpcaoEnvio);
            ToClick(selectOpcaoEnvio);
            WaitElementVisible(selectSMS);
            ToClick(selectSMS);
            WaitElementVisible(selectOpcaoSMS);
            ToClick(selectOpcaoSMS);
            WaitElementVisible(btnEnviarSMSAgora);
            ToClick(btnEnviarSMSAgora);
            Thread.Sleep(5000);
        }

        public void UltimasAtualizações()
        {
            BarradeRolagem();
            BarradeRolagem();
            Thread.Sleep(3000);
            WaitElementVisible(btnNegociacoes);
            ToClick(btnNegociacoes);
        }

        public void VisualizarUltimasAtualizações()
        {
            Thread.Sleep(3000);
            BarradeRolagem();
            Thread.Sleep(3000);
            Assert.AreEqual("Últimas negociações", GetText(By.XPath("//*[@id='div-ultimas-negociacoes']/div/span[text()='Últimas negociações']")));
        }

        public void SelecionarReimpressao()
        {
            Thread.Sleep(3000);
            WaitElementVisible(btnMostrarOpcoes);
            ToClick(btnMostrarOpcoes);
            WaitElementVisible(btnOpcoes);
            ToClick(btnOpcoes);
            Thread.Sleep(3000);
            WaitElementVisible(btnReimprimir);
            ToClick(btnReimprimir);
        }

        public void VisualizarReimpressao()
        {
            Thread.Sleep(5000);
        }

        public void CancelarBoleto()
        {
            Thread.Sleep(3000);
            WaitElementVisible(btnMostrarOpcoes);
            ToClick(btnMostrarOpcoes);
            WaitElementVisible(btnOpcoes);
            ToClick(btnOpcoes);
            Thread.Sleep(3000);
            WaitElementVisible(btnCancelar);
            ToClick(btnCancelar);
        }

        public void SalvarNegociacao()
        {
            Thread.Sleep(3000);
            BarradeRolagem();
            Thread.Sleep(5000);
            WaitElementVisible(inpDataPagamento);
            ToClick(inpDataPagamento);
            ToWrite(inpDataPagamento, "07/12/2020");
            Thread.Sleep(3000);
            BarradeRolagem();
            WaitElementVisible(btnComandos);
            ToClick(btnComandos);
            Thread.Sleep(3000);
            WaitElementVisible(btnGravarSimulacao);
            ToClick(btnGravarSimulacao);
        }

        public void EmitirBoleto()
        {
            Thread.Sleep(3000);
            WaitElementVisible(abrirOpcoes);
            ToClick(abrirOpcoes);
            WaitElementVisible(btnOpcoesGravados);
            ToClick(btnOpcoesGravados);
            Thread.Sleep(3000);
            WaitElementVisible(btnEmitirBoleto);
            ToClick(btnCancelar);
        }

        public void Abrir()
        {
            Thread.Sleep(3000);
            WaitElementVisible(abrirOpcoes);
            ToClick(abrirOpcoes);
            WaitElementVisible(btnOpcoesGravados);
            ToClick(btnOpcoesGravados);
            Thread.Sleep(3000);
            WaitElementVisible(btnAbrir);
            ToClick(btnAbrir);
        }

        public void Cancelar()
        {
            Thread.Sleep(3000);
            WaitElementVisible(abrirOpcoes);
            ToClick(abrirOpcoes);
            WaitElementVisible(btnOpcoesGravados);
            ToClick(btnOpcoesGravados);
            Thread.Sleep(3000);
            WaitElementVisible(btnCancelarNegociacao);
            ToClick(btnCancelarNegociacao);
        }

        public void RecebimentoNegociacao()
        {
            Thread.Sleep(3000);
            BarradeRolagem();
            Thread.Sleep(5000);
            WaitElementVisible(inpDataPagamento);
            ToClick(inpDataPagamento);
            ToWrite(inpDataPagamento, "07/12/2020");
            Thread.Sleep(3000);
            BarradeRolagem();
            WaitElementVisible(btnComandos);
            ToClick(btnComandos);
            Thread.Sleep(2000);
            WaitElementVisible(btnGravarPagamento);
            ToClick(btnGravarPagamento);
            Thread.Sleep(5000);
            WaitElementVisible(btnConfirmarPagamento);
        }
    }
}
