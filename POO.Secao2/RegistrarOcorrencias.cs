using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Secao2
{
    public class RegistrarOcorrencias : IRegistro
    {
        // injeção de dependência
        private readonly IRegistro _registro;

        public RegistrarOcorrencias(IRegistro registro)
        {
            _registro = registro;
        }

        public void RegistrarInfo(string mensagem)
        {
            _registro.RegistrarInfo($"{mensagem}:{DateTime.Now}");
        }
    }
}
