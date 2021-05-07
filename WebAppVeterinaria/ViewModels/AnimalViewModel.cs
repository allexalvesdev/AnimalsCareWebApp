using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppVeterinaria.Entity;

namespace WebAppVeterinaria.ViewModels
{
    public class AnimalViewModel
    {
        public int Id { get; set; }
        public Animal Animal { get; set; }


        public Cliente Cliente { get; set; }
        public string ClienteNome { get; set; }

        public ETipoSexo TipoSexo { get; set; }
        public ETipoEspecie TipoEspecie { get; set; }
        public ETipoPelo TipoPelo { get; set; }

        public List<SelectListItem> ClienteSelect { get; set; }

    }
}
