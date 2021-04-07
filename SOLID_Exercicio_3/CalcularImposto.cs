using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercicio_3
{
    public class CalcularImposto
    {
        public decimal Calcular(ICalcularImportoPais calcularImportoPais)
        {

            return calcularImportoPais.CalcularValorImposto();

        }
    }
}
