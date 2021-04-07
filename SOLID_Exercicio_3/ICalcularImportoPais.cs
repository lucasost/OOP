using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercicio_3
{
    public interface ICalcularImportoPais
    {
        decimal TotalRenda { get; set; }
        decimal TotalDeducao { get; set; }
        decimal CalcularValorImposto();
    }
}
