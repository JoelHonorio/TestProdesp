#region Usings

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prodesp.Negocios.Models;

#endregion

namespace Prodesp.Dados.Mappings
{
    public class FabricanteMapping : IEntityTypeConfiguration<Fabricante>
    {
        public void Configure(EntityTypeBuilder<Fabricante> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Marca).IsRequired().HasColumnType("nvarchar(50)");
            builder.Property(f => f.DataCriacao).IsRequired().HasColumnType("datetime");
            builder.Property(f => f.DataModificacao).IsRequired().HasColumnType("datetime");

            // 1 : N => Fabricante : Imunobiologico
            builder.HasMany(f => f.Imunobiologicos).WithOne(i => i.Fabricante).HasForeignKey(i => i.FabricanteId);

            builder.ToTable("Fabricante");
        }
    }
}