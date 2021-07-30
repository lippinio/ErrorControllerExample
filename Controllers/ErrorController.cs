using System.Diagnostics;
using ErrorControllerExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace ErrorControllerExample.Controllers
{
    public class ErrorController : Controller
    {
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Handle()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}