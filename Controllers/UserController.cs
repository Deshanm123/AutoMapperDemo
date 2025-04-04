using AutoMapper;
using AutoMapper_DEmo.Dtos.Requests;
using AutoMapper_DEmo.Dtos.Responses;
using AutoMapper_DEmo.Models.DbSet;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapper_DEmo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }


        [HttpGet("GetUserRespose")]
        //[Route("/")]
        public IActionResult GetUserRespose()
        {
            User moderateUser = new User
            {
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

        /*
            When a client sends a CreateUser request to the  endpoint, the data is typically sent in the request body as JSON, XML, or another format.
            [FromBody]  tells the framework to read the request body and try to deserialize it into a  object
         */
        [HttpPost("CreateUser")]
        public IActionResult CreateUser([FromBody] CreateUserRequest userRequest)
        {
            User newUser = _mapper.Map<User>(userRequest);
            if (newUser != null)
                return Ok(newUser);
            else
                return BadRequest("User not created");

        }

    }

}