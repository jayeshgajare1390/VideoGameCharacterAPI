using Microsoft.AspNetCore.Mvc;
using VideoGameCharacterAPI.Models;

namespace VideoGameCharacterAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class VideoGameCharactersController : Controller
{
    private static List<Character> characters = new List<Character>
    {
        new Character { id = 1, name = "Mario", Game = "Super Mario",Role = "Hero"},
        new Character { id = 2, name = "Link", Game = "Halo", Role = "Hero" },
        new Character { id = 3, name = "Bowser", Game = "Super Mario", Role = "Villain" },
    };
    // GET
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public async Task<ActionResult<List<Character>>> GetCharacters()
        => await Task.FromResult(Ok(characters));
}