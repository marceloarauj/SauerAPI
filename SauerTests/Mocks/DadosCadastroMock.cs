using ProjetoEngSoftware.DTO;

namespace SauerTests.Mocks
{
    public class DadosCadastroMock
    {
        public static DadosCadastroDTO mock1(){
            
            return new DadosCadastroDTO{
                Email = "email-base-tester",
                Login = "emailcoxuni31232122tesr",
                Password = "password123456",
                Medico = new MedicoDTO{Nome = "Carlos Teste",Crm = "12345",Tipo = 0}
            };
        }
        public static DadosCadastroDTO mock2(){
            
            return new DadosCadastroDTO{
                Email = "email-base-testador",
                Login = "emailcadastradsr",
                Password = "password123456",
                Medico = new MedicoDTO{Nome = "Carlos Teste",Crm = "12345",Tipo = 1}
            };
        }
        public static DadosCadastroDTO mock3(){
            
            return new DadosCadastroDTO{
                Email = "email-base-testeree1123",
                Login = "emailctes23123r",
                Password = "password123456",
                Medico = new MedicoDTO{Nome = "Carlos Teste",Crm = "12345",Tipo = 2}
            };
        }       
    }
}