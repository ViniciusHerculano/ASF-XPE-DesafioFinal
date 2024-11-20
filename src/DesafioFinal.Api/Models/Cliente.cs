using DesafioFinal.Api.ViewModels;

namespace DesafioFinal.Api.Models
{
    public class Cliente
    {
        protected Cliente() { }

        public Cliente(string nome, string email)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
        }

        public void AtualizarDados(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
    }
}
