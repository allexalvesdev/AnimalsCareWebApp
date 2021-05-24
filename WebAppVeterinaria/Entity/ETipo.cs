using System;
using System.ComponentModel.DataAnnotations;

namespace WebAppVeterinaria.Entity
{
    public enum ETipoEspecie
    {
        Canina = 1,
        Felina = 2
    }

    public enum ETipoSexo
    {
        [Display(Name = "Macho")]
        Macho = 1,
        [Display(Name = "Fêmea")]
        Femea = 2
    }

    public enum ETipoPelo
    {
        [Display(Name = "Pelo Longo")]
        PeloLongo = 1,
        [Display(Name = "Pelo Curto")]
        PeloCurto = 2,
        [Display(Name = "Pelo Curto Encaracolado")]
        PeloCurtoEncaracolado = 3,
        [Display(Name = "Pelo Ondulado Longo")]
        PeloOnduladoLongo = 4,
        [Display(Name = "Pelo Duplo")]
        PeloDupla = 5,
        [Display(Name = "Pelo Textura Dura ")]
        PeloTexturaDura = 5,
        [Display(Name = "Pelo Textura Lisa")]
        PeloTexturaLisa = 6,
        [Display(Name = "Pelo Peculiar")]
        PeloPeculiar = 7
    }


}
