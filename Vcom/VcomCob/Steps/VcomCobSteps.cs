using Vcom.Pages;
using TechTalk.SpecFlow;
using System.Configuration;

namespace Vcom.VcomCob.Steps
{
    [Binding]
    public class VcomCobSteps : BasePage
    {
        

        public HomePage HomePage { get; private set; }
        public VcomCobPage VcomCobPage { get; private set; }

        public VcomCobSteps()
        {
            HomePage = new HomePage();
            VcomCobPage = new VcomCobPage();
        }

        [Given(@"que eu acesso o VcomCob")]
        public void DadoQueEuAcessoOVcomCob()
        {
            HomePage.GoTo(ConfigurationManager.AppSettings["VcomCobURL"]);
        }

        [Given(@"informo usuario e senha")]
        public void DadoInformoUsuarioESenha()
        {
            VcomCobPage.Usuario();
            VcomCobPage.Senha();
        }

        [Then(@"e realizado o login com sucesso")]
        public void EntaoERealizadoOLoginComSucesso()
        {
            VcomCobPage.ValidarLogoZaap();
        }

        [Given(@"que esteja logado")]
        public void DadoQueEstejaLogado()
        {
            HomePage.GoTo(ConfigurationManager.AppSettings["VcomCobURL"]);
            VcomCobPage.Logar();
        }

        [Given(@"realizo uma busca de cliente por nome ""(.*)""")]
        public void DadoRealizoUmaBuscaDeClientePorNome(string nome)
        {
            VcomCobPage.Acessarfichadecliente();
            VcomCobPage.PesquisarPorNome(nome);
        }

        [Then(@"encontro o nome com sucesso na ficha de cliente ""(.*)""")]
        public void EntaoEncontroONomeComSucessoNaFichaDeCliente(string nome)
        {
            VcomCobPage.ResultadoEsperadoPesquisa(nome);
        }

        [Given(@"realizo uma busca de cliente por CPF ""(.*)""")]
        public void DadoRealizoUmaBuscaDeClientePorCPF(string CPF)
        {
            VcomCobPage.Acessarfichadecliente();
            VcomCobPage.PesquisarPorCPF(CPF);
        }

        [Then(@"encontro o CPF com sucesso na ficha de cliente ""(.*)""")]
        public void EntaoEncontroOCPFComSucessoNaFichaDeCliente(string CPF)
        {
            VcomCobPage.ResultadoEsperadoPesquisa(CPF);
        }

        [Given(@"realizo uma busca de cliente por contrato ""(.*)""")]
        public void DadoRealizoUmaBuscaDeClientePorContrato(string Contrato)
        {
            VcomCobPage.Acessarfichadecliente();
            VcomCobPage.PesquisarPorContrato(Contrato);
        }

        [Then(@"encontro o contrato com sucesso na ficha de cliente ""(.*)""")]
        public void EntaoEncontroOContratoComSucessoNaFichaDeCliente(string Contrato)
        {
            VcomCobPage.ResultadoEsperadoPesquisa(Contrato);
        }

        [Given(@"realizo uma busca de cliente por complemento do contrato ""(.*)""")]
        public void DadoRealizoUmaBuscaDeClientePorComplementoDoContrato(string CompContrato)
        {
            VcomCobPage.Acessarfichadecliente();
            VcomCobPage.PesquisarPorCompContrato(CompContrato);
        }

        [Then(@"encontro o complemento do contrato com sucesso na ficha de cliente ""(.*)""")]
        public void EntaoEncontroOComplementoDoContratoComSucessoNaFichaDeCliente(string CompContrato)
        {
            VcomCobPage.ResultadoEsperadoPesquisa(CompContrato);
        }

        [Given(@"realizo uma busca de cliente por Nosso Numero ""(.*)""")]
        public void DadoRealizoUmaBuscaDeClientePorNossoNumero(string NossoNumero)
        {
            VcomCobPage.Acessarfichadecliente();
            VcomCobPage.PesquisarPorCompContrato(NossoNumero);
        }

        [Then(@"encontro o Nosso Numero com sucesso na ficha de cliente ""(.*)""")]
        public void EntaoEncontroONossoNumeroComSucessoNaFichaDeCliente(string NossoNumero)
        {
            VcomCobPage.ResultadoEsperadoPesquisa(NossoNumero);
        }

        [Given(@"realizo uma busca com sucesso por um cliente")]
        public void DadoRealizoUmaBuscaComSucessoPorUmCliente()
        {
            VcomCobPage.Acessarfichadecliente();
            VcomCobPage.PesquisarPorNome("MARIA DA SILVA MIRANDA");
            VcomCobPage.ResultadoEsperadoPesquisa("MARIA DA SILVA MIRANDA");
        }

        [Then(@"e apresentado a tela de Ficha do Cliente")]
        public void EntaoEApresentadoATelaDeFichaDoCliente()
        {
            VcomCobPage.PaginaFichaCliente();
        }

        [When(@"seleciono inserção de serviços")]
        public void QuandoSelecionoInsercaoDeServicos()
        {
            VcomCobPage.PaginaFichaCliente();
            VcomCobPage.SelecionarServiços();
        }

        [When(@"confirmo a inserção com todos os campos preenchidos")]
        public void QuandoConfirmoAInsercaoComTodosOsCamposPreenchidos()
        {
            VcomCobPage.IncluirServico();
        }

        [Then(@"a insersão é criada com sucesso")]
        public void EntaoAInsersaoECriadaComSucesso()
        {
            VcomCobPage.ValidarSucesso();
        }

        [Given(@"seleciono a Opção de Aplicação de filtros")]
        public void DadoSelecionoAOpcaoDeAplicacaoDeFiltros()
        {
            VcomCobPage.AcessarAplicacaoDeFiltros();
        }

        [Given(@"confirmo a Aplicação de filtros com todos os campos preenchidos")]
        public void DadoConfirmoAAplicacaoDeFiltrosComTodosOsCamposPreenchidos()
        {
            VcomCobPage.PesquisarFiltros();
        }

        [Then(@"é criado o filtro com sucesso")]
        public void EntaoECriadoOFiltroComSucesso()
        {
            VcomCobPage.AplicarFiltros();
        }

        [Given(@"seleciono a Opção de Aplicação de sequência")]
        public void DadoSelecionoAOpcaoDeAplicacaoDeSequencia()
        {
            VcomCobPage.AcessarAplicaçãoDeSequencia();
            HomePage.GoTo(ConfigurationManager.AppSettings["AplicacaoDeSequenciaURL"]);
        }

        [Given(@"confirmo a Aplicação de sequência com todos os campos preenchidos")]
        public void DadoConfirmoAAplicacaoDeSequenciaComTodosOsCamposPreenchidos()
        {
            VcomCobPage.PesquisarSequencia();
        }

        [Then(@"é criado a Aplicação de sequência com sucesso")]
        public void EntaoECriadoAAplicacaoDeSequenciaComSucesso()
        {
            VcomCobPage.AplicarSequencia();
        }



    }
}
