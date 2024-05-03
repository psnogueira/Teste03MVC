using System.ComponentModel.DataAnnotations;

namespace Mini_Mundo.Models
{
    public class Venda
    {
        [Key]
        public int VendaID { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "A descrição da Venda é obrigatória.")]
        [StringLength(255, ErrorMessage = "A descrição não pode ter mais que 255 caracteres.")]
        public string Descricao { get; set; }

        [Display(Name = "Data da venda")]
        [Required(ErrorMessage = "A data da venda é obrigatória.")]
        public DateTime DataVenda { get; set; }

        [Display(Name = "Valor Total")]
        [Required(ErrorMessage = "O Valor Total é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O Valor da venda deve ser um valor positivo.")]
        public decimal ValorTotal { get; set; }

        [Display(Name = "ID do colaborador que realizou a venda")]
        [Required(ErrorMessage = "O ID do funcionário que realizou a venda é obrigatório.")]
        public int FuncionarioID { get; set; }

        [Display(Name = "ID do cliente associado à venda")]
        [Required(ErrorMessage = "O ID do cliente associado à venda é obrigatório.")]
        public int ClienteID { get; set; }
    }
}
