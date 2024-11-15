using DesafioFinal.Api.Models;
using DesafioFinal.Api.ViewModels;

namespace DesafioFinal.Api.Services.Interfaces
{
    public interface IClienteService
    {
        Task<Cliente> Adicionar(ClienteViewModel clienteVw);
        Task<Cliente> ObterPorId(Guid id);
        Task<List<Cliente>> ObterTodos();
        Task<List<Cliente>> ObterPorNome(string nome);
        Task<Cliente> Atualizar(Guid id, ClienteViewModel clienteVw);
        Task Remover(Guid id);
        Task<int> ContarClientes();
    }
}
