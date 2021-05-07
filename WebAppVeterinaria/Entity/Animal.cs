using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppVeterinaria.Entity
{
    public class Animal
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Raca { get; set; }
        public string Idade { get; set; }
        public string Peso { get; set; }
        public string Observacao { get; set; }
        public ETipoSexo TipoSexo { get; set; }
        public ETipoEspecie TipoEspecie { get; set; }
        public ETipoPelo TipoPelo { get; set; }
        public DateTime Nascimento { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
