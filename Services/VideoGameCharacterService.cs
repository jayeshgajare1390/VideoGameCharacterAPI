using VideoGameCharacterAPI.Models;

namespace VideoGameCharacterAPI.Services;

public class VideoGameCharacterService:IVideoGameCharacterServices
{
    private static List<Character> characters = new List<Character>
    {
        new Character { id = 1, name = "Mario", Game = "Super Mario",Role = "Hero"},
        new Character { id = 2, name = "Link", Game = "Halo World", Role = "Hero" },
        new Character { id = 3, name = "Bowser", Game = "Super Mario", Role = "Villain" },
    };
    public async Task<List<Character>> GetAllCharactersAsync()
        => await Task.FromResult(characters);

    public Task<Character> GetCharacterByIdAsync(int id)
    {
        var character = characters.FirstOrDefault(x => x.id == id);
        return Task.FromResult(character);
    }

    public Task<Character> AddCharacterAsync(Character character)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateCharacterAsync(Character character)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteCharacterAsync(int id)
    {
        throw new NotImplementedException();
    }
}