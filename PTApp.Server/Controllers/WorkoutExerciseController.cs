using Microsoft.AspNetCore.Mvc;
using PTApp.Server.Models;
using PTApp.Server.Repositories.Interfaces;

namespace PTApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkoutExerciseController : BaseController<WorkoutExercise>
    {
        public WorkoutExerciseController(IRepository<WorkoutExercise> workoutExerciseRepository) : base(workoutExerciseRepository)
        {
        }
    }
}
