using Microsoft.AspNetCore.Mvc;

namespace Smastad.Controllers
{
  public class ServiceController : Controller
  {
    // GET: /<controller>/
    public IActionResult service()
    {
      return View();
    }
  }
}
