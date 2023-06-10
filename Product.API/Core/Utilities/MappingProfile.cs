using AutoMapper;
using Product.API.Core.Entities;
using Product.API.Dtos;

namespace Product.API.Core.Utilities
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            //sourc to destionatio
            CreateMap<ProductToCreateDto, Productt>().ReverseMap();

                //source to destianation
            CreateMap<Productt, ProductToDisplayDto>().ReverseMap();


        }
    }
}
