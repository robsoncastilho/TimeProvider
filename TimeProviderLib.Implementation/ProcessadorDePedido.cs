using System;

namespace TimeProviderLib.Implementation
{
    public class ProcessadorDePedido
    {
        private readonly INotificadorDeEventos _notificador;

        public ProcessadorDePedido(INotificadorDeEventos notificador)
        {
            if (notificador == null) throw new ArgumentNullException("notificador");
            _notificador = notificador;
        }

        public void Processar()
        {
            // processando pedido...
            // so deve notificar no dia primeiro de cada mes
            if (TimeProvider.Current.Today.Day == 1)
                _notificador.Notificar();
        }
    }
}
