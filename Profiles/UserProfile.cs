using AutoMapper;
using AutoMapper_DEmo.Models.DbSet;
using AutoMapper_DEmo.Dtos.Responses;
using AutoMapper_DEmo.Dtos.Requests;

namespace AutoMapper_DEmo.UserProfile
{
    //when auto mapper scans through the dll files,It gonna search for the AutoMapper's inbuilt Library
    class UserProfile : Profile
    {
        //first object : source of information
        //second object : destination of the information
        public UserProfile()
        {
            CreateMap<User, GetUserResponse>()
                    .ForMember(des => des.FullName,
                                opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                    .ForMember(des => des.Address,
                                opt => opt.MapFrom(src => $"{src.StreetAddress} {src.PostCode}"))
                    .ForMember(des => des.Email,opt=> opt.MapFrom(src =>src.Email));


            CreateMap<CreateUserRequest, User>()
                    .ForMember(des => des.Id,
                               opt => opt.MapFrom(src => new Guid()))
                    .ForMember(des => des.FirstName,
                                opt => opt.MapFrom(src => src.FirstName)) //this is unneceessary AutoMapper will map it , names match from source and destinaton they will auto map.
                    .ForMember(des => des.Status,
                                opt => opt.MapFrom(src => 1))
                    .ForMember(des => des.CreatedAt, opt=>opt.MapFrom(src =>DateTime.UtcNow));
        
        }


    }
}