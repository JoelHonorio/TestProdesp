#region Usings

using Microsoft.EntityFrameworkCore;
using Prodesp.Negocios.Models;

#endregion

namespace Prodesp.Dados.Context
{
    public class ProdespDbContext : DbContext
    {
        public ProdespDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Imunobiologico> Imunobiologico { get; set; }
        public DbSet<Fabricante> Fabricante { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProdespDbContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.Restrict;

            base.OnModelCreating(modelBuilder);
        }
    }
}