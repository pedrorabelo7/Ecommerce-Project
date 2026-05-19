using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Ecommerce.Web.ViewModels
{
    public class ProdutoViewModel
    {
        [Required(ErrorMessage = "Informe o Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a Descrição!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe o preço!")]

        public Decimal Preco { get; set; }

        [Required(ErrorMessage = "Informe o Estoque!")]

        public int Estoque { get; set; }
    }
}
