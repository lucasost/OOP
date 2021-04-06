using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_LSP_Violacao
{
    class ContaComum : Conta
    {
        public double Sacar(double valor)
        {
            this.Saldo -= valor;
            return Saldo;
        }
    }
}
