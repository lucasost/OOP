namespace OOP
{
    public class ClienteModeloDominioRicoComExcecption
    {
        public ClienteModeloDominioRicoComExcecption(int id, string nome, string endereco)
        {
            DomainExceptionValidation.When(id <= 0, "Id Inválido");
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(nome), "Nome Inválido");
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(endereco), "Endereco Inválido");

            Id = id;
            Nome = nome;
            Endereco = endereco;
        }

        public int Id { get; private set; }

        public string Nome { get; private set; }

        public string Endereco { get; private set; }
    }
}
