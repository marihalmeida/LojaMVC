using LojaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMVCTests
{
     public class ProdutoTests
    {
        [Fact]
        public void ValorProd_Maior_que_Zero()  //É importante deixar direto e claro a nomenclatura
        {
            //Arrange
            var produto = new Produto
            {
                Nome = "Mouse",
                Preco = 0,
                Estoque = 50
            };

            //Act

            var resultado = produto.Validation();

            //Verificação= Assert

            Assert.False(resultado); //verifica se é falso. E sim! nesse caso é falso, por isso que funciona

        }

        [Fact]

        public void Estoque_Invalido_Quando_For_Negativo()
        {
            //Arrange
            var produto = new Produto
            {
                Nome = "Teclado",
                Preco = 50,
                Estoque = -1
            };

            //ACT 
            var resultado = produto.Validation();

            //Assert
            Assert.False(resultado);

        }

        [Fact]
        public void Nome_Invalido_seVazio_ou_Nulo()
        {
            //Arrange 
            var produto = new Produto
            {
                Nome = "",
                Preco = 50,
                Estoque = 10
            };

            //ACT 
            var resultado = produto.Validation();

            //Assert
            Assert.False(resultado);
        }





        [Fact]
        public void VerificaNome_Valido_Verifica_Preco_Valido_Verifica_Estoque_Valido()
        {
            //Arrange 
            var produto = new Produto
            {
                Nome = "Monitor",
                Preco = 50,
                Estoque = 10
            };

            //ACT 
            var resultado = produto.Validation();

            //Assert
            Assert.True(resultado);
        }


    }
}
