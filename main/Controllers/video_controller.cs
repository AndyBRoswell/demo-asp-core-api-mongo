using main.Services;
using main.Models.work.video;
using Microsoft.AspNetCore.Mvc;

namespace main.Controllers {
    [ApiController]
    [Route("video")]
    public class video_controller : Controller {
        private readonly video_service _video_service;
        public video_controller(video_service work_service) => _video_service = work_service;
        [HttpGet] public async Task<List<video>> get() => await _video_service.get_async();
        [HttpGet("{id:length(24)}")] public async Task<ActionResult<video>> get(string id) {
            var video = await _video_service.get_async(id);
            if (video == null) return NotFound();
            return video;
        }
        [HttpPost] public async Task<ActionResult<video>> create(video work) {
            await _video_service.create_async(work);
            return CreatedAtAction(nameof(get), new { id = work._id }, work);
        }
        [HttpPut("{id:length(24)}")] public async Task<IActionResult> update(string id, video video_in) {
            var video = await _video_service.get_async(id);
            if (video == null) return NotFound();
            await _video_service.update_async(id, video_in);
            return NoContent();
        }
        [HttpDelete("{id:length(24)}")] public async Task<IActionResult> delete(string id) {
            var video = await _video_service.get_async(id);
            if (video == null) return NotFound();
            await _video_service.delete_async(video._id);
            return NoContent();
        }
    }
}
