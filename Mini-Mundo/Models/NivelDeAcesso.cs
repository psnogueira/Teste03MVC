using System.ComponentModel.DataAnnotations;

namespace Mini_Mundo.Models
{
    public class NivelDeAcesso
    {
        [Key]
        public int NivelDeAcessoID { get; set; }

        [Display(Name = "Nome do Nível de Acesso")]
        [Required(ErrorMessage = "O Nome do Nível de Acesso é obrigatório.")]
        [StringLength(100, ErrorMessage = "O Nome não pode ter mais que 100 caracteres.")]
        public string NomeNivel { get; set; }
    }
}
