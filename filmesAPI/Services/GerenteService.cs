using AutoMapper;
using filmesAPI.Data;
using filmesAPI.Data.Dtos.Gerente;
using filmesAPI.Models;
using FluentResults;

namespace filmesAPI.Services
{
    public class GerenteService
    {
        private AppDbContext _context;
        private IMapper _mapper;
        public GerenteService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadGerenteDto AdicionaGerente(CreateGerenteDto dto)
        {
            Gerente gerente = _mapper.Map<Gerente>(dto);
            _context.Gerentes.Add(gerente);
            _context.SaveChanges();
            return _mapper.Map<ReadGerenteDto>(gerente);
        }

        public ReadGerenteDto RecuperaGerentesPorId(int id)
        {
            Gerente gerente = _context.Gerentes.FirstOrDefault(gerente => gerente.Id == id);
            if (gerente != null) return _mapper.Map<ReadGerenteDto>(gerente);
            return null;
        }

        public Result DeletarGerente(int id)
        {
            Gerente gerente = _context.Gerentes.FirstOrDefault(gerente => gerente.Id == id);
            if (gerente == null) return Result.Fail("Gerente não encontrado");               
            _context.Remove(gerente);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
