using System.ComponentModel.DataAnnotations;

namespace WebAppVeterinaria.ViewModels
{
    public class ServicoViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(500, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public decimal Preco { get; set; }
    }
}
