using Microsoft.AspNetCore.Mvc;
using VersionControlAPI.Models;
using VersionControlAPI.Services;

namespace VersionControlAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VersionControlController : ControllerBase
    {
        private readonly VersionControlService _versionControlService;

        public VersionControlController(VersionControlService versionControlService)
        {
            _versionControlService = versionControlService;
        }

        // GET: api/versioncontrol
        [HttpGet]
        public async Task<ActionResult<List<VersionControl>>> Get() =>
            Ok(await _versionControlService.GetAsync());

        // GET: api/versioncontrol/{id}
        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<VersionControl>> GetById(string id)
        {
            var versionControl = await _versionControlService.GetByIdAsync(id);

            if (versionControl == null)
            {
                return NotFound(new { status = 404, message = "Item not found" });
            }

            return Ok(new { status = 200, data = versionControl });
        }

        // POST: api/versioncontrol
        [HttpPost]
        public async Task<ActionResult<VersionControl>> Create(VersionControl versionControl)
        {
            await _versionControlService.CreateAsync(versionControl);
            return CreatedAtAction(nameof(GetById), new { id = versionControl.Id }, versionControl);
        }

        // PUT: api/versioncontrol/{id}
        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, VersionControl updatedVersionControl)
        {
            var versionControl = await _versionControlService.GetByIdAsync(id);

            if (versionControl == null)
            {
                return NotFound(new { status = 404, message = "Item not found" });
            }

            updatedVersionControl.Id = versionControl.Id;

            await _versionControlService.UpdateAsync(id, updatedVersionControl);

            return Ok(new { status = 200, message = "Update successful", data = updatedVersionControl });
        }

        // DELETE: api/versioncontrol/{id}
        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var versionControl = await _versionControlService.GetByIdAsync(id);

            if (versionControl == null)
            {
                return NotFound(new { status = 404, message = "Item not found" });
            }

            await _versionControlService.RemoveAsync(id);

            return Ok(new { status = 200, message = "Deletion successful" });
        }
    }
}
