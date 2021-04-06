using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Secao2
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public Pessoa(string nome, int idade, string sexo)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Sexo = sexo;
        }

        private DateTime dataNascimento = new DateTime(2020, 01, 01);

        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Sexo { get; set; }

        public void IdentificarPessoa()
        {
            Console.WriteLine($"{this.Nome} - {this.Idade} - {this.Sexo}");
        }
    }
}
