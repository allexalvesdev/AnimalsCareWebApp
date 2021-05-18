using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebAppVeterinaria.Entity;

namespace WebAppVeterinaria.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [DisplayName("Nome Completo")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(8, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 8)]
        [DisplayName("RG")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(11, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        [DisplayName("CPF")]
        public string Cpf { get; set; }

        [StringLength(11, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(11, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Celular { get; set; }

        public bool Ativo { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(8, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 8)]
        [DisplayName("CEP")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [DisplayName("Endereço")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(15, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [DisplayName("Número")]
        public string Numero { get; set; }
        public string Complemento { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Estado { get; set; }

        /*Relacao EF*/
        public virtual IEnumerable<Consulta> Consultas { get; set; }
        public virtual IEnumerable<Animal> Animais { get; set; }
        public virtual ApplicationUser Usuario { get; set; }
        public string UsuarioId { get; set; }
    }
}
