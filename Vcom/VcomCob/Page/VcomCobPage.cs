using GloboChallenge.Config.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using static GloboChallenge.Config.Utils.Helpers;

namespace Vcom.Pages
{
    public class VcomCobPage : BasePage
    {

        public By inpLogin = By.CssSelector("input#input-login");
        public By inpSenha = By.CssSelector("#input-senha");
        public By butEntrar = By.CssSelector("#botao-login");
        public By logoVcomCob = By.CssSelector("header a img");
        public By btnMenu = By.XPath("//*[@id='navMenuPrincipal']/ul[1]/li[1]/a");
        public By selectFichaCliente = By.XPath("//*[@id='M3053']/a");
        public By selectAplicaçãodeFiltros = By.XPath("//*[@id='M6006']/a");
        public By selectAplicaçãodeSequencia = By.XPath("//*[@id='M6006']/a");
        public By inputPesquisaMenu = By.CssSelector("#pesquisaMenuNovo");
        public By inputPesquisaCliente = By.CssSelector("#txtPesquisa");
        public By btnPesquisarCliente = By.CssSelector("#btn");
        public By btnPesquisarPorNome = By.XPath("//*[@id='divPesquisaPessoa']/div/div/div[2]/div[2]/div/div/div/ul/li[1]/a");
        public By btnPesquisarPorCPF = By.XPath("//*[@id='divPesquisaPessoa']/div/div/div[2]/div[2]/div/div/div/ul/li[2]/a");
        public By btnPesquisarPorContrato = By.XPath("//*[@id='divPesquisaPessoa']/div/div/div[2]/div[2]/div/div/div/ul/li[3]/a");
        public By btnPesquisarPorCompContrato = By.XPath("//*[@id='divPesquisaPessoa']/div/div/div[2]/div[2]/div/div/div/ul/li[4]/a");
        public By selectPesquisar = By.XPath("//*[@id='divReusltadoPesquisa']/table/tbody/tr/td[1]");
        public By titleFichaCliente = By.CssSelector("#appDiv h3");
        public By btnServicos = By.CssSelector("ul[id='ulMenuFichaListagens'] li[menu='ServicosTitulo']");
        public By btnInserirServico = By.CssSelector("#btnInserirServico");
        public By btnConfirmarSelecao = By.CssSelector("#btn-confirmar-selecao");
        public By selectServicos = By.CssSelector("#selServicosInd");
        public By selectOpcaoServicos = By.CssSelector("#selServicosInd > option:nth-child(2)");
        public By txtMotivoInclusao = By.CssSelector("#txtMotivoInclusao");
        public By txtObservacao = By.CssSelector("#txtObservacao");
        public By btnLocalizar = By.CssSelector("#nomeFiltro");
        public By btnConfirmarServico = By.CssSelector("#btn-confirmarServico");
        public By servicoSucesso = By.CssSelector("#divSucessoServico > div");
        public By btnLocalizarFiltro = By.CssSelector("#btn-Localizar");
        public By btnAplicarFiltro = By.CssSelector("#btn-aplicar-filtros");
        public By btnLocalizarSequencia = By.CssSelector("#btn-Localizar");
        public By descricaoFiltro = By.CssSelector("#tbNomeFiltro");
        public By btnFiltrar = By.CssSelector("#btn-Filtrar");
        public By btnNotificacoes = By.CssSelector("#menuNotificacoes");
        public By modalSequencia = By.CssSelector("#btn-yes-modal-aplicar-sequencia");
        public By btnAplicarSequencia = By.CssSelector("#btn-aplicar-sequencia");
        public By checkboxFiltros = By.CssSelector("#ListaFiltros_0__Selecionado");
        public By checkboxSequencia = By.CssSelector("#ListaFiltrosSequencia_0__Selecionado");

       

        public void Logar()
        {
            this.Usuario();
            this.Senha();  
           //Thread.Sleep(5000);
            //ToClick(inpLogin);
            //ToWrite(inpLogin, "cobsystems");
            //WaitElementVisible(inpSenha);
           //Thread.Sleep(3000);
            //ToClick(inpSenha);
           //Thread.Sleep(1000);
            //ToWrite(inpSenha, "cob3vc");
           //Thread.Sleep(3000);
            //ToClick(butEntrar);
           //Thread.Sleep(1000);
            //WaitElementVisible(logoVcomCob);
        }

        public void Usuario()
        {
          //Thread.Sleep(5000);
            ToClick(inpLogin);
            ToWrite(inpLogin, "cobsystems");
        }
        
        public void Senha()
        {
            //WaitElementVisible(inpSenha);
          //Thread.Sleep(3000);
            ToClick(inpSenha);
          //Thread.Sleep(1000);
            ToWrite(inpSenha, "cob3vc");
          //Thread.Sleep(3000);
            ToClick(butEntrar);
        }
        public void ValidarLogoZaap()
        {
          //Thread.Sleep(1000);
            WaitElementVisible(logoVcomCob);
        }

        public void Acessarfichadecliente()
        {
          //Thread.Sleep(3000);
            WaitElementVisible(btnMenu);
            ToClick(btnMenu);
            ToClick(inputPesquisaMenu);
          //Thread.Sleep(2000);
            ToWrite(inputPesquisaMenu, "Ficha do Cliente");
            WaitElementVisible(selectFichaCliente);
            ToClick(selectFichaCliente);
          //Thread.Sleep(2000);
        }

        public void PesquisarPorNome(string nome)
        {
            ToClick(inputPesquisaCliente);
          //Thread.Sleep(2000);
            ToWrite(inputPesquisaCliente, nome);
          //Thread.Sleep(2000);
            ToClick(btnPesquisarCliente);
          //Thread.Sleep(2000);
            ToClick(btnPesquisarPorNome);
          //Thread.Sleep(5000);
        }

        public void ResultadoEsperadoPesquisa(string nome, TipoPesquisa tipoPesquisa =new TipoPesquisa())
        {
            var y = GetText(By.XPath("//*[@id='divReusltadoPesquisa']/table/tbody/tr[1]"));
            var x = Helpers.AplicarMascaraPorTipo(nome, tipoPesquisa);
            //var x = GetText(By.XPath("//*[@id='divReusltadoPesquisa']/table/tbody/tr/td[text()='" + Helpers.AplicarMascaraPorTipo(nome, tipoPesquisa) + "']"));
            Assert.True(y.Contains(x),"Valor esperado: " +y+" é diferente do valor encontrado: "+x);
            //Assert.AreEqual(nome, GetText(By.XPath("//*[@id='divReusltadoPesquisa']/table/tbody/tr/td[text()='" + nome + "']")));
        }

      

        public void PesquisarPorCPF(string CPF)
        {
            ToClick(inputPesquisaCliente);
          //Thread.Sleep(2000);
            ToWrite(inputPesquisaCliente, CPF);
          //Thread.Sleep(2000);
            ToClick(btnPesquisarCliente);
          //Thread.Sleep(2000);
            ToClick(btnPesquisarPorCPF);
          //Thread.Sleep(5000);
        }

        public void PesquisarPorContrato(string Contrato)
        {
            ToClick(inputPesquisaCliente);
          //Thread.Sleep(2000);
            ToWrite(inputPesquisaCliente, Contrato);
          //Thread.Sleep(2000);
            ToClick(btnPesquisarCliente);
          //Thread.Sleep(2000);
            ToClick(btnPesquisarPorContrato);
          //Thread.Sleep(5000);
        }

        public void PesquisarPorCompContrato(string CompContrato)
        {
            ToClick(inputPesquisaCliente);
          //Thread.Sleep(2000);
            ToWrite(inputPesquisaCliente, CompContrato);
          //Thread.Sleep(2000);
            ToClick(btnPesquisarCliente);
          //Thread.Sleep(2000);
            ToClick(btnPesquisarPorCompContrato);
          //Thread.Sleep(5000);
        }

        public void PaginaFichaCliente()
        {
          //Thread.Sleep(2000);
            ToClick(selectPesquisar);
          //Thread.Sleep(2000);
            WaitElementVisible(titleFichaCliente);
        }

        public void SelecionarServiços()
        {
          //Thread.Sleep(2000);
            ToClick(btnServicos);
          //Thread.Sleep(2000);
            ToClick(btnInserirServico);
          //Thread.Sleep(2000);
            ToClick(btnConfirmarSelecao);
        }

        public void IncluirServico()
        {
          //Thread.Sleep(2000);
            ToClick(selectServicos);
          //Thread.Sleep(2000);
            ToClick(selectOpcaoServicos);
          //Thread.Sleep(2000);
            ToClick(txtMotivoInclusao);
          //Thread.Sleep(2000);
            ToWrite(txtMotivoInclusao, "Motivo Teste");
          //Thread.Sleep(2000);
            TAB(txtObservacao);
          //Thread.Sleep(2000);
            ToClick(btnConfirmarServico);
        }

        public void ValidarSucesso()
        {
          //Thread.Sleep(1000);
            WaitElementVisible(servicoSucesso);
        }

        public void AcessarAplicacaoDeFiltros()
        {
          //Thread.Sleep(3000);
            WaitElementVisible(btnMenu);
            ToClick(btnMenu);
            ToClick(inputPesquisaMenu);
          //Thread.Sleep(1000);
            ToWrite(inputPesquisaMenu, "Aplicação de Filtros");
            WaitElementVisible(selectAplicaçãodeFiltros);
            ToClick(selectAplicaçãodeFiltros);
          //Thread.Sleep(2000);
        }

        public void PesquisarFiltros()
        {
          //Thread.Sleep(1000);
            ToClick(btnLocalizar);
          //Thread.Sleep(1000);
            ToWrite(btnLocalizar, "Alma");
          //Thread.Sleep(1000);
            ToClick(btnLocalizarFiltro);
        }

        public void AplicarFiltros()
        {
          //Thread.Sleep(1000);
            BarradeRolagem();
          //Thread.Sleep(1000);
            ToClick(checkboxFiltros);
            BarradeRolagemSubindo();
            ToClick(btnAplicarFiltro);
            ValidarLogoZaap();
        }

        public void AcessarAplicaçãoDeSequencia()
        {
          //Thread.Sleep(3000);
            WaitElementVisible(btnMenu);
            ToClick(btnMenu);
            ToClick(inputPesquisaMenu);
          //Thread.Sleep(1000);
            ToWrite(inputPesquisaMenu, "Aplicação de sequência");
            WaitElementVisible(selectAplicaçãodeSequencia);
        }

        public void PesquisarSequencia()
        {
          //Thread.Sleep(2000);
            ToClick(btnLocalizarSequencia);
          //Thread.Sleep(1000);
            ToClick(descricaoFiltro);
          //Thread.Sleep(1000);
            ToWrite(descricaoFiltro, "Alma");
          //Thread.Sleep(1000);
            ToClick(btnFiltrar);           
        }

        public void AplicarSequencia()
        {
          //Thread.Sleep(1000);
            ToClick(checkboxSequencia);
          //Thread.Sleep(1000);
            ToClick(btnAplicarSequencia);
          //Thread.Sleep(1000);
            ToClick(modalSequencia);
            ValidarLogoZaap();
          //Thread.Sleep(1000);
            ToClick(btnNotificacoes);
          //Thread.Sleep(1000);
        }
        public string TratarRetorno(string msg) {

            return msg;
        }
    }
}
