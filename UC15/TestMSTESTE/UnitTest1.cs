using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto_teste;

namespace TestMSTeste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            //Arrange - Preparacao
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;


            //Act - Acao/Execucao
            var Resultado = operacoes.Somar(pNum, sNum);

            //Assert - Verificacao
            Assert.AreEqual(rNum, Resultado);

        }

        //arrange2
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 1, 3)]
        [DataRow(3, 3, 6)]
        [DataRow(4, 1, 4)] //Errado

        public void SomarDoisNumerosLista(double pNun, double sNun, double rNun)
        {
            //act2
            var resultado = operacoes.Somar(pNun, sNun);

            //assert2
            Assert.AreEqual(rNun, resultado);
        }
    }
}