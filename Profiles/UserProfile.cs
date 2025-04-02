using AutoMapper;
using Models.DbSet;
using Dtos.Responses;

namespace AutoMapper_DEmo.UserProfile
{
    //when auto mapper scans through the dll files,It gonna search for the AutoMapper's inbuilt Library
    class UserProfile : Profile
    {
        //first object : source of information
        //second object : destination of the information
        CreateMap<User,GetUserResponse>()
                .ForMember(des =>des.FullName,
                           src => src.MapFrom($"{src.FirstName} {src.LastName}"))
                .ForMember(des => des.Address,
                            src=> src.MapFrom($"{src.StreetAddress} {src.PostCode}"))
                .ForMember(des => des.Email,
                           src => src.Email);

    }
}