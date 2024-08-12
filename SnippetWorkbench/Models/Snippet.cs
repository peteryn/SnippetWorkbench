using Microsoft.AspNetCore.Identity;

namespace SnippetWorkbench.Models;

public class Snippet
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;

    public string UserId { get; set; } = string.Empty;
}
