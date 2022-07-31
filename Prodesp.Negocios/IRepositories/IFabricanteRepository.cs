#region Usings

using Prodesp.Negocios.Models;

#endregion

namespace Prodesp.Negocios.IRepositories
{
    public interface IFabricanteRepository : IRepository<Fabricante>
    {
        Task<Fabricante> ObterFabricante(Guid Id);
        Task<IEnumerable<Fabricante>> ObterTodosFabricantes();
    }
}