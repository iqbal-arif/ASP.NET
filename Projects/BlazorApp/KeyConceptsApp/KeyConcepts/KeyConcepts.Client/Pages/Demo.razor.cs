
using Microsoft.AspNetCore.Components;

namespace KeyConcepts.Client.Pages;

//This is a test from shortcut version
public partial class Demo
{
    [Inject]

    protected IConfiguration config { get; set; } = default!;

    private string? GetConnectionInfo()
    {
        return config.GetConnectionString("Default");
    }

    private string GetTestInfo()
    {
        return "This is test Info";
    }

}