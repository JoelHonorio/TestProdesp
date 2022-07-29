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

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string? Marca { get; set; }

        [DisplayName("Data de criação")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataCriacao { get; set; }

        [DisplayName("Data de modificação")]
        public DateTime DataModificacao { get; set; }

        public List<ImunobiologicoViewModel>? Imunobiologicos { get; set; }
    }
}