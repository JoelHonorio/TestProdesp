#region Usings

using Microsoft.EntityFrameworkCore;
using Prodesp.Dados.Context;
using Prodesp.Negocios.IRepositories;
using Prodesp.Negocios.Models;

#endregion

namespace Prodesp.Dados.Repositories
{
    public class ImunobiologicoRepository : Repository<Imunobiologico>, IImunobiologicoRepository
    {
        public ImunobiologicoRepository(ProdespDbContext context) : base(context) { }

        public async Task<Imunobiologico> ObterImunobiologico(Guid Id)
        {
            return await Db.Imunobiologico.AsNoTracking().FirstOrDefaultAsync(i => i.Id == Id);
        }

        public async Task<IEnumerable<Imunobiologico>> ObterTodosImunobiologicos()
        {
            return await Db.Imunobiologico.AsNoTracking().OrderBy(i => i.Fabricante).ToListAsync();
        }
    }
}