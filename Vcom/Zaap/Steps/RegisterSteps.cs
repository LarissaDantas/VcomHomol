using Vcom.Pages;
using System.Configuration;
using TechTalk.SpecFlow;
using System;

namespace Vcom.Zaap.Features
{
    [Binding]
    public class RegisterSteps : BasePage
    {
        

        public HomePage HomePage { get; private set; }
        public RegisterPage RegisterPage { get; private set; }

        public RegisterSteps()
        {
            HomePage = new HomePage();
            RegisterPage = new RegisterPage();

        }

        
        [Given(@"que eu acesso o Zaap")]
        public void DadoQueEuAcessoOZaap()
        {
            HomePage.GoTo(ConfigurationManager.AppSettings["ZaapURL"]);
            RegisterPage.Logar();
            RegisterPage.ValidarLogoZaap();
        }

        [Given(@"esteja logado com perfil Operador")]
        public void DadoEstejaLogadoComPerfilOperador()
        {
            RegisterPage.SelecionarModoOperador();
        }

        [Given(@"conecto em uma equipe")]
        public void DadoConectoEmUmaEquipe()
        {
            RegisterPage.SelecionarEquipe();
        }

        [Then(@"estarei na pagina inicial do Operador")]
        public void EntaoEstareiNaPaginaInicialDoOperador()
        {
            RegisterPage.MenuOperador();
        }

        [When(@"que esteja com perfil de operador")]
        public void QuandoQueEstejaComPerfilDeOperador()
        {
            HomePage.GoTo(ConfigurationManager.AppSettings["ZaapURL"]);
            RegisterPage.Logar();
            RegisterPage.ValidarLogoZaap();
            RegisterPage.SelecionarModoOperador();
            RegisterPage.SelecionarEquipe();
            RegisterPage.MenuOperador();
        }

        
        [When(@"realizo uma busca por nome ""(.*)""")]
        public void QuandoRealizoUmaBuscaPorNome(string nome)
        {
            RegisterPage.PesquisarporNome(nome);
        }


        [Then(@"encontro o ""(.*)"" com sucesso")]
        public void EntaoEncontroOComSucesso(string nome)
        {
            RegisterPage.ResultadoEsperadoPesquisa(nome);
        }

        [When(@"realizo uma busca por ""(.*)""")]
        public void QuandoRealizoUmaBuscaPor(string cd)
        {
            RegisterPage.PesquisarporCodigo(cd);
        }

        [When(@"realizo uma busca por cpf ""(.*)""")]
        public void QuandoRealizoUmaBuscaPorCpf(string CPF)
        {
            RegisterPage.PesquisarporCPF(CPF);
        }

        [Then(@"a pesquisa é realizada com sucesso")]
        public void EntaoAPesquisaERealizadaComSucesso()
        {
            RegisterPage.ValidarLogoZaap();
        }

        [When(@"realizo uma busca por Contrato ""(.*)""")]
        public void QuandoRealizoUmaBuscaPorContrato(string Contrato)
        {
            RegisterPage.PesquisarporContrato(Contrato);
        }

        [When(@"realizo uma busca por ComplementoDoContrato ""(.*)""")]
        public void QuandoRealizoUmaBuscaPorComplementoDoContrato(string CompContrato)
        {
            RegisterPage.PesquisarporComplementoDoContrato(CompContrato);
        }

        [When(@"realizo uma busca por Email ""(.*)""")]
        public void QuandoRealizoUmaBuscaPorEmail(string Email)
        {
            RegisterPage.PesquisarporEmail(Email);
        }

        [When(@"realizo uma busca por Telefone ""(.*)""")]
        public void QuandoRealizoUmaBuscaPorTelefone(String Telefone)
        {
            RegisterPage.PesquisarporTelefone(Telefone);
        }

        [Given(@"que realizo uma busca por cliente")]
        public void DadoQueRealizoUmaBuscaPorCliente()
        {
            HomePage.GoTo(ConfigurationManager.AppSettings["ZaapURL"]);
            RegisterPage.Logar();
            RegisterPage.ValidarLogoZaap();
            RegisterPage.SelecionarModoOperador();
            RegisterPage.SelecionarEquipe();
            RegisterPage.MenuOperador();
            RegisterPage.PesquisarporNome("LARISSA ALBARADO BEZERRA");
            RegisterPage.SelecionarCliente();
        }

        [Given(@"que realizo uma busca por cliente que tenha feito negociacao")]
        public void DadoQueRealizoUmaBuscaPorClienteQueTenhaFeitoNegociacao()
        {
            HomePage.GoTo(ConfigurationManager.AppSettings["ZaapURL"]);
            RegisterPage.Logar();
            RegisterPage.ValidarLogoZaap();
            RegisterPage.SelecionarModoOperador();
            RegisterPage.SelecionarEquipe2();
            RegisterPage.MenuOperador();
            RegisterPage.PesquisarporCPF("61896588704");
            RegisterPage.SelecionarCliente();
        }

        [When(@"seleciono a opção boletos")]
        public void QuandoSelecionoAOpcaoBoletos()
        {
            RegisterPage.SelecionarResponsavel();
            RegisterPage.ConfirmarCadastro();
        }

        [Then(@"acesso a lista de boletos com sucesso")]
        public void EntaoAcessoAListaDeBoletosComSucesso()
        {
            RegisterPage.Boletos();
        }

        [Then(@"a reimpressão é realizada com sucesso")]
        public void EntaoAReimpressaoERealizadaComSucesso()
        {
            RegisterPage.Boletos();
        }



        [When(@"seleciono a opção de email inativo")]
        public void QuandoSelecionoAOpcaoDeEmailInativo()
        {
            RegisterPage.InativarEmail();
        }


        [Then(@"o email é inativado com sucesso")]
        public void EntaoOEmailEInativadoComSucesso()
        {
            RegisterPage.SucessoEmailInativo();
        }


        [Given(@"seleciono a opção editar Telefone")]
        public void DadoSelecionoAOpcaoEditarTelefone()
        {
            RegisterPage.EditarTelefone();
        }

        [When(@"incluo as informações que desejo alterar")]
        public void QuandoIncluoAsInformacoesQueDesejoAlterar()
        {
            RegisterPage.AlterarTelefone();
        }

        [Then(@"o Telefone é alterado com sucesso")]
        public void EntaoOTelefoneEAlteradoComSucesso()
        {
            RegisterPage.SucessoAlteracaoTelefone();
        }

        [Given(@"seleciono cliente por Nome")]
        public void DadoPesquisoESelecionoClientePorNome()
        {
            RegisterPage.SelecionarResponsavel();
        }

        [Then(@"acesso a tela de negociação com sucesso")]
        public void EntaoAcessoATelaDeNegociacaoComSucesso()
        {
            RegisterPage.ConfirmarCadastro();
        }

        [When(@"incluo uma nova ocorrência em Nulo")]
        public void QuandoIncluoUmaNovaOcorrenciaEmNulo()
        {
            RegisterPage.SelecionarResponsavel();
            RegisterPage.ConfirmarCadastro();
            RegisterPage.SelecionarOcorrencia();
        }

        [Then(@"a ocorrência é realizada com sucesso")]
        public void EntaoAOcorrenciaERealizadaComSucesso()
        {
            RegisterPage.OcorrenciaNulo();
        }

        [When(@"incluo uma nova ocorrência em andamento")]
        public void QuandoIncluoUmaNovaOcorrenciaEmAndamento()
        {
            RegisterPage.SelecionarResponsavel();
            RegisterPage.ConfirmarCadastro();
            RegisterPage.SelecionarOcorrencia();
        }

        [When(@"incluo uma nova ocorrência em agendamento")]
        public void QuandoIncluoUmaNovaOcorrenciaEmAgendamento()
        {
            RegisterPage.SelecionarResponsavel();
            RegisterPage.ConfirmarCadastro();
            RegisterPage.SelecionarOcorrencia();
        }

        [When(@"incluo um novo serviço")]
        public void QuandoIncluoUmNovoServico()
        {
            RegisterPage.SelecionarResponsavel();
            RegisterPage.ConfirmarCadastro();
            RegisterPage.SelecionarOcorrencia();
        }

      


    }
}
