namespace KeyConcepts.Client.Pages;

public partial class Demo
{
    IConfiguration config;

    public Demo(IConfiguration config)
    {
        this.config = config;
    }

    public IConfiguration Config { get; }

    private string? GetConnectionInfo()
    {
        return config.GetConnectionString("Default");
    }

}