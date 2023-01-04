using Microsoft.AspNetCore.Mvc.RazorPages;
using SebsFirstWebapp.Services;

namespace SebsFirstWebapp.Pages;

public class HumanTestModel : PageModel
{
    public int Age { get; set; }

public string  Name { get; set; }

NameGenerator newName = new Services.NameGenerator ();


public void OnGet () {
    
    Name = newName.GenerateName();
}

}

