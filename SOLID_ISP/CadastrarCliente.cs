using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_ISP
{
    class CadastrarCliente : IPersistencia, IMensageiro
    {
        public void EnviarEmail()
        {
            Console.WriteLine("Enviar Email");
        }

        public void SalvarDataBase()
        {
            Console.WriteLine("Salvar dados");
        }

        public void ValidarDados()
        {
            Console.WriteLine("Validar Dados");
        }
    }
}
