using AutoMapper;
using Core.Entities;
using MemoApi.Dtos;

namespace MemoApi.Healpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<MenProducts, MenProductToReturnDto>()
                .ForMember(d=> d.MenProductBrand, o=> o.MapFrom(s=> s.MenProductBrand.Name))
                .ForMember(d => d.MenProductType, o => o.MapFrom(s => s.MenProductType.Name))
                .ForMember(d=> d.PictureUrl, o=> o.MapFrom<MenProductUrlResolver>());

        }
    }
}
