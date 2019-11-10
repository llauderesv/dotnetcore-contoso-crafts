using System.Text.Json;
using System.Text.Json.Serialization;

namespace myFirstWebApp.Models
{
  public class Person
  {
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("first_name")]
    public string FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string LastName { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("gender")]
    public string Gender { get; set; }

    [JsonPropertyName("img")]
    public string Image { get; set; }

    public override string ToString() => JsonSerializer.Serialize(this);

  }
}