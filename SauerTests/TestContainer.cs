using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjetoEngSoftware.Contexts;
using ProjetoEngSoftware.Controllers;
using ProjetoEngSoftware.Repositories;
using ProjetoEngSoftware.Services;

namespace SauerTests
{
    public class TestContainer
    {
        public TestContainer(){
            var services = new ServiceCollection();
            
            #region Controllers
            services.AddTransient<LoginController>();
            services.AddTransient<CadastroController>();
            services.AddTransient<ExameController>();
            #endregion
            
            #region Services
            services.AddTransient<CadastroService>();
            services.AddTransient<ExameService>();
            services.AddTransient<LaudoService>();
            services.AddTransient<LoginService>();
            services.AddTransient<MedicoResidenteService>();
            services.AddTransient<MedicoService>();
            services.AddTransient<ProfessorService>();
            #endregion

            #region Repositories
            services.AddTransient<CadastroRepository>();
            services.AddTransient<ExameRepository>();
            services.AddTransient<LaudoRepository>();
            services.AddTransient<LoginRepository>();
            services.AddTransient<MedicoResidenteRepository>();
            services.AddTransient<PerfilRepository>();
            services.AddTransient<ProfessorRepository>();
            #endregion

            services.AddEntityFrameworkNpgsql().AddDbContext<Context>
                (options =>options.UseNpgsql("Host=localhost;Port=5432;Database=sauer;User Id=postgres;Password=1234;"));

            Services = services.BuildServiceProvider();
        }
        public ServiceProvider Services{ get; private set;}
    }
}