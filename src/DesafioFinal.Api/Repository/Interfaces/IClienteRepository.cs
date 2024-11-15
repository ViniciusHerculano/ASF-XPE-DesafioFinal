using DesafioFinal.Api.Models;

namespace DesafioFinal.Api.Repository.Interfaces
{
    public interface IClienteRepository
    {
        Task Adicionar(Cliente cliente);
        Task<Cliente> ObterPorId(Guid id);
        Task<List<Cliente>> ObterTodos();
        Task<List<Cliente>> ObterPorNome(string nome);
        Task Atualizar(Cliente cliente);
        Task Remover(Cliente cliente);
        Task<int> ObterTotalClientes();
    }
}
