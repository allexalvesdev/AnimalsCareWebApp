using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppVeterinaria.Entity
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public bool Ativo { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }


        /*Relacao EF*/

        public virtual ApplicationUser Usuario { get; set; }
        public string UsuarioId { get; set; }

        public virtual IEnumerable<Consulta> Consultas { get; set; }
        public virtual IEnumerable<Animal> Animais { get; set; }
    }
}
