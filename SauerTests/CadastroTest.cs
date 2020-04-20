using Microsoft.Extensions.DependencyInjection;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Models;
using ProjetoEngSoftware.Services;
using SauerTests.Mocks;
using Xunit;

namespace SauerTests
{
    public class CadastroTest: IClassFixture<TestContainer>
    {
        private CadastroService cadastroService;
        public CadastroTest(TestContainer testContainer){
            cadastroService = testContainer.Services.GetRequiredService<CadastroService>();
        }

        [Fact]
        public void CadastroMedico(){
            DadosCadastroDTO mock1 = DadosCadastroMock.mock1();
            DadosCadastroDTO mock2 = DadosCadastroMock.mock2();
            DadosCadastroDTO mock3 = DadosCadastroMock.mock3();

            PerfilDTO perfil1 = cadastroService.efetuarCadastro(mock1);
            PerfilDTO perfil2 = cadastroService.efetuarCadastro(mock2);
            PerfilDTO perfil3 = cadastroService.efetuarCadastro(mock3);

            Assert.NotNull(perfil1);
            Assert.NotNull(perfil2);
            Assert.NotNull(perfil3);
            
            Assert.True(perfil1.UserRole.Equals("Medico"));
            Assert.True(perfil2.UserRole.Equals("Residente"));
            Assert.True(perfil3.UserRole.Equals("Professor"));
            
        }

        
    }
}