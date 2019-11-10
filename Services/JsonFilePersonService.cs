using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using myFirstWebApp.Models;

namespace ContosoCrafts.WebSite.Services
{
  public class JsonFilePersonService
  {
    public JsonFilePersonService(IWebHostEnvironment webHostEnvironment)
    {
      WebHostEnvironment = webHostEnvironment;
    }

    public IWebHostEnvironment WebHostEnvironment { get; }

    private string JsonFileName
    {
      get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "person.json"); }
    }

    public IEnumerable<Person> GetPersons()
    {
      using (var jsonFileReader = File.OpenText(JsonFileName))
      {
        return JsonSerializer.Deserialize<Person[]>(jsonFileReader.ReadToEnd(),
            new JsonSerializerOptions
            {
              PropertyNameCaseInsensitive = true
            });
      }
    }
  }

}