using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDI.Domain.Entities;
using DemoDI.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoDI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoRepository produtoRepository, IProdutoService produtoService)
        {
            _produtoRepository = produtoRepository;
            _produtoService = produtoService;
        }

        [HttpGet("obter-todos")]
        public async Task<ActionResult<IEnumerable<Produto>>> ObterTodos()
        {
            var produtos = await _produtoRepository.ObterTodos();

            if (produtos == null) return BadRequest();

            return Ok(produtos);
        }

        [HttpPost("gravar")]
        public async Task<ActionResult<Task<bool>>> Gravar([FromBody] Produto produto)
        {
            if (await _produtoService.ProdutoExistente(produto)) return BadRequest();

            return Ok(await _produtoRepository.Garvar(produto));
            
        }
    }

}
