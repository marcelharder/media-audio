using media_audio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace media_audio.Controllers;

[ApiController]
[Route("[controller]")]
public class AudioController : ControllerBase
{
    private readonly IAudio _audio;
    public AudioController(IAudio _audio)
    {
        this._audio = _audio;
    }
   
    [HttpPost("/{username}")]
    public async Task<ActionResult> getAudioFiles(string username)
    {
        var allAudio = await _audio.GetAllAudioFiles(username);
        return Ok(allAudio);
    }

    [HttpGet("/{id}")]
    public async Task<IActionResult> GetSpecificAudioFile(int id)
    {
        var specficAudio = await _audio.GetSpecificAudioFile(id);
        return Ok(specficAudio);
    }

    [HttpGet("/{albumId}")]
    public async Task<IActionResult> GetSpecificAlbum(int id)
    {
        var specficAudio = await _audio.GetSpecificAlbum(id);

        return Ok(specficAudio);
    }



}