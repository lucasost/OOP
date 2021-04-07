using System;

namespace SOLID_Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ICalcularImportoPais calcularImportoBrasil = new CalcularImpotoBrasil();
            calcularImportoBrasil.TotalDeducao = 100;
            calcularImportoBrasil.TotalRenda = 1000;

            CalcularImposto calcularImposto = new CalcularImposto();

            Console.WriteLine($"Brasil: {calcularImposto.Calcular(calcularImportoBrasil)}");

        }
    }
}
