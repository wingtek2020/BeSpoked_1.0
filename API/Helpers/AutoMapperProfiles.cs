using API.DTO;
using API.Entities;
using AutoMapper;
using Elfie.Serialization;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, UserDTO>()
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role.Name));
            CreateMap<Product, ProductDTO>();

            CreateMap<Sale, SalesDTO>()
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.ProductName))
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer.UserName))
                .ForMember(dest => dest.SalesRepName, opt => opt.MapFrom(src => src.SalesRep.UserName));

        }
    }
}
