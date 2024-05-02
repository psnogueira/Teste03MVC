using System.ComponentModel.DataAnnotations;

namespace Mini_Mundo.Models
{
    public class Cargo
    {
        [Key]
        public int CargoID { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "O título do cargo é obrigatório.")]
        [StringLength(50, ErrorMessage = "O título do cargo não pode ter mais que 50 caracteres.")]
        public string Titulo { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "A descrição do cargo é obrigatória.")]
        [StringLength(255, ErrorMessage = "A descrição do cargo não pode ter mais que 255 caracteres.")]
        public string Descricao { get; set; }

        [Display(Name = "Salário mínimo")]
        [Required(ErrorMessage = "O salário mínimo do cargo é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O salário mínimo do cargo deve ser um valor positivo.")]
        public decimal SalarioMinimo { get; set; }

        [Display(Name = "Salário máximo")]
        [Required(ErrorMessage = "O salário máximo do cargo é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O salário máximo do cargo deve ser um valor positivo.")]
        public decimal SalarioMaximo { get; set; }
    }
}
