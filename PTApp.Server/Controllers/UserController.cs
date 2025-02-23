using Microsoft.AspNetCore.Mvc;
using PTApp.Server.Models;
using PTApp.Server.Repositories.Interfaces;

namespace PTApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : BaseController<User>
    {
        public UserController(IRepository<User> userRepository) : base(userRepository)
        {
        }


    }
}
