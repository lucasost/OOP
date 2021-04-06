using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_OCP_Violacao
{
    class DescontoClienteAssociado : Pedido
    {
        public override double DescontoPedido(double valor)
        {
            return valor - 10;
        }
    }
}
