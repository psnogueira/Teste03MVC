using System.ComponentModel.DataAnnotations;

namespace Mini_Mundo.Models
{
    public class Funcionario
    {
        [Key]
        public int FuncionarioID { get; set; }

        [Display(Name = "Primeiro Nome")]
        [Required(ErrorMessage = "O primeiro nome do funcionário é obrigatório.")]
        [StringLength(50, ErrorMessage = "O primeiro nome do funcionário não pode ter mais que 50 caracteres.")]
        public string PrimeiroNome { get; set; }

        [Display(Name = "Último Nome")]
        [StringLength(50, ErrorMessage = "O último nome do funcionário não pode ter mais que 50 caracteres.")]
        public string UltimoNome { get; set; }

        [Display(Name = "Data de Cadastro")]
        [Required(ErrorMessage = "A data de cadastro do funcionário é obrigatória.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DtCad { get; set; }

        [Display(Name = "Salário")]
        [Required(ErrorMessage = "O salário do funcionário é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O salário do funcionário deve ser um valor positivo.")]
        public decimal Salario { get; set; }

        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "O cargo do funcionário é obrigatório.")]
        [StringLength(100, ErrorMessage = "O cargo do funcionário não pode ter mais que 100 caracteres.")]
        public string Cargo { get; set; }

        [Display(Name = "Nível de Acesso")]
        [Required(ErrorMessage = "O nível de acesso do funcionário é obrigatório.")]
        public int NivelDeAcessoID { get; set; }
    }
}
