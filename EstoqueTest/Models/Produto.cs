using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueTest.Models
{
    public class Produto
    {
        [Required]
        public int ProdutoId { get; set; }
        public int Lote {  get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public DateTime DateValidade { get; set; }
        public DateTime DataFabricacao { get; set; }

    }
}
