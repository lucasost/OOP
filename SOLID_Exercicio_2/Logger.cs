using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID_Exercicio_2
{
    public class Logger : ILogger
    {
        private readonly string _caminhoNomeDoArquivo;
        public Logger(string path)
        {
            _caminhoNomeDoArquivo = path;
        }

        public void Registrar(string mensagem)
        {
            RegistrarInfo(mensagem);
        }

        public void RegistrarInfo(string informacao)
        {
            using (var streamWriter = new StreamWriter(_caminhoNomeDoArquivo, true))
            {
                streamWriter.WriteLine(informacao);
            }
        }
    }
}