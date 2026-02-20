using VideoGameCharacterAPI.Dtos;
using VideoGameCharacterAPI.Models;

namespace VideoGameCharacterAPI.Services;

public interface IVideoGameCharacterServices
{
    Task<List<CharacterResponce>> GetAllCharactersAsync();
    Task<CharacterResponce> GetCharacterByIdAsync(int id);
    Task<Character> AddCharacterAsync(CreateCharacterRequest character);
    Task<bool > UpdateCharacterAsync(int id, UpdateCharacterRequest character);
    Task<bool> DeleteCharacterAsync(int id);
}