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
        public Consulta Consulta { get; set; }

        public List<SelectListItem> ClienteSelect { get; set; }
        public List<SelectListItem> VeterinarioSelect { get; set; }
    }
}
