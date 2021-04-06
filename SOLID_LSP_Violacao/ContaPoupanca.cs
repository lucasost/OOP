using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_LSP_Violacao
{
    class ContaPoupanca : Conta
    {
        public void Sacar(double valor)
        {
            
                if (this.Saldo > valor)
                    this.Saldo -= valor;
            
        }
    }
}
