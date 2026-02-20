namespace VideoGameCharacterAPI.Dtos;

public class UpdateCharacterRequest
{
    public int id { get; set; }
    public string name { get; set; }
    public string Game { get; set; }
    public string Role { get; set; }
}