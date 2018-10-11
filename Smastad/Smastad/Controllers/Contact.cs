using Microsoft.AspNetCore.Mvc;

namespace Smastad.Controllers
{
  public class Contact : Controller
  {
    // GET: /<controller>/
    public IActionResult contact()
    {
      return View();
    }
  }
}
