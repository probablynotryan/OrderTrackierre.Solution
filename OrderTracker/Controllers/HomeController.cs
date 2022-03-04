using Microsoft.AspNetCore.Mvc;

namespace OrderTracker.Controllers
{
    public class HomeController : Controller
    {
      string view = "";

      [HttpGet("/{currentPage}")]
      public ActionResult Create(string currentPage)
      {
        return View(currentPage);
      }

    }
}