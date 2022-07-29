#region Usings

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#endregion

namespace Prodesp.ViewModels
{
    public class ImunobiologicoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Fabricante")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid FabricanteId { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(400, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string? Descricao { get; set; }

        [DisplayName("Ano do lote")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Int32 AnoLote { get; set; }

        [DisplayName("Data de criação")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataCriacao { get; set; }

        [DisplayName("Data de modificação")]
        public DateTime DataModificacao { get; set; }

        public FabricanteViewModel? Fabricante { get; set; }

        public List<FabricanteViewModel>? Fabricantes { get; set; }
    }
}