using AutoMapper;
using filmesAPI.Data.Dtos.Filme;
using filmesAPI.Models;

namespace filmesAPI.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>();
            CreateMap<UpdateFilmeDto, Filme>();
        }
        
    }
}
