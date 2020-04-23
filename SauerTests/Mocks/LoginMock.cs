using ProjetoEngSoftware.DTO;

namespace SauerTests.Mocks
{
    public class LoginMock
    {
        public static LoginDTO mock1(){
            
            return new LoginDTO{
                Login = "admin",
                Password = "senha"
            };
        }
        public static LoginDTO mock2(){
            
            return new LoginDTO{
                Login = "professor",
                Password = "senha"
            };
        }
    }
}