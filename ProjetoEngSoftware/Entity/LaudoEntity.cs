using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Entity
{
    public class LaudoEntity : IEntityTypeConfiguration<Laudo>
    {
        public void Configure(EntityTypeBuilder<Laudo> builder)
        {
            builder.ToTable("tb_laudo");
            builder.HasKey(x => x.IdPedidoExame);
            builder.Property(x => x.IdPedidoExame).HasColumnName("id_laudo");
            builder.Property(x => x.Status).HasColumnName("status");
            builder.Property(x => x.DescricaoLaudo).HasColumnName("ds_laudo");
            builder.Property(x => x.MotivoRecusa).HasColumnName("ds_recusa");
            builder.Property(x => x.IdMedicoAprovacao).HasColumnName("id_medico_aprovacao");
            builder.Property(x => x.IdMedicoLaudo).HasColumnName("id_medico_laudo");
        }
    }
}