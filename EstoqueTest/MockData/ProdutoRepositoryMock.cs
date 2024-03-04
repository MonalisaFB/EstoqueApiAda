using EstoqueTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueTest.MockData
{
    public class ProdutoRepositoryMock
    {
        private List<Produto> _produtos;
        
        public ProdutoRepositoryMock()
        {
            _produtos = new List<Produto>();

            _produtos.Add(new Produto { ProdutoId = 1, Descricao = "Sorvete de Brigadeiro", Lote = 1, Quantidade = 5, DataFabricacao = DateTime.Now, DateValidade = DateTime.Now.AddDays(30) });
            _produtos.Add(new Produto { ProdutoId = 2, Descricao = "Suco", Lote = 2, Quantidade = 10, DataFabricacao = DateTime.Now, DateValidade = DateTime.Now.AddDays(5) });

        }

        public IEnumerable<Produto> ObterProdutos()
        {
            return _produtos;
        }
        public Produto ObterProdutoPorId(int id)
        {
            return _produtos.FirstOrDefault(x => x.ProdutoId == id);
        }

        public void AdicionarProduto(Produto produto)
        {
            _produtos.Add(produto);
        }

        public void AtualizarProduto(Produto produto)
        {
            var produtoExistente = _produtos.Find(x => x.ProdutoId == produto.ProdutoId);
            if(produtoExistente != null)
            {
                produtoExistente.Descricao = produto.Descricao;
                produtoExistente.Lote = produto.Lote;
                produtoExistente.Quantidade = produto.Quantidade;
                produtoExistente.DateValidade = produto.DateValidade;
                produtoExistente.DataFabricacao = produto.DataFabricacao;
            }
        }

        public void RemoverProduto(int id)
        {
            _produtos.RemoveAll( x => x.ProdutoId == id);
        }

    }


}
