using DocGenerator.Client;
using DocGenerator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

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
            return View();
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

        public async Task<JsonResult> PrintDocument(string text)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(text);
            var client = await _blClient.GetClient(new Guid("12345678-1234-1234-1234-1234567890AB"));

            sb.Replace("{ClientName}", $"{client.Name}");
            sb.Replace("{ClientDocument}", $"{client.Document}");
            sb.Replace("{ClientAdress}", $"{client.Address}");

            sb.Replace("{ItemsList}", "<table style=\"border-collapse: collapse; width: 100%;\" border=\"1\">");
            sb.Append("<tbody>");
            foreach (var game in client.ClientGames)
            {
                sb.Append("<tr>");
                sb.Append($"<td>{game.Name}</td>");
                sb.Append($"<td style=\"text-align:right;\">$ {game.Price}</td>");
                sb.Append("</tr>");
            }
            sb.Append("</tbody>");
            sb.Append("</table>");

            return Json(sb.ToString());
        }
    }
}