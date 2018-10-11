using Microsoft.AspNetCore.Mvc;

namespace Smastad.Controllers
{
  public class FAQ : Controller
  {
    // GET: /<controller>/
    public IActionResult faq()
    {
      return View();
    }
  }
}
