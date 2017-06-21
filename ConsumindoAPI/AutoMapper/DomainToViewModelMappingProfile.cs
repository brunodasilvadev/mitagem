using AutoMapper;
using ConsumindoAPI.Entities;
using ConsumindoAPI.Models;

namespace ConsumindoAPI.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Atleta, AtletaViewModel>();
            Mapper.CreateMap<Scout, AtletaViewModel>();
            Mapper.CreateMap<Scout, ScoutViewModel>();
        }
    }
}