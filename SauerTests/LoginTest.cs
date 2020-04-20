using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using ProjetoEngSoftware.Controllers;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Models;
using ProjetoEngSoftware.Services;
using Xunit;

namespace SauerTests
{
    public class LoginTest: IClassFixture<TestContainer>
    {
        private LoginController controller;
        private LoginService service;
        public LoginTest(TestContainer testContainer){
            service = testContainer.Services.GetRequiredService<LoginService>();
            controller = testContainer.Services.GetRequiredService<LoginController>();
        }
        [Fact]
        public void LoginMedico()
        {
            LoginDTO login1 = new LoginDTO{Login = "ddddd",Password = "eeeee"};

            ActionResult<PerfilDTO> result = controller.efetuarLogin(login1);
            
            //Assert.Is
        }
        
    }
}
