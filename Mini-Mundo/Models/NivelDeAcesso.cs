using System.ComponentModel.DataAnnotations;

namespace Mini_Mundo.Models
{
    public class NivelDeAcesso
    {
        [Key]
        public int NivelDeAcessoID { get; set; }

        [Display(Name = "Nível de Acesso")]
        [Required]
        public string NomeNivel { get; set; }
    }
}
