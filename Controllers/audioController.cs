using Microsoft.AspNetCore.Mvc;

namespace media_audio.Controllers;

[ApiController]
[Route("[controller]")]
public class AudioController : ControllerBase
{
    [HttpPost("/{username}")]
    public async Task<ActionResult> getAudioFiles(string username)
    {

        return Ok();
    }
}