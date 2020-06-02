using Microsoft.Extensions.DependencyInjection;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Models;
using ProjetoEngSoftware.Services;
using TechTalk.SpecFlow;
using Xunit; 
namespace SauerTests
{
    [Binding]
    public class CadastroTest: IClassFixture<TestContainer>
    {
        private CadastroService cadastroService;
        public CadastroTest(TestContainer testContainer){
            cadastroService = testContainer.Services.GetRequiredService<CadastroService>();
        }
        [Given(@"I have entered (\+d) into the calculator")]
        public void CadastroMedico(int nome){
            //DadosCadastroDTO mock1 = DadosCadastroMock.mock1();
            //DadosCadastroDTO mock2 = DadosCadastroMock.mock2();
            //DadosCadastroDTO mock3 = DadosCadastroMock.mock3();

            //PerfilDTO perfil1 = cadastroService.efetuarCadastro(mock1);
            //PerfilDTO perfil2 = cadastroService.efetuarCadastro(mock2);
            //PerfilDTO perfil3 = cadastroService.efetuarCadastro(mock3);

            //Assert.NotNull(perfil1);
            //Assert.NotNull(perfil2);
            //Assert.NotNull(perfil3);
            
            //Assert.True(perfil1.UserRole.Equals("Medico"));
            //Assert.True(perfil2.UserRole.Equals("Residente"));
            //Assert.True(nome.Equals("Carlos"));
            //Assert.True(login.Equals("teste"));
            
        }

        [Then(@"the result should be 120 on the screen")]
        public void tedste(){

        }
    }
}