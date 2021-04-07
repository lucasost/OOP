using System;

namespace SOLID_Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculaDescontoFidelidade descontoFidelidade = new CalculoDescontoFidelidade();

            ICalculaDescontoStatusContaFactory descontoConta = new CalculaDescontoStatusContaFactory();

            GerenciadorDeDescontos gerenciadorDeDescontos = new GerenciadorDeDescontos(descontoFidelidade, descontoConta);

            GerDesc gerDesc = new GerDesc();

            Console.WriteLine("Verificando GerDesc");
            Console.WriteLine($"Valor da compra 1000 e fidelidade 10 anos (5%)");
            Console.WriteLine($"Cliente tipo 2 - Resultado {(gerDesc.Calcular(1000, 2, 10))}");
            Console.WriteLine($"Cliente tipo 3 - Resultado {(gerDesc.Calcular(1000, 3, 10))}");
            Console.WriteLine($"Cliente tipo 4 - Resultado {(gerDesc.Calcular(1000, 4, 10))}");

            Console.WriteLine();
            Console.WriteLine($"Valor da compra 1000 e fidelidade 4 anos (4%)");
            Console.WriteLine($"Cliente tipo 2 - Resultado {(gerDesc.Calcular(1000, 2, 4))}");
            Console.WriteLine($"Cliente tipo 3 - Resultado {(gerDesc.Calcular(1000, 3, 4))}");
            Console.WriteLine($"Cliente tipo 4 - Resultado {(gerDesc.Calcular(1000, 4, 4))}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Verificando GerenciadorDeDescontos");
            Console.WriteLine($"Valor da compra 1000 e fidelidade 10 anos (5%)");
            Console.WriteLine($"Cliente tipo 2 - Resultado {(gerenciadorDeDescontos.AplicarDesconto(1000, Enum.StatusContaCliente.ClienteComum, 10))}");
            Console.WriteLine($"Cliente tipo 3 - Resultado{(gerenciadorDeDescontos.AplicarDesconto(1000, Enum.StatusContaCliente.ClienteEspecial, 10))}");
            Console.WriteLine($"Cliente tipo 4 - Resultado{(gerenciadorDeDescontos.AplicarDesconto(1000, Enum.StatusContaCliente.ClinteVip, 10))}");

            Console.WriteLine();
            Console.WriteLine($"Valor da compra 1000 e fidelidade 4 anos (4%)");
            Console.WriteLine($"Cliente tipo 2 - Resultado {(gerenciadorDeDescontos.AplicarDesconto(1000, Enum.StatusContaCliente.ClienteComum, 4))}");
            Console.WriteLine($"Cliente tipo 3 - Resultado{(gerenciadorDeDescontos.AplicarDesconto(1000, Enum.StatusContaCliente.ClienteEspecial, 4))}");
            Console.WriteLine($"Cliente tipo 4 - Resultado{(gerenciadorDeDescontos.AplicarDesconto(1000, Enum.StatusContaCliente.ClinteVip, 4))}");


        }
    }
}
