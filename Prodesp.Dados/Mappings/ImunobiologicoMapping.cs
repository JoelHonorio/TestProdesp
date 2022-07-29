#region Usings

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prodesp.Negocios.Models;

#endregion

namespace Prodesp.Dados.Mappings
{
    public class ImunobiologicoMapping : IEntityTypeConfiguration<Imunobiologico>
    {
        public void Configure(EntityTypeBuilder<Imunobiologico> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Descricao).IsRequired().HasColumnType("nvarchar(400)");
            builder.Property(i => i.AnoLote).IsRequired().HasColumnType("int");
            builder.Property(i => i.DataCriacao).IsRequired().HasColumnType("datetime");
            builder.Property(i => i.DataModificacao).IsRequired().HasColumnType("datetime");

            builder.ToTable("Imunobiologico");
        }
    }
}