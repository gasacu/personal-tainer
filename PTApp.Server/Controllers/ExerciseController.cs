using Microsoft.AspNetCore.Mvc;
using PTApp.Server.Models;
using PTApp.Server.Repositories.Interfaces;

namespace PTApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExerciseController : BaseController<Exercise>
    {
        public ExerciseController(IRepository<Exercise> exerciseRepository) : base(exerciseRepository)
        {
        }


    }
}
