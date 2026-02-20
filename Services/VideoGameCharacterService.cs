using Microsoft.EntityFrameworkCore;
using VideoGameCharacterAPI.Data;
using VideoGameCharacterAPI.Dtos;
using VideoGameCharacterAPI.Models;

namespace VideoGameCharacterAPI.Services;

public class VideoGameCharacterService(AppDbContext context):IVideoGameCharacterServices
{
    public async Task<List<CharacterResponce>> GetAllCharactersAsync()
        => await context.Characters.Select(c=>new CharacterResponce{id = c.id,name = c.name,Game = c.Game,Role = c.Role}).ToListAsync();
 
    public async Task<CharacterResponce> GetCharacterByIdAsync(int id)
    {
        var result = await context.Characters.Where(c=>c.id==id).Select(c=>new  CharacterResponce{id = c.id,name = c.name,Game = c.Game,Role = c.Role}).FirstOrDefaultAsync();
        return result;
    }

    public async Task<Character> AddCharacterAsync(CreateCharacterRequest character)
    {
        var newCharacter = new Character {name = character.name, Game = character.Game, Role = character.Role};
        context.Characters.Add(newCharacter);
        await context.SaveChangesAsync();
        return newCharacter;
    }

    public async Task<bool> UpdateCharacterAsync(int id,  UpdateCharacterRequest character)
    {
        var existingCharacter = await context.Characters.Where(c=>c.id==id).FirstOrDefaultAsync();
        if(existingCharacter!=null)
        {
            existingCharacter.name = character.name;
            existingCharacter.Game = character.Game;
            existingCharacter.Role = character.Role;
        }
        context.Characters.Update(existingCharacter);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteCharacterAsync(int id)
    {
        var characterToDelete = await context.Characters.FindAsync(id);
        if (characterToDelete is null)
        {
            return false;
        }
        context.Characters.Remove(characterToDelete);
        await context.SaveChangesAsync();
        return true;
    }
}