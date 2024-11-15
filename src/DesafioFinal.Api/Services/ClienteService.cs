using DesafioFinal.Api.Models;
using DesafioFinal.Api.Repository.Interfaces;
using DesafioFinal.Api.Services.Interfaces;
using DesafioFinal.Api.ViewModels;

namespace DesafioFinal.Api.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public async Task<Cliente> Adicionar(ClienteViewModel clienteVw)
        {
            var cliente = new Cliente(clienteVw.Nome, clienteVw.Email);
            await _clienteRepository.Adicionar(cliente);
            return cliente;
        }

        public async Task<Cliente> Atualizar(Guid id, ClienteViewModel clienteVw)
        {
            var cliente = await _clienteRepository.ObterPorId(id);
            cliente.AtualizarDados(clienteVw);
            await _clienteRepository.Atualizar(cliente);
            return cliente;
        }

        public async Task<Cliente> ObterPorId(Guid id)
        {
            return await _clienteRepository.ObterPorId(id);
        }

        public async Task<List<Cliente>> ObterPorNome(string nome)
        {
            return await _clienteRepository.ObterPorNome(nome);
        }

        public async Task<List<Cliente>> ObterTodos()
        {
            return await _clienteRepository.ObterTodos();
        }

        public async Task Remover(Guid id)
        {
            var clienteRemover = await _clienteRepository.ObterPorId(id);

            if (clienteRemover == null)
                return;

            await _clienteRepository.Remover(clienteRemover);
            return;
        }

        public async Task<int> ContarClientes()
        {
            return await _clienteRepository.ObterTotalClientes();
        }
    }
}
