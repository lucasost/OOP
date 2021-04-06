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

            ClienteModeloDominioRico clienteRico = new ClienteModeloDominioRico(1, "nome sobrenome", "endereco do cliente");
            Console.WriteLine("--------");
            Console.WriteLine("--------");
            Console.WriteLine();

            Console.WriteLine("Cliente Anemico");
            Console.WriteLine($"{clienteAnemico.Id} - {clienteAnemico.Nome} - {clienteAnemico.Endereco}");
            Console.WriteLine("--------");
            Console.WriteLine("--------");

            Console.WriteLine();
            Console.WriteLine("Cliente Rico");
            Console.WriteLine($"{clienteRico.Id} - {clienteRico.Nome} - {clienteRico.Endereco}");
            Console.WriteLine("--------");
            Console.WriteLine("--------");

            Console.WriteLine();
            Console.WriteLine("Static");
            Console.WriteLine($"{clienteRico.Id} - {FormatarString.TudoMaiusculo(clienteRico.Nome)} - {FormatarString.TudoMinusculo(clienteRico.Endereco)}");
            Console.WriteLine("--------");
            Console.WriteLine("--------");

            Console.WriteLine();
            Console.WriteLine("Extensions");
            Console.WriteLine($"{clienteRico.Id} - {clienteRico.Nome.TudoMaiusculo()} - {clienteRico.Endereco.TudoMinusculo()}");
            Console.WriteLine("Extensions 2");
            Console.WriteLine($"{clienteRico.Id} - {clienteRico.Nome.PrimeiraLetraMaiuscula()} - {clienteRico.Endereco.TudoMinusculo()}");
            Console.WriteLine("--------");
            Console.WriteLine("--------");

            Console.WriteLine();
            Console.WriteLine("HERANÇA CONTRUTORES");
            Console.WriteLine("Instanciando apenas veículo");
            var veiculo = new Veiculo();
            Console.WriteLine("Instanciando apenas carro");
            var carro = new Carro();
            Console.WriteLine("Instanciando carro passando número do motor");
            var carroComMotor = new Carro("12312asgfrtgb");
            Console.WriteLine("Chamando método Registrar da classe filha que chama registrar da classe pai (base)");
            carroComMotor.Registrar();
            Console.WriteLine("--------");
            Console.WriteLine("--------");

            Console.WriteLine();
            Console.WriteLine("HERANÇA UpCasting");
            var circulo = new Circulo();
            Forma f = circulo;
            Console.WriteLine($"Forma é um círculo {(f == circulo ? "SIM" : "NAO")}");
            f.Desenhar();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("HERANÇA DownCasting");
            Circulo c = (Circulo)f;
            Console.WriteLine($"Círculo é uma Forma {(circulo == f ? "SIM" : "NAO")}");
            Console.WriteLine($"Círculo (casting) é uma Circulo {(c == circulo ? "SIM" : "NAO")}");
            c.ColorirCiruculo();
            c.Desenhar();

            Console.WriteLine();
            Console.WriteLine("--------");
            Console.WriteLine("Operador AS (as)");
            Forma formaAs = new Forma();
            Circulo circuloAs = formaAs as Circulo;
            if (circuloAs != null)
            {
                circuloAs.ColorirCiruculo();
            }
            else
            {
                Console.WriteLine("Operação de downcast inválida (as)");
            }

            Console.WriteLine();
            Console.WriteLine("--------");
            Console.WriteLine("Operador IS (is)");
            Circulo circuloIs = new Circulo();
            Forma formaIs = circuloIs;
            if (formaIs is Circulo)
            {
                ((Circulo)formaIs).ColorirCiruculo();
            }
            else
            {
                Console.WriteLine("Operação de downcast inválida (is)");
            }


        }
    }
}
