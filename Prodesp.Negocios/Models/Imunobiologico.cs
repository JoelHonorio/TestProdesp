namespace Prodesp.Negocios.Models
{
    public class Imunobiologico : Entity
    {
        public Guid FabricanteId { get; set; }
        public string? Descricao { get; set; }
        public Int32 AnoLote { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }

        public Fabricante? Fabricante { get; set; }
    }
}