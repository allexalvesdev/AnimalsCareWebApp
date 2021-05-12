using System;
using System.ComponentModel.DataAnnotations;

namespace WebAppVeterinaria.Entity
{
    public class Consulta
    {
        //Dados Consulta

        [Key]
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime DataConsulta { get; set; }
        public Nullable<DateTime> DataRetorno { get; set; } = null;
        public string Descricao { get; set; }
        public bool Retorno { get; set; }
        public string Observacao { get; set; }

        //Dados Pet

        public string NomeAnimal { get; set; }
        public string RacaAnimal { get; set; }
        public ETipoSexo TipoSexo { get; set; }
        public ETipoEspecie TipoEspecie { get; set; }
        public string Idade { get; set; }
        public string Peso { get; set; }
        public string HistoricoClinicoAnimal { get; set; }


        public int ClienteId { get; set; }
        public int VeterinarioId { get; set; }

        /*Relacao EF*/
        public virtual Cliente Cliente { get; set; }
        public virtual Veterinario Veterinario { get; set; }

    }
}
