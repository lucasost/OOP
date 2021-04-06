using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Carro : Veiculo
    {
        public Carro(string numeroMotor) : base(numeroMotor)
        {
            Console.WriteLine($"Construtor Carro. - Motor: {numeroMotor}");
        }

        public Carro()
        {
            Console.WriteLine("Construtor Carro.");
        }
        public string Placa { get; set; }

        public override void Registrar()
        {
            base.Registrar();
            Console.WriteLine("Carro Registrado.");
        }
    }
}

