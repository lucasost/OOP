using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercicio_1
{
    public class ClienteComumDesconto : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return preco - (Constantes.DecontoClienteComum * preco);
        }
    }
}
