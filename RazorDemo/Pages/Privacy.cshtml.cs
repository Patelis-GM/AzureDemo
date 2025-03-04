using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorDemo.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;
    public string EnvVariableMessage { get; private set; }


    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        var envVar = Environment.GetEnvironmentVariable("MY_ENV_VAR_IN_AZURE");
        EnvVariableMessage = string.IsNullOrEmpty(envVar) ? "Environment variable not set." : envVar;

    }
}

