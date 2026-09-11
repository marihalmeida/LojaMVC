using LojaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMVCTests
{
    public class ClienteTest
    {
        [Fact]
        public void Idada_Menor_18anos_Cadastro_Inválido()
        {
            //arrange
            var cliente = new Cliente

            {
               Nome = "gisela",
               Email = "gisela@gmail.com",
               Idade = 17,
               Ativo = true

            };

            //Act 
            var resultado = cliente.Validation();

            //Verificação

            Assert.False(resultado); 
        }


        [Fact]
        public void Verifica_Ciente_Pode_Comprar_Se_Maior_de_Idade_E_Ativo()
        {
            var cliente = new Cliente

            {
                Nome = "Mari",
                Email = "mari@gmail.com",
                Idade = 18,
                Ativo = true
            };
            var resultado = cliente.Validation() && cliente.Permission();
            Assert.True(resultado);

        }

        [Fact]
        public void Verifica_Cliente_Inativo_Nao_Faz_Compras()
        {
            var cliente = new Cliente
            {
                Nome = "davi",
                Email = "davizinho@gmail.com",
                Idade = 20,
                Ativo = false
            };

        }
    }
}
