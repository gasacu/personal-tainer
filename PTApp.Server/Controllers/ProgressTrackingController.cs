using Microsoft.AspNetCore.Mvc;
using PTApp.Server.Models;
using PTApp.Server.Repositories.Interfaces;

namespace PTApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProgressTrackingController : BaseController<ProgressTracking>
    {
        public ProgressTrackingController(IRepository<ProgressTracking> progressTrackingRepository) : base(progressTrackingRepository)
        {
        }
    }
}
