using System.ComponentModel.DataAnnotations;

namespace Mini_Mundo.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }

        [Display(Name = "Primeiro Nome")]
        [Required(ErrorMessage = "O primeiro nome do cliente é obrigatório.")]
        [StringLength(50, ErrorMessage = "O primeiro nome do cliente não pode ter mais que 50 caracteres.")]
        public string PrimeiroNome { get; set; }

        [Display(Name = "Último Nome")]
        [StringLength(50, ErrorMessage = "O último nome do cliente não pode ter mais que 50 caracteres.")]
        public string UltimoNome { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "O endereço do cliente é obrigatório.")]
        [StringLength(255, ErrorMessage = "O endereço do cliente não pode ter mais que 255 caracteres.")]
        public string Endereco { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O CPF do cliente é obrigatório.")]
        [StringLength(11, ErrorMessage = "O CPF do cliente deve ter 11 dígitos.", MinimumLength = 11)]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF do cliente deve conter apenas dígitos.")]
        public string CPF { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O telefone do cliente é obrigatório.")]
        [StringLength(15, ErrorMessage = "O telefone do cliente não pode ter mais que 15 caracteres.")]
        [RegularExpression(@"^\d{10,15}$", ErrorMessage = "O telefone do cliente deve conter apenas dígitos e ter entre 10 e 15 dígitos.")]
        public string Telefone { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "O e-mail do cliente é obrigatório.")]
        [StringLength(100, ErrorMessage = "O e-mail do cliente não pode ter mais que 100 caracteres.")]
        [EmailAddress(ErrorMessage = "O e-mail do cliente não é válido.")]
        public string Email { get; set; }

    }
}
