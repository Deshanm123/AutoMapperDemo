using AutoMapper;
using AutoMapper_DEmo.Dtos.Responses;
using AutoMapper_DEmo.Models.DbSet;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapper_DEmo.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UserController : ControllerBase
    {
            private readonly IMapper _mapper;
            public UserController(IMapper mapper)
            {
                _mapper = mapper;
            }


            [HttpGet]
            public IActionResult GetUserRespose()
            {
                User moderateUser = new User {
                    Id = new Guid(),
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "johndoe@mail.com",
                    PostCode = "JH49DE",
                    StreetAddress = "LoremIpsum Street",
                };

                //mapping
                GetUserResponse resp = _mapper.Map<GetUserResponse>(moderateUser);
                return Ok(resp);
            }
    }

}