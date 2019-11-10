using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using myFirstWebApp.Models;

namespace myFirstWebApp.Pages
{
  public class IndexModel : PageModel
  {
    private readonly ILogger<IndexModel> _logger;
    private readonly JsonFilePersonService PersonService;

    public IEnumerable<Person> PersonsCollection { get; private set; }

    public IndexModel(
        ILogger<IndexModel> logger,
        JsonFilePersonService jsonFilePersonService)
    {
      _logger = logger;
      PersonService = jsonFilePersonService;
    }

    public void OnGet()
    {
      PersonsCollection = PersonService.GetPersons();
    }
  }
}
