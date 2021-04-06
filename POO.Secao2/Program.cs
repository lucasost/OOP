using System;

namespace POO.Secao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diagrama de Classes");

            //interfaces

            var registraOcorrenciasConsole = new RegistrarOcorrencias(new RegistrarNoConsole());

            registraOcorrenciasConsole.RegistrarInfo("Registro console");

            var registrarOcorrenciasArquivo = new RegistrarOcorrencias(new RegistrarNoArquivo(@"c:\\teste.txt"));

            registrarOcorrenciasArquivo.RegistrarInfo("Registro Arquivo");

            Console.ReadLine();
        }
    }
}
