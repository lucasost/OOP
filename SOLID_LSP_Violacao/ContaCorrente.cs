using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_LSP_Violacao
{
    class ContaCorrente : Conta
    {
        public void Sacar(double valor)
        {
            this.Saldo -= valor;
        }
    }
}
