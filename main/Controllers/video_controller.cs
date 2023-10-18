using main.Services;
using main.Models.work;
using Microsoft.AspNetCore.Mvc;

namespace main.Controllers {
    [ApiController]
    [Route("video")]
    public class video_controller : Controller {
        private readonly work_service _work_service;
        public video_controller(work_service work_service) => _work_service = work_service;
        [HttpGet] public async Task<List<work>> get() => await _work_service.get_async();
        [HttpGet("{id:length(24)}")] public async Task<ActionResult<work>> get(string id) {
            var work = await _work_service.get_async(id);
            if (work == null) return NotFound();
            return work;
        }
        [HttpPost] public async Task<ActionResult<work>> create(work work) {
            await _work_service.create_async(work);
            return CreatedAtAction(nameof(get), new { id = work._id }, work);
        }
        [HttpPut("{id:length(24)}")] public async Task<IActionResult> update(string id, work work_in) {
            var work = await _work_service.get_async(id);
            if (work == null) return NotFound();
            await _work_service.update_async(id, work_in);
            return NoContent();
        }
        [HttpDelete("{id:length(24)}")] public async Task<IActionResult> delete(string id) {
            var work = await _work_service.get_async(id);
            if (work == null) return NotFound();
            await _work_service.delete_async(work._id);
            return NoContent();
        }
    }
}
