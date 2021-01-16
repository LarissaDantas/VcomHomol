using System.Threading;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Vcom.Pages
{
    public class RegisterPage : BasePage
    {
        public By inpLogin = By.CssSelector("div[class='form-group'] input[name='Login']");
        public By inpSenha = By.CssSelector("div[class='form-group'] input[name='Senha']");
        public By butEntrar = By.CssSelector("form[id='loginForm'] div[class='form-group'] button[id='btn-entrar']");
        public By imgLogoZaap = By.CssSelector("div[class='col-md-5'] img[class='site-logo']");
        public By inpModo = By.XPath("//*[@id='userSettings']/div/header/div[2]/div/ul/li[1]/a");
        public By inpModoOperador = By.XPath("//*[@id='userSettings']/div/header/div[2]/div/ul/li[1]/div/a[1]");
        public By inpEquipe = By.XPath("/html/body/div[2]/div/div/div[2]/form/button[1]/div");
        public By inpEquipe2 = By.XPath("/html/body/div[2]/div/div/div[2]/form/button[2]/div");
        public By menuOperador = By.CssSelector("div[class='col-md-12'] div[class='profile hiddenAtendimento']");
        public By btnPesquisarInicial = By.CssSelector("#btnPesquisarInicial");
        public By inpConteudo = By.CssSelector("#idValor");
        public By btnPesquisar = By.CssSelector("#btnPesquisar");
        public By btnPesquisarConteudo = By.CssSelector("#idContexto");
        public By btnPesquisarCodigoIdentificacao = By.XPath("//*[@id='idContexto']/option[3]");
        public By btnPesquisarCPF = By.XPath("//*[@id='idContexto']/option[4]");
        public By btnPesquisarContrato = By.XPath("//*[@id='idContexto']/option[5]");
        public By btnPesquisarComplementoDoContrato = By.XPath("//*[@id='idContexto']/option[6]");
        public By btnPesquisarEmail = By.XPath("//*[@id='idContexto']/option[7]");
        public By btnPesquisarTelefone = By.XPath("//*[@id='idContexto']/option[2]");
        public By divResultados = By.XPath("//*[@id='divResultados']/div/div/div/div[2]/table/tbody/tr");
        public By btnResponsavelSim = By.XPath("//*[@id='operation']/section/div[2]/div/div[1]/a");
        public By btnEditarEmail = By.XPath("//*[@id='tblEmails']/tbody/tr/td[2]/a");
        public By btnEditarTelefone = By.CssSelector("#tblTelefones > tbody > tr:nth-child(1) > td.text-right > a.btn.btn-primary.btn-xs.cursor-pointer");
        public By ComboStatus = By.CssSelector("#Status");
        public By InpTelefoneNumero = By.CssSelector("#TelefoneNumero");
        public By btnConfirmTelefone = By.CssSelector("#formTelefone > div.button-holder > input");
        public By ComboStatusInativo = By.CssSelector("#Status > option:nth-child(2)");
        public By btnEditarEndereco = By.CssSelector("#tblEnderecos > tbody > tr > td.text-right > a");
        public By btnConfirmStatus = By.CssSelector("#formEmail > div.button-holder > input");
        public By flamedisabled = By.CssSelector("#tblEmails > tbody > tr > td:nth-child(1) > i.flame-xs.flame.flame-pink.disabled");
        public By flameAtivo = By.XPath("//*[@id='tblTelefones']/tbody/tr[1]/td[1]/i[1]");
        public By btnConfirmaCadastro = By.XPath("//*[@id='operation']/section/div[2]/form/div[3]/a");
        public By btnBoletos = By.CssSelector("#panel-group-contratos > div > div.panel-footer.panel-footer-completo > div.col-md-4.text-right > div > div:nth-child(1) > a");
        public By btnInserirOcorrencia = By.CssSelector("#panel-group-contratos > div > div.panel-footer.panel-footer-completo > div.col-md-4.text-right > div > div:nth-child(2) > a");
        public By btnOcorrenciaNulo = By.XPath("//*[@id='divOcorrencias']/a[7]");
        public By comboMotivo = By.CssSelector("#ddlOcorrenciaMotivos");
        public By comboMotivo1 = By.CssSelector("#ddlOcorrenciaMotivos > option:nth-child(1)");
        public By comboEndereco = By.CssSelector("#Endereco");
        public By inpCompleTexto = By.CssSelector("#complTexto");
        public By inpCompleValor = By.CssSelector("#complValor");
        public By formInsereOcorrencia = By.CssSelector("#formInsereOcorrencia > div.button-holder.col-md-12 > input");


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
            ToClick(butEntrar);
          //Thread.Sleep(1000);
            WaitElementVisible(imgLogoZaap);
        }

        public void ValidarLogoZaap()
        {
          //Thread.Sleep(1000);
            WaitElementVisible(imgLogoZaap);
        }

        public void SelecionarModoOperador()
        {
          //Thread.Sleep(1000);
            WaitElementVisible(inpModo);
          //Thread.Sleep(1000);
            ToClick(inpModo);
        
            WaitElementVisible(inpModoOperador);
            ToClick(inpModoOperador);
        }

        public void SelecionarEquipe()
        {
          //Thread.Sleep(1000);
            WaitElementVisible(inpEquipe);
          //Thread.Sleep(1000);
            ToClick(inpEquipe);
        }

        public void SelecionarEquipe2()
        {
          //Thread.Sleep(1000);
            WaitElementVisible(inpEquipe2);
          //Thread.Sleep(1000);
            ToClick(inpEquipe2);
        }
        public void MenuOperador()
        {
          //Thread.Sleep(1000);
            WaitElementVisible(menuOperador);
        }

        public void PesquisarporNome(string nome)
        {
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisarInicial);
          //Thread.Sleep(1000);
            ToClick(btnPesquisarInicial);
          //Thread.Sleep(1000);
            WaitElementVisible(inpConteudo);
          //Thread.Sleep(1000);
            ToClick(inpConteudo);
            ToWrite(inpConteudo, nome);
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisar);
          //Thread.Sleep(1000);
            ToClick(btnPesquisar);
        }

        public void ResultadoEsperadoPesquisa(string nome)
        {
          //Thread.Sleep(1000);
            BarradeRolagem();
          //Thread.Sleep(1000);
            Assert.AreEqual(nome, GetText(By.XPath("//table[@class='table table-condensed table-hover']/tbody/tr/td[text()='" + nome + "']")));
        }

        public void PesquisarporCodigo(string cd)
        {
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisarInicial);
          //Thread.Sleep(1000);
            ToClick(btnPesquisarInicial);
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisarConteudo);
          //Thread.Sleep(1000);
            ToClick(btnPesquisarConteudo);
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisarCodigoIdentificacao);
            ToClick(btnPesquisarCodigoIdentificacao);
          //Thread.Sleep(1000);
            ToClick(inpConteudo);
            ToWrite(inpConteudo, cd);
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisar);
            ToClick(btnPesquisar);
        }

        public void PesquisarporCPF(string CPF)
        {
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisarInicial);
          //Thread.Sleep(1000);
            ToClick(btnPesquisarInicial);
            WaitElementVisible(btnPesquisarConteudo);
          //Thread.Sleep(1000);
            ToClick(btnPesquisarConteudo);
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisarCPF);
            ToClick(btnPesquisarCPF);
          //Thread.Sleep(1000);
            ToClick(inpConteudo);
            ToWrite(inpConteudo, CPF);
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisar);
            ToClick(btnPesquisar);
        }

        public void PesquisarporContrato(string Contrato)
        {
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisarInicial);
          //Thread.Sleep(1000);
            ToClick(btnPesquisarInicial);
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisarConteudo);
          //Thread.Sleep(1000);
            ToClick(btnPesquisarConteudo);
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisarContrato);
            ToClick(btnPesquisarContrato);
          //Thread.Sleep(1000);
            ToClick(inpConteudo);
            ToWrite(inpConteudo, Contrato);
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisar);
            ToClick(btnPesquisar);
        }

        public void PesquisarporComplementoDoContrato(string ComplementoDoContrato)
        {
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisarInicial);
          //Thread.Sleep(1000);
            ToClick(btnPesquisarInicial);
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisarConteudo);
          //Thread.Sleep(1000);
            ToClick(btnPesquisarConteudo);
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisarComplementoDoContrato);
            ToClick(btnPesquisarComplementoDoContrato);
          //Thread.Sleep(1000);
            ToClick(inpConteudo);
            ToWrite(inpConteudo, ComplementoDoContrato);
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisar);
            ToClick(btnPesquisar);
        }

        public void PesquisarporEmail(string PesquisarEmail)
        {
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisarInicial);
          //Thread.Sleep(1000);
            ToClick(btnPesquisarInicial);
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisarConteudo);
          //Thread.Sleep(1000);
            ToClick(btnPesquisarConteudo);
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisarEmail);
            ToClick(btnPesquisarEmail);
          //Thread.Sleep(1000);
            ToClick(inpConteudo);
            ToWrite(inpConteudo, PesquisarEmail);
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisar);
            ToClick(btnPesquisar);
        }

        public void PesquisarporTelefone(string PesquisarTelefone)
        {
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisarInicial);
          //Thread.Sleep(1000);
            ToClick(btnPesquisarInicial);
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisarConteudo);
          //Thread.Sleep(1000);
            ToClick(btnPesquisarConteudo);
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisarTelefone);
            ToClick(btnPesquisarTelefone);
          //Thread.Sleep(1000);
            ToClick(inpConteudo);
            ToWrite(inpConteudo, PesquisarTelefone);
          //Thread.Sleep(1000);
            WaitElementVisible(btnPesquisar);
            ToClick(btnPesquisar);
        }

        public void SelecionarCliente()
        {
          //Thread.Sleep(1000);
            BarradeRolagem();
          //Thread.Sleep(1000);
            WaitElementVisible(divResultados);
          //Thread.Sleep(1000);
            ToClick(divResultados);
           
        }

        public void InativarEmail()
        {
          //Thread.Sleep(1000);
            BarradeRolagem();
          //Thread.Sleep(1000);
            WaitElementVisible(btnResponsavelSim);
          //Thread.Sleep(1000);
            ToClick(btnResponsavelSim);
          //Thread.Sleep(1000);
            ToClick(btnEditarEmail);
          //Thread.Sleep(1000);
            ToClick(ComboStatus);
          //Thread.Sleep(1000);
            ToClick(ComboStatusInativo);
          //Thread.Sleep(1000);
            ToClick(btnConfirmStatus);
        }

        public void SelecionarResponsavel()
        {
          //Thread.Sleep(1000);
            BarradeRolagem();
            BarradeRolagem();
          //Thread.Sleep(1000);
            WaitElementVisible(btnResponsavelSim);
          //Thread.Sleep(1000);
            ToClick(btnResponsavelSim);
        }
        public void SucessoEmailInativo()
        {
          //Thread.Sleep(1000);
            WaitElementVisible(flamedisabled);
        }

        public void EditarEndereço()
        {
          //Thread.Sleep(1000);
            WaitElementVisible(btnResponsavelSim);
          //Thread.Sleep(1000);
            ToClick(btnResponsavelSim);
          //Thread.Sleep(1000);
            ToClick(btnEditarEndereco);
          //Thread.Sleep(1000);
        }

        public void EditarTelefone()
        {
          //Thread.Sleep(1000);
            BarradeRolagem();
          //Thread.Sleep(1000);
            WaitElementVisible(btnResponsavelSim);
          //Thread.Sleep(1000);
            ToClick(btnResponsavelSim);
          //Thread.Sleep(1000);
            ToClick(btnEditarTelefone);
        }

        public void AlterarTelefone()
        {
          //Thread.Sleep(1000);
            ToClick(InpTelefoneNumero);
            ToWrite(InpTelefoneNumero, "33353636");
          //Thread.Sleep(1000);
            ToClick(btnConfirmTelefone);
        }
        public void SucessoAlteracaoTelefone()
        {
          //Thread.Sleep(1000);
            WaitElementVisible(flameAtivo);
        }

        public void ConfirmarCadastro()
        {
          //Thread.Sleep(1000);
            BarradeRolagem();
          //Thread.Sleep(1000);
            WaitElementVisible(btnConfirmaCadastro);
          //Thread.Sleep(1000);
            ToClick(btnConfirmaCadastro);
          //Thread.Sleep(1000);
        }

        public void Boletos()
        {
          //Thread.Sleep(1000);
            WaitElementVisible(btnBoletos);
          //Thread.Sleep(1000);
            ToClick(btnBoletos);
          //Thread.Sleep(1000);
        }

        public void SelecionarOcorrencia()
        {
          //Thread.Sleep(1000);
            WaitElementVisible(btnInserirOcorrencia);
          //Thread.Sleep(1000);
            ToClick(btnInserirOcorrencia);
          //Thread.Sleep(1000);
        }

        public void OcorrenciaNulo()
        {
          //Thread.Sleep(1000);
            WaitElementVisible(btnOcorrenciaNulo);
          //Thread.Sleep(1000);
            BarradeRolagem();
          //Thread.Sleep(1000);
            ToClick(btnOcorrenciaNulo);
          //Thread.Sleep(1000);
            WaitElementVisible(comboMotivo);
          //Thread.Sleep(1000);
            ToClick(comboMotivo);
          //Thread.Sleep(1000);
            ToClick(comboMotivo1);
          //Thread.Sleep(1000);
            ToClick(inpCompleTexto);
          //Thread.Sleep(1000);
            ToWrite(inpCompleTexto, "Ocorrencia Nulo");
          //Thread.Sleep(1000);
            ToClick(inpCompleValor);
          //Thread.Sleep(1000);
            ToWrite(inpCompleValor, "100");
          //Thread.Sleep(1000);
            ToClick(formInsereOcorrencia);
        }

    }
}
