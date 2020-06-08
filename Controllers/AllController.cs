using Microsoft.AspNetCore.Mvc;

namespace Portfolio
{
  public class AllController : Controller
  {
      // Requests
      // localhost:5000
      [HttpGet("")]
      public IActionResult Home()
      {
        return View();
      }

      [HttpGet("projects")]
      public IActionResult Projects()
      {
        return View();
      }

      [HttpGet("contact")]

      public IActionResult Contact()
      {
        return View();
      }
  }
}