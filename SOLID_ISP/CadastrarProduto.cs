using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_ISP
{
    class CadastrarProduto : IPersistencia
    {
        public void SalvarDataBase()
        {
            Console.WriteLine("Salvar dados");
        }

        public void ValidarDados()
        {
            Console.WriteLine("Validar dados");
        }
    }
}
