using DocGenerator.Client;
using DocGenerator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DocGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BlClient _blClient;

        public HomeController(ILogger<HomeController> logger, BlClient blClient)
        {
            _logger = logger;
            _blClient = blClient;
        }

        public async Task<IActionResult> Index()
        {
            var client = await _blClient.GetClient(new Guid("12345678-1234-1234-1234-1234567890AB"));
            return View(client);
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
}
