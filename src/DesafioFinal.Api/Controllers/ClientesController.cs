using DesafioFinal.Api.Models;
using DesafioFinal.Api.Services.Interfaces;
using DesafioFinal.Api.ViewModels;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DesafioFinal.Api.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        [Route("adicionar")]
        public async Task<IActionResult> AdicionarCliente(ClienteViewModel clienteVw)
        {
            var retorno = await _clienteService.Adicionar(clienteVw);
            return Ok(retorno);
        }

        [HttpPut]
        [Route("atualizar/{id}")]
        public async Task<IActionResult> AtualizarCliente(Guid id, [FromBody] ClienteViewModel clienteVw)
        {
            var retorno = await _clienteService.Atualizar(id, clienteVw);
            return Ok(retorno);
        }

        [HttpGet]
        [Route("obter-por-id")]
        public async Task<IActionResult> ObterPorId(Guid id)
        {
            var retorno = await _clienteService.ObterPorId(id);
            return Ok(retorno);
        }

        [HttpGet]
        [Route("obter-por-nome")]
        public async Task<IActionResult> ObterPorNome(string nome)
        {
            var retorno = await _clienteService.ObterPorNome(nome);
            return Ok(retorno);
        }

        [HttpGet]
        [Route("obter-todos")]
        public async Task<IActionResult> ObterTodos()
        {
            var retorno = await _clienteService.ObterTodos();
            return Ok(retorno);
        }

        [HttpGet]
        [Route("contar")]
        public async Task<IActionResult> ContarClientes()
        {
            var retorno = await _clienteService.ContarClientes();
            return Ok(new { TotalClientes = retorno });
        }

        [HttpDelete]
        [Route("remover")]
        public async Task<IActionResult> RemoverCliente(Guid id)
        {
            await _clienteService.Remover(id);
            return Ok();
        }

    }
}
