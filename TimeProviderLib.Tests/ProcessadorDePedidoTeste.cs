using Moq;
using NUnit.Framework;
using System;
using TimeProviderLib.Implementation;

namespace TimeProviderLib.Tests
{
    [TestFixture]
    public class ProcessadorDePedidoTeste
    {
        [Test]
        public void Deve_notificar_somente_no_dia_primeiro()
        {
            var primeiroDiaDoMes = new DateTime(2014, 10, 1);
            var timeProviderStub = new Mock<TimeProvider>();
            timeProviderStub.Setup(t => t.Today).Returns(primeiroDiaDoMes);
            TimeProvider.Current = timeProviderStub.Object;

            var notificadorMock = new Mock<INotificadorDeEventos>();
            var processador = new ProcessadorDePedido(notificadorMock.Object);

            processador.Processar();

            notificadorMock.Verify(n => n.Notificar());
        }

        [TearDown]
        public void TearDown()
        {
            TimeProvider.ResetToDefault();
        }
    }
}
