using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercicio_3
{
    class CalcularImpotoEUA : ICalcularImportoPais
    {
        public decimal TotalRenda { get; set; }
        public decimal TotalDeducao { get; set; }

        public decimal CalcularValorImposto()
        {
            decimal valorBase = TotalRenda - TotalDeducao;
            return valorBase * 10 / 100;
        }
    }
}
