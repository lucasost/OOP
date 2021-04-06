using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace POO.Secao2
{
    public class RegistrarNoArquivo : IRegistro
    {
        private readonly string _caminhoNomeDoArquivo;

        public RegistrarNoArquivo(string path)
        {
            _caminhoNomeDoArquivo = path;
        }

        public void RegistrarInfo(string mensagem)
        {
            Log(mensagem);
        }

        private void Log(string mensagem)
        {
            using (var streamWriter = new StreamWriter(_caminhoNomeDoArquivo, true))
            {
                streamWriter.WriteLine(mensagem);
            }
        }
    }
}
