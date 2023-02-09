using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SebsFirstWebapp.Services;

namespace SebsFirstWebapp.Pages;

public class QuizModel : PageModel
{

    public string? Answer { get; set; }

    public string? CorrectAnswer { get; set; }
    NameGenerator newName = new Services.NameGenerator();


    public void OnGet()
    {

    }

    public IActionResult OnPost()
    {

        // another way presented by ChatGTP
        if (Request.Form["answer"].ToString() == Request.Form["correctAnswer"].ToString())
        {
            ViewData["Result"] = "Correct";

        }
        else
        {
            ViewData["Result"] = "Incorrect";
        }

        return Page();

    }

}

