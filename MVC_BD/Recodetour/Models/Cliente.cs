using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Recodetour.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Nome obrigatório")]
        public string Nome { get; set; }
        [Display(Name = "RG")]
        [Required(ErrorMessage = "Campo RG obrigatório")]
        public string Rg { get; set; }
        [Required(ErrorMessage = "Campo Email obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo Telefone obrigatório")]
        public string Telefone { get; set; }
        public List<Destino> Destinos { get; set; }
    }
}
