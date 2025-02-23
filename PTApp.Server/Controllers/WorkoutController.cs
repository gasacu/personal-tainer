using Microsoft.AspNetCore.Mvc;
using PTApp.Server.Models;
using PTApp.Server.Repositories.Interfaces;

namespace PTApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkoutController : BaseController<Workout>
    {
        public WorkoutController(IRepository<Workout> workoutRepository) : base(workoutRepository)
        {
        }
    }
}
