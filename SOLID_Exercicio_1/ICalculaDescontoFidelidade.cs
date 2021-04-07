using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercicio_1
{
    public interface ICalculaDescontoFidelidade
    {
        decimal AplicarDescontoFidelidade(decimal preco, int tempoDeContaEmAnos);
    }
}
