using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using WebAppVeterinaria.Entity;

namespace WebAppVeterinaria.ViewModels
{
    public class AnimalViewModel
    {
        public int Id { get; set; }
        public string ClienteNome { get; set; }
        public ETipoSexo TipoSexo { get; set; }
        public ETipoEspecie TipoEspecie { get; set; }
        public ETipoPelo TipoPelo { get; set; }

        public virtual Animal Animal { get; set; }

        public virtual Cliente Cliente { get; set; }
        public List<SelectListItem> ClienteSelect { get; set; }

    }
}
