namespace VideoGameCharacterAPI.Dtos;

public class CreateCharacterRequest
{
    public string name { get; set; }
    public string Game { get; set; }
    public string Role { get; set; }
}