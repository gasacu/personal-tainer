using Microsoft.AspNetCore.Mvc;
using PTApp.Server.Repositories.Interfaces;

namespace PTApp.Server.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : class, IIdentifiable
    {
        private readonly IRepository<T> _repository;

        public BaseController(IRepository<T> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<T>>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<T>> GetById(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);

            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] T entity)
        {
            if (entity == null)
            {
                return BadRequest();
            }

            await _repository.AddAsync(entity);

            return CreatedAtAction(nameof(GetById), new { id = Guid.NewGuid() }, entity); // extract id from entity
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteById(Guid id)
        {
            await _repository.DeleteAsync(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<T>> UpdateAsync(Guid id, [FromBody] T entity)
        {
            if (entity.Id != id)
            {
                return BadRequest();
            }

            await _repository.UpdateAsync(entity);

            return CreatedAtAction(nameof(GetById), new { id = Guid.NewGuid() }, entity);
        }
    }
}
