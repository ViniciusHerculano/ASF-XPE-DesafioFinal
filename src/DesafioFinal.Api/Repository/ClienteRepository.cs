using DesafioFinal.Api.Data;
using DesafioFinal.Api.Models;
using DesafioFinal.Api.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DesafioFinal.Api.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ClienteContext _context;
        public ClienteRepository(ClienteContext context)
        {
            _context = context;
        }
        public async Task Adicionar(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task Atualizar(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task<Cliente> ObterPorId(Guid id)
        {
            return await _context.Clientes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Cliente>> ObterPorNome(string nome)
        {
            return await _context.Clientes.Where(x => x.Nome.Contains(nome)).ToListAsync();
        }

        public async Task<List<Cliente>> ObterTodos()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<int> ObterTotalClientes()
        {
            return await _context.Clientes.CountAsync();
        }

        public async Task Remover(Cliente cliente)
        {
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
        }
    }
}
