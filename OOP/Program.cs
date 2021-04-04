using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteModeloDominioAnemico clienteAnemico = new ClienteModeloDominioAnemico()
            {
                Id = -1,
                Nome = "",
                Endereco = null
            };

            ClienteModeloDominioRico clienteRico = new ClienteModeloDominioRico(1,"Nome", "Endereco");
            Console.WriteLine("--------");
            Console.WriteLine("Cliente Anemico");
            Console.WriteLine($"{clienteAnemico.Id} - {clienteAnemico.Nome} - {clienteAnemico.Endereco}");
            Console.WriteLine("--------");
            Console.WriteLine("Cliente Rico");
            Console.WriteLine($"{clienteRico.Id} - {clienteRico.Nome} - {clienteRico.Endereco}");
            Console.WriteLine("Hello World!");
        }
    }
}
