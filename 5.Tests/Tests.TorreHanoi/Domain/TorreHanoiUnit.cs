using System;
using Infrastructure.TorreHanoi.Log;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.TorreHanoi;
using Moq;

namespace TorreHanoi.Tests
{
    [TestClass]
    public class TorreHanoiUnit
    {
        private const string CategoriaTeste = "Domain/TorreHanoi";

        private Mock<ILogger> _mockLogger;

        [TestInitialize]
        public void SetUp()
        {
            _mockLogger = new Mock<ILogger>();
            _mockLogger.Setup(s => s.Logar(It.IsAny<string>(), It.IsAny<TipoLog>()));
        }

        [TestMethod]
        [TestCategory(CategoriaTeste)]
        public void Construtor_Deve_Retornar_Sucesso()
        {
            var torreHanoi = new Domain.TorreHanoi.TorreHanoi(3, _mockLogger.Object);
            Assert.IsNotNull(torreHanoi.Id);
            Assert.IsNotNull(torreHanoi.Discos);
            Assert.IsNotNull(torreHanoi.Destino);
            Assert.IsNotNull(torreHanoi.Intermediario);
            Assert.IsNotNull(torreHanoi.Origem);
            Assert.IsNotNull(torreHanoi.DataCriacao);
            Assert.AreEqual(torreHanoi.Status,TipoStatus.Pendente);
            Assert.IsNotNull(torreHanoi.PassoAPasso);
        }

        [TestMethod]
        [TestCategory(CategoriaTeste)]
        public void Processar_Deverar_Retornar_Sucesso()
        {
            var torreHanoi = new Domain.TorreHanoi.TorreHanoi(3,_mockLogger.Object);
            Assert.IsTrue(torreHanoi.Processar());
        }
    }
}
