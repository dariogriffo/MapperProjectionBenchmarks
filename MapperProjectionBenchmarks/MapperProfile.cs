using AutoMapper;

namespace automapper_01;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<PostsSummary, PostsSummaryDto>();
        CreateMap<Address, AddressDto>()
            .ForMember(x => x.AddressWithPostCode, opt => opt.MapFrom(src => $"{src.FirstLine} | {src.PostCode}"));
    }
}