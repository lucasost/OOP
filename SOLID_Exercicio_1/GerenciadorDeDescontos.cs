using SOLID_Exercicio_1.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercicio_1
{
    class GerenciadorDeDescontos
    {
        private readonly ICalculaDescontoFidelidade _calculaDescontoFidelidade;
        private readonly ICalculaDescontoStatusContaFactory _calculaDescontoStatusContaFactory;

        public GerenciadorDeDescontos(ICalculaDescontoFidelidade calculaDescontoFidelidade,
            ICalculaDescontoStatusContaFactory calculaDescontoStatusContaFactory)
        {
            _calculaDescontoFidelidade = calculaDescontoFidelidade;
            _calculaDescontoStatusContaFactory = calculaDescontoStatusContaFactory;
        }

        public decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoDepoisDoDesconto = 0;
            precoDepoisDoDesconto = _calculaDescontoStatusContaFactory.
           GetCalculoDescontoStatusConta(statusContaCliente).AplicarDescontoStatusConta(precoProduto);

            precoDepoisDoDesconto = _calculaDescontoFidelidade.
                AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContaEmAnos);

            return precoDepoisDoDesconto;
        }
    }
}
