using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppVeterinaria.Entity;

namespace WebAppVeterinaria.ViewModels
{
    public class ConsultaViewModel
    {
        //Dados Consulta
        public int Id { get; set; }

        [DisplayName("Data do Cadastro")]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        [DisplayName("Data da Consuta")]
        [Required(ErrorMessage = "Escolha uma data para consulta")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy HH:mm:ss}")]
        public DateTime DataConsulta { get; set; }

        [DisplayName("Data do Retorno")]
        public DateTime? DataRetorno { get; set; } = null;

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(500, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        public bool Retorno { get; set; }

        [StringLength(500, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [DisplayName("Observação")]
        public string Observacao { get; set; }

        //Dados Pet

        [DisplayName("Raça")]
        public string Raca { get; set; }

        [DisplayName("Sexo")]
        public ETipoSexo TipoSexo { get; set; }

        [DisplayName("Espécie")]
        public ETipoEspecie TipoEspecie { get; set; }
        public string Idade { get; set; }
        public string Peso { get; set; }

        [DisplayName("Histórico Clinico")]
        public string HistoricoClinicoAnimal { get; set; }

        [DisplayName("Cliente")]
        public int ClienteId { get; set; }

        [DisplayName("Veterinário")]
        public int VeterinarioId { get; set; }

        [DisplayName("Pet")]
        public int AnimalId { get; set; }

        public string UsuarioId { get; set; }

        /*Relacao EF*/
        public virtual Cliente Cliente { get; set; }
        public virtual Animal Animal { get; set; }
        public virtual Veterinario Veterinario { get; set; }
        public virtual ApplicationUser Usuario { get; set; }
     
    }
}
