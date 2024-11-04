using AutoMapper;
using P2.DTOs;
using P2.Models;

namespace P2.Automappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<BeerInsertDto, Beer>();
            CreateMap<Beer, BeerDto>()
                .ForMember(dto => dto.BeerId,
                m=> m.MapFrom(b => b.Id));
            CreateMap<BeerUpdateDto, Beer>();
        }
    }
}
