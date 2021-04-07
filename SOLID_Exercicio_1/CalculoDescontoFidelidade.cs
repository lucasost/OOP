using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercicio_1
{
    public class CalculoDescontoFidelidade : ICalculaDescontoFidelidade
    {
        public decimal AplicarDescontoFidelidade(decimal preco, int tempoDeContaEmAnos)
        {
            decimal descontoPorFidelidade = (tempoDeContaEmAnos > Constantes.DescontoMaximoPorFidelidade) ?
             (decimal)Constantes.DescontoMaximoPorFidelidade / 100 : (decimal)tempoDeContaEmAnos / 100;

            return preco - (descontoPorFidelidade * preco);
        }

    }
}
