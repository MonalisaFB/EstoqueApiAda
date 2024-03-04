using EstoqueTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueTest.MockData
{
    public class ProdutoServiceMock
    {
        private readonly ProdutoRepositoryMock _produtoRepositoryMock;

        public ProdutoServiceMock(ProdutoRepositoryMock produtoRepositoryMock)
        {
            _produtoRepositoryMock = produtoRepositoryMock;
        }

        public IEnumerable<Produto> ObterProdutos()
        {
            return _produtoRepositoryMock.ObterProdutos();
        }

        public void AdicionarProduto(Produto produto)
        {
            _produtoRepositoryMock.AdicionarProduto(produto);
        }

        public void AtualizarProduto(Produto produto)
        {
            _produtoRepositoryMock.AdicionarProduto(produto);
        }

        public void RemoverProduto(int id)
        {
            _produtoRepositoryMock.RemoverProduto(id);
        }
    }
}
