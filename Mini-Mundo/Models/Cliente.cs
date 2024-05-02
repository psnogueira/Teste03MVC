using System.ComponentModel.DataAnnotations;

namespace Mini_Mundo.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }

        [Required]
        [Display(Name = "Primeiro Nome")]
        public string PrimeiroNome { get; set; }

        [Display(Name = "Último Nome")]
        public string UltimoNome { get; set; }

        public string CPF { get; set; }

        [Required]
        [Display(Name = "Nível de Acesso")]
        public int NivelDeAcessoID { get; set; }
    }
}
