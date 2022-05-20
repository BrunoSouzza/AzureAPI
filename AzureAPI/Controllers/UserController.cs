using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AzureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly List<User> _user;


        public UserController()
        {
            _user = new List<User>
            {
                new User { Id = 1 ,Name = "Bruno"},
                new User { Id = 2 ,Name = "Carlo"},
                new User { Id = 3 ,Name = "Paula"},
                new User { Id = 4 ,Name = "Marina"},
                new User { Id = 5 ,Name = "Mayara"},
            };
        }

        [HttpGet("All")]
        public IActionResult GetAll()
        {
            return Ok(_user);
        }
    }

    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
