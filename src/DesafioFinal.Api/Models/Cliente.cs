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

        public void AtualizarDados(ClienteViewModel clienteVw)
        {
            Nome = clienteVw.Nome;
            Email = clienteVw.Email;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
    }
}
