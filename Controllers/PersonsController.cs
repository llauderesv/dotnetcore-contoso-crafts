using System.Collections.Generic;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using myFirstWebApp.Models;

namespace myFirstWebApp.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class PersonsController : ControllerBase
  {
    public JsonFilePersonService PersonService { get; }
    
    public PersonsController(JsonFilePersonService personService)
    {
      PersonService = personService;
    }

    [HttpGet]
    public IEnumerable<Person> Get()
    {
      return PersonService.GetPersons();
    }
  }
}