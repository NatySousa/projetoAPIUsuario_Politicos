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
    public class VereadorController : ControllerBase
    {
        private readonly IVereadorRepository _vereadorRepository;
        private readonly IMapper _mapper;

        public VereadorController(IVereadorRepository vereadorRepository, IMapper mapper)
        {
            _vereadorRepository = vereadorRepository;
            _mapper = mapper;
        }


        [HttpGet("ObterTodos")]//Nomeando o get, de forma a diferenciar dos demais
        public async Task<IActionResult> ObterTodos()
        {    
            return Ok(_mapper.Map<IEnumerable<GetVereadorViewModel>>(await _vereadorRepository.ObterTodos()));
        }

        [HttpGet("ObterPorId{id:int}")]
        public async Task<IActionResult> ObterPorId(int id)
        {    
            var retorno = _mapper.Map<GetVereadorViewModel>(await _vereadorRepository.ObterPorId(id));

            if(retorno ==null)
            {
                return UnprocessableEntity("Cadastro não localizado");
            }
            return Ok(retorno);
        }

        [HttpGet("ObterOrdemCrescente")]
        public async Task<IActionResult> ObterOrdemCrescente()
        {    
            var retorno = await _vereadorRepository.ObterTodos();
            var ordenado = retorno.OrderBy(d => d.Nome);
            return Ok(_mapper.Map<IEnumerable<GetVereadorViewModel>>(ordenado));
        }

        [HttpGet("ObterOrdemDecrescente")]
        public async Task<IActionResult> ObterOrdemDecrescente()
        {    
            var retorno = await _vereadorRepository.ObterTodos();
            var ordenado = retorno.OrderByDescending(d => d.Nome);
            return Ok(_mapper.Map<IEnumerable<GetVereadorViewModel>>(ordenado));
        }

        [HttpGet("ObterPorProjeto")]
        public async Task<IActionResult> FiltarPorProcesso(string projetoLei)
        {    
            var retorno = await _vereadorRepository.ObterTodos();
            var ordenado = retorno.Where(d => d.ProjetoLei == projetoLei);

            if(ordenado.Count() == 0)
            {
                return UnprocessableEntity("Projeto de Lei não localizado");
            }

            return Ok(_mapper.Map<IEnumerable<GetVereadorViewModel>>(ordenado));
        }

    }
}