using Vcom.Pages;
using TechTalk.SpecFlow;
using System.Configuration;

namespace Vcom.VcomCob.Steps
{
    [Binding]
    public class CobWebSteps : BasePage
    {
        

        public HomePage HomePage { get; private set; }
        public CobWebPage CobWebPage { get; private set; }

        public CobWebSteps()
        {
            HomePage = new HomePage();
            CobWebPage = new CobWebPage();
        }


        [Given(@"que eu acesso o CobWeb")]
        public void DadoQueEuAcessoOCobWeb()
        {
            HomePage.GoTo(ConfigurationManager.AppSettings["CobWebURL"]); 
        }

        [Given(@"preencho usuario e senha")]
        public void DadoPreenchoUsuarioESenha()
        {
            CobWebPage.Usuario();
            CobWebPage.Senha();
        }

        [Then(@"e realizado o logon com sucesso")]
        public void EntaoERealizadoOLogonComSucesso()
        {
            CobWebPage.PaginaInicial();
        }

        [Given(@"que eu esteja logado")]
        public void DadoQueEuEstejaLogado()
        {
            HomePage.GoTo(ConfigurationManager.AppSettings["CobWebURL"]);
            CobWebPage.Usuario();
            CobWebPage.Senha();
            CobWebPage.PaginaInicial();
        }

        [Given(@"realizo uma busca de cliente por nome")]
        public void DadoRealizoUmaBuscaDeClientePorNome()
        {
            HomePage.GoTo(ConfigurationManager.AppSettings["CobWeCobrançabURL"]);
            CobWebPage.Telecobrança();
        }

        [Then(@"encontro o nome do cliente com sucesso")]
        public void EntaoEncontroONomeDoClienteComSucesso()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
