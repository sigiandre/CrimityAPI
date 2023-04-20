using AutoMapper;
using CrimityAPI.Models;
using CrimityAPI.Models.Dtos;

namespace CrimityAPI.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Usuario, UsuarioDto>();
        }
    }
}
