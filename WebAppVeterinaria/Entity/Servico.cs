using System.ComponentModel.DataAnnotations;

namespace WebAppVeterinaria.Entity
{
    public class Servico
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

    }
}
