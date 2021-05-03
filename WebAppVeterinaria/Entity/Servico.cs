using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppVeterinaria.Entity
{
    public class Servico : Animal
    {
        public int Id { get; set; }
        public DateTime DataChegada { get; set; }
        public DateTime PrevisaoEntrega { get; set; }
        public string Nome { get; set; }
    }
}
