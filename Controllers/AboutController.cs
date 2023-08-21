using Microsoft.AspNetCore.Mvc;
using l04_assignment.Models;

public class AboutController : Controller
{
    private readonly ILogger<AboutController> _logger;



    public AboutController(ILogger<AboutController> logger)
    {
        _logger = logger;
    }
}