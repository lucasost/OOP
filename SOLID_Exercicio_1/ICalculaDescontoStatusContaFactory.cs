using SOLID_Exercicio_1.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercicio_1
{
   public  interface ICalculaDescontoStatusContaFactory
    {
        ICalculaDescontoStatusConta GetCalculoDescontoStatusConta(StatusContaCliente statusContaCliente);
    }
}
