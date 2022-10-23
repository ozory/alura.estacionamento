using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alura.Estacionamento.Modelos;
using Xunit;

namespace Alura.Estacionamento.Tests
{
    public class VeiculoTest
    {
        [Fact(DisplayName = "Teste n°1")]
        [Trait("Funcionalidade", "Acelerar")]
        public void TestaVeiculoAcelerar()
        {
            // Arrange
            var veiculo = new Veiculo();

            // Act
            veiculo.Acelerar(10);

            // Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact(DisplayName = "Teste n°2")]
        [Trait("Funcionalidade", "Frear")]
        public void TestaVeiculoFrear()
        {
            var veiculo = new Veiculo();
            veiculo.Frear(10);

            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact(Skip = "Ainda não implementado")]
        public void ValidaNomeProprietario()
        {

        }
    }
}