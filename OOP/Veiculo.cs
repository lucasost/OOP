using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Veiculo
    {
        public Veiculo()
        {
            Console.WriteLine("Construtor veículo.");
        }
        private string _numeroMotor;
        public Veiculo(string numeroMotor)
        {
            _numeroMotor = numeroMotor;
            NumeroMotor = numeroMotor;
            Console.WriteLine("Construtor veículo.");
        }

        public string NumeroMotor { get; set; }

        public string Cor { get; set; }

        public virtual void Registrar()
        {
            Console.WriteLine("Veículo Registrado.");
        }
    }
}
