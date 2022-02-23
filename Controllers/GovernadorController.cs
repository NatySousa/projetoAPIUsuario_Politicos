using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Projeto_Desafio_API_Usuario.Interfaces;
using Projeto_Desafio_API_Usuario.Models;

namespace Projeto_Desafio_API_Usuario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GovernadorController : ControllerBase
    {
        private readonly IGovernadorRepository _governadorRepository;
        private readonly IMapper _mapper;

        public GovernadorController(IGovernadorRepository governadorRepository, IMapper mapper)
        {
            _governadorRepository = governadorRepository;
            _mapper = mapper;
        }

        [HttpGet("ObterTodos")]//Nomeando o get, de forma a diferenciar dos demais
        public async Task<IActionResult> ObterTodos()
        {    
            return Ok(_mapper.Map<IEnumerable<GetGovernadorViewModel>>(await _governadorRepository.ObterTodos()));
        }

        [HttpGet("ObterPorId{id:int}")]//Nomeando o get, de forma a diferenciar dos demais
        public async Task<IActionResult> ObterPorId(int id)
        {    
            var retorno = _mapper.Map<GetGovernadorViewModel>(await _governadorRepository.ObterPorId(id));

            if(retorno ==null)
            {
                return UnprocessableEntity("Cadastro não localizado");
            }
            return Ok(retorno);
        }

        [HttpGet("ObterOrdemCrescente")]
        public async Task<IActionResult> ObterOrdemCrescente()
        {    
            var retorno = await _governadorRepository.ObterTodos();
            var ordenado = retorno.OrderBy(d => d.Nome);
            return Ok(_mapper.Map<IEnumerable<GetGovernadorViewModel>>(ordenado));
        }

        [HttpGet("ObterOrdemDecrescente")]
        public async Task<IActionResult> ObterOrdemDecrescente()
        {    
            var retorno = await _governadorRepository.ObterTodos();
            var ordenado = retorno.OrderByDescending(d => d.Nome);
            return Ok(_mapper.Map<IEnumerable<GetGovernadorViewModel>>(ordenado));
        }

        [HttpGet("ObterPorProjeto")]
        public async Task<IActionResult> FiltarPorProcesso(string projetoLei)
        {    
            var retorno = await _governadorRepository.ObterTodos();
            var ordenado = retorno.Where(d => d.ProjetoLei == projetoLei);

            if(ordenado.Count() == 0)
            {
                return UnprocessableEntity("Projeto de Lei não localizado");
            }
            
            return Ok(_mapper.Map<IEnumerable<GetGovernadorViewModel>>(ordenado));
        }


    }
}