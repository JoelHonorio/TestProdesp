namespace Prodesp.Negocios.Models
{
    public class Fabricante : Entity
    {
        public string? Marca { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }

        public List<Imunobiologico>? Imunobiologicos { get; set; }
    }
}