using AutoMapper;
using ConsumindoAPI.Entities;
using ConsumindoAPI.Models;
using System.Collections.Generic;

namespace ConsumindoAPI.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<AtletaViewModel, Atleta>();
            Mapper.CreateMap<AtletaViewModel, Scout>();
            Mapper.CreateMap<ScoutViewModel, Scout>();

        }
    }
}