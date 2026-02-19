using Microsoft.EntityFrameworkCore;
using VideoGameCharacterAPI.Data;
using VideoGameCharacterAPI.Dtos;
using VideoGameCharacterAPI.Models;

namespace VideoGameCharacterAPI.Services;

public class VideoGameCharacterService(AppDbContext context):IVideoGameCharacterServices
{
    public async Task<List<CharacterResponce>> GetAllCharactersAsync()
        => await context.Characters.Select(c=>new CharacterResponce{name = c.name,Game = c.Game,Role = c.Role}).ToListAsync();
 
    public async Task<CharacterResponce> GetCharacterByIdAsync(int id)
    {
        var result = await context.Characters.Where(c=>c.id==id).Select(c=>new  CharacterResponce{name = c.name,Game = c.Game,Role = c.Role}).FirstOrDefaultAsync();
        return result;
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