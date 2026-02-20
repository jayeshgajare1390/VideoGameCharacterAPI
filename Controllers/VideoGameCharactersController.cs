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

    [HttpPost]
    public async Task<ActionResult<CreateCharacterRequest>> CreateCharacter(
        CreateCharacterRequest createCharacterRequest)
    {
        var createdCharacter = await service.AddCharacterAsync(createCharacterRequest);
        return CreatedAtAction(nameof(GetCharacter),new{id=createdCharacter.name},createdCharacter);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<CharacterResponce>> UpdateCharacter(int id, UpdateCharacterRequest updateCharacterRequest)
    {
        var updated=await service.UpdateCharacterAsync(id, updateCharacterRequest);
        return updated ? Ok(updated) : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<CharacterResponce>> DeleteCharacter(int id)
    {
        var deletedCharacter = await service.DeleteCharacterAsync(id);
        return deletedCharacter ? Ok(deletedCharacter) : NotFound();
    }
}