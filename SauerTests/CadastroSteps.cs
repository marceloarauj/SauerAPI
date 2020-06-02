using Microsoft.Extensions.DependencyInjection;
using ProjetoEngSoftware.Controllers;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Models;
using ProjetoEngSoftware.Services;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace SauerTests
{
    [Binding]
    public class CadastroSteps : IClassFixture<TestContainer>
    {
        private CadastroService cadastroService;
        private CadastroController cadastroController;
        public CadastroSteps(TestContainer testContainer)
        {
            cadastroService = testContainer.Services.GetRequiredService<CadastroService>();
            cadastroController = testContainer.Services.GetRequiredService<CadastroController>();
        }

        private DadosCadastroDTO dadosCadastrais;
        private PerfilDTO perfilRetorno;

        [Given(@"nome (.*)")]
        public void GivenNome(string nome)
        {
            dadosCadastrais = new DadosCadastroDTO();
            dadosCadastrais.Medico = new MedicoDTO();

            dadosCadastrais.Medico.Nome = nome;

        }
        
        [Given(@"tipo (.*)")]
        public void GivenTipo(int tipo)
        {
            dadosCadastrais.Medico.Tipo = tipo;
        }
        
        [Given(@"email (.*)")]
        public void GivenEmail(string email)
        {
            dadosCadastrais.Email = email;
        }
        
        [Given(@"login (.*)")]
        public void GivenLogin(string login)
        {
            dadosCadastrais.Login = login;
        }
        
        [Given(@"senha (.*)")]
        public void GivenSenha(string senha)
        {
            dadosCadastrais.Password = senha;
        }
        
        [Given(@"crm (.*)")]
        public void GivenCrm(string crm)
        {
            dadosCadastrais.Medico.Crm = crm;
        }
        
        [When(@"realizo o cadastro das informações no banco")]
        public void WhenRealizoOCadastroDasInformacoesNoBanco()
        {
            perfilRetorno = cadastroService.efetuarCadastro(dadosCadastrais);

        }
        
        [Then(@"O retorno deve ser um perfil do tipo (.*)")]
        public void ThenORetornoDeveSerUmPerfilDoTipo(string tipo)
        {
            Assert.Equal(perfilRetorno.UserRole,tipo);
            Assert.Equal(perfilRetorno.Nome,dadosCadastrais.Medico.Nome);
            Assert.Equal(perfilRetorno.Login, dadosCadastrais.Login);

        }
    }
}
