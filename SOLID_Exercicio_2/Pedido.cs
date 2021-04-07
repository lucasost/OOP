using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercicio_2
{
    public class Pedido
    {
        private readonly ILogger _logger;

        public Pedido(ILogger logger)
        {
            _logger = logger;
        }
        public virtual void AdicionarPedido()
        {
            try
            {
                _logger.Registrar($"PEDIDO INCLUIDO AS {DateTime.Now}");
            }
            catch (Exception ex)
            {

                _logger.Registrar($"ERRO AO INCLUIR PEDIDO AS {DateTime.Now} -- {ex.Message}");
            }
        }
    }
}
