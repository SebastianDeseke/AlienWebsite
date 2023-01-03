using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SebsFirstWebapp.Pages;

public class IndexModel : PageModel
{
    [Parameter]
    public string Name { get; set; }
    [Parameter]
    public string Time { get; set; }
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Name = "Human Being";
        Time = DateTime.Now.ToString();
        _logger.LogWarning("This is a warning message");
    }
}
