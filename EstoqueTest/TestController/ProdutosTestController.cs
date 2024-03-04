using EstoqueTest.MockData;
using EstoqueTest.Models;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueTest.TestController
{
    public class ProdutosTestController
    {
        [Fact]
        public void RegistrarEntrada_Item_Sucesso()
        {
            //Arrange
            var produtoRepositorioMock = new ProdutoRepositoryMock();
            var service = new ProdutoServiceMock(produtoRepositorioMock);
            var novoProduto = new Produto
            {
                ProdutoId = 2,
                Descricao = "Suco",
                Quantidade = 5,
                DataFabricacao = DateTime.Now,
                DateValidade = DateTime.Now.AddDays(1)
            };

            //Act
            service.AdicionarProduto(novoProduto);

            //Assert
            var produtos = service.ObterProdutos();
            produtos.Should().ContainEquivalentOf(novoProduto);

            var quantidadeTotal = produtos.
                                    Where(x => x.ProdutoId == novoProduto.ProdutoId).Sum(y => y.Quantidade);
            quantidadeTotal.Should().Be(45);
        }

       
    }
}
