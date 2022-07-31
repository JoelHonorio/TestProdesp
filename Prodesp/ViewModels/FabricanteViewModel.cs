#region Usings

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#endregion

namespace Prodesp.ViewModels
{
    public class FabricanteViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public string? Marca { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }
        public IEnumerable<ImunobiologicoViewModel>? Imunobiologicos { get; set; }
    }
}