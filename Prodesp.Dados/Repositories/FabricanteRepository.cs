#region Usings

using Microsoft.EntityFrameworkCore;
using Prodesp.Dados.Context;
using Prodesp.Negocios.IRepositories;
using Prodesp.Negocios.Models;

#endregion

namespace Prodesp.Dados.Repositories
{
    public class FabricanteRepository : Repository<Fabricante>, IFabricanteRepository
    {
        public FabricanteRepository(ProdespDbContext context) : base(context) { }

        public async Task<Fabricante> ObterFabricante(Guid Id)
        {
            return await Db.Fabricante.AsNoTracking().FirstOrDefaultAsync(f => f.Id == Id);
        }

        public async Task<IEnumerable<Fabricante>> ObterTodosFabricantes()
        {
            return await Db.Fabricante.AsNoTracking().OrderBy(p => p.Marca).ToListAsync();
        }
    }
}