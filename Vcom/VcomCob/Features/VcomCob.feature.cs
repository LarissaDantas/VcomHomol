// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GloboChallenge.VcomCob.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("VcomCob")]
    [NUnit.Framework.CategoryAttribute("Chrome")]
    public partial class VcomCobFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "VcomCob.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "VcomCob", null, ProgrammingLanguage.CSharp, new string[] {
                        "Chrome"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Acessar VcomCob")]
        public virtual void AcessarVcomCob()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Acessar VcomCob", null, ((string[])(null)));
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 testRunner.Given("que eu acesso o VcomCob", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 9
 testRunner.And("informo usuario e senha", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 10
 testRunner.Then("e realizado o login com sucesso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pesquisar cliente por Nome na Ficha de Cliente")]
        [NUnit.Framework.TestCaseAttribute("\"MARIA DA SILVA MIRANDA\"", null)]
        public virtual void PesquisarClientePorNomeNaFichaDeCliente(string nome, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pesquisar cliente por Nome na Ficha de Cliente", null, exampleTags);
#line 12
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 13
 testRunner.Given("que esteja logado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 14
 testRunner.And(string.Format("realizo uma busca de cliente por nome {0}", nome), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 15
 testRunner.Then(string.Format("encontro o nome com sucesso na ficha de cliente {0}", nome), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pesquisar cliente CPF na Ficha de Cliente")]
        [NUnit.Framework.TestCaseAttribute("\"94707570763\"", null)]
        public virtual void PesquisarClienteCPFNaFichaDeCliente(string cPF, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pesquisar cliente CPF na Ficha de Cliente", null, exampleTags);
#line 21
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 22
 testRunner.Given("que esteja logado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 23
 testRunner.And(string.Format("realizo uma busca de cliente por CPF {0}", cPF), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 24
 testRunner.Then(string.Format("encontro o CPF com sucesso na ficha de cliente {0}", cPF), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pesquisar cliente por Contrato na Ficha de Cliente")]
        [NUnit.Framework.TestCaseAttribute("\"001010106646001\"", null)]
        public virtual void PesquisarClientePorContratoNaFichaDeCliente(string contrato, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pesquisar cliente por Contrato na Ficha de Cliente", null, exampleTags);
#line 30
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 31
 testRunner.Given("que esteja logado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 32
 testRunner.And(string.Format("realizo uma busca de cliente por contrato {0}", contrato), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 33
 testRunner.Then(string.Format("encontro o contrato com sucesso na ficha de cliente {0}", contrato), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pesquisar cliente por Complemento do Contrato na Ficha de Cliente")]
        [NUnit.Framework.TestCaseAttribute("\"01020201985000\"", null)]
        public virtual void PesquisarClientePorComplementoDoContratoNaFichaDeCliente(string compContrato, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pesquisar cliente por Complemento do Contrato na Ficha de Cliente", null, exampleTags);
#line 39
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 40
 testRunner.Given("que esteja logado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 41
 testRunner.And(string.Format("realizo uma busca de cliente por complemento do contrato {0}", compContrato), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 42
 testRunner.Then(string.Format("encontro o complemento do contrato com sucesso na ficha de cliente {0}", compContrato), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pesquisar cliente por Nosso Numero")]
        [NUnit.Framework.TestCaseAttribute("\"01020201985000\"", null)]
        public virtual void PesquisarClientePorNossoNumero(string nossoNumero, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pesquisar cliente por Nosso Numero", null, exampleTags);
#line 48
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 49
 testRunner.Given("que esteja logado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 50
 testRunner.And(string.Format("realizo uma busca de cliente por Nosso Numero {0}", nossoNumero), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 51
 testRunner.Then(string.Format("encontro o Nosso Numero com sucesso na ficha de cliente {0}", nossoNumero), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Acesso a tela Ficha do Cliente")]
        public virtual void AcessoATelaFichaDoCliente()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Acesso a tela Ficha do Cliente", null, ((string[])(null)));
#line 57
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 58
 testRunner.Given("que esteja logado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 59
 testRunner.And("realizo uma busca com sucesso por um cliente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 60
 testRunner.Then("e apresentado a tela de Ficha do Cliente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Inserção de Serviço")]
        public virtual void InsercaoDeServico()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Inserção de Serviço", null, ((string[])(null)));
#line 62
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 63
 testRunner.Given("que esteja logado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 64
 testRunner.And("realizo uma busca com sucesso por um cliente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 65
 testRunner.When("seleciono inserção de serviços", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 66
 testRunner.And("confirmo a inserção com todos os campos preenchidos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 67
 testRunner.Then("a insersão é criada com sucesso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Aplicação de filtros")]
        public virtual void AplicacaoDeFiltros()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Aplicação de filtros", null, ((string[])(null)));
#line 69
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 70
 testRunner.Given("que esteja logado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 71
 testRunner.And("seleciono a Opção de Aplicação de filtros", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 72
 testRunner.And("confirmo a Aplicação de filtros com todos os campos preenchidos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 73
 testRunner.Then("é criado o filtro com sucesso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Aplicação de sequência")]
        public virtual void AplicacaoDeSequencia()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Aplicação de sequência", null, ((string[])(null)));
#line 75
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 76
 testRunner.Given("que esteja logado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 77
 testRunner.And("seleciono a Opção de Aplicação de sequência", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 78
 testRunner.And("confirmo a Aplicação de sequência com todos os campos preenchidos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 79
 testRunner.Then("é criado a Aplicação de sequência com sucesso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
