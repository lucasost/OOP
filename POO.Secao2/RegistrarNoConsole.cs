using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Secao2
{
    public class RegistrarNoConsole : IRegistro
    {
        public void RegistrarInfo(string mensagem)
        {
            Console.WriteLine($"info:{mensagem}");
        }
    }
}
