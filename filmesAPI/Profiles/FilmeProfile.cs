using AutoMapper;
using filmesAPI.Dtos;
using filmesAPI.Models;

namespace filmesAPI.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<FilmeProfile, ReadFilmeDto>();
            CreateMap<UpdateFilmeDto, Filme>();
        }
        
    }
}
