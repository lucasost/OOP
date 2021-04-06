using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_OCP_Violacao
{
    class Pedido
    {
        public virtual double DescontoPedido(double valor)
        {
            return valor;
        }
    }
}
