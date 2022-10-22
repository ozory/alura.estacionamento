using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using Xunit;

namespace Alura.Estacionamento.Tests
{
    public class PatioTest
    {
        [Fact]
        public void ValidaFatureamento()
        {
            // Arrange
            var estacionamento = new Patio();
            var operador = new Operador() { Nome = "André" };
            var veiculo = new Veiculo()
            {
                Proprietario = "Paulo",
                Tipo = TipoVeiculo.Automovel,
                Cor = "Preto",
                Modelo = "Mustang",
                Placa = "ASD-9999"
            };

            estacionamento.OperadorPatio = operador;
            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            // Act
            double faturamento = estacionamento.TotalFaturado();

            // Assert
            Assert.Equal(2, faturamento);
        }

        [Theory]
        [InlineData("Paulo Dias", "ASD-1234", "Preto", "Mustang")]
        [InlineData("Paulo Dias", "ASD-4321", "Vermelho", "Dodge")]
        [InlineData("Paulo Dias", "ASD-5678", "Azul", "Camaro")]
        public void ValidaFatureamentoComVariosVeiculos(
                string proprietario,
                string placa,
                string cor,
                string modelo
            )
        {

        }
    }
}