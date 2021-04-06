using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_OCP_Violacao
{
    class DescontoClienteEspecial:Pedido
    {
        public override double DescontoPedido(double valor)
        {
            return valor - 50;
        }
    }
}
