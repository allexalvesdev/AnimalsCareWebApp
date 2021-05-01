using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppVeterinaria.Entity;

namespace WebAppVeterinaria.ViewModels
{
    public class ConsultaViewModel
    {
        public int Id { get; set; }
        public Consulta Consulta { get; set; }

        public DateTime DataConsulta { get; set; }

        public DateTime DataRetorno { get; set; }

        public bool Retorno { get; set; }

        public Cliente Cliente { get; set; }
        public string ClienteNome { get; set; }
        public Veterinario Veterinario { get; set; }
        public string VeterinarioNome { get; set; }

        public List<SelectListItem> ClienteSelect { get; set; }
        public List<SelectListItem> VeterinarioSelect { get; set; }
    }
}
