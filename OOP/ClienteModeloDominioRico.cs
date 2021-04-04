using System;

namespace OOP
{
    public class ClienteModeloDominioRico
    {
        public ClienteModeloDominioRico(int id, string nome, string endereco)
        {
            if (id <= 0)
                throw new InvalidOperationException("Id Inválido");
            if (string.IsNullOrWhiteSpace(nome))
                throw new InvalidOperationException("Nome Inválido");
            if (string.IsNullOrWhiteSpace(endereco))
                throw new InvalidOperationException("Endereco Inválido");

            Id = id;
            Nome = nome;
            Endereco = endereco;
        }

        public int Id { get; private set; }

        public string Nome { get; private set; }

        public string Endereco { get; private set; }
    }
}
