using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DIP
{
    class SqlConnection : IDataBaseConnection
    {
        public void Conectar()
        {
            Console.WriteLine("Conectado ao banco");
        }
    }
}
