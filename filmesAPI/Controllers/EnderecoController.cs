﻿using AutoMapper;
using filmesAPI.Data;
using filmesAPI.Data.Dtos.Endereco;
using filmesAPI.Models;
using filmesAPI.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace filmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private EnderecoService _enderecoService;        

        public EnderecoController(EnderecoService enderecoService)
        {
           _enderecoService = enderecoService;
        }


        [HttpPost]
        public IActionResult AdicionaEndereco([FromBody] CreateEnderecoDto enderecoDto)
        {
            ReadEnderecoDto readDto = _enderecoService.AdicionaEndereco(enderecoDto);           
            return CreatedAtAction(nameof(RecuperaEnderecosPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperaEnderecos()
        {
            List<ReadEnderecoDto> readDto = _enderecoService.RecuperaEnderecos();
            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaEnderecosPorId(int id)
        {
            ReadEnderecoDto readDto = _enderecoService.RecuperaEnderecosPorId(id);
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaEndereco(int id, [FromBody] UpdateEnderecoDto enderecoDto)
        {
            Result resultado = _enderecoService.AtualizaEndereco(id, enderecoDto);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaEndereco(int id)
        {
            Result resultado = _enderecoService.DeletaEndereco(id);
            if(resultado.IsFailed) return NotFound();
            return NoContent();
        }

    }
}
