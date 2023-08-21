using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using l04_assignment.Models;
using l04_assignment.Repositories;

namespace l04_assignment.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IStaffRepository _staffRepository;

    public HomeController(ILogger<HomeController> logger, IStaffRepository repository)
    {
        _logger = logger;
        _staffRepository = repository;
    }

    public IActionResult Index()
    {
        return View();
    }

        public IActionResult About()
        {
            var staffList = _staffRepository.GetAllStaff();
            return View(staffList);
        }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
