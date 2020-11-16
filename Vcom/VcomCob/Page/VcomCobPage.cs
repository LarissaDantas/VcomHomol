using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace Vcom.Pages
{
    public class VcomCobPage : BasePage
    {

        public By inpLogin = By.CssSelector("#input-login");
        public By inpSenha = By.CssSelector("#input-senha");
        public By butEntrar = By.CssSelector("#botao-login");
        public By logoVcomCob = By.CssSelector("#appDiv > div > div > h3");
        public By btnMenu = By.XPath("//*[@id='navMenuPrincipal']/ul[1]/li[1]/a");
        public By selectFichaCliente = By.XPath("//*[@id='M3053']/a");
        public By inputPesquisaMenu = By.CssSelector("#pesquisaMenuNovo");
        public By inputPesquisaCliente = By.CssSelector("#txtPesquisa");
        public By btnPesquisarCliente = By.CssSelector("#btn");
        public By btnPesquisarPorNome = By.XPath("//*[@id='divPesquisaPessoa']/div/div/div[2]/div[2]/div/div/div/ul/li[1]/a");
        public By btnPesquisarPorCPF = By.XPath("//*[@id='divPesquisaPessoa']/div/div/div[2]/div[2]/div/div/div/ul/li[2]/a");
        public By btnPesquisarPorContrato = By.XPath("//*[@id='divPesquisaPessoa']/div/div/div[2]/div[2]/div/div/div/ul/li[3]/a");
        public By btnPesquisarPorCompContrato = By.XPath("//*[@id='divPesquisaPessoa']/div/div/div[2]/div[2]/div/div/div/ul/li[4]/a");
        public By selectPesquisar = By.XPath("//*[@id='divReusltadoPesquisa']/table/tbody/tr/td[1]");
        public By titleFichaCliente = By.CssSelector("#appDiv h3");

        public void Logar()
        {
            Thread.Sleep(5000);
            ToClick(inpLogin);
            ToWrite(inpLogin, "cobsystems");
            WaitElementVisible(inpSenha);
            Thread.Sleep(3000);
            ToClick(inpSenha);
            Thread.Sleep(1000);
            ToWrite(inpSenha, "cob3vc");
            Thread.Sleep(3000);
            ToClick(butEntrar);
            Thread.Sleep(1000);
            WaitElementVisible(logoVcomCob);
        }

        public void Usuario()
        {
            Thread.Sleep(5000);
            ToClick(inpLogin);
            ToWrite(inpLogin, "cobsystems");
        }
        
        public void Senha()
        {
            WaitElementVisible(inpSenha);
            Thread.Sleep(3000);
            ToClick(inpSenha);
            Thread.Sleep(1000);
            ToWrite(inpSenha, "cob3vc");
            Thread.Sleep(3000);
            ToClick(butEntrar);
        }
        public void ValidarLogoZaap()
        {
            Thread.Sleep(1000);
            WaitElementVisible(logoVcomCob);
        }

        public void Acessarfichadecliente()
        {
            Thread.Sleep(3000);
            WaitElementVisible(btnMenu);
            ToClick(btnMenu);
            ToClick(inputPesquisaMenu);
            Thread.Sleep(1000);
            ToWrite(inputPesquisaMenu, "Ficha do Cliente");
            WaitElementVisible(selectFichaCliente);
            ToClick(selectFichaCliente);
            Thread.Sleep(2000);
        }

        public void PesquisarPorNome(string nome)
        {
            ToClick(inputPesquisaCliente);
            Thread.Sleep(2000);
            ToWrite(inputPesquisaCliente, nome);
            Thread.Sleep(2000);
            ToClick(btnPesquisarCliente);
            Thread.Sleep(2000);
            ToClick(btnPesquisarPorNome);
            Thread.Sleep(5000);
        }

        public void ResultadoEsperadoPesquisa(string nome)
        {
            Assert.AreEqual(nome, GetText(By.XPath("//*[@id='divReusltadoPesquisa']/table/tbody/tr/td[text()='" + nome + "']")));
        }

        public void PesquisarPorCPF(string CPF)
        {
            ToClick(inputPesquisaCliente);
            Thread.Sleep(2000);
            ToWrite(inputPesquisaCliente, CPF);
            Thread.Sleep(2000);
            ToClick(btnPesquisarCliente);
            Thread.Sleep(2000);
            ToClick(btnPesquisarPorCPF);
            Thread.Sleep(5000);
        }

        public void PesquisarPorContrato(string Contrato)
        {
            ToClick(inputPesquisaCliente);
            Thread.Sleep(2000);
            ToWrite(inputPesquisaCliente, Contrato);
            Thread.Sleep(2000);
            ToClick(btnPesquisarCliente);
            Thread.Sleep(2000);
            ToClick(btnPesquisarPorContrato);
            Thread.Sleep(5000);
        }

        public void PesquisarPorCompContrato(string CompContrato)
        {
            ToClick(inputPesquisaCliente);
            Thread.Sleep(2000);
            ToWrite(inputPesquisaCliente, CompContrato);
            Thread.Sleep(2000);
            ToClick(btnPesquisarCliente);
            Thread.Sleep(2000);
            ToClick(btnPesquisarPorCompContrato);
            Thread.Sleep(5000);
        }

        public void PaginaFichaCliente()
        {
            Thread.Sleep(2000);
            ToClick(selectPesquisar);
            Thread.Sleep(2000);
            WaitElementVisible(titleFichaCliente);
        }
    }
}
