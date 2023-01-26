using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SebsFirstWebapp.Services;

namespace SebsFirstWebapp.Pages;

public class QuizModel : PageModel
{
    public int Age { get; set; }

    public string? Name { get; set; }

    public string? WackyName { get; set; }

    NameGenerator newName = new Services.NameGenerator();


    public void OnGet()
    {
        Name = newName.GenerateName();
        WackyName = newName.WackyNameGenerator();
    }

    public IActionResult OnPost()
    {
        if (Request.Form["answer"].ToString() == Request.Form["correctAnswer"].ToString())
        {
            return RedirectToPage("Quiz");
        }

        return Page();
    }

}

