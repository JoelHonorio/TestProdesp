#region Usings

using Prodesp.Negocios.Models;

#endregion

namespace Prodesp.Negocios.IRepositories
{
    public interface IImunobiologicoRepository : IRepository<Imunobiologico>
    {
        Task<Imunobiologico> ObterImunobiologico(Guid Id);
        Task<List<Imunobiologico>> ObterTodosImunobiologicos();
    }
}