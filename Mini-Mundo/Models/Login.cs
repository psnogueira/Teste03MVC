using System.ComponentModel.DataAnnotations;

namespace Mini_Mundo.Models
{
    public class Login
    {
        [Key]
        public int LoginID { get; set; }

        [Required(ErrorMessage = "O Usuário é obrigatório.")]
        [StringLength(50, ErrorMessage = "O Usuário não pode ter mais que 50 caracteres.")]
        [Display(Name = "Nome do Usuário")]
        public string Usuario { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [StringLength(100, ErrorMessage = "O e-mail não pode ter mais que 100 caracteres.")]
        [EmailAddress(ErrorMessage = "O e-mail não é válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória.")]
        [StringLength(100, ErrorMessage = "A senha não pode ter mais que 100 caracteres.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "A senha deve ter pelo menos 8 caracteres, um caracter especial, um número e uma letra maiúscula.")]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Display(Name = "Nível de Acesso")]
        [Required(ErrorMessage = "O nível de acesso do Login é obrigatório.")]
        public int NivelDeAcessoID { get; set; }
    }
}
