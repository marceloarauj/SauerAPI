using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjetoEngSoftware.Contexts;
using Microsoft.Extensions.Configuration;
using ProjetoEngSoftware.Services;
using ProjetoEngSoftware.Repositories;
using System;

namespace ProjetoEngSoftware.Configurations
{
    public class DependencyInjectConfiguration
    {
        public static void Registrar(IServiceCollection services, IConfiguration configuration){
            
            #region Services
            services.AddTransient<CadastroService>();
            services.AddTransient<ExameService>();
            services.AddTransient<LaudoService>();
            services.AddTransient<LoginService>();
            services.AddTransient<MedicoResidenteService>();
            services.AddTransient<MedicoService>();
            services.AddTransient<ProfessorService>();
            services.AddTransient<EtniaService>();
            #endregion

            #region Repositories
            services.AddTransient<CadastroRepository>();
            services.AddTransient<ExameRepository>();
            services.AddTransient<LaudoRepository>();
            services.AddTransient<LoginRepository>();
            services.AddTransient<MedicoResidenteRepository>();
            services.AddTransient<PerfilRepository>();
            services.AddTransient<ProfessorRepository>();
            services.AddTransient<MedicoRepository>();
            services.AddTransient<EtniaRepository>();
            services.AddTransient<PacienteRepository>();
            #endregion

            string Database = "d2d0es6177uqdb";
            string user = "hinzrvsvoxqyti";
            string password = "6f833a813d66fc006b27bc0f50c42e3967b1da33d90745bdf55c3f8179eca147";
            string host = "ec2-54-88-130-244.compute-1.amazonaws.com";
            string URL = "Host="+host+";Port=5432;Database="+Database+";User Id="+user+";Password="+password+";sslmode=Prefer;Trust Server Certificate=true";
            // services.AddEntityFrameworkNpgsql().AddDbContext<Context>
            //     (options =>options.UseNpgsql(configuration.GetConnectionString("SauerBD")));
            services.AddEntityFrameworkNpgsql().AddDbContext<Context>
                (options =>options.UseNpgsql(URL));                 
        }
    }
}