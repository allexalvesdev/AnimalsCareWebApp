using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebAppVeterinaria.ViewModels;

namespace WebAppVeterinaria.Entity
{
    public class Consulta
    {
        //Dados Consulta
        [Key]
        public int Id { get; set; }
        [DisplayName("Data Cadastro")]

        public DateTime DataCadastro { get; set; } = DateTime.Now;

        [DisplayName("Data da Consulta")]
        public DateTime DataConsulta { get; set; }

        [DisplayName("Data do Retorno")]
        public DateTime DataRetorno { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Retorno?")]
        public bool Retorno { get; set; }

        [DisplayName("Observação")]
        public string Observacao { get; set; }

        //Dados Pet
        [DisplayName("Paciente")]
        public string NomeAnimal { get; set; }

        [DisplayName("Raça")]
        public string RacaAnimal { get; set; }

        [DisplayName("Sexo")]
        public ETipoSexo TipoSexo { get; set; }

        [DisplayName("Espécie")]
        public ETipoEspecie TipoEspecie { get; set; }
        public string Idade { get; set; }
        public string Peso { get; set; }

        [DisplayName("Histórico Clinico")]
        public string HistoricoClinicoAnimal { get; set; }


        public int ClienteId { get; set; }
        public int VeterinarioId { get; set; }

        /*Relacao EF*/
        public virtual Cliente Cliente { get; set; }
        public virtual Veterinario Veterinario { get; set; }
    }
}
