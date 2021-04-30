using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppVeterinaria.Entity
{
    public class Veterinario
    {
        [Key]
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string CodigoCRMV { get; set; }
        public bool Ativo { get; set; }

        public Endereco Endereco { get; set; }

        /*Relacao EF*/
        public IEnumerable<Consulta> Consultas { get; set; }
    }
}
