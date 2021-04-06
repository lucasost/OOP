using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_SRP
{
    class RegistraLogger : ILogger
    {
        public void Informacao(string info)
        {
            Console.WriteLine(info);
        }
    }
}
