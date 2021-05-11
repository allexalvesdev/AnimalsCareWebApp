using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppVeterinaria.Entity
{
    public class Animal
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Raca { get; set; }

        [Required(ErrorMessage = "Digite uma idade")]
        public string Idade { get; set; }

        [Required(ErrorMessage = "Digite um peso")]
        public string Peso { get; set; }

        [StringLength(500, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Observacao { get; set; }
        public ETipoSexo TipoSexo { get; set; }
        public ETipoEspecie TipoEspecie { get; set; }

        [Required(ErrorMessage = "Escolha uma opção de Pelo")]
        public ETipoPelo TipoPelo { get; set; }

        [Required(ErrorMessage = "Escolha a data de Nascimento")]
        public DateTime Nascimento { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
