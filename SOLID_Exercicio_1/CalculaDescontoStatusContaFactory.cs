using SOLID_Exercicio_1.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercicio_1
{
    public class CalculaDescontoStatusContaFactory : ICalculaDescontoStatusContaFactory
    {
        public ICalculaDescontoStatusConta GetCalculoDescontoStatusConta(StatusContaCliente statusContaCliente)
        {
            ICalculaDescontoStatusConta calcular;
            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    calcular = new ClienteNaoRegistradoDesconto();
                    break;
                case StatusContaCliente.ClienteComum:
                    calcular = new ClienteComumDesconto();
                    break;
                case StatusContaCliente.ClienteEspecial:
                    calcular = new ClienteEspecialDesconto();
                    break;
                case StatusContaCliente.ClinteVip:
                    calcular = new ClienteVIPDesconto();
                    break;
                default:
                    throw new NotImplementedException();
            }
            return calcular;
        }
    }
}
