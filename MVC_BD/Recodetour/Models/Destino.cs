using System.ComponentModel.DataAnnotations;

namespace Recodetour.Models
{
    public class Destino
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Origem obrigatório")]
        public string Origem { get; set; }
        [Display(Name = "Destino")]
        [Required(ErrorMessage = "Campo Destino obrigatório")]
        public string Destino_ { get; set; }
        [Display(Name = "Data de Embarque")]
        [Required(ErrorMessage = "Campo Data de Embarque obrigatório")]
        public string DataEmbarque { get; set; }
        [Display(Name = "Horário de Embarque")]
        [Required(ErrorMessage = "Campo Horário de Embarque obrigatório")]
        public string HorarioEmbarque { get; set; }
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

    }
}
