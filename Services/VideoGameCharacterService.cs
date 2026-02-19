using Microsoft.EntityFrameworkCore;
using VideoGameCharacterAPI.Data;
using VideoGameCharacterAPI.Models;

namespace VideoGameCharacterAPI.Services;

public class VideoGameCharacterService(AppDbContext context):IVideoGameCharacterServices
{
    public async Task<List<Character>> GetAllCharactersAsync()
        => await context.Characters.ToListAsync();
 
    public async Task<Character> GetCharacterByIdAsync(int id)
    {
        var result = await context.Characters.FindAsync(id);
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