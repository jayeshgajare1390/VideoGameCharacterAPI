using Microsoft.AspNetCore.Mvc;
using VideoGameCharacterAPI.Dtos;
using VideoGameCharacterAPI.Models;
using VideoGameCharacterAPI.Services;

namespace VideoGameCharacterAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class VideoGameCharactersController(IVideoGameCharacterServices service) : Controller
{
    
    // GET
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public async Task<ActionResult<List<CharacterResponce>>> GetCharacters()
    =>Ok(await service.GetAllCharactersAsync());

    [HttpGet("{id}")]
    public async Task<ActionResult<Character>> GetCharacter(int id)
    {
        var character = await service.GetCharacterByIdAsync(id);
        return character is  null ? NotFound("Character not found") : Ok(character);
    }
}