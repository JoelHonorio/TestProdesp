#region Usings

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Prodesp.ViewModels;

#endregion

namespace Prodesp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<FabricanteViewModel> FabricanteViewModel { get; set; }
        public DbSet<ImunobiologicoViewModel> ImunobiologicoViewModel { get; set; }
    }
}