using Microsoft.Extensions.DependencyInjection;
using ProjetoEngSoftware.Controllers;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace SauerTests
{
    [Binding]
    public class CadastroMedicoSteps:IClassFixture<TestContainer>
    {
        public CadastroMedicoSteps(TestContainer container)
        {
            this.cadastroController = container.Services.GetRequiredService<CadastroController>();
        }
        private CadastroController cadastroController;

        [Given(@"Eu Criei um cliente de nome (.*) e tipo (.*)")]
        public void GivenEuCrieiUmClienteDeNomeMarcosJuniorETipo(string nome,int tipo)
        {
            Assert.True(nome.Equals("Marcos Júnio"));

            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"O resultado deve ser (.*)")]
        public void ThenOResultadoDeveSerSucesso(string sucesso)
        {
            Assert.True(sucesso.Equals("sucesso"));
        }
    }
}
