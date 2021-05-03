using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppVeterinaria.Entity
{
    public class Animal
    {
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
    }
}
