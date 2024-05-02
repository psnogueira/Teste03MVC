using System.ComponentModel.DataAnnotations;

namespace Mini_Mundo.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoID { get; set; }

        [Display(Name = "Nome do Produto")]
        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome do produto não pode ter mais que 100 caracteres.")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "A descrição do produto é obrigatória.")]
        [StringLength(255, ErrorMessage = "A descrição do produto não pode ter mais que 255 caracteres.")]
        public string Descricao { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "O preço do produto é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço do produto deve ser um valor positivo.")]
        public decimal Preco { get; set; }

        [Display(Name = "Quantidade de Estoque")]
        [Required(ErrorMessage = "A quantidade em estoque do produto é obrigatória.")]
        [Range(0, int.MaxValue, ErrorMessage = "A quantidade em estoque do produto deve ser um valor positivo.")]
        public int QuantidadeEstoque { get; set; }
    }
}
